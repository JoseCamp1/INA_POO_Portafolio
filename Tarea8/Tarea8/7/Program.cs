using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //7.Leer 10 números e indicar cuánto suman los números pares.
            // Estudiante: Jose Campos Chaves
            // Módulo: POO
            // Tarea #8 Ejercicio 7
            int suma = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Ingrese un número: ");
                int numero = int.Parse(Console.ReadLine());

                if (numero % 2 == 0)
                {
                    suma += numero;
                }
            }
            Console.WriteLine($"La suma de los números pares es: {suma}");
            Console.ReadKey();
        }
    }
}
