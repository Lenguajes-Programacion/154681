using System;

namespace CalculadoraPro
{
    class Calculator
    {
        static void Main(string[] args)
        {
            FuncionesMejoradas MoreOp = new FuncionesMejoradas();
            float ValorA = 0;
            float ValorB = 0;
            float Res = 0;
            int Principal;
            do
            {
                Console.WriteLine("Bienvenido, que operación deseas realizar...");
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine("1. Suma" + "\n" + "2. Resta" + "\n" + "3. Multiplicacion" + "\n" + "4. Division" + "\n" + "5. potencia" + "\n6. Salir");
                Principal = Int32.Parse(Console.ReadLine());
                switch (Principal)
                {
                    case 1:
                        Console.WriteLine("Ingresa los valores para sumar\n");
                        Console.WriteLine("Primer Valor: ");
                        ValorA = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("Segundo Valor: ");
                        ValorB = Int32.Parse(Console.ReadLine());
                        Res = Operaciones.Suma(ValorA, ValorB);
                        Console.WriteLine("El resultado es: " + Res);
                        break;

                    case 2:
                        Console.WriteLine("Ingresa los valores para restar");
                        Console.WriteLine("Primer Valor: ");
                        ValorA = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("Segundo Valor: ");
                        ValorB = Int32.Parse(Console.ReadLine());
                        Res = Operaciones.Resta(ValorA, ValorB);
                        Console.WriteLine("El resultado es: " + Res);
                        break;

                    case 3:
                        Console.WriteLine("Ingresa los valores para multiplicar");
                        Console.WriteLine("Primer Valor: ");
                        ValorA = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("Segundo Valor: ");
                        ValorB = Int32.Parse(Console.ReadLine());
                        Res = Operaciones.Multiplicacion(ValorA, ValorB);
                        Console.WriteLine("El resultado es: " + Res);
                        break;

                    case 4:
                        Console.WriteLine("Ingresa los valores para dividir");
                        Console.WriteLine("Primer Valor: ");
                        ValorA = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("Segundo Valor: ");
                        ValorB = Int32.Parse(Console.ReadLine());
                        Res = Operaciones.Division(ValorA, ValorB);
                        Console.WriteLine("El resultado es: " + Res);
                        break;

                    case 5:
                        Console.WriteLine("Ingresa los valores para sacar la potencia");
                        Console.WriteLine("Primer Valor: ");
                        ValorA = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("Segundo Valor: ");
                        ValorB = Int32.Parse(Console.ReadLine());
                        MoreOp.Potencia(ValorA, ValorB);
                        Console.WriteLine("\n");
                        break;

                    case 6:
                        Console.Clear();
                        Console.WriteLine("Nos vemos");
                        //Principal = Console.Read();
                        Console.WriteLine("\n");
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Valores no validos, ingresar de nuevo...");
                        Console.WriteLine("\n");
                        break;
                }
            } while (Principal != 6);
        }
    }
    class Operaciones
    {
        public float valor1;
        public float valor2;

        public static float Suma(float valor1, float valor2)
        {
            float Res = 0;
            Res = valor1 + valor2;
            return Res;
        }
        public static float Resta(float valor1, float valor2)
        {
            float Res = 0;
            Res = valor1 - valor2;
            return Res;
        }

        public static float Multiplicacion(float valor1, float valor2)
        {
            float Res = 0;
            Res = valor1 * valor2;
            return Res;
        }

        public static float Division(float valor1, float valor2)
        {
            float Res = 0;
            Res = valor1 / valor2;
            return Res;
        }
    }

    class FuncionesMejoradas : Operaciones
    {
        public void Potencia(float valor1, float valor2)
        {
            double Opecuad = Math.Pow(valor1, valor2);
            Console.WriteLine("Su numero {0} elevado por {1} es {2}", valor1, valor2, Opecuad);
        }
    }
}
