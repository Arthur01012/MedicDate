using MedicDate.Datos;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text.RegularExpressions;
namespace MedicDate.Procesos
{
    internal class clsCitaDAL
    {        
        private static string ObtenerQueryBase()// query base para evitar duplicación de código en los métodos de consulta
        {
            return @"
                SELECT 
                    c.id_cita,
                    CONCAT(p.nombre, ' ', p.apellido_paterno, ' ', IFNULL(p.apellido_materno, '')) AS Paciente,
                    c.fecha AS Fecha,
                    c.hora AS Hora,
                    c.motivo AS Motivo,
                    p.telefono_principal AS 'Teléfono Paciente',
                    s.nombre_especialidad AS Especialidad,
                    CONCAT(e.nombre, ' ', e.apellido_paterno, ' ', IFNULL(e.apellido_materno, '')) AS Doctor,
                    c.estado AS Estado,
                    c.costo AS Costo
                FROM cita c
                INNER JOIN paciente p ON c.id_paciente = p.id_paciente
                INNER JOIN empleado e ON c.id_doctor = e.id_empleado
                LEFT JOIN doctor d ON e.id_empleado = d.id_empleado
                LEFT JOIN especialidad s ON d.especialidad_principal = s.id_especialidad";
        }

        public static DataTable CargarDataGrid(DateTime fecha)// Carga todas las citas de un día específico
        {
            var tabla = new DataTable();
            try
            {
                using var conexion = clsConexion.ObtenerConexion();
                string sql = ObtenerQueryBase() + @"
                    WHERE c.fecha = @fecha AND c.estado != 'Cancelada'
                    ORDER BY c.hora";

                using var cmd = new MySqlCommand(sql, conexion);
                cmd.Parameters.AddWithValue("@fecha", fecha);
                using var adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(tabla);
                return tabla;
            }
            catch (MySqlException ex)
            {
                throw new Exception($"Error al cargar citas: {ex.Message}", ex);
            }
        }
        
        public static DataTable Consultar(DateTime fecha, string texto)// Consulta citas por fecha y texto de búsqueda (nombre de paciente, doctor o especialidad)
        {
            if (string.IsNullOrWhiteSpace(texto))
                return CargarDataGrid(fecha);

            var tabla = new DataTable();
            try
            {
                using var conexion = clsConexion.ObtenerConexion();
                string sql = ObtenerQueryBase() + @"
                    WHERE c.fecha = @fecha AND c.estado != 'Cancelada'
                      AND (CONCAT(p.nombre, ' ', p.apellido_paterno, ' ', IFNULL(p.apellido_materno, '')) LIKE @texto
                           OR CONCAT(e.nombre, ' ', e.apellido_paterno, ' ', IFNULL(e.apellido_materno, '')) LIKE @texto
                           OR s.nombre_especialidad LIKE @texto)
                    ORDER BY c.hora";

                using var cmd = new MySqlCommand(sql, conexion);
                cmd.Parameters.AddWithValue("@fecha", fecha);
                cmd.Parameters.AddWithValue("@texto", "%" + texto + "%");
                using var adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(tabla);
                return tabla;
            }
            catch (Exception ex)
            {
                throw new Exception("Error en la búsqueda de citas: " + ex.Message);
            }
        }

        public static DataTable ObtenerCitas(int idDoctor, DateTime fecha)// Sobrecarga del método para obtener citas sin especificar estado
        {
            return ObtenerCitas(idDoctor, fecha, null);
        }

        public static DataTable ObtenerCitas(int idDoctor, DateTime fecha, string estado = null)// Obtiene citas de un doctor en una fecha específica, con opción de filtrar por estado
        {
            string sql = ObtenerQueryBase() + @"
        WHERE c.id_doctor = @idDoctor
          AND c.fecha = @fecha";

            var parametros = new List<MySqlParameter>
            {
                new MySqlParameter("@idDoctor", idDoctor),
                new MySqlParameter("@fecha", fecha.Date)
            };

            if (string.IsNullOrWhiteSpace(estado) || estado == "Todos")
            {
                sql += " AND c.estado != 'Cancelada'";
            }
            else
            {
                sql += " AND c.estado = @estado";
                parametros.Add(new MySqlParameter("@estado", estado));
            }

            sql += " ORDER BY c.hora";

            return clsConexion.EjecutarConsulta(sql, parametros.ToArray());
        }
   

