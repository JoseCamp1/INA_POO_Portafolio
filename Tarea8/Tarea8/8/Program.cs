using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //8.Leer una cantidad variable de números e indicar cuánto suman todos los números, y cuál es el promedio de los números            
            // Tarea #8 Ejercicio 8
            // Estudiante: Jose Campos Chaves
            // Módulo: POO
            int cantNum = 0;
            int suma = 0;
            string opcion = "S";
            while (opcion.ToUpper() == "S")
            {
                Console.Write("Ingrese un numero: ");
                int numero = int.Parse(Console.ReadLine());
                cantNum++;
                suma += numero;
                Console.Write("Desea agregar otro numero? (S/N): ");
                opcion = Console.ReadLine().ToUpper();                
            }
            double promedio = (double)suma / cantNum;
            Console.WriteLine($"La suma de los numeros es: {suma}\nEl promedio de los numeros es: {promedio}");           
            Console.ReadKey();
        }
    }
}
