using MedicDate.Datos;
using MedicDate.Prosesos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;
namespace MedicDate.Procesos
{
    internal class clsAsistenteDAL
    {
        public static bool Insertar(clsAsistente asistente, MySqlTransaction? transaccion = null)
        {

            string consulta = @"INSERT INTO asistente (id_empleado, turno)
                       VALUES (@id_empleado, @turno)";

            MySqlParameter[] parametros = {
        new MySqlParameter("@id_empleado", asistente.id_empleado),
        new MySqlParameter("@turno", string.IsNullOrEmpty(asistente.turno) ? DBNull.Value : (object)asistente.turno)
    };

            return clsConexion.EjecutarNonQuery(consulta, parametros, transaccion) > 0;

        }
    }
}
