using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la cantidad de megabytes que desea convertir: ");
            double megabytes = double.Parse(Console.ReadLine());
            double bits = megabytes * 8 * 1024 * 1024;
            double bytes = megabytes * 1024 * 1024;
            double kilobytes = megabytes * 1024;
            double gigabytes = megabytes / 1024;
            Console.WriteLine("Equivalencia en bits: {0},\nEquivalencia en bytes: {1},\nEquivalencia en kilobytes: {2},\nEquivalencia en gigabytes: {3}.", bits, bytes, kilobytes, gigabytes);            
            Console.ReadKey();
        }
    }
}
