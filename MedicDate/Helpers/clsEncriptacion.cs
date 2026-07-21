using System;
using System.Security.Cryptography;
using System.Text;

namespace MedicDate.Helpers
{
    public static class clsEncriptacion
    {
        public static string EncriptarSHA256(string texto) // Método para encriptar un texto utilizando SHA256
        {
            if (string.IsNullOrEmpty(texto)) // Verifica si el texto es nulo o vacío
                return string.Empty;

            using (SHA256 sha256 = SHA256.Create()) // Crea una instancia de SHA256 para encriptar el texto
            {
                byte[] bytes = Encoding.UTF8.GetBytes(texto); // Convierte el texto a un arreglo de bytes utilizando UTF8
                byte[] hash = sha256.ComputeHash(bytes); // Calcula el hash del arreglo de bytes
                return BitConverter.ToString(hash).Replace("-", "").ToLower(); // Convierte el hash a una cadena hexadecimal y la devuelve en minúsculas
            }
        }
        //El metodo sha256 es un metodo de encriptacion que se utiliza para encriptar contraseñas y otros datos sensibles. Este metodo es unidireccional,
        //lo que significa que no se puede desencriptar el texto original a partir del hash generado.
        //Esto lo hace ideal para almacenar contraseñas de manera segura en bases de datos.


        //El metodo md5 es un metodo de encriptacion que se utiliza para encriptar contraseñas y otros datos sensibles. Este metodo es unidireccional,
        //lo que significa que no se puede desencriptar el texto original a partir del hash generado.
        //Esto lo hace ideal para almacenar contraseñas de manera segura en bases de datos.
        public static string EncriptarMD5(string texto) // Método para encriptar un texto utilizando MD5
        {
            if (string.IsNullOrEmpty(texto)) // Verifica si el texto es nulo o vacío
                return string.Empty; 

            using (MD5 md5 = MD5.Create()) // Crea una instancia de MD5 para encriptar el texto
            {
                byte[] bytes = Encoding.UTF8.GetBytes(texto); // Convierte el texto a un arreglo de bytes utilizando UTF8
                byte[] hash = md5.ComputeHash(bytes); // Calcula el hash del arreglo de bytes
                return BitConverter.ToString(hash).Replace("-", "").ToLower(); // Convierte el hash a una cadena hexadecimal y la devuelve en minúsculas
            }
        }




        //Ambos métodos son seguros para almacenar contraseñas, pero SHA256 es más seguro que MD5, ya que produce un hash más largo y menos susceptible a colisiones.
        // Podria usarse tanto MD5 como SHA256 para encriptar contraseñas, bien podria implementarse MD5 pero se decidio implementar SHA256 por ser más seguro y moderno, ya que MD5 es considerado obsoleto y vulnerable a ataques de colisión.
        // El metodo SHA256 esta basado en el algoritmo de hash SHA-2, que es ampliamente utilizado en la industria para proteger datos sensibles. Por otro lado, MD5 es un algoritmo más antiguo y menos seguro, que ha sido reemplazado por SHA-2 en la mayoría de las aplicaciones modernas.
    }
}