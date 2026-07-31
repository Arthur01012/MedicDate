using MedicDate.Datos;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;

namespace MedicDate.Procesos
{
    internal class clsCitaDAL
    {
        // Método para cargar TODAS las citas activas de un día específico
        public static DataTable CargarDataGrid(DateTime fecha)
        {
            var tabla = new DataTable();
            try
            {
                using var conexion = clsConexion.ObtenerConexion();

                string sql = @"
                    SELECT 
                        c.id_cita,
                        c.fecha AS Fecha,
                        c.hora AS Hora,
                        c.motivo AS Motivo,
                        c.estado AS Estado,
                        c.costo AS Costo,
                        CONCAT(p.nombre, ' ', p.apellido_paterno, ' ', IFNULL(p.apellido_materno, '')) AS Paciente,
                        p.telefono_principal AS 'Teléfono Paciente',
                        CONCAT(e.nombre, ' ', e.apellido_paterno, ' ', IFNULL(e.apellido_materno, '')) AS Doctor,
                        s.nombre_especialidad AS Especialidad
                    FROM cita c
                    INNER JOIN paciente p ON c.id_paciente = p.id_paciente
                    INNER JOIN empleado e ON c.id_doctor = e.id_empleado
                    LEFT JOIN doctor d ON e.id_empleado = d.id_empleado
                    LEFT JOIN especialidad s ON d.especialidad_principal = s.id_especialidad
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

        // Método para buscar (devuelve todas las citas del día que coincidan con el texto)
        public static DataTable Consultar(DateTime fecha, string texto)
        {
            // Si no escribió nada, devolvemos todo el día
            if (string.IsNullOrWhiteSpace(texto))
                return CargarDataGrid(fecha);

            var tabla = new DataTable();
            try
            {
                using var conexion = clsConexion.ObtenerConexion();

                string sql = @"
                    SELECT 
                        c.id_cita,
                        c.fecha AS Fecha,
                        c.hora AS Hora,
                        c.motivo AS Motivo,
                        c.estado AS Estado,
                        c.costo AS Costo,
                        CONCAT(p.nombre, ' ', p.apellido_paterno, ' ', IFNULL(p.apellido_materno, '')) AS Paciente,
                        p.telefono_principal AS 'Teléfono Paciente',
                        CONCAT(e.nombre, ' ', e.apellido_paterno, ' ', IFNULL(e.apellido_materno, '')) AS Doctor,
                        s.nombre_especialidad AS Especialidad
                    FROM cita c
                    INNER JOIN paciente p ON c.id_paciente = p.id_paciente
                    INNER JOIN empleado e ON c.id_doctor = e.id_empleado
                    LEFT JOIN doctor d ON e.id_empleado = d.id_empleado
                    LEFT JOIN especialidad s ON d.especialidad_principal = s.id_especialidad
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

        public static DataTable ObtenerCitas(int? idDoctor = null)
        {
            string sql = @"
        SELECT 
            c.id_cita,
            c.fecha AS Fecha,
            c.hora AS Hora,
            c.motivo AS Motivo,
            c.estado AS Estado,
            c.costo AS Costo,
            CONCAT(p.nombre, ' ', p.apellido_paterno, ' ', IFNULL(p.apellido_materno, '')) AS Paciente,
            p.telefono_principal AS 'Teléfono Paciente',
            CONCAT(e.nombre, ' ', e.apellido_paterno, ' ', IFNULL(e.apellido_materno, '')) AS Doctor,
            s.nombre_especialidad AS Especialidad
        FROM cita c
        INNER JOIN paciente p ON c.id_paciente = p.id_paciente
        INNER JOIN empleado e ON c.id_doctor = e.id_empleado
        LEFT JOIN doctor d ON e.id_empleado = d.id_empleado
        LEFT JOIN especialidad s ON d.especialidad_principal = s.id_especialidad
        WHERE c.estado != 'Cancelada'";

            if (idDoctor.HasValue)
            {
                sql += " AND c.id_doctor = @idDoctor";
            }

            sql += " ORDER BY c.fecha DESC, c.hora DESC";

            var parametros = new List<MySqlParameter>();
            if (idDoctor.HasValue)
            {
                parametros.Add(new MySqlParameter("@idDoctor", idDoctor.Value));
            }

            return clsConexion.EjecutarConsulta(sql, parametros.ToArray());
        }

        public static bool CambiarEstado(int id_cita, string nuevoEstado)
        {
            string consulta = "UPDATE cita SET estado = @estado WHERE id_cita = @id";
            MySqlParameter[] parametros = {
                new MySqlParameter("@estado", nuevoEstado),
                new MySqlParameter("@id", id_cita)
            };
            return clsConexion.EjecutarNonQuery(consulta, parametros) > 0;
        }
        public static bool Cancelar(int id_cita)
        {
            string consulta = "UPDATE cita SET estado = 'Cancelada' WHERE id_cita = @id";
            MySqlParameter[] parametros = { new MySqlParameter("@id", id_cita) };
            return clsConexion.EjecutarNonQuery(consulta, parametros) > 0;
        }
    }
}