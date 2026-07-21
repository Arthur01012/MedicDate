using MedicDate.Datos;
using MedicDate.Procesos;
using MySqlConnector;
using System;
using System.Data;

namespace MedicDate.Procesos
{
    public class clsDoctorDAL
    {
        // ============================================================
        // ⚠️ MÉTODOS DEL DATAGRIDVIEW (NO MODIFICADOS)
        // ============================================================

        public DataTable CargarDataGrid()
        {
            var tabla = new DataTable();
            try
            {
                using var conexion = clsConexion.ObtenerConexion();
                string sql = @"
                    SELECT 
                        CONCAT(E.nombre, ' ', E.apellido_paterno, ' ', E.apellido_materno) AS 'Nombre Completo',
                        E.fecha_nacimiento AS Fecha_Nacimiento,
                        E.curp AS Curp,
                        E.email AS Correo,
                        E.telefono_principal AS Telefono,
                        E.id_empleado,
                        D.cedula_profesional AS Cedula,
                        S.nombre_especialidad AS Especialidad,
                        D.consultorio AS Consultorio
                    FROM empleado E
                    INNER JOIN doctor D ON E.id_empleado = D.id_empleado
                    LEFT JOIN especialidad S ON D.especialidad_principal = S.id_especialidad
                    WHERE E.estado = 1 AND E.tipo_empleado = 'doctor'";

                using var adapter = new MySqlDataAdapter(sql, conexion);
                adapter.Fill(tabla);
                return tabla;
            }
            catch (MySqlException ex)
            {
                throw new Exception($"Error de base de datos al cargar doctores: {ex.Message}", ex);
            }
        }

        public DataTable Consultar(string texto)
        {
            if (string.IsNullOrWhiteSpace(texto))
                return CargarDataGrid();

            var tabla = new DataTable();
            try
            {
                using var conexion = clsConexion.ObtenerConexion();
                string sql = @"
                    SELECT 
                        CONCAT(E.nombre, ' ', E.apellido_paterno, ' ', E.apellido_materno) AS 'Nombre Completo',
                        E.fecha_nacimiento AS Fecha_Nacimiento,
                        E.curp AS Curp,
                        E.email AS Correo,
                        E.telefono_principal AS Telefono,
                        E.id_empleado,
                        D.cedula_profesional AS Cedula,
                        S.nombre_especialidad AS Especialidad,
                        D.consultorio AS Consultorio
                    FROM empleado E
                    INNER JOIN doctor D ON E.id_empleado = D.id_empleado
                    LEFT JOIN especialidad S ON D.especialidad_principal = S.id_especialidad
                    WHERE E.estado = 1 AND E.tipo_empleado = 'doctor'
                      AND CONCAT(E.nombre, ' ', E.apellido_paterno, ' ', E.apellido_materno) LIKE @nombre";

                using var cmd = new MySqlCommand(sql, conexion);
                cmd.Parameters.AddWithValue("@nombre", "%" + texto + "%");
                using var adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(tabla);
                return tabla;
            }
            catch (MySqlException ex)
            {
                throw new Exception($"Error en búsqueda de doctores: {ex.Message}", ex);
            }
        }

        // ============================================================
        // 🆕 MÉTODOS PRIVADOS AUXILIARES (LÓGICA COMPARTIDA)
        // ============================================================

        /// <summary>
        /// Obtiene la información de un empleado: tipo, estado e id_usuario.
        /// Lanza excepciones si no existe o no es doctor.
        /// </summary>
        private static (string tipo, bool estado, int? idUsuario) ObtenerInfoDoctor(
            int idEmpleado,
            MySqlTransaction? transaccion = null)
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
        }

