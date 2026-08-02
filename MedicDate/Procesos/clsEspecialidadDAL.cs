using MedicDate.Datos;
using MySqlConnector;
using System;
using System.Data;

namespace MedicDate.Procesos
{
    internal class clsEspecialidadDAL
    {
        public DataTable CargarDataGrid()// Método para cargar todas las especialidades en un DataTable
        {
            DataTable tabla = new DataTable();
            try
            {
                using var conexion = clsConexion.ObtenerConexion();
                string sql = "SELECT id_especialidad, nombre_especialidad AS Especialidades, descripcion AS Descripciones FROM especialidad ORDER BY nombre_especialidad ASC;";
                using var adapter = new MySqlDataAdapter(sql, conexion);
                adapter.Fill(tabla);
                return tabla;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al cargar las especialidades: " + ex.Message, ex);
            }
        }

        public DataTable Consultar(string texto)// Método para buscar especialidades por nombre o descripción
        {
            if (string.IsNullOrWhiteSpace(texto))
                return CargarDataGrid();

            DataTable tabla = new DataTable();
            try
            {
                using var conexion = clsConexion.ObtenerConexion();
                // Se busca tanto por nombre como por descripción
                string sql = @"SELECT id_especialidad, nombre_especialidad AS Especialidades, descripcion AS Descripciones 
                               FROM especialidad 
                               WHERE nombre_especialidad LIKE @especialidad
                               ORDER BY nombre_especialidad ASC;";
                using var cmd = new MySqlCommand(sql, conexion);
                cmd.Parameters.AddWithValue("@especialidad", "%" + texto + "%");
                using var adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(tabla);
                return tabla;
            }
            catch (Exception ex)
            {
                throw new Exception("Error en la búsqueda de especialidades: " + ex.Message, ex);
            }
        }
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
        public static bool Actualizar(clsEspecialidad especialidad, MySqlTransaction? transaccion = null)// Método para actualizar una especialidad existente
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
        public static bool Eliminar(int idEspecialidad, MySqlTransaction? transaccion = null)// Método para eliminar una especialidad existente
        {
            try
            {
                string sqlVerificar = "SELECT COUNT(*) FROM doctor WHERE especialidad_principal = @id";
                MySqlParameter[] paramVerificar = { new MySqlParameter("@id", idEspecialidad) };

                object resultadoConteo = clsConexion.EjecutarScalar(sqlVerificar, paramVerificar, transaccion);
                int cantidadDoctores = (resultadoConteo != null && resultadoConteo != DBNull.Value)
                                       ? Convert.ToInt32(resultadoConteo)
                                       : 0;

                if (cantidadDoctores > 0)
                {
                    throw new InvalidOperationException($"No se puede eliminar esta especialidad porque está asociada a {cantidadDoctores} doctor(es).");// Lanza una excepción si hay doctores asociados a la especialidad
                }

                string consulta = "DELETE FROM especialidad WHERE id_especialidad = @id";
                MySqlParameter[] parametros = { new MySqlParameter("@id", idEspecialidad) };

                int filasAfectadas = clsConexion.EjecutarNonQuery(consulta, parametros, transaccion);
                return filasAfectadas > 0;
            }
            catch (InvalidOperationException)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw new Exception("Error inesperado al intentar eliminar la especialidad: " + ex.Message, ex);
            }
        }
    }
}