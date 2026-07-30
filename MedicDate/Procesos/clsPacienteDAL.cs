using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;
namespace MedicDate.Procesos
{
    internal class clsPacienteDAL
    {
        public DataTable cargarDataGrid()
        {
            DataTable tabla = new DataTable();
            try
            {
                using var conexion = clsConexion.ObtenerConexion();
                string sql = @"SELECT 
                
                ";
                using var adapter =  new MySqlDataAdapter(sql, conexion);
                adapter.Fill(tabla);
                return tabla;
            }
            catch(Exception ex) {
            
                throw new Exception("Error al cargar los datos del paciente: " + ex.Message); 
            }

        }
    }
}
