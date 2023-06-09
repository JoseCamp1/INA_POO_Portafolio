﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_10_JoseCamposChaves
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Portafolio#10
            //Modulo:POO
            //Alumno:JoseCamposChaves
            //FechadeCreacion:28/mayo/23
            TourVacaciones[] tours = CrearTours();

            //
            var vehiculos = new[]
            {
                new { Placa = "654123", Tipo = "Automóvil", Color = "Rojo", Año = 2020, Fabricante = "Toyota", Modelo = "Corolla" },
                new { Placa = "987456", Tipo = "SUV4x2", Color = "Azul", Año = 2019, Fabricante = "Honda", Modelo = "CR-V" },
                new { Placa = "789789", Tipo = "SUV4x4", Color = "Negro", Año = 2022, Fabricante = "Ford", Modelo = "Explorer" },
                new { Placa = "798012", Tipo = "Automovil", Color = "Blanco", Año = 2021, Fabricante = "Chevrolet", Modelo = "Cruze" },
                new { Placa = "466345", Tipo = "SUV4x2", Color = "Gris", Año = 2018, Fabricante = "Nissan", Modelo = "Rogue" },
                new { Placa = "321678", Tipo = "Automovil", Color = "Plata", Año = 2023, Fabricante = "Volkswagen", Modelo = "Jetta" }
            };

            Console.WriteLine("Informacion de los Vehiculos:");
            Console.WriteLine("----------------------------");
            Console.WriteLine("Placa\tTipo\t\tColor\t\tAño\tFabricante\tModelo");
            Console.WriteLine("----------------------------");
            foreach (var vehiculo in vehiculos)
            {
                Console.WriteLine($"{vehiculo.Placa}\t{vehiculo.Tipo}\t{vehiculo.Color}\t{vehiculo.Año}\t{vehiculo.Fabricante}\t{vehiculo.Modelo}");
            }
            Console.WriteLine("----------------------------");

            //
            foreach (var vehiculo in vehiculos)
            {
                Console.WriteLine($"Placa:\t\t{vehiculo.Placa}");
                Console.WriteLine($"Tipo:\t\t{vehiculo.Tipo}");
                Console.WriteLine($"Color:\t\t{vehiculo.Color}");
                Console.WriteLine($"Año:\t\t{vehiculo.Año}");
                Console.WriteLine($"Fabricante:\t{vehiculo.Fabricante}");
                Console.WriteLine($"Modelo:\t\t{vehiculo.Modelo}");
                Console.WriteLine();
            }

            TourVacaciones.MostrarCantidadObjetos();

        }

        static TourVacaciones[] CrearTours()
        {
            TourVacaciones[] tours = new TourVacaciones[5];

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Ingrese los datos del Tour #{i + 1}:");
                
                int idTour = i + 1;

                Console.Write("Destino: ");
                string destino = Console.ReadLine();

                Console.Write("Precio: ");
                decimal precio = Convert.ToDecimal(Console.ReadLine());

                Console.Write("Fecha de salida: ");
                DateTime fechaSalida = Convert.ToDateTime(Console.ReadLine());

                Console.Write("Fecha de regreso: ");
                DateTime fechaRegreso = Convert.ToDateTime(Console.ReadLine());

                Console.Write("Descripcion: ");
                string descripcion = Console.ReadLine();

                TourVacaciones tour = new TourVacaciones(idTour, destino, precio, fechaSalida, fechaRegreso, descripcion);
                tours[i] = tour;

                Console.WriteLine();
            }

            return tours;
        }


        static void MostrarTours(TourVacaciones[] tours)
        {
            Console.WriteLine("Datos de los Tours:");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Id\tDestino\t\tPrecio\t\tFecha Salida\t\tFecha Regreso\t\tDescripción");
            Console.WriteLine("-------------------------------------");
            foreach (TourVacaciones tour in tours)
            {
                Console.WriteLine($"{tour.IdTour}\t{tour.Destino}\t\t{tour.Precio}\t\t{tour.FechaSalida.ToShortDateString()}\t\t{tour.FechaRegreso.ToShortDateString()}\t\t{tour.Descripcion}");
            }
            Console.WriteLine("-------------------------------------");
        }
    }    
}
