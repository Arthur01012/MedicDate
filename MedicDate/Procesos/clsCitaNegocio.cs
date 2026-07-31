using MedicDate.Datos;
using System;
using System.Collections.Generic;
using System.Data;

namespace MedicDate.Procesos
{
    // Clase auxiliar para devolver el resultado del cálculo de horarios
    public class HorarioDisponibleResult
    {
        public bool DoctorAtiende { get; set; }          // Si tiene horario ese día
        public List<string> HorasDisponibles { get; set; } // Lista de horas formateadas (hh:mm)
        public TimeSpan? HoraOriginalEdicion { get; set; } // Hora de la cita si se está editando
    }

    public class clsCitaNegocio
    {
        // Método que calcula los horarios disponibles
        public HorarioDisponibleResult ObtenerHorasDisponibles(int idDoctor, DateTime fecha, int? idCitaEdicion = null)
        {
            var resultado = new HorarioDisponibleResult();
            resultado.HorasDisponibles = new List<string>();

            // 1. Obtener día de la semana en español
            string[] diasEspañol = { "Domingo", "Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sábado" };
            string diaSemana = diasEspañol[(int)fecha.DayOfWeek];

            // 2. Obtener el horario laboral del doctor desde la DAL
            DataTable horarioDoctor = clsCitaDAL.ObtenerHorarioDoctor(idDoctor, diaSemana);

            // 3. Validar si el doctor atiende ese día
            if (horarioDoctor.Rows.Count == 0)
            {
                resultado.DoctorAtiende = false;
                return resultado;
            }

            resultado.DoctorAtiende = true;

            // 4. Extraer horas de inicio y fin
            TimeSpan horaInicio = TimeSpan.Parse(horarioDoctor.Rows[0]["hora_inicio"].ToString());
            TimeSpan horaFin = TimeSpan.Parse(horarioDoctor.Rows[0]["hora_fin"].ToString());

            // 5. Generar bloques de 30 minutos
            List<TimeSpan> slotsTotales = new List<TimeSpan>();
            TimeSpan intervalo = new TimeSpan(0, 30, 0);
            TimeSpan actual = horaInicio;
            while (actual < horaFin)
            {
                slotsTotales.Add(actual);
                actual = actual.Add(intervalo);
            }

            // 6. Obtener horas ya ocupadas en la BD
            List<TimeSpan> horasOcupadas = clsCitaDAL.ObtenerHorasOcupadas(idDoctor, fecha);

            // 7. Obtener la hora original si estamos editando
            TimeSpan? horaPropia = null;
            if (idCitaEdicion.HasValue)
            {
                var citaOriginal = clsCitaDAL.ObtenerPorId(idCitaEdicion.Value);
                if (citaOriginal != null)
                    horaPropia = citaOriginal.hora;
            }

            // 8. Filtrar y llenar la lista de salida
            foreach (var slot in slotsTotales)
            {
                if (horasOcupadas.Contains(slot))
                {
                    if (horaPropia.HasValue && slot == horaPropia.Value)
                        continue; // Permitir la propia hora en edición
                    else
                        continue; // Saltar horas ocupadas por otros
                }
                resultado.HorasDisponibles.Add(slot.ToString(@"hh\:mm"));
            }

            // 9. Guardar la hora original para la preselección en el formulario
            resultado.HoraOriginalEdicion = horaPropia;

            return resultado;
        }

        // Método que centraliza y valida el guardado de la cita
        public void ValidarYPrepararCita(clsCita cita, int? idCitaEdicion, DateTime fechaOriginal, TimeSpan? horaOriginal)
        {
            // 1. Si es edición y el usuario NO cambió la fecha, permitimos guardar aunque el doctor ya no atienda
            if (idCitaEdicion.HasValue && fechaOriginal == cita.fecha)
            {
                return;
            }

            // 2. Si es una cita nueva, o se cambió la fecha, debemos verificar disponibilidad de horario
            var disponibilidad = ObtenerHorasDisponibles(cita.id_doctor, cita.fecha, idCitaEdicion);
            if (!disponibilidad.DoctorAtiende)
            {
                throw new InvalidOperationException("El doctor no tiene horario disponible para la fecha seleccionada.");
            }

            // 3. Verificar choque de horarios (solo para nuevas citas o si se cambió la hora)
            if (!clsCitaDAL.VerificarDisponibilidad(cita.id_doctor, cita.fecha, cita.hora, cita.duracion))
            {
                throw new InvalidOperationException("Alguien más ya reservó esta hora. Por favor, seleccione otra.");
            }
        }
    }
}