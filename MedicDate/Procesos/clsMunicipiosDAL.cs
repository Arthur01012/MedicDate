using MedicDate.Helpers;
using MySqlConnector;
using System;
using System.Data;

namespace MedicDate.Procesos
{

    public class clsMunicipioDAL
    {
        public static DataTable ObtenerMunicipios()// Método para obtener los municipios desde la base de datos
        {
            DataTable tabla = new DataTable();

            try
            {
                using var conexion = clsConexion.ObtenerConexion();

                string sql = @"
                        SELECT id_municipio,
                               nombre
                        FROM municipio
                        ORDER BY nombre";

                using var adapter = new MySqlDataAdapter(sql, conexion);
                adapter.Fill(tabla);

                return tabla;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al cargar municipios: " + ex.Message);
            }
        }
    }

}
