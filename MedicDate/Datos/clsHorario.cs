using System;

namespace MedicDate.Datos
{
    public class clsHorario
    {
        public int id_horario { get; set; }
        public int id_doctor { get; set; }
        public string dia_semana { get; set; }
        public TimeSpan hora_inicio { get; set; }
        public TimeSpan hora_fin { get; set; }
        public int intervalo_atencion { get; set; } = 30;
        public bool activo { get; set; } = true;

        public string RangoHorario
        {
            get { return $"{hora_inicio:hh\\:mm} - {hora_fin:hh\\:mm}"; }
        }
        public class HorarioDisponibleResult
        {
            public bool DoctorAtiende { get; set; }          // Si tiene horario ese día
            public List<string> HorasDisponibles { get; set; } // Lista de horas formateadas (hh:mm)
            public TimeSpan? HoraOriginalEdicion { get; set; } // Hora de la cita si se está editando
        }

        // Clase auxiliar para devolver los resultados de disponibilidad
        public class DisponibilidadDia
        {
            public DateTime Fecha { get; set; }
            public string DiaSemana { get; set; }
            public bool HayDisponibilidad { get; set; } // True si tiene al menos una hora libre
            public List<string> HorasDisponibles { get; set; }
        }

    }
}