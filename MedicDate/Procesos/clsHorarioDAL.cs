using System;
using System.Data;
using MySqlConnector;
using MedicDate.Datos;

namespace MedicDate.Procesos
{
    public class clsHorarioDAL
    {

        // Carga todos los horarios con el nombre del doctor para mostrar en un DataGridView.

        public DataTable CargarGrid()
        {
            var tabla = new DataTable();
            try
            {
                using var conexion = clsConexion.ObtenerConexion();
                string sql = @"
                    SELECT 
                           h.id_horario,
                           CONCAT(e.nombre, ' ', e.apellido_paterno) AS Doctor,
                           h.dia_semana,
                           h.hora_inicio,
                           h.hora_fin,
                           h.intervalo_atencion,
                           CASE WHEN h.activo = 1 THEN 'Activo' ELSE 'Inactivo' END AS Estado,
                           h.activo AS ActivoBool,
                           h.id_doctor
                    FROM horario h
                    INNER JOIN empleado e ON h.id_doctor = e.id_empleado
                    ORDER BY e.apellido_paterno, 
                             FIELD(h.dia_semana, 'Lunes','Martes','Miércoles','Jueves','Viernes','Sábado','Domingo'),
                             h.hora_inicio";
                using var adapter = new MySqlDataAdapter(sql, conexion);
                adapter.Fill(tabla);
                return tabla;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al cargar horarios: " + ex.Message);
            }
        }


        // Busca horarios por nombre del doctor (coincidencia parcial).

        public DataTable Buscar(string texto)
        {
            if (string.IsNullOrWhiteSpace(texto))
                return CargarGrid();

            var tabla = new DataTable();
            try
            {
                using var conexion = clsConexion.ObtenerConexion();
                string sql = @"
                    SELECT h.id_horario,
                           h.id_doctor,
                           CONCAT(e.nombre, ' ', e.apellido_paterno) AS Doctor,
                           h.dia_semana,
                           h.hora_inicio,
                           h.hora_fin,
                           h.intervalo_atencion,
                           CASE WHEN h.activo = 1 THEN 'Activo' ELSE 'Inactivo' END AS Estado,
                           h.activo AS ActivoBool,
                           h.id_doctor
                    FROM horario h
                    INNER JOIN empleado e ON h.id_doctor = e.id_empleado
                    WHERE CONCAT(e.nombre, ' ', e.apellido_paterno) LIKE @texto
                    ORDER BY e.apellido_paterno, FIELD(h.dia_semana, 'Lunes','Martes','Miércoles','Jueves','Viernes','Sábado','Domingo'), h.hora_inicio";
                using var cmd = new MySqlCommand(sql, conexion);
                cmd.Parameters.AddWithValue("@texto", "%" + texto + "%");
                using var adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(tabla);
                return tabla;
            }
            catch (Exception ex)
            {
                throw new Exception("Error en búsqueda de horarios: " + ex.Message);
            }
        }

        // Obtiene un horario específico por su ID (para edición).

        public static DataTable ObtenerHorarioPorId(int idHorario)
        {
            var tabla = new DataTable();
            try
            {
                using var conexion = clsConexion.ObtenerConexion();
                string sql = "SELECT * FROM horario WHERE id_horario = @id";
                using var cmd = new MySqlCommand(sql, conexion);
                cmd.Parameters.AddWithValue("@id", idHorario);
                using var adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(tabla);
                return tabla;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener horario por ID: " + ex.Message);
            }
        }


        // Verifica si existe un horario que se solape con el rango dado para el mismo doctor y día.

        public static bool ExisteSolapamiento(int idDoctor, string diaSemana, TimeSpan horaInicio, TimeSpan horaFin, int? idExcluir = null)
        {
            string consulta = @"SELECT COUNT(*) FROM horario 
                                WHERE id_doctor = @id_doctor 
                                  AND dia_semana = @dia_semana
                                  AND activo = 1
                                  AND (
                                      (hora_inicio <= @hora_inicio AND hora_fin > @hora_inicio)
                                      OR
                                      (hora_inicio < @hora_fin AND hora_fin >= @hora_fin)
                                      OR
                                      (hora_inicio >= @hora_inicio AND hora_fin <= @hora_fin)
                                  )";
            if (idExcluir.HasValue)
                consulta += " AND id_horario != @id_excluir";

            MySqlParameter[] parametros = {
                new MySqlParameter("@id_doctor", idDoctor),
                new MySqlParameter("@dia_semana", diaSemana),
                new MySqlParameter("@hora_inicio", horaInicio),
                new MySqlParameter("@hora_fin", horaFin)
            };
            if (idExcluir.HasValue)
            {
                Array.Resize(ref parametros, 5);
                parametros[4] = new MySqlParameter("@id_excluir", idExcluir.Value);
            }

            object resultado = clsConexion.EjecutarScalar(consulta, parametros);
            return Convert.ToInt32(resultado) > 0;
        }

