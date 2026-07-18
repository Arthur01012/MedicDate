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

            object resultado = clsConexion.EjecutarScalar(consulta, parametros, transaccion);
            return resultado == DBNull.Value ? 0 : Convert.ToInt32(resultado);
        }
    }
}
