using MedicDate.Datos;
using MedicDate.Procesos;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.ComponentModel.Design.ObjectSelectorEditor;
namespace MedicDate.Procesos
{
    internal class clsAsistenteDAL
    {
        private MySqlCommand comando;
        private MySqlDataAdapter consulta;
        private DataTable tabla;
        public static bool Insertar(clsAsistente asistente, MySqlTransaction? transaccion = null)
        {

            string consulta = @"INSERT INTO asistente (id_empleado, turno)
                       VALUES (@id_empleado, @turno)";

            MySqlParameter[] parametros = {
        new MySqlParameter("@id_empleado", asistente.id_empleado),
        new MySqlParameter("@turno", string.IsNullOrEmpty(asistente.turno) ? DBNull.Value : (object)asistente.turno)
    };

            return clsConexion.EjecutarNonQuery(consulta, parametros, transaccion) > 0;

        }
        public object? CargarDataGrid()
        {
            tabla = new DataTable();

            try
            {
                using (var conexion = clsConexion.ObtenerConexion())
                {
                    string sql = "SELECT CONCAT(E.nombre, ' ', E.apellido_paterno, ' ', E.apellido_materno) AS 'Nombre Completo',"+
                                 "E.fecha_nacimiento AS Fecha_Nacimiento, E.curp AS Curp, E.email AS Correo, E.telefono_principal AS Telefono," +
                                 "E.telefono_secundario AS 'Telefono secundario', E.tipo_empleado AS Tipo,"+
                                 "E.id_empleado, E.estado AS Estado, A.id_empleado, A.turno " +
                                 "FROM empleado E INNER JOIN asistente A ON E.id_empleado = A.id_empleado;";

                    using (consulta = new MySqlDataAdapter(sql, conexion))
                    {
                        consulta.Fill(tabla);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error en la tabla " + ex.Message);
            }
            return tabla;
        }

        public DataTable Consultar(string text)
        {
            tabla = new DataTable();

            try
            {
                using (var conexion = clsConexion.ObtenerConexion())
                {
                    string sql = "SELECT CONCAT(E.nombre, ' ', E.apellido_paterno, ' ', E.apellido_materno) AS 'Nombre Completo'," +
                                "E.curp AS Curp," +
                                "E.email AS Correo," +
                                "E.telefono_principal AS Telefono," +
                                "E.id_usuario, U.id_usuario, R.id_rol, R.nombre AS Tipo " +
                                "FROM empleado E " +
                                "INNER JOIN usuario U ON E.id_usuario = U.id_usuario " +
                                "INNER JOIN rol R ON U.id_rol = R.id_rol " +
                                "WHERE R.nombre = 'Asistente' " +
                                "AND CONCAT(E.nombre, ' ', E.apellido_paterno, ' ', E.apellido_materno) LIKE @nombre;";

                    using (var consultar = new MySqlCommand(sql, conexion))
                    {
                        consultar.Parameters.AddWithValue("@nombre", "%" + text + "%");
                        using (consulta = new MySqlDataAdapter(consultar))
                        {
                            consulta.Fill(tabla);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error en la conexion" + ex.Message);
            }
            return tabla;
        }

        public static bool DarBaja(int idEmpleado, MySqlTransaction? transaccion = null)
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

    }
}
