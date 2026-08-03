using MedicDate.Datos;
using MySqlConnector;
using System;
using System.Data;

namespace MedicDate.Procesos
{
    public class clsEmpleadoDAL
    {
        public static int Insertar(clsEmpleado empleado, MySqlTransaction? transaccion = null) // Método para insertar un nuevo empleado en la base de datos
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
            // Crear un arreglo de parámetros para la consulta

            MySqlParameter[] parametros = {                 // Crear un arreglo de parámetros para la consulta
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
            // Se utiliza DBNull.Value para los campos opcionales que pueden ser nulos

            object? resultado = clsConexion.EjecutarScalar(consulta, parametros, transaccion);  // Ejecutar la consulta y obtener el ID del nuevo empleado insertado
            return resultado == null || resultado == DBNull.Value ? 0 : Convert.ToInt32(resultado); // Devolver el ID del nuevo empleado insertado, o 0 si no se pudo obtener el ID
        }

        public static bool Actualizar(clsEmpleado empleado, MySqlTransaction? transaccion = null) // Método para actualizar un empleado existente en la base de datos
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
            // Crear un arreglo de parámetros para la consulta
            MySqlParameter[] parametros = {                 // Crear un arreglo de parámetros para la consulta
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
            // Se utiliza DBNull.Value para los campos opcionales que pueden ser nulos

            try
            {
                int filas = clsConexion.EjecutarNonQuery(sql, parametros, transaccion); // Ejecutar la consulta y devolver true si se actualizó al menos una fila, o false si no se actualizó ninguna fila
                return filas > 0; // Devolver true si se actualizó al menos una fila, o false si no se actualizó ninguna fila
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 1062) // Código de error para clave duplicada
                    throw new InvalidOperationException($"El email '{empleado.email}' o CURP ya están registrados.", ex); // Lanzar una excepción específica para clave duplicada
                else
                    throw new Exception("Error al actualizar el empleado: " + ex.Message, ex); // Lanzar una excepción genérica para otros errores
            }
        }
    }
}