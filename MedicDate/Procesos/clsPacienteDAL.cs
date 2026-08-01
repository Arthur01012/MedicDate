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
    internal class clsPacienteDAL
    {
        public DataTable CargarDataGrid()
        {
            DataTable tabla = new DataTable();
            try
            {
                using var conexion = clsConexion.ObtenerConexion();
                string sql = @"
                    SELECT 
                        id_paciente,
                        CONCAT(nombre, ' ', apellido_paterno, ' ', IFNULL(apellido_materno, '')) AS 'Nombre Completo',
                        email AS Correo,
                        telefono_principal AS Teléfono,
                        fecha_nacimiento AS 'Fecha Nacimiento',
                        alergias AS Alergias,
                        fecha_registro AS 'Fecha Registro'
                    FROM paciente 
                    ORDER BY apellido_paterno, nombre ASC;";

                using var adapter = new MySqlDataAdapter(sql, conexion);
                adapter.Fill(tabla);
                return tabla;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al cargar los pacientes: " + ex.Message, ex);
            }
        }

        public DataTable Consultar(string texto)
        {
            if (string.IsNullOrWhiteSpace(texto))
                return CargarDataGrid();

            DataTable tabla = new DataTable();
            try
            {
                using var conexion = clsConexion.ObtenerConexion();
                string sql = @"
                    SELECT 
                        id_paciente,
                        CONCAT(nombre, ' ', apellido_paterno, ' ', IFNULL(apellido_materno, '')) AS 'Nombre Completo',
                        email AS Correo,
                        telefono_principal AS Teléfono,
                        fecha_nacimiento AS 'Fecha Nacimiento',
                        alergias AS Alergias,
                        fecha_registro AS 'Fecha Registro'
                    FROM paciente 
                    WHERE CONCAT(nombre, ' ', apellido_paterno, ' ', IFNULL(apellido_materno, '')) LIKE @busqueda
                       OR email LIKE @busqueda
                       OR telefono_principal LIKE @busqueda
                    ORDER BY apellido_paterno, nombre ASC;";

                using var cmd = new MySqlCommand(sql, conexion);
                cmd.Parameters.AddWithValue("@busqueda", "%" + texto + "%");
                using var adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(tabla);
                return tabla;
            }
            catch (Exception ex)
            {
                throw new Exception("Error en la búsqueda de pacientes: " + ex.Message, ex);
            }
        }

    }
}


