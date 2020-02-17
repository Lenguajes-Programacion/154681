using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace CalculadoraSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el numero de la operacion que quieres realizar");
            Console.WriteLine("1)- Sumar");
            Console.WriteLine("2)- Restar");
            Console.WriteLine("3)- Multiplicar");
            Console.WriteLine("4)- Dividir");
            Console.WriteLine(" ");
            int operacion = int.Parse(Console.ReadLine());
            calcular(operacion);
        }
 
        private static void calcular(int operacion)
        {
            Console.Clear();
            switch (operacion)
            {
                case 1:
                    {
                        Console.WriteLine("Suma");
                        Console.WriteLine("");
                        procesar(operacion);
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("resta");
                        Console.WriteLine("");
                        procesar(operacion);
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Multiplicacion");
                        Console.WriteLine("");
                        procesar(operacion);
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("Division");
                        Console.WriteLine("");
                        procesar(operacion);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Opcion invalida");
                        Console.ReadKey();
                        break;
                    }
            }
 
        }
 
        private static void procesar(int numOperacion)
        {
            Console.Write("Ingrese el primer Numero: ");
            double numero1 = double.Parse(Console.ReadLine());
 
            Console.Write("Ingrese el segundo Numero: ");
            double numero2 = double.Parse(Console.ReadLine());
 
            if (numOperacion == 1)
            {
                double respuesta = numero1 + numero2;
                Console.WriteLine("Resultado: {0} + {1} = {2} ", numero1, numero2, respuesta);
            }
            if (numOperacion == 2)
            {
                double respuesta = numero1 - numero2;
                Console.WriteLine("Resultado: {0} - {1} = {2} ", numero1, numero2, respuesta);
            }
            if (numOperacion == 3)
            {
                double respuesta = numero1 * numero2;
                Console.WriteLine("Resultado: {0} x {1} = {2} ", numero1, numero2, respuesta);
            }
            if (numOperacion == 4)
            {
                if (numero2 == 0)
                {
                    Console.WriteLine("No se puede dividir entre {0}", numero2);
                }
                else
                {
                    double respuesta = numero1 / numero2;
                    Console.WriteLine("Resultado: {0} / {1} = {2} ", numero1, numero2, respuesta);
                }
            }
            Console.ReadKey();
        }
    }
}