using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Tarea8_JoseCamposChaves
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Construya un programa que permita leer una cantidad de 20 números y nos indique finalmente cuantos fueron positivos,
            //cuantos fueron negativos y cuantas veces se introdujo el cero.
            // Estudiante: Jose Campos Chaves
            // Módulo: POO
            // Tarea #8 Ejericio 1
            int positivos = 0;
            int negativos = 0;
            int ceros = 0;

            for (int i = 0; i < 20; i++)
            {
                Console.Write($"Ingrese el número {i + 1}: ");
                int numero = int.Parse(Console.ReadLine());

                if (numero > 0)
                {
                    positivos++;
                }
                else if (numero < 0)
                {
                    negativos++;
                }
                else
                {
                    ceros++;
                }
            }
            Console.WriteLine($"Total de números positivos: {positivos}\nTotal de números negativos: {negativos}\nTotal de ceros introducidos: {ceros}");
           
        }
    }
}
