using MedicDate.Datos;
using MedicDate.Procesos;
using MySqlConnector;
using System;
using System.Data;

namespace MedicDate.Datos
{
    public class clsEmpleadoDAL
    {
        public static int Insertar(clsEmpleado empleado, MySqlTransaction? transaccion = null)
        {
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

            object? resultado = clsConexion.EjecutarScalar(consulta, parametros, transaccion);
            return resultado == null || resultado == DBNull.Value ? 0 : Convert.ToInt32(resultado);
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

            try
            {
                int filas = clsConexion.EjecutarNonQuery(sql, parametros, transaccion);
                return filas > 0;
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 1062)
                    throw new InvalidOperationException($"El email '{empleado.email}' o CURP ya están registrados.", ex);
                else
                    throw new Exception("Error al actualizar el empleado: " + ex.Message, ex);
            }
        }
    }
}