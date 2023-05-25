using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el monto del salario base del empleado en colones.");
            double salarioBase = double.Parse(Console.ReadLine());
            double comision = salarioBase * 0.1;
            double salarioBruto = salarioBase + comision;
            Console.WriteLine($"El Salario bruto del empleado es de : {salarioBruto} colones.");
            Console.ReadKey();
        }
    }
}