        /// Inserta un nuevo horario en la base de datos.
        public static int Insertar(clsHorario horario, MySqlTransaction? transaccion = null)
        {
            string consulta = @"INSERT INTO horario 
                               (id_doctor, dia_semana, hora_inicio, hora_fin, intervalo_atencion, activo)
                               VALUES 
                               (@id_doctor, @dia_semana, @hora_inicio, @hora_fin, @intervalo_atencion, @activo);
                               SELECT LAST_INSERT_ID();";

            MySqlParameter[] parametros = {
                new MySqlParameter("@id_doctor", horario.id_doctor),
                new MySqlParameter("@dia_semana", horario.dia_semana),
                new MySqlParameter("@hora_inicio", horario.hora_inicio),
                new MySqlParameter("@hora_fin", horario.hora_fin),
                new MySqlParameter("@intervalo_atencion", horario.intervalo_atencion),
                new MySqlParameter("@activo", horario.activo ? 1 : 0)
            };

            object resultado = clsConexion.EjecutarScalar(consulta, parametros, transaccion);
            return resultado == DBNull.Value ? 0 : Convert.ToInt32(resultado);
        }

        public static bool Actualizar(clsHorario horario, MySqlTransaction? transaccion = null)
        {
            string consulta = @"UPDATE horario 
                               SET id_doctor = @id_doctor, 
                                   dia_semana = @dia_semana, 
                                   hora_inicio = @hora_inicio, 
                                   hora_fin = @hora_fin, 
                                   intervalo_atencion = @intervalo_atencion, 
                                   activo = @activo
                               WHERE id_horario = @id_horario";

            MySqlParameter[] parametros = {
                new MySqlParameter("@id_doctor", horario.id_doctor),
                new MySqlParameter("@dia_semana", horario.dia_semana),
                new MySqlParameter("@hora_inicio", horario.hora_inicio),
                new MySqlParameter("@hora_fin", horario.hora_fin),
                new MySqlParameter("@intervalo_atencion", horario.intervalo_atencion),
                new MySqlParameter("@activo", horario.activo ? 1 : 0),
                new MySqlParameter("@id_horario", horario.id_horario)
            };

            int filasAfectadas = clsConexion.EjecutarNonQuery(consulta, parametros, transaccion);
            return filasAfectadas > 0;
        }

        // Cambia el estado (activo/inactivo) de un horario.
        public static bool CambiarEstado(int idHorario, bool activo, MySqlTransaction? transaccion = null)
        {
            string consulta = "UPDATE horario SET activo = @activo WHERE id_horario = @id";
            MySqlParameter[] parametros = {
                new MySqlParameter("@activo", activo ? 1 : 0),
                new MySqlParameter("@id", idHorario)
            };

            int filasAfectadas = clsConexion.EjecutarNonQuery(consulta, parametros, transaccion);
            return filasAfectadas > 0;
        }
        public static bool DesactivarTodosPorDoctor(int idDoctor, MySqlTransaction? transaccion = null)
        {
            // Actualiza todos los registros cuyo id_doctor coincida
            string sql = "UPDATE horario SET activo = 0 WHERE id_doctor = @id_doctor;";

            MySqlParameter[] parametros = {
                new MySqlParameter("@id_doctor", idDoctor)
            };

            try
            {
                int filasAfectadas = clsConexion.EjecutarNonQuery(sql, parametros, transaccion);
                // Devuelve true si afectó al menos 1 fila, o false si no tenía horarios activos
                return filasAfectadas > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Error en la base de datos al desactivar los horarios del doctor: " + ex.Message, ex);
            }
        }
    }
}