        /// <summary>
        /// Cambia el estado de un doctor (activo/inactivo) y actualiza recursos asociados.
        /// </summary>
        /// <param name="idEmpleado">ID del doctor.</param>
        /// <param name="activar">true = reactivar, false = dar de baja.</param>
        /// <param name="transaccion">Transacción externa opcional.</param>
        private static bool CambiarEstadoDoctor(
            int idEmpleado,
            bool activar,
            MySqlTransaction? transaccion = null)
        {
            // 1. Obtener información del doctor
            var (tipo, estadoActual, idUsuario) = ObtenerInfoDoctor(idEmpleado, transaccion);

            // 2. Validar que el estado actual sea diferente al deseado
            if (estadoActual == activar)
                throw new InvalidOperationException(activar
                    ? "El doctor ya está activo."
                    : "El doctor ya está inactivo.");

            // 3. Transacción local si no se proporciona una externa
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

                // 4. Actualizar estado del empleado
                int nuevoEstado = activar ? 1 : 0;
                string sqlEmpleado = "UPDATE empleado SET estado = @estado WHERE id_empleado = @id";
                MySqlParameter[] paramEmpleado = {
                    new MySqlParameter("@estado", nuevoEstado),
                    new MySqlParameter("@id", idEmpleado)
                };
                if (clsConexion.EjecutarNonQuery(sqlEmpleado, paramEmpleado, transaccionUsar) == 0)
                    throw new Exception($"No se pudo {(activar ? "reactivar" : "desactivar")} el empleado.");

                // 5. Actualizar horarios (activo/inactivo)
                string sqlHorarios = activar
                    ? "UPDATE horario SET activo = 1 WHERE id_doctor = @id"
                    : "UPDATE horario SET activo = 0 WHERE id_doctor = @id";
                MySqlParameter[] paramHorarios = { new MySqlParameter("@id", idEmpleado) };
                clsConexion.EjecutarNonQuery(sqlHorarios, paramHorarios, transaccionUsar);

                // 6. Si es baja, cancelar citas futuras (solo cuando se desactiva)
                if (!activar)
                {
                    string sqlCitas = @"UPDATE cita 
                                        SET estado = 'Cancelada' 
                                        WHERE id_doctor = @id AND fecha >= CURDATE() 
                                        AND estado IN ('Pendiente', 'Confirmada')";
                    MySqlParameter[] paramCitas = { new MySqlParameter("@id", idEmpleado) };
                    clsConexion.EjecutarNonQuery(sqlCitas, paramCitas, transaccionUsar);
                }

                // 7. Actualizar estado del usuario asociado
                if (idUsuario.HasValue)
                {
                    string sqlUsuario = activar
                        ? "UPDATE usuario SET activo = 1 WHERE id_usuario = @id"
                        : "UPDATE usuario SET activo = 0 WHERE id_usuario = @id";
                    MySqlParameter[] paramUsuario = { new MySqlParameter("@id", idUsuario.Value) };
                    clsConexion.EjecutarNonQuery(sqlUsuario, paramUsuario, transaccionUsar);
                }

                // 8. Commit si se usó transacción local
                if (usarTransaccionLocal)
                    transaccionLocal?.Commit();

                return true;
            }
            catch (Exception ex)
            {
                if (usarTransaccionLocal)
                    transaccionLocal?.Rollback();
                throw new Exception($"Error al {(activar ? "reactivar" : "dar de baja")} al doctor ID {idEmpleado}: {ex.Message}", ex);
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

        // ============================================================
        // 🆕 MÉTODOS PÚBLICOS QUE USAN LA LÓGICA COMPARTIDA
        // ============================================================

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
                if (ex.Number == 1062)
                {
                    if (ex.Message.Contains("cedula_profesional"))
                        throw new InvalidOperationException($"La cédula '{doctor.cedula_profesional}' ya está registrada.", ex);
                    else if (ex.Message.Contains("id_empleado"))
                        throw new InvalidOperationException($"El empleado ID {doctor.id_empleado} ya es doctor.", ex);
                    else
                        throw new InvalidOperationException("El registro ya existe.", ex);
                }
                else if (ex.Number == 1452)
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

        public static bool Actualizar(clsDoctor doctor, MySqlTransaction? transaccion = null)
        {
            // Validar cédula única (excluyendo al propio doctor)
            string consultaCedula = "SELECT COUNT(*) FROM doctor WHERE cedula_profesional = @cedula AND id_empleado != @id";
            MySqlParameter[] paramCedula = {
                new MySqlParameter("@cedula", doctor.cedula_profesional),
                new MySqlParameter("@id", doctor.id_empleado)
            };
            object cedulaExiste = clsConexion.EjecutarScalar(consultaCedula, paramCedula, transaccion);
            if (cedulaExiste != null && Convert.ToInt32(cedulaExiste) > 0)
                throw new InvalidOperationException($"La cédula {doctor.cedula_profesional} ya está registrada por otro doctor.");

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
                else if (ex.Number == 1452)
                    throw new InvalidOperationException($"La especialidad seleccionada no es válida.", ex);
                else
                    throw new Exception("Error al actualizar el doctor: " + ex.Message, ex);
            }
        }

        public static bool DarBaja(int idEmpleado, MySqlTransaction? transaccion = null)
        {
            return CambiarEstadoDoctor(idEmpleado, activar: false, transaccion);
        }

        public static bool Reactivar(int idEmpleado, MySqlTransaction? transaccion = null)
        {
            return CambiarEstadoDoctor(idEmpleado, activar: true, transaccion);
        }

        public static clsDoctor? ObtenerDoctorPorId(int idEmpleado)
        {
            string sql = @"SELECT E.*, D.cedula_profesional, D.especialidad_principal, D.consultorio, U.usuario AS NombreUsuario
                           FROM empleado E
                           INNER JOIN doctor D ON E.id_empleado = D.id_empleado
                           LEFT JOIN usuario U ON E.id_usuario = U.id_usuario
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
                consultorio = row["consultorio"]?.ToString(),
                NombreUsuario = row["NombreUsuario"]?.ToString()
            };
        }
    }
}