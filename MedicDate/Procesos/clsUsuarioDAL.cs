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
        public static bool UsuarioExiste(string usuario)
        {
            string consulta = "SELECT COUNT(*) FROM usuario WHERE usuario = @usuario";
            MySqlParameter[] parametros = {
                new MySqlParameter("@usuario", usuario)
            };

            object resultado = clsConexion.EjecutarScalar(consulta, parametros);
            return Convert.ToInt32(resultado) > 0;
        }

        public static bool UsuarioActivo(string usuario)
        {
            string consulta = "SELECT activo FROM usuario WHERE usuario = @usuario";
            MySqlParameter[] parametros = {
                new MySqlParameter("@usuario", usuario)
            };

            DataTable resultado = clsConexion.EjecutarConsulta(consulta, parametros);
            if (resultado.Rows.Count > 0)
            {
                return Convert.ToBoolean(resultado.Rows[0]["activo"]);
            }
            return false;
        }

        public static clsUsuario Autenticar(string usuario, string contrasena)
        {
            string contrasenaEncriptada = clsEncriptacion.EncriptarSHA256(contrasena);
            string consulta = @"SELECT u.*, r.nombre as nombre_rol 
                               FROM usuario u
                               INNER JOIN rol r ON u.id_rol = r.id_rol
                               WHERE u.usuario = @usuario AND u.activo = 1";

            MySqlParameter[] parametros = {
                new MySqlParameter("@usuario", usuario)
            };

            DataTable resultado = clsConexion.EjecutarConsulta(consulta, parametros);

            if (resultado.Rows.Count == 0)
            {
                return null;
            }

            DataRow fila = resultado.Rows[0];
            string contrasenaAlmacenada = fila["contrasena"].ToString();
            bool passwordValido = string.Equals(contrasenaAlmacenada, contrasenaEncriptada, StringComparison.OrdinalIgnoreCase)
                                   || string.Equals(contrasenaAlmacenada, contrasena, StringComparison.Ordinal);

            if (!passwordValido)
            {
                return null;
            }

            clsUsuario user = new clsUsuario
            {
                id_usuario = Convert.ToInt32(fila["id_usuario"]),
                usuario = fila["usuario"].ToString(),
                id_rol = Convert.ToInt32(fila["id_rol"]),
                nombre_rol = fila["nombre_rol"].ToString(),
                activo = Convert.ToBoolean(fila["activo"])
            };

            if (!string.Equals(contrasenaAlmacenada, contrasenaEncriptada, StringComparison.OrdinalIgnoreCase))
            {
                // Actualizar contraseña almacenada en texto plano a su hash SHA256
                string actualizacion = "UPDATE usuario SET contrasena = @contrasena WHERE id_usuario = @id";
                MySqlParameter[] parametrosActualizacion = {
                    new MySqlParameter("@contrasena", contrasenaEncriptada),
                    new MySqlParameter("@id", user.id_usuario)
                };
                clsConexion.EjecutarNonQuery(actualizacion, parametrosActualizacion);
            }

            ActualizarUltimoAcceso(user.id_usuario);
            return user;
        }

        public static void ActualizarUltimoAcceso(int id_usuario)
        {
            string consulta = "UPDATE usuario SET ultimo_acceso = @fecha WHERE id_usuario = @id";
            MySqlParameter[] parametros = {
                new MySqlParameter("@fecha", DateTime.Now),
                new MySqlParameter("@id", id_usuario)
            };
            clsConexion.EjecutarNonQuery(consulta, parametros);
        }
        public static bool CrearUsuario(clsUsuario usuario, MySqlTransaction? transaccion = null)
        {
            // Validar que el nombre de usuario no exista
            string consultaExistencia = "SELECT COUNT(*) FROM usuario WHERE usuario = @usuario";
            MySqlParameter[] paramExistencia = { new MySqlParameter("@usuario", usuario.usuario) };
            object existe = clsConexion.EjecutarScalar(consultaExistencia, paramExistencia, transaccion);
            if (existe != null && Convert.ToInt32(existe) > 0)
                throw new InvalidOperationException($"El usuario '{usuario.usuario}' ya existe.");

            string contrasenaEncriptada = clsEncriptacion.EncriptarSHA256(usuario.contrasena);
            string consulta = @"INSERT INTO usuario (usuario, contrasena, id_rol, activo) 
                        VALUES (@usuario, @contrasena, @id_rol, @activo);
                        SELECT LAST_INSERT_ID();";

            MySqlParameter[] parametros = {
             new MySqlParameter("@usuario", usuario.usuario),
             new MySqlParameter("@contrasena", contrasenaEncriptada),
             new MySqlParameter("@id_rol", usuario.id_rol),
             new MySqlParameter("@activo", usuario.activo)
            };

            try
            {
                object? resultado = clsConexion.EjecutarScalar(consulta, parametros, transaccion);
                if (resultado != null && resultado != DBNull.Value)
                {
                    usuario.id_usuario = Convert.ToInt32(resultado);
                    return true;
                }
                return false;
            }
            catch (MySqlException ex)
            {
                // Personalizar mensaje según el error de MySQL
                if (ex.Number == 1062) // Duplicado (usuario ya existe)
                    throw new InvalidOperationException($"El nombre de usuario '{usuario.usuario}' ya está en uso.", ex);
                else if (ex.Number == 1452) // Clave foránea (rol no existe)
                    throw new InvalidOperationException($"El rol seleccionado no es válido.", ex);
                else
                    throw new Exception("Error al crear el usuario: " + ex.Message, ex);
            }
        }
    }
}

