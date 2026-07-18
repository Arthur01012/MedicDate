using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace MedicDate.Procesos
{
    internal class clsEspecialidadDAL
    {
        public static DataTable ObtenerTodos()
        {
            string consulta = "SELECT id_especialidad, nombre_especialidad FROM especialidad ORDER BY nombre_especialidad";
            return clsConexion.EjecutarConsulta(consulta);
        }
    }
}
