using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedicDate.Datos;
using MySqlConnector;

namespace MedicDate.Procesos
{
    internal class clsPacienteDAL
    {
        public static int Insertar(clsPaciente paciente, MySqlTransaction? transaccion = null)
        {
            string consulta = @"
            INSERT INTO paciente
            (
                nombre,
                apellido_paterno,
                apellido_materno,
                fecha_nacimiento,
                telefono_principal,
                telefono_secundario,
                email,
                calle,
                colonia,
                numero,
                localidad,
                id_municipio,
                alergias,
                notas_medicas,
                fecha_registro
            )
              VALUES
            (
                @nombre,
                @apellido_paterno,
                @apellido_materno,
                @fecha_nacimiento,
                @telefono_principal,
                @telefono_secundario,
                @email,
                @calle,
                @colonia,
                @numero,
                @localidad,
                @id_municipio,
                @alergias,
                @notas_medicas,
                @fecha_registro
            );

            SELECT LAST_INSERT_ID();";

            MySqlParameter[] parametros =
            {
                    new MySqlParameter("@nombre", paciente.nombre),
                    new MySqlParameter("@apellido_paterno", paciente.apellido_paterno),
                    new MySqlParameter("@apellido_materno", paciente.apellido_materno),
                    new MySqlParameter("@fecha_nacimiento", paciente.fecha_nacimiento),
                    new MySqlParameter("@telefono_principal", paciente.telefono_principal),
                    new MySqlParameter("@telefono_secundario", paciente.telefono_secundario),
                    new MySqlParameter("@email", paciente.email),
                    new MySqlParameter("@calle", paciente.calle),
                    new MySqlParameter("@colonia", paciente.colonia),
                    new MySqlParameter("@numero", paciente.numero),
                    new MySqlParameter("@localidad", paciente.localidad),
                    new MySqlParameter("@id_municipio", paciente.id_municipio),
                    new MySqlParameter("@alergias", paciente.alergias),
                    new MySqlParameter("@notas_medicas", paciente.notas_medicas),
                    new MySqlParameter("@fecha_registro", DateTime.Now)
                };

            object resultado = clsConexion.EjecutarScalar(consulta, parametros, transaccion);

            return resultado == DBNull.Value ? 0 : Convert.ToInt32(resultado);
        }

    }
}