        public static bool CambiarEstado(int id_cita, string nuevoEstado)// Cambia el estado de una cita específica
        {
            string consulta = "UPDATE cita SET estado = @estado WHERE id_cita = @id";
            MySqlParameter[] parametros = {
                new MySqlParameter("@estado", nuevoEstado),
                new MySqlParameter("@id", id_cita)
            };
            return clsConexion.EjecutarNonQuery(consulta, parametros) > 0;
        }

        public static bool Cancelar(int id_cita) => CambiarEstado(id_cita, "Cancelada");

        public static clsCita ObtenerPorId(int id_cita)// Obtiene los detalles de una cita específica por su ID
        {
            string consulta = @"
                SELECT c.*, 
                       CONCAT(p.nombre, ' ', p.apellido_paterno, ' ', IFNULL(p.apellido_materno, '')) as nombre_paciente,
                       CONCAT(e.nombre, ' ', e.apellido_paterno, ' ', IFNULL(e.apellido_materno, '')) as nombre_doctor
                FROM cita c
                INNER JOIN paciente p ON c.id_paciente = p.id_paciente
                INNER JOIN empleado e ON c.id_doctor = e.id_empleado
                WHERE c.id_cita = @id";

            MySqlParameter[] parametros = { new MySqlParameter("@id", id_cita) };
            DataTable resultado = clsConexion.EjecutarConsulta(consulta, parametros);

            if (resultado.Rows.Count > 0)
            {
                DataRow row = resultado.Rows[0];
                return new clsCita
                {
                    id_cita = Convert.ToInt32(row["id_cita"]),
                    id_paciente = Convert.ToInt32(row["id_paciente"]),
                    nombre_paciente = row["nombre_paciente"].ToString(),
                    id_doctor = Convert.ToInt32(row["id_doctor"]),
                    nombre_doctor = row["nombre_doctor"].ToString(),
                    fecha = Convert.ToDateTime(row["fecha"]),
                    hora = TimeSpan.Parse(row["hora"].ToString()),
                    duracion = Convert.ToInt32(row["duracion"]),
                    motivo = row["motivo"]?.ToString(),
                    estado = row["estado"].ToString(),
                    costo = row["costo"] == DBNull.Value ? (decimal?)null : Convert.ToDecimal(row["costo"]),
                    notas_internas = row["notas_internas"]?.ToString(),
                    id_registrado_por = row["id_registrado_por"] == DBNull.Value ? (int?)null : Convert.ToInt32(row["id_registrado_por"]),
                };
            }
            return null;
        }

        public static bool VerificarDisponibilidad(int id_doctor, DateTime fecha, TimeSpan hora, int duracion)// Verifica si un doctor está disponible para una cita en un horario específico
        {
            string consulta = @"
                SELECT COUNT(*) FROM cita 
                WHERE id_doctor = @id_doctor 
                  AND fecha = @fecha 
                  AND estado != 'Cancelada'
                  AND (
                      (hora <= @hora AND DATE_ADD(hora, INTERVAL duracion MINUTE) > @hora)
                      OR
                      (@hora <= hora AND DATE_ADD(@hora, INTERVAL @duracion MINUTE) > hora)
                  )";

            MySqlParameter[] parametros = {
                new MySqlParameter("@id_doctor", id_doctor),
                new MySqlParameter("@fecha", fecha),
                new MySqlParameter("@hora", hora),
                new MySqlParameter("@duracion", duracion)
            };

            int count = Convert.ToInt32(clsConexion.EjecutarScalar(consulta, parametros));
            return count == 0;
        }

        public static int Insertar(clsCita cita, MySqlTransaction? transaccion = null)// Inserta una nueva cita en la base de datos y devuelve el ID generado
        {
            string consulta = @"
                INSERT INTO cita (id_paciente, id_doctor, fecha, hora, duracion, motivo, estado, 
                                  costo, notas_internas, id_registrado_por)
                VALUES (@id_paciente, @id_doctor, @fecha, @hora, @duracion, @motivo, @estado,
                        @costo, @notas_internas, @id_registrado_por);
                SELECT LAST_INSERT_ID();";

            MySqlParameter[] parametros = {
                new MySqlParameter("@id_paciente", cita.id_paciente),
                new MySqlParameter("@id_doctor", cita.id_doctor),
                new MySqlParameter("@fecha", cita.fecha),
                new MySqlParameter("@hora", cita.hora),
                new MySqlParameter("@duracion", cita.duracion),
                new MySqlParameter("@motivo", (object)cita.motivo ?? DBNull.Value),
                new MySqlParameter("@estado", cita.estado),
                new MySqlParameter("@costo", (object)cita.costo ?? DBNull.Value),
                new MySqlParameter("@notas_internas", (object)cita.notas_internas ?? DBNull.Value),
                new MySqlParameter("@id_registrado_por", (object)cita.id_registrado_por ?? DBNull.Value)
            };

            object resultado = clsConexion.EjecutarScalar(consulta, parametros, transaccion);
            return resultado != null ? Convert.ToInt32(resultado) : 0;
        }

