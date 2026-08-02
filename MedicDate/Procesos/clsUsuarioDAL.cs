using MedicDate.Datos;
using MedicDate.Helpers;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicDate.Procesos
{
    internal class clsUsuarioDAL
    {
        public static bool UsuarioExiste(string usuario) // Verifica si un usuario existe en la base de datos
        {
            string consulta = "SELECT COUNT(*) FROM usuario WHERE usuario = @usuario";
            MySqlParameter[] parametros = {
                new MySqlParameter("@usuario", usuario)
            }; // Parámetros para la consulta

            object resultado = clsConexion.EjecutarScalar(consulta, parametros); // Ejecuta la consulta y obtiene el resultado
            return Convert.ToInt32(resultado) > 0; // Retorna true si el usuario existe, false en caso contrario
        }

        public static bool UsuarioActivo(string usuario) // Verifica si un usuario está activo en la base de datos
        {
            string consulta = "SELECT activo FROM usuario WHERE usuario = @usuario";
            MySqlParameter[] parametros = {
                new MySqlParameter("@usuario", usuario)
            }; // Parámetros para la consulta

            DataTable resultado = clsConexion.EjecutarConsulta(consulta, parametros); // Ejecuta la consulta y obtiene el resultado
            if (resultado.Rows.Count > 0)
            {
                return Convert.ToBoolean(resultado.Rows[0]["activo"]); // Retorna true si el usuario está activo, false en caso contrario
            }
            return false; // Retorna false si el usuario no existe
        }

        public static clsUsuario Autenticar(string usuario, string contrasena) // Autentica un usuario verificando su nombre de usuario y contraseña
        {
            string contrasenaEncriptada = clsEncriptacion.EncriptarSHA256(contrasena); // Encripta la contraseña ingresada por el usuario
            string consulta = @"SELECT u.*, r.nombre as nombre_rol 
                               FROM usuario u
                               INNER JOIN rol r ON u.id_rol = r.id_rol
                               WHERE u.usuario = @usuario AND u.activo = 1";

            MySqlParameter[] parametros = {
                new MySqlParameter("@usuario", usuario)
            }; // Parámetros para la consulta

            DataTable resultado = clsConexion.EjecutarConsulta(consulta, parametros); // Ejecuta la consulta y obtiene el resultado

            if (resultado.Rows.Count == 0)
            {
                return null;
            } // Retorna null si el usuario no existe o no está activo

            DataRow fila = resultado.Rows[0];
            string contrasenaAlmacenada = fila["contrasena"].ToString();
            bool passwordValido = string.Equals(contrasenaAlmacenada, contrasenaEncriptada, StringComparison.OrdinalIgnoreCase)
                                   || string.Equals(contrasenaAlmacenada, contrasena, StringComparison.Ordinal); // Verifica si la contraseña ingresada coincide con la almacenada

            if (!passwordValido)
            {
                return null;
            } // Retorna null si la contraseña es incorrecta

            clsUsuario user = new clsUsuario
            {
                id_usuario = Convert.ToInt32(fila["id_usuario"]),
                usuario = fila["usuario"].ToString(),
                id_rol = Convert.ToInt32(fila["id_rol"]),
                nombre_rol = fila["nombre_rol"].ToString(),
                activo = Convert.ToBoolean(fila["activo"])
            }; // Crea un objeto clsUsuario con los datos del usuario autenticado 


            if (!string.Equals(contrasenaAlmacenada, contrasenaEncriptada, StringComparison.OrdinalIgnoreCase)) // Verifica si la contraseña almacenada no está encriptada
            {
                // Actualizar contraseña almacenada en texto plano a su hash SHA256
                string actualizacion = "UPDATE usuario SET contrasena = @contrasena WHERE id_usuario = @id";
                MySqlParameter[] parametrosActualizacion = {
                    new MySqlParameter("@contrasena", contrasenaEncriptada),
                    new MySqlParameter("@id", user.id_usuario)
                };
                clsConexion.EjecutarNonQuery(actualizacion, parametrosActualizacion); // Actualiza la contraseña en la base de datos a su versión encriptada
            }

            ActualizarUltimoAcceso(user.id_usuario); // Actualiza la fecha y hora del último acceso del usuario en la base de datos
            return user; // Retorna el objeto clsUsuario con los datos del usuario autenticado
        }
        /*
             [Usuario ingresa usuario y contraseña]
                           ↓
             [Se encripta la contraseña con SHA-256]
                           ↓
             [Se busca el usuario en la BD (activo y que coincida el nombre)]
                           ↓
                   ¿Existe el usuario? → NO → Retorna NULL (usuario no encontrado)
                           ↓      SÍ
             [Se obtiene la contraseña guardada en la BD]
                           ↓
             [Comparación 1: hash guardado == hash calculado?] → SÍ → Contraseña correcta
                           ↓ NO
             [Comparación 2: hash calculado == texto plano guardado?] → SÍ → Contraseña correcta (pero es vieja)
                           ↓ NO
             [Retorna NULL (contraseña incorrecta)]
                           ↓ SÍ (cualquiera de las dos)
             [Crear objeto clsUsuario]
                           ↓
             [Si fue la comparación 2 (contraseña vieja en texto plano)]
                → Actualizar la BD guardando el hash (migración automática)
                           ↓
             [Actualizar fecha de último acceso]
                           ↓
             [Retornar objeto clsUsuario]  →  ¡Usuario autenticado!
         */

        public static void ActualizarUltimoAcceso(int id_usuario) // Actualiza la fecha y hora del último acceso del usuario en la base de datos
        {
            string consulta = "UPDATE usuario SET ultimo_acceso = @fecha WHERE id_usuario = @id";
            MySqlParameter[] parametros = {
                new MySqlParameter("@fecha", DateTime.Now),
                new MySqlParameter("@id", id_usuario)
            }; // Parámetros para la consulta
            clsConexion.EjecutarNonQuery(consulta, parametros); // Ejecuta la consulta para actualizar el último acceso del usuario
        }
        public static bool CrearUsuario(clsUsuario usuario, MySqlTransaction? transaccion = null) // Crea un nuevo usuario en la base de datos
        {
            // Validar que el nombre de usuario no exista
            string consultaExistencia = "SELECT COUNT(*) FROM usuario WHERE usuario = @usuario"; // Consulta para verificar si el usuario ya existe
            MySqlParameter[] paramExistencia = { new MySqlParameter("@usuario", usuario.usuario) }; // Parámetros para la consulta de existencia
            object existe = clsConexion.EjecutarScalar(consultaExistencia, paramExistencia, transaccion); // Ejecuta la consulta y obtiene el resultado
            if (existe != null && Convert.ToInt32(existe) > 0)
                throw new InvalidOperationException($"El usuario '{usuario.usuario}' ya existe."); // Lanza una excepción si el usuario ya existe

            string contrasenaEncriptada = clsEncriptacion.EncriptarSHA256(usuario.contrasena); // Encripta la contraseña del usuario antes de almacenarla en la base de datos
            string consulta = @"INSERT INTO usuario (usuario, contrasena, id_rol, activo) 
                        VALUES (@usuario, @contrasena, @id_rol, @activo);
                        SELECT LAST_INSERT_ID();";
            // Consulta para insertar un nuevo usuario y obtener el ID generado automáticamente
            MySqlParameter[] parametros = {
             new MySqlParameter("@usuario", usuario.usuario),
             new MySqlParameter("@contrasena", contrasenaEncriptada),
             new MySqlParameter("@id_rol", usuario.id_rol),
             new MySqlParameter("@activo", usuario.activo)
            }; //   Parámetros para la consulta de inserción

            try
            {
                object? resultado = clsConexion.EjecutarScalar(consulta, parametros, transaccion); // Ejecuta la consulta para insertar el usuario y obtener el ID generado
                if (resultado != null && resultado != DBNull.Value) // Verifica si se obtuvo un resultado válido
                {
                    usuario.id_usuario = Convert.ToInt32(resultado); // Asigna el ID generado al objeto usuario
                    return true;
                } // Retorna true si el usuario se creó correctamente y se obtuvo un ID válido
                return false;
            }
            catch (MySqlException ex)
            {
                // Personalizar mensaje según el error de MySQL
                if (ex.Number == 1062) // Duplicado (usuario ya existe)
                    throw new InvalidOperationException($"El nombre de usuario '{usuario.usuario}' ya está en uso.", ex);
                else
                    throw new Exception("Error al crear el usuario: " + ex.Message, ex);
            }
        }

        public static int ObtenerIdEmpleadoPorIdUsuario(int idUsuario)// Obtiene el ID del empleado asociado a un usuario dado
        {
            string sql = "SELECT id_empleado FROM empleado WHERE id_usuario = @id_usuario";
            MySqlParameter[] param = { new MySqlParameter("@id_usuario", idUsuario) };

            object resultado = clsConexion.EjecutarScalar(sql, param);

            // Retorna el ID si existe, o 0 si no existe o es nulo
            return (resultado != null && resultado != DBNull.Value) ? Convert.ToInt32(resultado) : 0;
        }
    }
}

