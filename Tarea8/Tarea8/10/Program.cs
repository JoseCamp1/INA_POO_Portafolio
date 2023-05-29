using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //10.	Leer las edades de los asistentes a un cine e indicar finalmente cuántos de estos fueron: niños (1-10),
            //adolescentes (11-15), jóvenes (16-22), adultos (23-65), adultos mayores (más de 65), preguntar si desea leer otro asistente.
            // Tarea #8 Ejercicio 10
            // Estudiante: Jose Campos Chaves
            // Módulo: POO
            int contNinos = 0;
            int contAdolescentes = 0;
            int contJovenes = 0;
            int contAdultos = 0;
            int contAdultosMayores = 0;
            bool OtroAsistente = true;

            while (OtroAsistente)
            {
                Console.Write("Ingrese la edad del asistente: ");
                int edad = Convert.ToInt32(Console.ReadLine());
                if (edad >= 1 && edad <= 10)
                {
                    contNinos++;
                }
                else if (edad >= 11 && edad <= 15)
                {
                    contAdolescentes++;
                }
                else if (edad >= 16 && edad <= 22)
                {
                    contJovenes++;
                }
                else if (edad >= 23 && edad <= 65)
                {
                    contAdultos++;
                }
                else if (edad > 65)
                {
                    contAdultosMayores++;
                }
                Console.Write("¿Desea leer la edad de otro asistente? (S/N): ");
                string respuesta = Console.ReadLine();
                if (respuesta.ToUpper() != "S")
                {
                    OtroAsistente = false;
                }
            }            
            Console.WriteLine($"Cantidad de asistentes: \nNiños (1-10 años): {contNinos}\nAdolescentes (11-15 años): {contAdolescentes}\nJóvenes (16-22 años): {contJovenes}\nAdultos (23-65 años): {contAdultos}\nAdultos mayores (más de 65 años): {contAdultosMayores}");    
            Console.ReadKey();
        }
    }
}
