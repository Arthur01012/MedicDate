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
    // Clase auxiliar para devolver los resultados de disponibilidad
    public class DisponibilidadDia
    {
        public DateTime Fecha { get; set; }
        public string DiaSemana { get; set; }
        public bool HayDisponibilidad { get; set; } // True si tiene al menos una hora libre
        public List<string> HorasDisponibles { get; set; }
    }
    public class clsCitaNegocio
    {
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


        public void ValidarYPrepararCita(clsCita cita, int? idCitaEdicion, DateTime fechaOriginal, TimeSpan? horaOriginal)
        {
            
            if (cita == null)
            {
                throw new ArgumentNullException(nameof(cita), "El doctor no tiene horario disponible para la fecha seleccionada.");
            }

            
            if (idCitaEdicion.HasValue && fechaOriginal == cita.fecha)
            {
                return;
            }

            
            var disponibilidad = ObtenerHorasDisponibles(cita.id_doctor, cita.fecha, idCitaEdicion);
            if (!disponibilidad.DoctorAtiende)
            {
                throw new InvalidOperationException("El doctor no tiene horario disponible para la fecha seleccionada.");
            }

            
            if (!clsCitaDAL.VerificarDisponibilidad(cita.id_doctor, cita.fecha, cita.hora, cita.duracion))
            {
                throw new InvalidOperationException("Alguien más ya reservó esta hora. Por favor, seleccione otra.");
            }
        }


      /*  public List<DisponibilidadDia> ObtenerCalendarioDisponibilidad(int idDoctor, DateTime fechaInicio, int diasAVer)
        {
            var resultado = new List<DisponibilidadDia>();
            DateTime fechaFin = fechaInicio.AddDays(diasAVer);
            string[] diasEspañol = { "Domingo", "Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sábado" };


            DataTable citasOcupadas = clsCitaDAL.ObtenerCitasDoctorRango(idDoctor, fechaInicio, fechaFin);
            var ocupadasAgrupadas = citasOcupadas.AsEnumerable()
                .GroupBy(r => Convert.ToDateTime(r["fecha"]).Date)
                .ToDictionary(g => g.Key, g => g.Select(r => TimeSpan.Parse(r["hora"].ToString())).ToList());


            for (int i = 0; i <= diasAVer; i++)
            {
                DateTime fechaActual = fechaInicio.AddDays(i);
                string diaSemana = diasEspañol[(int)fechaActual.DayOfWeek];


                DataTable horarioDoctor = clsCitaDAL.ObtenerHorarioDoctor(idDoctor, diaSemana);

                if (horarioDoctor.Rows.Count == 0)
                {

                    resultado.Add(new DisponibilidadDia
                    {
                        Fecha = fechaActual,
                        DiaSemana = diaSemana,
                        HayDisponibilidad = false,
                        HorasDisponibles = new List<string>()
                    });
                    continue;
                }


                TimeSpan horaInicio = TimeSpan.Parse(horarioDoctor.Rows[0]["hora_inicio"].ToString());
                TimeSpan horaFin = TimeSpan.Parse(horarioDoctor.Rows[0]["hora_fin"].ToString());

                List<TimeSpan> slotsTotales = new List<TimeSpan>();
                TimeSpan actual = horaInicio;
                while (actual < horaFin)
                {
                    slotsTotales.Add(actual);
                    actual = actual.Add(new TimeSpan(0, 30, 0));
                }


                List<TimeSpan> ocupadasDelDia = ocupadasAgrupadas.ContainsKey(fechaActual)
                    ? ocupadasAgrupadas[fechaActual]
                    : new List<TimeSpan>();


                List<string> horasLibres = new List<string>();
                foreach (var slot in slotsTotales)
                {
                    if (!ocupadasDelDia.Contains(slot))
                    {
                        horasLibres.Add(slot.ToString(@"hh\:mm"));
                    }
                }

                resultado.Add(new DisponibilidadDia
                {
                    Fecha = fechaActual,
                    DiaSemana = diaSemana,
                    HayDisponibilidad = horasLibres.Count > 0,
                    HorasDisponibles = horasLibres
                });
            }

            return resultado;
        }*/
    }
}