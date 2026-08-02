using MedicDate.Datos;
using MedicDate.Procesos;
using Microsoft.Win32;
using MySqlConnector;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace MedicDate.Procesos
{
    internal class clsAsistenteDAL
    {

        public int TotalAsistentes() // Obtiene el total de asistentes activos en la base de datos
        {
            using var conexion = clsConexion.ObtenerConexion();

            string sql = @"SELECT COUNT(*)
                           FROM empleado
                           WHERE estado = 1
                           AND tipo_empleado = 'asistente'";

            using var cmd = new MySqlConnector.MySqlCommand(sql, conexion);

            return Convert.ToInt32(cmd.ExecuteScalar());
        }

        public DataTable CargarDataGrid(int pagina, int registros)// Obtiene los registros de la tabla asistente para paginación
        {
            var tabla = new DataTable();
            try
            {
                using var conexion = clsConexion.ObtenerConexion();
                int offset = (pagina - 1) * registros;

                string sql = @"SELECT CONCAT(E.nombre, ' ', E.apellido_paterno, ' ', E.apellido_materno) AS 'Nombre Completo',
                                 E.fecha_nacimiento AS Fecha_Nacimiento,
                                 E.curp AS Curp,
                                 E.email AS Correo,
                                 E.telefono_principal AS Telefono,
                                 E.telefono_secundario AS 'Telefono secundario',
                                 E.tipo_empleado AS Tipo,
                                 E.id_empleado,
                                 E.estado AS Estado,
                                 A.id_empleado, A.turno FROM empleado E INNER JOIN asistente A ON E.id_empleado = A.id_empleado 
                                 WHERE E.tipo_empleado = 'asistente' 
                                 ORDER BY E.apellido_paterno, E.nombre 
                                 LIMIT @limite OFFSET @offset;";

                using var cmd = new MySqlCommand(sql, conexion);
                cmd.Parameters.AddWithValue("@limite", registros);
                cmd.Parameters.AddWithValue("@offset", offset);
                using var adapter = new MySqlDataAdapter(cmd);

                adapter.Fill(tabla);
                return tabla;
            }
            catch (Exception ex)
            {
                throw new Exception("Error en la tabla " + ex.Message);
            }
        }

        public int TotalBusqueda(string texto)// Obtiene el total de registros que coinciden con la búsqueda en la tabla asistente
        {
            using var conexion = clsConexion.ObtenerConexion();

            string sql = @"SELECT COUNT(*)
                   FROM empleado E
                   INNER JOIN asistente A ON E.id_empleado = A.id_empleado
                   WHERE E.estado = 1
                   AND E.tipo_empleado = 'asistente'
                   AND CONCAT(E.nombre, ' ', E.apellido_paterno, ' ', E.apellido_materno)
                   LIKE @nombre";

            using var cmd = new MySqlCommand(sql, conexion);
            cmd.Parameters.AddWithValue("@nombre", "%" + texto + "%");

            return Convert.ToInt32(cmd.ExecuteScalar());
        }

        public DataTable Consultar(string texto, int pagina, int registros)// Obtiene los registros de la tabla asistente que coinciden con la búsqueda para paginación
        {
            if (string.IsNullOrWhiteSpace(texto))
                return CargarDataGrid(pagina, registros); // usa la página real, no fija 1,10

            var tabla = new DataTable();
            try
            {
                using var conexion = clsConexion.ObtenerConexion();
                int offset = (pagina - 1) * registros;

                string sql = @"SELECT CONCAT(E.nombre, ' ', E.apellido_paterno, ' ', E.apellido_materno) AS 'Nombre Completo',
                         E.fecha_nacimiento AS Fecha_Nacimiento,
                         E.curp AS Curp,
                         E.email AS Correo,
                         E.telefono_principal AS Telefono,
                         E.telefono_secundario AS 'Telefono secundario',
                         E.tipo_empleado AS Tipo,
                         E.id_empleado,
                         E.estado AS Estado,
                         A.id_empleado, A.turno
                       FROM empleado E
                       INNER JOIN asistente A ON E.id_empleado = A.id_empleado
                       WHERE E.tipo_empleado = 'asistente'
                       AND E.estado = 1 AND CONCAT(E.nombre, ' ', E.apellido_paterno, ' ', E.apellido_materno) LIKE @nombre
                       ORDER BY E.apellido_paterno, E.nombre
                       LIMIT @limite OFFSET @offset;";

                using var cmd = new MySqlCommand(sql, conexion);
                cmd.Parameters.AddWithValue("@limite", registros);
                cmd.Parameters.AddWithValue("@offset", offset);
                cmd.Parameters.AddWithValue("@nombre", "%" + texto + "%");
                using var adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(tabla);
                return tabla;
            }
            catch (Exception ex)
            {
                throw new Exception("Error en la conexion: " + ex.Message);
            }
        }

        public static bool DarBaja(int idEmpleado, MySqlTransaction? transaccion = null)// Desactiva un asistente y su usuario asociado en la base de datos
        {

            string consultaEmpleado = "UPDATE empleado SET estado = 0 WHERE id_empleado = @id";
            MySqlParameter[] parametrosEmpleado = { new MySqlParameter("@id", idEmpleado) };
            int filasEmpleado = clsConexion.EjecutarNonQuery(consultaEmpleado, parametrosEmpleado, transaccion);

            if (filasEmpleado == 0)
                return false;

            string consultaUsuario = @"UPDATE usuario u 
                               INNER JOIN empleado e ON u.id_usuario = e.id_usuario
                               SET u.activo = 0
                               WHERE e.id_empleado = @id";
            MySqlParameter[] parametrosUsuario = { new MySqlParameter("@id", idEmpleado) };
            clsConexion.EjecutarNonQuery(consultaUsuario, parametrosUsuario, transaccion);

            return true;
        }

        /*private static (string tipo, bool estado, int? idUsuario) ObtenerInfoAsistente(
            int idEmpleado, MySqlTransaction? transaccion = null)
        {
            string consulta = @"SELECT tipo_empleado, estado, id_usuario FROM empleado WHERE id_empleado = @id";
            MySqlParameter[] parametros = { new MySqlParameter("@id", idEmpleado) };

            DataTable resultado = clsConexion.EjecutarConsulta(consulta, parametros, transaccion);
            if (resultado.Rows.Count == 0)
                throw new ArgumentException("El empleado no existe.");

            DataRow row = resultado.Rows[0];
            string tipo = row["tipo_empleado"].ToString()!;
            if (tipo != "doctor")
                throw new InvalidOperationException("La operación solo aplica a doctores.");

            bool estado = Convert.ToBoolean(row["estado"]);
            int? idUsuario = row["id_usuario"] == DBNull.Value ? null : Convert.ToInt32(row["id_usuario"]);

            return (tipo, estado, idUsuario);
        }*/

       /* private static bool CambiarEstadoAsistente(int idEmpleado, bool activar, MySqlTransaction? transaccion = null)
        {
            var (tipo, estadoActual, idUsuario) = ObtenerInfoAsistente(idEmpleado, transaccion);

            if (estadoActual == activar)
                throw new InvalidOperationException(activar
                    ? "El Asistente ya está activo."
                    : "El Asistente ya está inactivo.");

            MySqlConnection? conexionLocal = null;
            MySqlTransaction? transaccionLocal = null;
            bool usarTransaccionLocal = transaccion == null;

            try
            {
                if (usarTransaccionLocal)
                {
                    conexionLocal = clsConexion.ObtenerConexion();
                    transaccionLocal = conexionLocal.BeginTransaction();
                }

                MySqlTransaction transaccionUsar = transaccion ?? transaccionLocal;


                int nuevoEstado = activar ? 1 : 0;
                string sqlEmpleado = "UPDATE empleado SET estado = @estado WHERE id_empleado = @id";
                MySqlParameter[] paramEmpleado =
                {
                    new MySqlParameter("@estado", nuevoEstado),
                    new MySqlParameter("@id", idEmpleado)
                };
                if (clsConexion.EjecutarNonQuery(sqlEmpleado, paramEmpleado, transaccionUsar) == 0)
                    throw new Exception($"No se pudo {(activar ? "reactivar" : "desactivar")} el empleado.");

                if (idUsuario.HasValue)
                {
                    string sqlUsuario = activar
                        ? "UPDATE usuario SET activo = 1 WHERE id_usuario = @id"
                        : "UPDATE usuario SET activo = 0 WHERE id_usuario = @id";
                    MySqlParameter[] paramUsuario = { new MySqlParameter("@id", idUsuario.Value) };
                }

                if (usarTransaccionLocal)
                    transaccionLocal?.Commit();

                return true;
            }
            catch (Exception ex)
            {
                if (usarTransaccionLocal)
                    transaccionLocal?.Rollback();
                throw new Exception($"Error al {(activar ? "reactivar" : "dar de baja")} al asistente ID {idEmpleado}: {ex.Message}", ex);
            }
            finally
            {
                if (usarTransaccionLocal && conexionLocal != null)
                {
                    conexionLocal.Close();
                    conexionLocal.Dispose();
                }
            }
        }
       */
        public static bool Insertar(clsAsistente asistente, MySqlTransaction? transaccion = null)// Inserta un nuevo asistente en la base de datos
        {

            string consulta = @"INSERT INTO asistente (id_empleado, turno)
                       VALUES (@id_empleado, @turno)";

            MySqlParameter[] parametros = {
                new MySqlParameter("@id_empleado", asistente.id_empleado),
                new MySqlParameter("@turno", string.IsNullOrEmpty(asistente.turno) ? DBNull.Value : (object)asistente.turno)
             };

            return clsConexion.EjecutarNonQuery(consulta, parametros, transaccion) > 0;
        }
        public static bool Actualizar(clsAsistente asistente, MySqlTransaction? transaccion = null)// Actualiza la información de un asistente en la base de datos
        {
            string sql = @"UPDATE asistente 
                           SET turno = @turno
                           WHERE id_empleado = @id";

            MySqlParameter[] parametros = {
                new MySqlParameter("@turno", string.IsNullOrEmpty(asistente.turno) ? DBNull.Value : (object)asistente.turno),
                new MySqlParameter("@id", asistente.id_empleado)
            };

            try
            {
                int filas = clsConexion.EjecutarNonQuery(sql, parametros, transaccion);
                return filas > 0;
            }
            catch (MySqlException ex)
            {
                throw new Exception("Error al actualizar el asistente: " + ex.Message, ex);
            }
        }
        public static clsAsistente? ObtenerAsistentePorId(int idEmpleado)// Obtiene la información de un asistente por su ID de empleado
        {
            string sql = @"SELECT E.*, A.turno, U.usuario AS NombreUsuario
                           FROM empleado E
                           INNER JOIN asistente A ON E.id_empleado = A.id_empleado
                           LEFT JOIN usuario U ON E.id_usuario = U.id_usuario
                           WHERE E.id_empleado = @id";

            MySqlParameter[] parametros = { new MySqlParameter("@id", idEmpleado) };
            DataTable resultado = clsConexion.EjecutarConsulta(sql, parametros);

            if (resultado.Rows.Count == 0) return null;

            DataRow row = resultado.Rows[0];
            return new clsAsistente
            {
                id_empleado = Convert.ToInt32(row["id_empleado"]),
                nombre = row["nombre"].ToString(),
                apellido_paterno = row["apellido_paterno"].ToString(),
                apellido_materno = row["apellido_materno"]?.ToString(),
                fecha_nacimiento = Convert.ToDateTime(row["fecha_nacimiento"]),
                curp = row["curp"]?.ToString(),
                email = row["email"].ToString(),
                telefono_principal = row["telefono_principal"]?.ToString(),
                telefono_secundario = row["telefono_secundario"]?.ToString(),
                tipo_empleado = row["tipo_empleado"].ToString(),
                fecha_contratacion = Convert.ToDateTime(row["fecha_contratacion"]),
                estado = Convert.ToBoolean(row["estado"]),
                id_usuario = row["id_usuario"] == DBNull.Value ? null : Convert.ToInt32(row["id_usuario"]),
                turno = row["turno"]?.ToString(),
                NombreUsuario = row["NombreUsuario"]?.ToString()
            };
        }
    }
}




