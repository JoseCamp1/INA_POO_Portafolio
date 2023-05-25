using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //6.Leer 10 números e indicar cuánto es la suma de todos ellos.
            // Estudiante: Jose Campos Chaves
            // Módulo: POO
            // Tarea #8 Ejercicio 6
            int suma = 0;
            for (int i = 0; i <= 9; i++)
            {
                Console.WriteLine($"Ingrese un numero: ");
                int num = int.Parse( Console.ReadLine() );
                suma= suma + num;
            }
            Console.WriteLine($"El total de numeros sumados es: {suma}");
            Console.ReadKey();
        }
        
    }
}
