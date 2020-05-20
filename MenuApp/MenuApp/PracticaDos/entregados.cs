using System;
using System.Collections.Generic;
using System.Text;

namespace MenuApp.PracticaDos
{
    class entregados
    {
        static void Calc(string[] args)
        {
            FuncionesMejoradas MoreOp = new FuncionesMejoradas();
            memoria memoria = new memoria();
            Console.WriteLine("----------------- \n");
            Console.WriteLine("Calculator");
            Console.WriteLine("----------------- \n");
            bool close_app = true;
            int valor1 = 0;
            int valor2 = 0;
            int Res = 0;
            while (close_app)
            {
                Console.WriteLine("Elige una opción:");
                Console.WriteLine("(1) Suma");
                Console.WriteLine("(2) Resta");
                Console.WriteLine("(3) Multiplicación");
                Console.WriteLine("(4) Disión");
                Console.WriteLine("(5) Memoria");
                Console.WriteLine("(6) Borrar Memoria");
                Console.WriteLine("7 Para salir \n");
                string opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "1":
                        Console.WriteLine("Suma \n");
                        Console.WriteLine("Captura el primer valor:");
                        valor1 = Res == 0 ? int.Parse(Console.ReadLine()) : Res;
                        Console.WriteLine("Captura el segundo valor:");
                        valor2 = int.Parse(Console.ReadLine());
                        Res = Operaciones.suma(valor1, valor2);
                        Console.WriteLine("Tu resultado es: {0} \n", Res);
                        String o = valor1 + "+" + valor2;
                        MemoriaData data = new MemoriaData(DateTime.Now.ToString(), o, Res.ToString());
                        memoria.GuardarMemoria(data);
                        Res = 0;
                        break;
                    case "2":
                        Console.WriteLine("Resta \n");
                        Console.WriteLine("Captura el primer valor:");
                        valor1 = Res == 0 ? int.Parse(Console.ReadLine()) : Res;
                        Console.WriteLine("Captura el segundo valor:");
                        valor2 = int.Parse(Console.ReadLine());
                        Res = Operaciones.resta(valor1, valor2);
                        Console.WriteLine("Tu resultado es: {0} \n", Res);
                        Res = 0;

                        break;
                    case "3":
                        Console.WriteLine("Multiplicación \n");
                        Console.WriteLine("Captura el primer valor:");
                        valor1 = Res == 0 ? int.Parse(Console.ReadLine()) : Res;
                        Console.WriteLine("Captura el segundo valor:");
                        valor2 = int.Parse(Console.ReadLine());
                        Res = Operaciones.multi(valor1, valor2);
                        Console.WriteLine("Tu resultado es: {0} \n", Res);
                        Res = 0;

                        break;
                    case "4":
                        Console.WriteLine("División \n");
                        Console.WriteLine("Captura el primer valor:");
                        valor1 = Res == 0 ? int.Parse(Console.ReadLine()) : Res;
                        Console.WriteLine("Captura el segundo valor:");
                        valor2 = int.Parse(Console.ReadLine());
                        Res = Operaciones.division(valor1, valor2);
                        Console.WriteLine("Tu resultado es: {0} \n", Res);
                        Res = 0;

                        break;
                    case "5":
                        Console.WriteLine("Accediendo a Memoria \n");
                        Console.WriteLine("-----------------\n");
                        //memoria.multidimensional();
                        String key = Console.ReadLine();
                        Res = memoria.GetMemoriaData(key);
                        Console.WriteLine(Res);
                        break;
                    case "6":
                        Console.WriteLine("Memoria Temporal Reiniciada! \n");
                        Res = 0;
                        break;
                    case "7":
                        Console.WriteLine("-----------------\n");
                        Console.WriteLine("Cerrando Calculator Nos vemos! \n");
                        close_app = false;
                        break;
                    default:
                        Console.WriteLine("Opción invalida: {0}, intenta de nuevo \n", opcion);
                        break;
                }
            }
        }
    }
    class Operaciones
    {
        public int valor1;
        public int valor2;

        public static int suma(int valor1, int valor2)
        {
            int result = 0;
            result = valor1 + valor2;
            return result;
        }
        public static int resta(int valor1, int valor2)
        {
            int result = 0;
            result = valor1 - valor2;
            return result;
        }
        public static int multi(int valor1, int valor2)
        {
            int result = 0;
            result = valor1 * valor2;
            return result;
        }
        public static int division(int valor1, int valor2)
        {
            int result = 0;
            result = valor1 / valor2;
            return result;
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
