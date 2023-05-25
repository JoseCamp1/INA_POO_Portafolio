using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //9.Leer una cantidad de números variables hasta que se ingrese un número múltiplo de 5.
            // Indicar el número de datos que fueron ingresados, sin contar el múltiplo de la condición de término.
            // Tarea #8 Ejercicio 9
            // Estudiante: Jose Campos Chaves
            // Módulo: POO
            int cantNum = 0;
            int num = 0;
            string opcion;
            do
            {
                Console.Write("Ingrese un numero: ");
                num = int.Parse(Console.ReadLine());
                if (num % 5 == 0)
                {
                    break;
                }
                cantNum++;
                Console.Write("Desea agregar otro numero? (S/N): ");
                opcion = Console.ReadLine().ToUpper();
            } while (opcion == "S");
            Console.WriteLine($"Cantidad de datos ingresados: {cantNum}");
            Console.ReadKey();
        }
    }
}
