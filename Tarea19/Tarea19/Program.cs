using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea19
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2: Cree los siguientes arreglos para utilizarlos como origenes de datos
            // Arreglo de clases anónimas de Materias (cod, nombre, creditos)
            var materias = new[]
            {
            new { Cod = 1, Nombre = "Matemáticas", Creditos = 4 },
            new { Cod = 2, Nombre = "Historia", Creditos = 3 },
            new { Cod = 3, Nombre = "Programación", Creditos = 5 },
            new { Cod = 4, Nombre = "Inglés", Creditos = 3 },
            new { Cod = 5, Nombre = "Biología", Creditos = 4 },
            new { Cod = 6, Nombre = "Física", Creditos = 5 }
        };

            // Arreglo de clases anónimas de Estudiantes (id, Nombre y telefono)
            var estudiantes = new[]
            {
            new { Id = 1, Nombre = "Juan", Telefono = "111111111" },
            new { Id = 2, Nombre = "María", Telefono = "222222222" },
            new { Id = 3, Nombre = "Pedro", Telefono = "333333333" },
            new { Id = 4, Nombre = "Ana", Telefono = "444444444" }
        };

            // Arreglo de clases anónimas de Matriculas (codMatricula, id_Estudiante, cod_Materia)
            var matriculas = new[]
            {
            new { CodMatricula = 101, IdEstudiante = 1, CodMateria = 3 },
            new { CodMatricula = 102, IdEstudiante = 1, CodMateria = 2 },
            new { CodMatricula = 103, IdEstudiante = 2, CodMateria = 1 },
            new { CodMatricula = 104, IdEstudiante = 3, CodMateria = 3 },
            new { CodMatricula = 105, IdEstudiante = 4, CodMateria = 4 },
            new { CodMatricula = 106, IdEstudiante = 4, CodMateria = 6 }
        };

            // 3: Seleccionar el nombre de los estudiantes matriculados
            var estudiantesMatriculados = from estudiante in estudiantes
                                          join matricula in matriculas on estudiante.Id equals matricula.IdEstudiante
                                          select estudiante.Nombre;

            // Mostrar el resultado con un foreach
            Console.WriteLine("Estudiantes Matriculados:");
            foreach (var nombreEstudiante in estudiantesMatriculados)
            {
                Console.WriteLine(nombreEstudiante);
            }

            // 4: Contar la cantidad de veces que se ha matriculado una materia
            var matriculasPorMateria = from matricula in matriculas
                                       group matricula by matricula.CodMateria into grupo
                                       select new
                                       {
                                           CodMateria = grupo.Key,
                                           CantidadMatriculas = grupo.Count()
                                       };

            // Mostrar el resultado con un foreach
            Console.WriteLine("\nCantidad de veces que se ha matriculado una materia:");
            foreach (var materia in matriculasPorMateria)
            {
                Console.WriteLine($"Materia Cod: {materia.CodMateria}, Cantidad de Matrículas: {materia.CantidadMatriculas}");
            }

            // 5: Mostrar el nombre de los estudiantes matriculados y el nombre de la materia en la que se matriculó
            var estudiantesYmateriasMatriculadas = from matricula in matriculas
                                                   join estudiante in estudiantes on matricula.IdEstudiante equals estudiante.Id
                                                   join materia in materias on matricula.CodMateria equals materia.Cod
                                                   select new
                                                   {
                                                       NombreEstudiante = estudiante.Nombre,
                                                       NombreMateria = materia.Nombre
                                                   };

            // Mostrar el resultado con un foreach
            Console.WriteLine("\nEstudiantes Matriculados y Materia en la que se matricularon:");
            foreach (var estudianteMateria in estudiantesYmateriasMatriculadas)
            {
                Console.WriteLine($"Estudiante: {estudianteMateria.NombreEstudiante}, Materia: {estudianteMateria.NombreMateria}");
            }


            // 6: Cree la siguiente clase anónima
            var autos = new[]
            {
                new{ cod=1, marca="Toyota", precio = 40000, modelo = 2020},
                new{ cod=2, marca="Honda", precio = 30000, modelo = 2020},
                new{ cod=3, marca="Toyota", precio = 50000, modelo = 2022},
                new{ cod=4, marca="Honda", precio = 35000, modelo = 2022},
                new{ cod=5, marca="Toyota", precio = 45000, modelo = 2021},
                new{ cod=6, marca="Toyota", precio = 37000, modelo = 2019},
            };

            // a: Mostrar el precio más alto por cada modelo.
            var preciosMasAltosPorModelo = autos
                .GroupBy(a => a.modelo)
                .Select(g => new { Modelo = g.Key, PrecioMasAlto = g.Max(a => a.precio) });

            // Mostrar el resultado con un foreach
            Console.WriteLine("\nPrecios más altos por cada modelo:");
            foreach (var precio in preciosMasAltosPorModelo)
            {
                Console.WriteLine($"Modelo {precio.Modelo}: Precio más alto: {precio.PrecioMasAlto}");
            }

            // b: Mostrar el precio más bajo por cada modelo.
            var preciosMasBajosPorModelo = autos
                .GroupBy(a => a.modelo)
                .Select(g => new { Modelo = g.Key, PrecioMasBajo = g.Min(a => a.precio) });

            // Mostrar el resultado con un foreach
            Console.WriteLine("\nPrecios más bajos por cada modelo:");
            foreach (var precio in preciosMasBajosPorModelo)
            {
                Console.WriteLine($"Modelo {precio.Modelo}: Precio más bajo: {precio.PrecioMasBajo}");
            }

            // c: Mostrar la suma total de los precios por modelo.
            var sumasDePreciosPorModelo = autos
                .GroupBy(a => a.modelo)
                .Select(g => new { Modelo = g.Key, SumaTotalPrecios = g.Sum(a => a.precio) });

            // d: Mostrar el resultado con un foreach
            Console.WriteLine("\nSuma total de precios por cada modelo:");
            foreach (var suma in sumasDePreciosPorModelo)
            {
                Console.WriteLine($"Modelo {suma.Modelo}: Suma total de precios: {suma.SumaTotalPrecios}");
            }
            Console.ReadKey();            
        }
    }
    
}
