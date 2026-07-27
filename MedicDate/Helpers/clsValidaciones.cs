using System;
using System.Text.RegularExpressions;

namespace MedicDate.Helpers
{
    public static class clsValidaciones
    {
        public static bool EsEmailValido(string email) // Validación básica de correo electrónico
        {
            if (string.IsNullOrEmpty(email)) return false; // Verifica si el correo electrónico es nulo o vacío
            try
            {
                var addr = new System.Net.Mail.MailAddress(email); // Intenta crear una instancia de MailAddress con el correo electrónico proporcionado
                return addr.Address == email; // Verifica si la dirección de correo electrónico es válida comparando la propiedad Address con el correo electrónico original
            }
            catch
            {
                return false;
            }
        }

        public static bool EsTelefonoValido(string telefono) // Validación básica de número de teléfono (10 dígitos)
        {
            if (string.IsNullOrEmpty(telefono)) return false; // Verifica si el número de teléfono es nulo o vacío
            return Regex.IsMatch(telefono, @"^[0-9]{10}$"); // Verifica si el número de teléfono tiene exactamente 10 dígitos utilizando una expresión regular
        }

        public static bool EsCURPValido(string curp)
        {
            if (string.IsNullOrEmpty(curp)) return false; // Verifica si la CURP es nula o vacía
            return Regex.IsMatch(curp, @"^[A-Z]{4}[0-9]{6}[A-Z]{6}[0-9]{2}$"); // Verifica si la CURP tiene el formato correcto utilizando una expresión regular
        }

        public static bool EsFechaNacimientoValida(DateTime fechaNacimiento)// Validación de fecha de nacimiento
        {
            return fechaNacimiento <= DateTime.Today // No puede ser una fecha futura
                   && fechaNacimiento.Year >= 1900 // No puede ser menor a 1900
                   && fechaNacimiento > DateTime.Today.AddYears(-120); // No mayor a 120 años
        }


        public static bool EsEdadValida(DateTime fechaNacimiento, int edadMinima = 0, int edadMaxima = 120) // Validación de edad basada en la fecha de nacimiento
        {
            if (fechaNacimiento > DateTime.Today) // Verifica si la fecha de nacimiento es una fecha futura
                return false; // No puede ser una fecha futura

            int edad = DateTime.Today.Year - fechaNacimiento.Year; // Calcula la edad en años
            if (fechaNacimiento.Date > DateTime.Today.AddYears(-edad)) edad--; // Ajusta la edad si el cumpleaños aún no ha ocurrido este año

            return edad >= edadMinima && edad <= edadMaxima; // Verifica si la edad está dentro del rango permitido (edad mínima y máxima)
        }
    }
}