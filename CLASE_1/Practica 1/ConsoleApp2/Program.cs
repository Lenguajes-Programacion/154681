using System;

namespace ConsoleApp2
{
    class Program
    {
     

        //variable de la clase
         static string nombre = "Daniel";
        static void Main(string[] args)
        {
            if( args[0].Length > 0 && args[0] == nombre) //true or false
            {
                //Respondamos con el primer argumento y segundo;
                Console.WriteLine($"Hola {args[0]} ");

            } else
            {
                Console.WriteLine("usuario no autorizado");
            }


        }
    }
}
