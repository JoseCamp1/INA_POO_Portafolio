using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11
{
    internal class Program
    {
        //11.Construya un programa que permita leer sólo números positivos hasta reunir 10 números pares,
        //o el número 5 cuatro veces.Al final debe indicar la totalidad de números leídos.
        // Tarea #8 Ejercicio 11
        // Estudiante: Jose Campos Chaves
        // Módulo: POO
        static void Main(string[] args)
        {
            int contPares = 0;
            int contCinco = 0;
            int contTotal = 0;

            while (contPares < 10 && contCinco < 4)
            {
                Console.Write("Ingrese un numero positivo: ");
                int num = Convert.ToInt32(Console.ReadLine());
                if (num > 0)
                {
                    contTotal++;

                    if (num % 2 == 0)
                    {
                        contPares++;
                    }

                    if (num == 5)
                    {
                        contCinco++;
                    }
                }
            }
            Console.WriteLine($"Total de números leídos: {contTotal}\nTotal de numeros pares: {contPares}\nVeces que se repitio el numero 5: {contCinco}");
            Console.ReadKey();
        }
    }
}
