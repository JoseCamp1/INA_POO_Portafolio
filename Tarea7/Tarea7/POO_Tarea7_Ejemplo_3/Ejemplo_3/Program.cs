using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la cantidad de horas: ");
            int horas = int.Parse(Console.ReadLine());
            Console.Write("Ingrese la cantidad de minutos: ");
            int minutos = int.Parse(Console.ReadLine());
            Console.Write("Ingrese la cantidad de segundos: ");
            int segundos = int.Parse(Console.ReadLine());
            int totalSegundos = (horas * 3600) + (minutos * 60) + segundos;
            Console.WriteLine($"El total de segundos es: {totalSegundos}");
            Console.ReadKey();
        }
    }
}
