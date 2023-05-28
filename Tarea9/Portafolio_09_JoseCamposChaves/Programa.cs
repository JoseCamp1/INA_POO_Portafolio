using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Portafolio_09_JoseCamposChaves
{
    internal class Programa
    {
        static void Main(string[] args)
        {
            //objetos de la clase Libro
            Libro libro1 = new Libro(1, "El Principito", "Antoine de Saint-Exupéry", 1943, "Reynal & Hitchcock", 5000.00m);
            Libro libro2 = new Libro(2, "Cthulhu", "H.P. Lovecraft", 1928, "Arkham House", 14000.00m);

            //metodos getter y setter de Libro
            int codigoLibro1 = libro1.getCodigo();
            string tituloLibro2 = libro2.getTitulo();

            Console.WriteLine("Información del libro 1:");
            Console.WriteLine(libro1.getInformacionLibro());

            Console.WriteLine("Información del libro 2:");
            Console.WriteLine(libro2.getInformacionLibro());

            //metodos de funcionalidad de Libro
            decimal precioTotal1 = libro1.CalcularPrecioTotal(3);
            decimal precioTotal2 = libro2.CalcularPrecioTotal(2, 0.1m, true);

            Console.WriteLine("Precio total del libro 1 (3 unidades): $" + precioTotal1);
            Console.WriteLine("Precio total del libro 2 (2 unidades con descuento y envío gratis): $" + precioTotal2);

            //objetos de la clase Cliente
            Cliente cliente1 = new Cliente(1, "Jose", "Campos Chaves", "jose@gmail.com", "Alajuela,Narajo,Palmitos", "88990849", DateTime.Now);
            Cliente cliente2 = new Cliente(2, "Ana", "Rojas Rojas", "anar@gmail.com", "San Jose,San Pedro", "88888888", DateTime.Now);

            //metodos getter y setter de Cliente
            string nombreCliente1 = cliente1.getNombre();
            DateTime fechaRegistroCliente2 = cliente2.getFechaRegistro();

            Console.WriteLine("Información del cliente 1:");
            Console.WriteLine(cliente1.GetInformacionCliente());

            Console.WriteLine("Información del cliente 2:");
            Console.WriteLine(cliente2.GetInformacionCliente());

            //metodos de funcionalidad de Cliente
            string nombreCompleto1 = cliente1.getNombreCompleto();
            (string correo2, DateTime fechaRegistro2) = cliente2.getCorreoYFechaRegistro();

            Console.WriteLine("Nombre completo del cliente 1: " + nombreCompleto1);
            Console.WriteLine("Correo electrónico del cliente 2: " + correo2);
            Console.WriteLine("Fecha de registro del cliente 2: " + fechaRegistro2);
        }
    }
}
