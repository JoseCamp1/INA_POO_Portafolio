using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_10_JoseCamposChaves
{
    internal class TourVacaciones
    {
        //variable
        private static int contador = 0;

        //atributos
        public int _idTour;
        public string _Destino;
        public decimal _Precio;
        public DateTime _FechaSalida;
        public DateTime _FechaRegreso;
        public string _Descripcion;

        //metodos

        //constructores
        public TourVacaciones(int idTour, string destino, decimal precio, DateTime fechaSalida, DateTime fechaRegreso, string descripcion)
        {
            _idTour = idTour;
            _Destino = destino;
            _Precio = precio;
            _FechaSalida = fechaSalida;
            _FechaRegreso = fechaRegreso;
            _Descripcion = descripcion;

            contador++;
        }


        public TourVacaciones()
        {
            _idTour = 0;
            _Destino = string.Empty;
            _Precio = 0.0m;
            _FechaSalida = DateTime.MinValue;
            _FechaRegreso = DateTime.MinValue;
            _Descripcion = string.Empty;

            contador++;
        }

        //getters y setters
        public int IdTour
        {
            get { return _idTour; }
            set { _idTour = value; }
        }

        public string Destino
        {
            get { return _Destino; }
            set { _Destino = value; }
        }

        public decimal Precio
        {
            get { return _Precio; }
            set
            {
                if (value > 0)
                {
                    _Precio = value;
                }
                else
                {
                    Console.WriteLine("El precio debe ser mayor a cero.");
                }
            }
        }

        public DateTime FechaSalida
        {
            get { return _FechaSalida; }
            set { _FechaSalida = value; }
        }

        public DateTime FechaRegreso
        {
            get { return _FechaRegreso; }
            set { _FechaRegreso = value; }
        }

        public string Descripcion
        {
            get { return _Descripcion; }
            set { _Descripcion = value; }
        }

        public static int ObtenerContador()
        {
            return contador;
        }

        public static void MostrarCantidadObjetos()
        {
            Console.WriteLine($"La cantidad de objetos TourVacaciones creados hasta ahora es: {contador}");
        }

    }
}
