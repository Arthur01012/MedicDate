using MedicDate.Procesos;
using System.Collections.Generic;
using System.Data;

namespace MedicDate.Datos
{
    public class clsDoctor : clsEmpleado
    {
        public string cedula_profesional { get; set; }
        public int? especialidad_principal { get; set; }
        public string nombre_especialidad { get; set; } // Para mostrar en la interfaz
        public string consultorio { get; set; }
        public List<clsHorario> Horarios { get; set; } = new List<clsHorario>();
        public string? NombreUsuario { get; set; }

        public clsDoctor()
        {
            tipo_empleado = "doctor";
        }
    }
}