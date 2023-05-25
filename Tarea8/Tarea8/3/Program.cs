using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //3.Construya un programa que permita ingresar 10 notas entre 1 y 100, indicando finalmente cuántos alumnos aprobaron (>=70) y cuantos reprobaron (<70).            
            // Estudiante: Jose Campos Chaves
            // Módulo: POO
            // Tarea #8 Ejericio 3
            int aprovados = 0;
            int reprovados = 0;
            for (int i = 0; i <= 9; i++) {
                Console.WriteLine($"Ingrese la nota de un alumno.\nNotas Ingresadas : {i}.");
                int nota = int.Parse(Console.ReadLine());
                if (nota >= 70) {
                    aprovados++;
                }
                else if (nota < 70)
                {
                    reprovados++;
                }
                
            }
            Console.WriteLine($"Total de notas analizadas: {aprovados+reprovados}.");
            Console.WriteLine($"Total Alumnos Aprovados: {aprovados}.\nTotal Alumnos Reprovados: {reprovados}.");
            Console.ReadKey();
        }
    }
}
