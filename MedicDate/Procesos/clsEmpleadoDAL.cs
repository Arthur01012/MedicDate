using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedicDate.Procesos;
using MySqlConnector;
using MedicDate.Datos;

namespace MedicDate.Procesos
{
    internal class clsEmpleadoDAL
    {
        public static int Insertar(clsEmpleado empleado, MySqlTransaction? transaccion = null)
        {
            // Validar email único
            string consultaEmail = "SELECT COUNT(*) FROM empleado WHERE email = @email";
            MySqlParameter[] paramEmail = { new MySqlParameter("@email", empleado.email) };
            object existeEmail = clsConexion.EjecutarScalar(consultaEmail, paramEmail, transaccion);
            if (existeEmail != null && Convert.ToInt32(existeEmail) > 0)
                throw new InvalidOperationException($"El email '{empleado.email}' ya está registrado.");

            // Validar CURP único 
            if (!string.IsNullOrEmpty(empleado.curp))
            {
                string consultaCurp = "SELECT COUNT(*) FROM empleado WHERE curp = @curp";
                MySqlParameter[] paramCurp = { new MySqlParameter("@curp", empleado.curp) };
                object existeCurp = clsConexion.EjecutarScalar(consultaCurp, paramCurp, transaccion);
                if (existeCurp != null && Convert.ToInt32(existeCurp) > 0)
                    throw new InvalidOperationException($"La CURP '{empleado.curp}' ya está registrada.");
            }

            // Validar que el usuario exista 
            if (empleado.id_usuario.HasValue)
            {
                string consultaUsuario = "SELECT COUNT(*) FROM usuario WHERE id_usuario = @id";
                MySqlParameter[] paramUsuario = { new MySqlParameter("@id", empleado.id_usuario.Value) };
                object existeUsuario = clsConexion.EjecutarScalar(consultaUsuario, paramUsuario, transaccion);
                if (existeUsuario == null || Convert.ToInt32(existeUsuario) == 0)
                    throw new InvalidOperationException($"El usuario ID {empleado.id_usuario.Value} no existe.");
            }

            string consulta = @"INSERT INTO empleado 
                               (nombre, apellido_paterno, apellido_materno, fecha_nacimiento, 
                                curp, email, telefono_principal, telefono_secundario, 
                                tipo_empleado, fecha_contratacion, estado, id_usuario)
                               VALUES 
                               (@nombre, @apellido_paterno, @apellido_materno, @fecha_nacimiento,
                                @curp, @email, @telefono_principal, @telefono_secundario,
                                @tipo_empleado, @fecha_contratacion, @estado, @id_usuario);
                               SELECT LAST_INSERT_ID();";

            MySqlParameter[] parametros = {
                new MySqlParameter("@nombre", empleado.nombre),
                new MySqlParameter("@apellido_paterno", empleado.apellido_paterno),
                new MySqlParameter("@apellido_materno", string.IsNullOrEmpty(empleado.apellido_materno) ? DBNull.Value : (object)empleado.apellido_materno),
                new MySqlParameter("@fecha_nacimiento", empleado.fecha_nacimiento),
                new MySqlParameter("@curp", string.IsNullOrEmpty(empleado.curp) ? DBNull.Value : (object)empleado.curp),
                new MySqlParameter("@email", empleado.email),
                new MySqlParameter("@telefono_principal", string.IsNullOrEmpty(empleado.telefono_principal) ? DBNull.Value : (object)empleado.telefono_principal),
                new MySqlParameter("@telefono_secundario", string.IsNullOrEmpty(empleado.telefono_secundario) ? DBNull.Value : (object)empleado.telefono_secundario),
                new MySqlParameter("@tipo_empleado", empleado.tipo_empleado),
                new MySqlParameter("@fecha_contratacion", empleado.fecha_contratacion),
                new MySqlParameter("@estado", empleado.estado ? 1 : 0),
                new MySqlParameter("@id_usuario", empleado.id_usuario.HasValue ? (object)empleado.id_usuario.Value : DBNull.Value)
            };
            try
            {
                object? resultado = clsConexion.EjecutarScalar(consulta, parametros, transaccion);
                return resultado == DBNull.Value ? 0 : Convert.ToInt32(resultado);
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 1062) // Duplicado
                {
                    // Identificar cuál campo causó el duplicado
                    if (ex.Message.Contains("email"))
                        throw new InvalidOperationException($"El email '{empleado.email}' ya está registrado.", ex);
                    else if (ex.Message.Contains("curp"))
                        throw new InvalidOperationException($"La CURP '{empleado.curp}' ya está registrada.", ex);
                    else if (ex.Message.Contains("id_usuario"))
                        throw new InvalidOperationException($"El usuario ya tiene un empleado asociado.", ex);
                    else
                        throw new InvalidOperationException("El registro ya existe (campo duplicado).", ex);
                }
                else if (ex.Number == 1452) // Clave foránea
                {
                    if (ex.Message.Contains("id_usuario"))
                        throw new InvalidOperationException($"El usuario ID {empleado.id_usuario} no existe.", ex);
                    else
                        throw new InvalidOperationException("Error de clave foránea al insertar el empleado.", ex);
                }
                else
                    throw new Exception("Error al insertar el empleado: " + ex.Message, ex);
            }
        }

        public static bool Actualizar(clsEmpleado empleado, MySqlTransaction? transaccion = null)
        {
            string sql = @"UPDATE empleado 
                   SET nombre = @nombre,
                       apellido_paterno = @apellido_paterno,
                       apellido_materno = @apellido_materno,
                       fecha_nacimiento = @fecha_nacimiento,
                       curp = @curp,
                       email = @email,
                       telefono_principal = @telefono_principal,
                       telefono_secundario = @telefono_secundario,
                       tipo_empleado = @tipo_empleado,
                       fecha_contratacion = @fecha_contratacion,
                       estado = @estado
                   WHERE id_empleado = @id";

            MySqlParameter[] parametros = {
                new MySqlParameter("@nombre", empleado.nombre),
                new MySqlParameter("@apellido_paterno", empleado.apellido_paterno),
                new MySqlParameter("@apellido_materno", string.IsNullOrEmpty(empleado.apellido_materno) ? DBNull.Value : (object)empleado.apellido_materno),
                new MySqlParameter("@fecha_nacimiento", empleado.fecha_nacimiento),
                new MySqlParameter("@curp", string.IsNullOrEmpty(empleado.curp) ? DBNull.Value : (object)empleado.curp),
                new MySqlParameter("@email", empleado.email),
                new MySqlParameter("@telefono_principal", string.IsNullOrEmpty(empleado.telefono_principal) ? DBNull.Value : (object)empleado.telefono_principal),
                new MySqlParameter("@telefono_secundario", string.IsNullOrEmpty(empleado.telefono_secundario) ? DBNull.Value : (object)empleado.telefono_secundario),
                new MySqlParameter("@tipo_empleado", empleado.tipo_empleado),
                new MySqlParameter("@fecha_contratacion", empleado.fecha_contratacion),
                new MySqlParameter("@estado", empleado.estado ? 1 : 0),
                new MySqlParameter("@id", empleado.id_empleado)
            };

            return clsConexion.EjecutarNonQuery(sql, parametros, transaccion) > 0;
        }
    }
}
