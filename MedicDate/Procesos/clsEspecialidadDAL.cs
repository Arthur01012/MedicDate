using MedicDate.Datos;
using MySqlConnector;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace MedicDate.Procesos
{
    internal class clsEspecialidadDAL
    {
        private MySqlDataAdapter consulta;
        private DataTable tabla;

        public static DataTable ObtenerTodos() // Método para obtener todas las especialidades
        {
            string consulta = "SELECT id_especialidad, nombre_especialidad FROM especialidad ORDER BY nombre_especialidad";
            return clsConexion.EjecutarConsulta(consulta); // Llamada al método de clsConexion para ejecutar la consulta y obtener los resultados en un DataTable
        }

        public static int Insertar(clsEspecialidad especialidad, MySqlTransaction? transaccion = null) // Método para insertar una nueva especialidad
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
        public object? CargarDataGrid()
        {
            tabla = new DataTable();

            try
            {
                using (var conexion = clsConexion.ObtenerConexion())
                {
                    string sql = "SELECT nombre_especialidad AS Especialdiades, descripcion AS Descripciones FROM especialidad ORDER BY nombre_especialidad ASC;";

                    using (consulta = new MySqlDataAdapter(sql, conexion))
                    {
                        consulta.Fill(tabla);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error en la tabla " + ex.Message);
            }
            return tabla;
        }
        public DataTable Consultar(string text)
        {
            tabla = new DataTable();

            try
            {
                using (var conexion = clsConexion.ObtenerConexion())
                {
                    string sql = "SELECT nombre_especialidad AS Especialidades " +
                                 "FROM especialidad " +
                                 "WHERE nombre_especialidad LIKE @especialidad;";

                    using (var consultar = new MySqlCommand(sql, conexion))
                    {
                        consultar.Parameters.AddWithValue("@especialidad", "%" + text + "%");
                        using (consulta = new MySqlDataAdapter(consultar))
                        {
                            consulta.Fill(tabla);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error en la conexion" + ex.Message);
            }
            return tabla;
        }
    }
}
