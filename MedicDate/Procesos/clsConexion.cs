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
        private static readonly string cadenaConexion = ObtenerCadenaConexion();

        private static string ObtenerCadenaConexion()
        {

            string? fromConfig = ConfigurationManager.ConnectionStrings["MedicDateDB"]?.ConnectionString;
            if (!string.IsNullOrWhiteSpace(fromConfig))
            {
                return fromConfig;
            }

            return "";
        }

        public static MySqlConnection ObtenerConexion()
        {
            try
            {
                MySqlConnection conexion = new MySqlConnection(cadenaConexion);
                if (conexion.State == ConnectionState.Closed)
                {
                    conexion.Open();
                }
                return conexion;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al conectar con la base de datos: " + ex.Message);
            }
        }
    }
}