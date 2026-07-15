using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicDate.CapaDatos
{
    internal class clsConexion
    {
        // 1. LEER LA CADENA DE CONEXIÓN DESDE App.config
        private static readonly string cadenaConexion = ObtenerCadenaConexion();
        // "MedicDateDB" es el name del <add> en App.config

        private static string ObtenerCadenaConexion()
        {

            string? fromConfig = ConfigurationManager.ConnectionStrings["MedicDateDB"]?.ConnectionString;
            if (!string.IsNullOrWhiteSpace(fromConfig))
            {
                return fromConfig;
            }

            return "";
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
                    conexion.Open();
                }
                return conexion;
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
            MySqlConnection conexion = transaccion?.Connection ?? ObtenerConexion();
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
                    }
                }
            }
            finally
            {
                if (cerrarConexion)
                {
                    conexion.Dispose();
                }
            }
        }
        // 4. EJECUTAR CONSULTAS QUE NO DEVUELVEN DATOS (INSERT, UPDATE, DELETE) - DML
        public static int EjecutarNonQuery(string consulta, MySqlParameter[] parametros = null, MySqlTransaction? transaccion = null)
        {
            MySqlConnection conexion = transaccion?.Connection ?? ObtenerConexion();
            bool cerrarConexion = transaccion == null;
            try
            {
                using (MySqlCommand comando = new MySqlCommand(consulta, conexion, transaccion))
                {
                    if (parametros != null)
                    {
                        comando.Parameters.AddRange(parametros);
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
                }
            }
        }
        // 5. EJECUTAR CONSULTAS QUE DEVUELVEN UN SOLO VALOR (COUNT, SUM, etc.)
        public static object EjecutarScalar(string consulta, MySqlParameter[] parametros = null, MySqlTransaction? transaccion = null)
        {
            MySqlConnection conexion = transaccion?.Connection ?? ObtenerConexion();
            bool cerrarConexion = transaccion == null;
            try
            {
                using (MySqlCommand comando = new MySqlCommand(consulta, conexion, transaccion))
                {
                    if (parametros != null)
                    {
                        comando.Parameters.AddRange(parametros);
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
                }
            }
        }

    }
}