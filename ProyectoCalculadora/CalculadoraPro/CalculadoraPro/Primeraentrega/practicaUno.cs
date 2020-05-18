using System;
using System.Collections.Generic;
using System.Text;

namespace CalculadoraPro.Primeraentrega
{
    class practicaUno
    {
        static string nombre = "Daniel";
        public static void Comprobacion()
        {
            Console.WriteLine("Usuario:");
            string usuario = Console.ReadLine();

            if (usuario.Length > 0 && usuario == nombre) // true o false
            {
                Console.WriteLine($"Hola Bienvenido {usuario}");
            }
            else
            {
                Console.WriteLine("Usuario no autorizado");
            }
        }
    }
}
