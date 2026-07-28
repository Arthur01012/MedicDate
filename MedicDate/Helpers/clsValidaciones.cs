using System;
using System.Text.RegularExpressions;

namespace MedicDate.Helpers
{
    public static class clsValidaciones
    {
        public static bool EsEmailValido(string email)
        {
            if (string.IsNullOrWhiteSpace(email)) return false;
            string patron = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            return Regex.IsMatch(email, patron);
        }

        public static bool EsTelefonoValido(string telefono)
        {
            if (string.IsNullOrWhiteSpace(telefono)) return false;
            string soloNumeros = Regex.Replace(telefono, @"[^0-9]", "");
            return soloNumeros.Length == 10;
        }

        public static bool EsCURPValido(string curp)
        {
            if (string.IsNullOrWhiteSpace(curp)) return false;

            // Eliminar espacios y convertir a mayúsculas
            curp = curp.Trim().ToUpper();

            // Debe tener exactamente 18 caracteres
            if (curp.Length != 18) return false;

            // Solo permitir letras mayúsculas (A-Z) y números (0-9)
            foreach (char c in curp)
            {
                if (!char.IsLetterOrDigit(c)) return false;
                if (char.IsLetter(c) && !char.IsUpper(c)) return false;
            }

            return true;
        }

        public static bool EsFechaNacimientoValida(DateTime fechaNacimiento)
        {
            return fechaNacimiento <= DateTime.Today
                   && fechaNacimiento.Year >= 1900
                   && fechaNacimiento > DateTime.Today.AddYears(-120);
        }

        public static bool EsEdadValida(DateTime fechaNacimiento, int edadMinima = 0, int edadMaxima = 120)
        {
            if (fechaNacimiento > DateTime.Today) return false;
            int edad = DateTime.Today.Year - fechaNacimiento.Year;
            if (fechaNacimiento.Date > DateTime.Today.AddYears(-edad)) edad--;
            return edad >= edadMinima && edad <= edadMaxima;
        }
    }
}