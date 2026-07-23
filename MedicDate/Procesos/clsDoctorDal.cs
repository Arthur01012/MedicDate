using MedicDate.Datos;
using MedicDate.Procesos;
using MySqlConnector;
using System;
using System.Data;

namespace MedicDate.Procesos
{
    public class clsDoctorDAL
    {
        public DataTable CargarDataGrid() // Método para cargar todos los doctores activos
        {
            var tabla = new DataTable();
            try
            {
                using var conexion = clsConexion.ObtenerConexion();
                // Consulta SQL para obtener la información de los doctores activos
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
                
                using var adapter = new MySqlDataAdapter(sql, conexion); // Se utiliza MySqlDataAdapter para llenar el DataTable con los resultados de la consulta
                adapter.Fill(tabla); // Llenar el DataTable con los resultados de la consulta
                return tabla;
            }
            catch (MySqlException ex)
            {
                throw new Exception($"Error de base de datos al cargar doctores: {ex.Message}", ex);
            }
        }

        public DataTable Consultar(string texto)
        {
            if (string.IsNullOrWhiteSpace(texto)) // Si el texto de búsqueda está vacío o es nulo, se cargan todos los doctores activos
                return CargarDataGrid(); 

            var tabla = new DataTable();
            try
            {
                using var conexion = clsConexion.ObtenerConexion();
                // Consulta SQL para buscar doctores por nombre completo, utilizando LIKE para coincidencias parciales
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
                // Se utiliza un parámetro para evitar inyecciones SQL y permitir coincidencias parciales
                using var cmd = new MySqlCommand(sql, conexion); // Se crea un comando SQL con la consulta y la conexión
                cmd.Parameters.AddWithValue("@nombre", "%" + texto + "%"); // Se agrega el parámetro con el texto de búsqueda, rodeado de % para permitir coincidencias parciales
                using var adapter = new MySqlDataAdapter(cmd); // Se utiliza MySqlDataAdapter para llenar el DataTable con los resultados de la consulta
                adapter.Fill(tabla); // Llenar el DataTable con los resultados de la consulta
                return tabla;
            }
            catch (MySqlException ex)
            {
                throw new Exception($"Error en búsqueda de doctores: {ex.Message}", ex);
            }
        }
        
        /// Obtiene la información de un empleado: tipo, estado e id_usuario.
        /// Lanza excepciones si no existe o no es doctor.
        private static (string tipo, bool estado, int? idUsuario) ObtenerInfoDoctor(  
            int idEmpleado,                       
            MySqlTransaction? transaccion = null) // Método privado para obtener información de un doctor por su ID de empleado
        {
            string consulta = @"SELECT tipo_empleado, estado, id_usuario FROM empleado WHERE id_empleado = @id"; // Consulta SQL para obtener el tipo de empleado, estado e ID de usuario asociado
            MySqlParameter[] parametros = { new MySqlParameter("@id", idEmpleado) }; // Se crea un parámetro para evitar inyecciones SQL

            DataTable resultado = clsConexion.EjecutarConsulta(consulta, parametros, transaccion); // Se ejecuta la consulta y se obtiene el resultado en un DataTable
            if (resultado.Rows.Count == 0) // Si no se encuentra ningún registro, se lanza una excepción indicando que el empleado no existe
                throw new ArgumentException("El empleado no existe.");

            DataRow row = resultado.Rows[0]; // Se obtiene la primera fila del resultado
            string tipo = row["tipo_empleado"].ToString()!; // Se obtiene el tipo de empleado y se asegura que no sea nulo
            
            bool estado = Convert.ToBoolean(row["estado"]); // Se obtiene el estado del empleado (activo/inactivo) y se convierte a boolean
            int? idUsuario = row["id_usuario"] == DBNull.Value ? null : Convert.ToInt32(row["id_usuario"]); // Se obtiene el ID de usuario asociado, si existe; si no, se asigna null

            return (tipo, estado, idUsuario); // Se retorna una tupla con el tipo de empleado, estado e ID de usuario asociado
        }

     
        /// Cambia el estado de un doctor (activo/inactivo) y actualiza recursos asociados.
        private static bool CambiarEstadoDoctor(
            int idEmpleado,
            bool activar,
            MySqlTransaction? transaccion = null) // Método privado para cambiar el estado de un doctor (activo/inactivo) y actualizar recursos asociados
        {
            // 1. Obtener información del doctor
            var (tipo, estadoActual, idUsuario) = ObtenerInfoDoctor(idEmpleado, transaccion);

            // 2. Validar que el estado actual sea diferente al deseado
            if (estadoActual == activar)
                throw new InvalidOperationException(activar
                    ? "El doctor ya está activo."
                    : "El doctor ya está inactivo.");// Si el estado actual es igual al deseado, se lanza una excepción indicando que no se puede cambiar el estado

            // 3. Transacción local
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

                MySqlTransaction transaccionUsar = transaccion ?? transaccionLocal!; // Se utiliza la transacción proporcionada o la transacción local si no se proporciona ninguna

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

        public static DataTable ObtenerDoctoresActivos()
        {
            string sql = @"SELECT e.id_empleado,
                          CONCAT(e.nombre, ' ', e.apellido_paterno, ' ', IFNULL(e.apellido_materno, '')) AS NombreCompleto
                   FROM empleado e
                   INNER JOIN doctor d ON e.id_empleado = d.id_empleado
                   WHERE e.estado = 1 AND e.tipo_empleado = 'doctor'
                   ORDER BY e.apellido_paterno, e.nombre";
            return clsConexion.EjecutarConsulta(sql);
        }
    }
}