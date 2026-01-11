using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Git
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double resultado = 0, num1 = 10, num2 = 20;

            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Resta");
            Console.WriteLine("3. Multiplicación");

            Console.Write("Escoge una opción: ");
            int opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    resultado = Suma(num1, num2);
                    Console.WriteLine($"El resultado de la suma es: {resultado}");
                    break;
                case 2:
                    resultado = Resta(num1, num2);
                    Console.WriteLine($"El resultado de la resta es: {resultado}");
                    break;
                case 3:
                    resultado = Multiplicacion(num1, num2);
                    Console.WriteLine($"El resultado de la multiplicación es: {resultado}");
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
        }

        static double Suma(double num1, double num2)
        {
            double resultado = num1 + num2;

            return resultado;
        }

        static double Resta(double num1, double num2)
        {
            double resultado = num1 - num2;

            return resultado;
        }

        static double Multiplicacion(double num1, double num2)
        {
            double resultado = num1 * num2;
            return resultado;
        }
    }
}
