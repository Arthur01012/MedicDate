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
    internal class clsEspecialidadDAL
    {
        public static DataTable ObtenerTodos()
        {
            string consulta = "SELECT id_especialidad, nombre_especialidad FROM especialidad ORDER BY nombre_especialidad";
            return clsConexion.EjecutarConsulta(consulta);
        }

        public static int Insertar(clsEspecialidad especialidad, MySqlTransaction? transaccion = null)
        {
            string consulta = @"INSERT INTO especialidad (nombre_especialidad, descripcion)
                               VALUES (@nombre, @descripcion);
                               SELECT LAST_INSERT_ID();";

            MySqlParameter[] parametros = {
                new MySqlParameter("@nombre", especialidad.nombre_especialidad),
                new MySqlParameter("@descripcion",
                    string.IsNullOrEmpty(especialidad.descripcion) ? DBNull.Value : (object)especialidad.descripcion)
            };

            object resultado = clsConexion.EjecutarScalar(consulta, parametros, transaccion);
            return resultado == DBNull.Value ? 0 : Convert.ToInt32(resultado);
        }
        public static bool Actualizar(clsEspecialidad especialidad, MySqlTransaction? transaccion = null)
        {
            string consulta = @"UPDATE especialidad 
                               SET nombre_especialidad = @nombre, 
                                   descripcion = @descripcion
                               WHERE id_especialidad = @id";

            MySqlParameter[] parametros = {
                new MySqlParameter("@nombre", especialidad.nombre_especialidad),
                new MySqlParameter("@descripcion",
                    string.IsNullOrEmpty(especialidad.descripcion) ? DBNull.Value : (object)especialidad.descripcion),
                new MySqlParameter("@id", especialidad.id_especialidad)
            };

            int filasAfectadas = clsConexion.EjecutarNonQuery(consulta, parametros, transaccion);
            return filasAfectadas > 0;
        }
    }
}
