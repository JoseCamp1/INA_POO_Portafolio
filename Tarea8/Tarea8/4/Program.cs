using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //4.Construya un programa que permita leer una cantidad variable de números indicando finalmente lo siguiente:
            //	cuantos fueron pares
            //	cuantos fueron impares
            //	cuántos fueron múltiplos de tres
            // Estudiante: Jose Campos Chaves
            // Módulo: POO
            // Tarea #8 Ejercicio 4

            int pares = 0;
            int impares = 0;
            int multiplo = 0;
            string opcion = "S";
            while (opcion == "S")
            {
                Console.Write("Inrese un Número: ");
                int numero = int.Parse(Console.ReadLine());
                if (numero % 2 == 0)
                {
                    pares++;
                }
                else
                {
                    impares++;
                }
                if (numero % 3 == 0)
                {
                    multiplo++;
                }
                Console.Write("¿Desea ingresar otro número? (S/N): ");
                opcion = Console.ReadLine().ToUpper();
            }
            Console.WriteLine($"Cantidad de números pares: {pares}\nCantidad de números impares: {impares}\nCantidad de números múltiplos de tres: {multiplo}");
            Console.ReadKey();            
        }
    }
}
