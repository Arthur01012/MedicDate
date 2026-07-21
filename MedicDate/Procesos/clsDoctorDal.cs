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
    internal class clsDoctorDAL
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
                    string sql = "SELECT CONCAT(E.nombre, ' ', E.apellido_paterno, ' ', E.apellido_materno) AS 'Nombre Completo'," +
                                "E.curp AS Curp," +
                                "E.email AS Correo," +
                                "E.telefono_principal AS Telefono," +
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
            // Validar que el empleado no sea ya doctor
            string consultaExiste = "SELECT COUNT(*) FROM doctor WHERE id_empleado = @id";
            MySqlParameter[] paramExiste = { new MySqlParameter("@id", doctor.id_empleado) };
            object existe = clsConexion.EjecutarScalar(consultaExiste, paramExiste, transaccion);
            if (existe != null && Convert.ToInt32(existe) > 0)
                throw new InvalidOperationException($"El empleado ID {doctor.id_empleado} ya es doctor.");

            // Validar cédula única
            string consultaCedula = "SELECT COUNT(*) FROM doctor WHERE cedula_profesional = @cedula";
            MySqlParameter[] paramCedula = { new MySqlParameter("@cedula", doctor.cedula_profesional) };
            object cedulaExiste = clsConexion.EjecutarScalar(consultaCedula, paramCedula, transaccion);
            if (cedulaExiste != null && Convert.ToInt32(cedulaExiste) > 0)
                throw new InvalidOperationException($"La cédula {doctor.cedula_profesional} ya está registrada.");


            string consulta = @"INSERT INTO doctor (id_empleado, cedula_profesional, especialidad_principal, consultorio)
                        VALUES (@id_empleado, @cedula, @especialidad, @consultorio)";

            MySqlParameter[] parametros = {
                new MySqlParameter("@id_empleado", doctor.id_empleado),
                new MySqlParameter("@cedula", doctor.cedula_profesional),
                new MySqlParameter("@especialidad", doctor.especialidad_principal.HasValue ? (object)doctor.especialidad_principal.Value : DBNull.Value),
                new MySqlParameter("@consultorio", string.IsNullOrEmpty(doctor.consultorio) ? DBNull.Value : (object)doctor.consultorio)
            };

            try
            {
                int filasAfectadas = clsConexion.EjecutarNonQuery(consulta, parametros, transaccion);
                return filasAfectadas > 0;
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 1062) // Duplicado
                {
                    if (ex.Message.Contains("cedula_profesional"))
                        throw new InvalidOperationException($"La cédula '{doctor.cedula_profesional}' ya está registrada.", ex);
                    else if (ex.Message.Contains("id_empleado"))
                        throw new InvalidOperationException($"El empleado ID {doctor.id_empleado} ya es doctor.", ex);
                    else
                        throw new InvalidOperationException("El registro ya existe.", ex);
                }
                else if (ex.Number == 1452) // Clave foránea
                {
                    if (ex.Message.Contains("id_empleado"))
                        throw new InvalidOperationException($"El empleado ID {doctor.id_empleado} no existe.", ex);
                    else if (ex.Message.Contains("especialidad_principal"))
                        throw new InvalidOperationException($"La especialidad seleccionada no es válida.", ex);
                    else
                        throw new InvalidOperationException("Error de clave foránea al insertar el doctor.", ex);
                }
                else
                    throw new Exception("Error al insertar el doctor: " + ex.Message, ex);
            }
        }
        public static bool DarBaja(int idEmpleado, MySqlTransaction? transaccion = null)
        {
            // Validar que el empleado sea doctor
            string consultaValidar = @"SELECT tipo_empleado, id_usuario FROM empleado WHERE id_empleado = @id";
            MySqlParameter[] paramValidar = { new MySqlParameter("@id", idEmpleado) };
            DataTable resultado = clsConexion.EjecutarConsulta(consultaValidar, paramValidar, transaccion);
            if (resultado.Rows.Count == 0)
                throw new ArgumentException("El empleado no existe.");

            string tipo = resultado.Rows[0]["tipo_empleado"].ToString();
            if (tipo != "doctor")
                throw new InvalidOperationException("Solo se puede dar de baja a doctores.");

            int? idUsuario = resultado.Rows[0]["id_usuario"] == DBNull.Value ? null : Convert.ToInt32(resultado.Rows[0]["id_usuario"]);

            // Usar transacción (si no se proporcionó una externa)
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

                MySqlTransaction transaccionUsar = transaccion ?? transaccionLocal!;

                // Desactivar empleado
                string consultaEmpleado = "UPDATE empleado SET estado = 0 WHERE id_empleado = @id";
                MySqlParameter[] parametrosEmpleado = { new MySqlParameter("@id", idEmpleado) };
                int filas = clsConexion.EjecutarNonQuery(consultaEmpleado, parametrosEmpleado, transaccionUsar);
                if (filas == 0)
                    throw new Exception("No se pudo desactivar el empleado.");

                // Desactivar horarios
                string consultaHorarios = "UPDATE horario SET activo = 0 WHERE id_doctor = @id";
                MySqlParameter[] parametrosHorarios = { new MySqlParameter("@id", idEmpleado) };
                clsConexion.EjecutarNonQuery(consultaHorarios, parametrosHorarios, transaccionUsar);

                // Cancelar citas futuras
                string consultaCitas = @"UPDATE cita 
                                 SET estado = 'Cancelada' 
                                 WHERE id_doctor = @id AND fecha >= CURDATE() 
                                 AND estado IN ('Pendiente', 'Confirmada')";
                MySqlParameter[] parametrosCitas = { new MySqlParameter("@id", idEmpleado) };
                clsConexion.EjecutarNonQuery(consultaCitas, parametrosCitas, transaccionUsar);

                // Desactivar usuario asociado
                if (idUsuario.HasValue)
                {
                    string consultaUsuario = "UPDATE usuario SET activo = 0 WHERE id_usuario = @id";
                    MySqlParameter[] parametrosUsuario = { new MySqlParameter("@id", idUsuario.Value) };
                    clsConexion.EjecutarNonQuery(consultaUsuario, parametrosUsuario, transaccionUsar);
                }

                if (usarTransaccionLocal)
                    transaccionLocal?.Commit();

                return true;
            }
            catch (Exception ex)
            {
                if (usarTransaccionLocal)
                    transaccionLocal?.Rollback();
                throw new Exception($"Error al dar de baja al doctor ID {idEmpleado}: {ex.Message}", ex);
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

        /// <summary>
        /// Reactiva a un doctor (cambia estado a activo y reactiva su usuario y horarios).
        /// </summary>
        public static bool Reactivar(int idEmpleado, MySqlTransaction? transaccion = null)
        {
            // Validar que el empleado sea doctor y esté inactivo
            string consultaValidar = @"SELECT tipo_empleado, id_usuario, estado FROM empleado WHERE id_empleado = @id";
            MySqlParameter[] paramValidar = { new MySqlParameter("@id", idEmpleado) };
            DataTable resultado = clsConexion.EjecutarConsulta(consultaValidar, paramValidar, transaccion);
            if (resultado.Rows.Count == 0)
                throw new ArgumentException("El empleado no existe.");

            string tipo = resultado.Rows[0]["tipo_empleado"].ToString();
            if (tipo != "doctor")
                throw new InvalidOperationException("Solo se puede reactivar a doctores.");

            bool estadoActual = Convert.ToBoolean(resultado.Rows[0]["estado"]);
            if (estadoActual)
                throw new InvalidOperationException("El doctor ya está activo.");

            int? idUsuario = resultado.Rows[0]["id_usuario"] == DBNull.Value ? null : Convert.ToInt32(resultado.Rows[0]["id_usuario"]);

            // Transacción
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

                MySqlTransaction transaccionUsar = transaccion ?? transaccionLocal!;

                // Reactivar empleado
                string consultaEmpleado = "UPDATE empleado SET estado = 1 WHERE id_empleado = @id";
                MySqlParameter[] parametrosEmpleado = { new MySqlParameter("@id", idEmpleado) };
                int filas = clsConexion.EjecutarNonQuery(consultaEmpleado, parametrosEmpleado, transaccionUsar);
                if (filas == 0)
                    throw new Exception("No se pudo reactivar el empleado.");

                // Reactivar horarios (opcional: si quieres que todos los horarios se activen)
                string consultaHorarios = "UPDATE horario SET activo = 1 WHERE id_doctor = @id";
                MySqlParameter[] parametrosHorarios = { new MySqlParameter("@id", idEmpleado) };
                clsConexion.EjecutarNonQuery(consultaHorarios, parametrosHorarios, transaccionUsar);

                // Reactivar usuario asociado
                if (idUsuario.HasValue)
                {
                    string consultaUsuario = "UPDATE usuario SET activo = 1 WHERE id_usuario = @id";
                    MySqlParameter[] parametrosUsuario = { new MySqlParameter("@id", idUsuario.Value) };
                    clsConexion.EjecutarNonQuery(consultaUsuario, parametrosUsuario, transaccionUsar);
                }

                if (usarTransaccionLocal)
                    transaccionLocal?.Commit();

                return true;
            }
            catch (Exception ex)
            {
                if (usarTransaccionLocal)
                    transaccionLocal?.Rollback();
                throw new Exception($"Error al reactivar al doctor ID {idEmpleado}: {ex.Message}", ex);
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

        public static clsDoctor? ObtenerDoctorPorId(int idEmpleado)
        {
            string sql = @"SELECT E.*, D.cedula_profesional, D.especialidad_principal, D.consultorio
                   FROM empleado E
                   INNER JOIN doctor D ON E.id_empleado = D.id_empleado
                   WHERE E.id_empleado = @id";

            MySqlParameter[] parametros = { new MySqlParameter("@id", idEmpleado) };
            DataTable resultado = clsConexion.EjecutarConsulta(sql, parametros);

            if (resultado.Rows.Count == 0) return null;

            DataRow row = resultado.Rows[0];
            return new clsDoctor
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
                cedula_profesional = row["cedula_profesional"].ToString(),
                especialidad_principal = row["especialidad_principal"] == DBNull.Value ? null : Convert.ToInt32(row["especialidad_principal"]),
                consultorio = row["consultorio"]?.ToString()
            };
        }

        public static bool Actualizar(clsDoctor doctor, MySqlTransaction? transaccion = null)
        {
            string sql = @"UPDATE doctor 
                   SET cedula_profesional = @cedula,
                       especialidad_principal = @especialidad,
                       consultorio = @consultorio
                   WHERE id_empleado = @id";

            MySqlParameter[] parametros = {
        new MySqlParameter("@cedula", doctor.cedula_profesional),
        new MySqlParameter("@especialidad", doctor.especialidad_principal.HasValue ? (object)doctor.especialidad_principal.Value : DBNull.Value),
        new MySqlParameter("@consultorio", string.IsNullOrEmpty(doctor.consultorio) ? DBNull.Value : (object)doctor.consultorio),
        new MySqlParameter("@id", doctor.id_empleado)
    };

            try
            {
                int filas = clsConexion.EjecutarNonQuery(sql, parametros, transaccion);
                return filas > 0;
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 1062)
                    throw new InvalidOperationException($"La cédula '{doctor.cedula_profesional}' ya está registrada.", ex);
                else
                    throw new Exception("Error al actualizar el doctor: " + ex.Message, ex);
            }
        }
    }
}
