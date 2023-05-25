using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //5.Construya un programa que permita leer una cantidad variable de números hasta que se ingresen 5 números negativos. Indicar cantidad total de números leídos.
            // Estudiante: Jose Campos Chaves
            // Módulo: POO
            // Tarea #8 Ejercicio 5
            // Fecha de creacion:
            // Fecha de modificacion:

            int total = 0;
            int numNegativos = 0;
            Console.WriteLine("Ingrese varios numeros y el programa se detendra cuando ingrese 5 numeros negativos.");
            while (numNegativos < 5)
            {
                Console.Write("Ingrese un numero: ");
                int numero = int.Parse(Console.ReadLine());
                total++;
                if (numero < 0)
                {
                    numNegativos++;
                }
            }
            Console.WriteLine($"Cantidad total de números leídos: {total}");
            Console.ReadKey();
        }
    }
}
