using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la cantidad de segundos: ");
            int segundosTotal = int.Parse(Console.ReadLine());
            int horas = segundosTotal / 3600;
            int minutos = (segundosTotal % 3600) / 60;
            int segundos = (segundosTotal % 3600) % 60;
            Console.WriteLine($"Horas: {horas}, Minutos: {minutos}, Segundos:  {segundos}" );
            Console.ReadKey();            
        }
    }
}
