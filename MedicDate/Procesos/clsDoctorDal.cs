using MedicDate.Datos;
using MedicDate.Procesos;
using Microsoft.Win32;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MedicDate.Procesos
{
    internal class clsDoctorDal
    {
        private MySqlCommand comando;
        private MySqlDataAdapter consulta;
        private DataTable tabla;

        public object? CargarDataGrid()
        {
            tabla = new DataTable();

            try
            {
                using (var conexion = clsConexion.ObtenerConexion())
                {
                    string sql = "SELECT CONCAT(E.nombre, ' ', E.apellido_paterno, ' ', E.apellido_materno) AS 'Nombre Completo'," +
                                 "E.fecha_nacimiento AS Fecha_Nacimiento, E.curp AS Curp, E.email AS Correo, E.telefono_principal AS Telefono," +
                                 "E.id_empleado,D.cedula_profesional AS Cedula, D.especialidad_principal AS Especialidad, D.consultorio AS consultorio " +
                                 "FROM empleado E INNER JOIN doctor D ON E.id_empleado = D.id_empleado; "; 

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
                    string sql = "SELECT CONCAT(E.nombre, ' ', E.apellido_paterno, ' ', E.apellido_materno) AS 'Nombre Completo', " +
                                 "E.curp AS Curp, " +
                                 "E.email AS Correo, " +
                                 "E.telefono_principal AS Telefono, " +
                                 "E.id_usuario, U.id_usuario, R.id_rol, R.nombre AS Tipo " +
                                 "FROM empleado E " +
                                 "INNER JOIN usuario U ON E.id_usuario = U.id_usuario " +
                                 "INNER JOIN rol R ON U.id_rol = R.id_rol " +
                                 "WHERE R.nombre = 'Doctor' " +
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

        public static bool Insertar(clsDoctor doctor, MySqlTransaction? transaccion = null)
        {
            string consulta = @"INSERT INTO DOCTOR (id_empleado, cedula_profesional, especialidad_principal, consultorio)
                               VALUES (@id_empleado, @cedula, @especialidad, @consultorio)";

            MySqlParameter[] parametros = {
                new MySqlParameter("@id_empleado", doctor.id_empleado),
                new MySqlParameter("@cedula", doctor.cedula_profesional),
                new MySqlParameter("@especialidad", doctor.especialidad_principal.HasValue ? (object)doctor.especialidad_principal.Value : DBNull.Value),
                new MySqlParameter("@consultorio", string.IsNullOrEmpty(doctor.consultorio) ? DBNull.Value : (object)doctor.consultorio)
            };

            return clsConexion.EjecutarNonQuery(consulta, parametros, transaccion) > 0;
        }

    }
}



