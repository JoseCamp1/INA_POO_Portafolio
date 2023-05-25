using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2.Construya un programa que permita leer una cantidad variable de números y nos indique cuantos fueron mayores
            //  o iguales a 100 y cuántos menores a 100, cada vez que ingresa un número debe preguntar si desea ingresar otro.
            // Estudiante: Jose Campos Chaves
            // Módulo: POO
            // Tarea #8 Ejericio 2
            string opcion = "S";
            int contMayores = 0;
            int contMenores = 0;
            while (opcion == "S") { 
                Console.WriteLine("Ingrese un numero.");
                int numero = int.Parse(Console.ReadLine());
                if (numero >= 100) {
                    contMayores++;
                }
                else if (numero < 100)
                {
                    contMenores++;
                }
                Console.WriteLine($"Numeros mayores o iguales a 100: {contMayores}\nNumeros menores a 100: {contMenores}");
                Console.WriteLine("Desea ingresar un nuevo numero (S/N)?");
                opcion = Console.ReadLine().ToUpper();                
            }
            Console.ReadKey();   
        }
    }
}
