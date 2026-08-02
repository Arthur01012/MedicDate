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

        public static int Insertar(clsPaciente paciente, MySqlTransaction? transaccion = null)
        {
            string consulta = @"
            INSERT INTO paciente
            (
                nombre,
                apellido_paterno,
                apellido_materno,
                fecha_nacimiento,
                telefono_principal,
                telefono_secundario,
                email,
                calle,
                colonia,
                numero,
                localidad,
                id_municipio,
                alergias,
                notas_medicas,
                fecha_registro
            )
              VALUES
            (
                @nombre,
                @apellido_paterno,
                @apellido_materno,
                @fecha_nacimiento,
                @telefono_principal,
                @telefono_secundario,
                @email,
                @calle,
                @colonia,
                @numero,
                @localidad,
                @id_municipio,
                @alergias,
                @notas_medicas,
                @fecha_registro
            );

            SELECT LAST_INSERT_ID();";

            MySqlParameter[] parametros =
            {
                    new MySqlParameter("@nombre", paciente.nombre),
                    new MySqlParameter("@apellido_paterno", paciente.apellido_paterno),
                    new MySqlParameter("@apellido_materno", paciente.apellido_materno),
                    new MySqlParameter("@fecha_nacimiento", paciente.fecha_nacimiento),
                    new MySqlParameter("@telefono_principal", paciente.telefono_principal),
                    new MySqlParameter("@telefono_secundario", paciente.telefono_secundario),
                    new MySqlParameter("@email", paciente.email),
                    new MySqlParameter("@calle", paciente.calle),
                    new MySqlParameter("@colonia", paciente.colonia),
                    new MySqlParameter("@numero", paciente.numero),
                    new MySqlParameter("@localidad", paciente.localidad),
                    new MySqlParameter("@id_municipio", paciente.id_municipio),
                    new MySqlParameter("@alergias", paciente.alergias),
                    new MySqlParameter("@notas_medicas", paciente.notas_medicas),
                    new MySqlParameter("@fecha_registro", DateTime.Now)
                };

            object resultado = clsConexion.EjecutarScalar(consulta, parametros, transaccion);

            return resultado == DBNull.Value ? 0 : Convert.ToInt32(resultado);
        }
        public static DataTable ObtenerTodos()
        {
            string sql = @"
        SELECT 
            id_paciente,
            CONCAT(nombre, ' ', apellido_paterno, ' ', IFNULL(apellido_materno, '')) AS NombreCompleto
        FROM paciente 
        ORDER BY apellido_paterno, nombre ASC";

            return clsConexion.EjecutarConsulta(sql);
        }
    }
}


