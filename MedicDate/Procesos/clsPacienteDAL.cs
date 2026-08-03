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
        public DataTable CargarDataGrid()// Método para cargar los datos del grid de pacientes
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

        public DataTable Consultar(string texto)// Método para buscar pacientes por nombre, correo o teléfono
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

        public static int Insertar(clsPaciente paciente, MySqlTransaction? transaccion = null)// Método para insertar un nuevo paciente en la base de datos
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
        public static DataTable ObtenerTodos()// Método para obtener todos los pacientes de la base de datos
        {
            string sql = @"
        SELECT
            id_paciente,
            CONCAT(nombre, ' ', apellido_paterno, ' ', IFNULL(apellido_materno, '')) AS NombreCompleto
        FROM paciente
        ORDER BY apellido_paterno, nombre ASC";

            return clsConexion.EjecutarConsulta(sql);
        }

        public static clsPaciente? ObtenerPorId(int idPaciente)// Método para obtener la información de un paciente por su ID
        {
            string sql = @"SELECT * FROM paciente WHERE id_paciente = @id";

            MySqlParameter[] parametros = { new MySqlParameter("@id", idPaciente) };
            DataTable resultado = clsConexion.EjecutarConsulta(sql, parametros);

            if (resultado.Rows.Count == 0) return null;

            DataRow row = resultado.Rows[0];
            return new clsPaciente
            {
                id_paciente = Convert.ToInt32(row["id_paciente"]),
                nombre = row["nombre"].ToString(),
                apellido_paterno = row["apellido_paterno"].ToString(),
                apellido_materno = row["apellido_materno"]?.ToString(),
                fecha_nacimiento = Convert.ToDateTime(row["fecha_nacimiento"]),
                telefono_principal = row["telefono_principal"]?.ToString(),
                telefono_secundario = row["telefono_secundario"]?.ToString(),
                email = row["email"]?.ToString(),
                calle = row["calle"]?.ToString(),
                colonia = row["colonia"]?.ToString(),
                numero = row["numero"]?.ToString(),
                localidad = row["localidad"]?.ToString(),
                id_municipio = row["id_municipio"] == DBNull.Value ? null : Convert.ToInt32(row["id_municipio"]),
                fecha_registro = Convert.ToDateTime(row["fecha_registro"]),
                alergias = row["alergias"]?.ToString(),
                notas_medicas = row["notas_medicas"]?.ToString()
            };
        }

        public static bool Actualizar(clsPaciente paciente, MySqlTransaction? transaccion = null)// Método para actualizar la información de un paciente
        {
            string sql = @"UPDATE paciente
                           SET nombre = @nombre,
                               apellido_paterno = @apellido_paterno,
                               apellido_materno = @apellido_materno,
                               fecha_nacimiento = @fecha_nacimiento,
                               telefono_principal = @telefono_principal,
                               telefono_secundario = @telefono_secundario,
                               email = @email,
                               calle = @calle,
                               colonia = @colonia,
                               numero = @numero,
                               localidad = @localidad,
                               id_municipio = @id_municipio,
                               alergias = @alergias,
                               notas_medicas = @notas_medicas
                           WHERE id_paciente = @id";

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
                new MySqlParameter("@id", paciente.id_paciente)
            };

            try
            {
                int filas = clsConexion.EjecutarNonQuery(sql, parametros, transaccion);
                return filas > 0;
            }
            catch (MySqlException ex)
            {
                throw new Exception("Error al actualizar el paciente: " + ex.Message, ex);
            }
        }
    }
}


