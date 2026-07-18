using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedicDate.Datos;
using MySqlConnector;

namespace MedicDate.Procesos
{
    internal class clsHorarioDAL
    {
        public static DataTable ObtenerTodos()
        {
            string consulta = @"SELECT h.*, 
                               CONCAT(e.nombre, ' ', e.apellido_paterno) as nombre_doctor
                               FROM horario h
                               INNER JOIN empleado e ON h.id_doctor = e.id_empleado
                               ORDER BY e.apellido_paterno, h.dia_semana, h.hora_inicio";
            return clsConexion.EjecutarConsulta(consulta);
        }
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
    }
}
