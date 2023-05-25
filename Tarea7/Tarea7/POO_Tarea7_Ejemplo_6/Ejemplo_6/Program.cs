using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double suma = 0;
            for (int i = 1; i <= 12; i++)
            {
                Console.Write($"Ingrese el salario del mes " + i + ": ");
                double salario = double.Parse(Console.ReadLine());
                suma += salario;
            }
            double aguinaldo = suma * 0.5;
            Console.WriteLine($"El aguinaldo seria: {aguinaldo} colones.");
            Console.ReadKey();
        }
    }
}