        public static bool Actualizar(clsCita cita)
        {
            if (cita.id_cita <= 0)
                throw new ArgumentException("El ID de la cita no es válido.");

            string consulta = @"
        UPDATE cita 
        SET id_paciente = @id_paciente, id_doctor = @id_doctor,
            fecha = @fecha, hora = @hora, duracion = @duracion,
            motivo = @motivo, estado = @estado, costo = @costo,
            notas_internas = @notas_internas
        WHERE id_cita = @id_cita";

            MySqlParameter[] parametros = {
        new MySqlParameter("@id_paciente", cita.id_paciente),
        new MySqlParameter("@id_doctor", cita.id_doctor),
        new MySqlParameter("@fecha", cita.fecha),
        new MySqlParameter("@hora", cita.hora),
        new MySqlParameter("@duracion", cita.duracion),
        new MySqlParameter("@motivo", (object)cita.motivo ?? DBNull.Value),
        new MySqlParameter("@estado", cita.estado),
        new MySqlParameter("@costo", (object)cita.costo ?? DBNull.Value),
        new MySqlParameter("@notas_internas", (object)cita.notas_internas ?? DBNull.Value),
        new MySqlParameter("@id_cita", cita.id_cita)
    };

            try
            {
                int filasAfectadas = clsConexion.EjecutarNonQuery(consulta, parametros);
                return filasAfectadas > 0;
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 1452)
                    throw new Exception("El paciente o doctor seleccionado no existe.", ex);
                throw new Exception($"Error en la base de datos: {ex.Message}", ex);
            }
        }

        public static DataTable ObtenerHorarioDoctor(int idDoctor, string diaSemana)// Obtiene el horario de un doctor para un día específico de la semana
        {
            string sql = @"
                SELECT hora_inicio, hora_fin 
                FROM horario 
                WHERE id_doctor = @idDoctor AND dia_semana = @diaSemana";

            MySqlParameter[] parametros = {
                new MySqlParameter("@idDoctor", idDoctor),
                new MySqlParameter("@diaSemana", diaSemana)
            };
            return clsConexion.EjecutarConsulta(sql, parametros);
        }

        public static List<TimeSpan> ObtenerHorasOcupadas(int idDoctor, DateTime fecha)// Obtiene las horas ocupadas de un doctor en una fecha específica
        {
            List<TimeSpan> horasOcupadas = new List<TimeSpan>();
            string sql = @"
                SELECT hora FROM cita 
                WHERE id_doctor = @idDoctor AND fecha = @fecha 
                AND estado != 'Cancelada'";

            MySqlParameter[] parametros = {
                new MySqlParameter("@idDoctor", idDoctor),
                new MySqlParameter("@fecha", fecha)
            };

            DataTable tabla = clsConexion.EjecutarConsulta(sql, parametros);
            foreach (DataRow row in tabla.Rows)
            {
                horasOcupadas.Add(TimeSpan.Parse(row["hora"].ToString()));
            }
            return horasOcupadas;
        }
        public static List<string> ObtenerEstadosENUM()// Obtiene los posibles estados de la cita desde la definición ENUM en la base de datos
        {
            var estados = new List<string>();
            string sql = "SHOW COLUMNS FROM cita LIKE 'estado'";
            DataTable dt = clsConexion.EjecutarConsulta(sql);

            if (dt.Rows.Count > 0)
            {
                string type = dt.Rows[0]["Type"].ToString();
                                                             
                MatchCollection matches = Regex.Matches(type, "'([^']*)'");
                foreach (Match match in matches)
                {
                    estados.Add(match.Groups[1].Value);
                }
            }
            return estados;
        }
    }
}