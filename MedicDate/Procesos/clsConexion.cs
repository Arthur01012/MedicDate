using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicDate.Procesos
{
    internal class clsConexion
    {
        // 1. LEER LA CADENA DE CONEXIÓN DESDE App.config
        private static readonly string cadenaConexion = ObtenerCadenaConexion();
        // "MedicDateDB" es el name del <add> en App.config

        private static string ObtenerCadenaConexion()
        {
            // Intentar leer la cadena de conexión desde App.config
            string? fromConfig = ConfigurationManager.ConnectionStrings["MedicDateDB"]?.ConnectionString;
            if (!string.IsNullOrWhiteSpace(fromConfig)) // Verificar si la cadena no es nula o vacía
            {
                return fromConfig;
                // Si se encuentra la cadena, se devuelve
            }

            return "";
            // Si no se encuentra, se devuelve una cadena vacía
        }

        // 2. ABRIR UNA CONEXIÓN
        public static MySqlConnection ObtenerConexion()
        {
            try
            {
                // Crear un objeto de conexión con la cadena leída
                MySqlConnection conexion = new MySqlConnection(cadenaConexion);
                // Si está cerrada, se abre la conexión
                if (conexion.State == ConnectionState.Closed)
                {
                    conexion.Open();// Abrir la conexión si está cerrada
                }
                return conexion;// Devolver la conexión abierta
            }
            catch (Exception ex)
            {
                // Mostrar un mensaje de error si no se puede conectar a la base de datos
                throw new Exception("Error al conectar con la base de datos: " + ex.Message);
            }
        }

        // 3. EJECUTAR CONSULTAS QUE DEVUELVEN DATOS (SELECT) - DQl
        public static DataTable EjecutarConsulta(string consulta, MySqlParameter[] parametros = null, MySqlTransaction? transaccion = null)
        {
            // Si se pasa una transacción, usamos su conexión; si no, obtenemos una nueva conexión
            MySqlConnection conexion = transaccion?.Connection ?? ObtenerConexion();
            // Si no hay transacción, cerramos la conexión al final
            bool cerrarConexion = transaccion == null;
            try
            {
                // Usamos 'using' para asegurar que la conexión y los recursos se liberen
                using (MySqlCommand comando = new MySqlCommand(consulta, conexion, transaccion))
                {
                    // Si hay parámetros, los agregamos (evita inyección SQL)
                    if (parametros != null)
                    {
                        comando.Parameters.AddRange(parametros);
                    }
                    // Adaptador para llenar un DataTable con el resultado
                    using (MySqlDataAdapter adaptador = new MySqlDataAdapter(comando))
                    {
                        DataTable tabla = new DataTable();
                        adaptador.Fill(tabla);
                        return tabla;
                        // Devolvemos el DataTable con los resultados de la consulta
                    }
                }
            }
            finally
            {
                if (cerrarConexion)
                {
                    conexion.Dispose();
                    // Liberamos la conexión si no hay transacción
                }
            }
        }
        // 4. EJECUTAR CONSULTAS QUE NO DEVUELVEN DATOS (INSERT, UPDATE, DELETE) - DML
        public static int EjecutarNonQuery(string consulta, MySqlParameter[] parametros = null, MySqlTransaction? transaccion = null)
        {
            // Si se pasa una transacción, usamos su conexión; si no, obtenemos una nueva conexión
            MySqlConnection conexion = transaccion?.Connection ?? ObtenerConexion();                            //Es lo mismo que hacemos arriba, pero para consultas que no devuelven datos ⬆️
            // Si no hay transacción, cerramos la conexión al final
            bool cerrarConexion = transaccion == null;
            try
            {
                using (MySqlCommand comando = new MySqlCommand(consulta, conexion, transaccion))
                {
                    if (parametros != null)
                    {
                        comando.Parameters.AddRange(parametros);
                        // Esto evita inyección SQL y permite pasar valores dinámicos a la consulta
                        // Agregamos los parámetros al comando si existen
                    }
                    // ExecuteNonQuery devuelve el número de filas afectadas
                    return comando.ExecuteNonQuery();
                }
            }
            finally
            {
                if (cerrarConexion)
                {
                    conexion.Dispose();
                    // Liberamos la conexión si no hay transacción
                }
            }
        }
        // 5. EJECUTAR CONSULTAS QUE DEVUELVEN UN SOLO VALOR (COUNT, SUM, etc.)
        // son consultas que devuelven un solo valor, como COUNT, SUM, AVG, etc. Se usa ExecuteScalar para obtener ese valor.
        // uno de sus usos en el proyecto es para obtener el ID de un registro insertado recientemente, usando LAST_INSERT_ID() en MySQL.
        public static object EjecutarScalar(string consulta, MySqlParameter[] parametros = null, MySqlTransaction? transaccion = null)
        {
            // Si se pasa una transacción, usamos su conexión; si no, obtenemos una nueva conexión
            MySqlConnection conexion = transaccion?.Connection ?? ObtenerConexion();                             //Aqui es lo mismo que arriba, pero para consultas que devuelven un solo valor ⬆️ 
            // Si no hay transacción, cerramos la conexión al final
            bool cerrarConexion = transaccion == null;
            try
            {
                using (MySqlCommand comando = new MySqlCommand(consulta, conexion, transaccion))
                {
                    // Agregamos los parámetros al comando si existen
                    if (parametros != null)
                    {
                        comando.Parameters.AddRange(parametros);
                        // Esto evita inyección SQL y permite pasar valores dinámicos a la consulta
                    }
                    // ExecuteScalar devuelve la primera columna de la primera fila
                    return comando.ExecuteScalar();
                }
            }
            finally
            {
                if (cerrarConexion)
                {
                    conexion.Dispose();
                    // Liberamos la conexión si no hay transacción
                }
            }
        }

    }
}