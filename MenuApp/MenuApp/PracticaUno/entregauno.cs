using System;
using System.Collections.Generic;
using System.Text;

namespace MenuApp.PracticaUno
{
    class entregauno
    {

        static string nombre = "Daniel";
        static void Main(string[] args)
        {
           
            if (args[0].Length == 0 || args[0] != nombre) // true o false
            {
                Console.WriteLine("Usuario no autorizado");
            }
            else
            {
                Console.WriteLine($"Hola! Bienvenido {args[0]}");
            }
        }
    }
}
