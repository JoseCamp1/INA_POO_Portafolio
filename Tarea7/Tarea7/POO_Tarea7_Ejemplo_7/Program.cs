using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Por favor ingrese el ancho del terreno en metros: ");
            double ancho = double.Parse(Console.ReadLine());
            double largo = 2 * ancho;
            double perimetro = 2 * (largo + ancho);
            double distanciaEntrePostes = 2;
            int cantidadPostes = (int)(perimetro / distanciaEntrePostes);
            Console.WriteLine($"La cantidad de postes que se necesita es: {cantidadPostes}" );
            Console.ReadKey();
        }
    }
}
