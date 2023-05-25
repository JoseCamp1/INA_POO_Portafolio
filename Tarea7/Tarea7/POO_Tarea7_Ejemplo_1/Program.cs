using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Tarea7_Ejemplo_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el fondo del terreno en pies");
            Double fondo_pies = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el frente del terreno en pies");
            Double frente_pies = double.Parse(Console.ReadLine());

            Double fondo_MetrosCua = fondo_pies * 0.3048;
            Double frente_MetrosCua = frente_pies * 0.3048;
            Double area_MetrosCua = frente_MetrosCua * fondo_MetrosCua;

            Console.WriteLine("El area del terreno es: " + area_MetrosCua + " metros cuadrados");
            Console.ReadLine();
        }
    }
}


