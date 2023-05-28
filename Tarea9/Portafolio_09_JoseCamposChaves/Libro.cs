using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portafolio_09_JoseCamposChaves
{
    public class Libro
    {
        //atributos
        private int codigo;
        private string titulo;
        private string autor;
        private int añoPublicacion;
        private string editorial;
        private decimal precio;
        private bool disponible;
        private bool borrado;

        //constructores
        public Libro()
        {
            codigo = 1;
            titulo = string.Empty;
            autor = string.Empty;
            añoPublicacion = DateTime.Now.Year;
            editorial = string.Empty;
            precio = 0;
            disponible = true;
            borrado = false;
        }

        public Libro(int codigo, string titulo, string autor, int añoPublicacion, string editorial, decimal precio)
        {
            this.codigo = codigo;
            this.titulo = titulo;
            this.autor = autor;
            this.añoPublicacion = añoPublicacion;
            this.editorial = editorial;
            this.precio = precio;
            disponible = true;
            borrado = false;
        }

        public Libro(int codigo, string titulo, string autor, int añoPublicacion, string editorial, decimal precio, bool disponible, bool borrado)
        {
            this.codigo = codigo;
            this.titulo = titulo;
            this.autor = autor;
            this.añoPublicacion = añoPublicacion;
            this.editorial = editorial;
            this.precio = precio;
            this.disponible = disponible;
            this.borrado = borrado;
        }



        //getters y setters

        public int getCodigo()
        {
            return codigo;
        }

        public void setCodigo(int codigo)
        {
            this.codigo = codigo;
        }

        public string getTitulo()
        {
            return titulo;
        }

        public void setTitulo(string titulo)
        {
            this.titulo = titulo;
        }

        public string getAutor()
        {
            return autor;
        }

        public void setAutor(string autor)
        {
            this.autor = autor;
        }

        public int getAñoPublicacion()
        {
            return añoPublicacion;
        }

        public void setAñoPublicacion(int añoPublicacion)
        {
            this.añoPublicacion = añoPublicacion;
        }

        public string getEditorial()
        {
            return editorial;
        }

        public void setEditorial(string editorial)
        {
            this.editorial = editorial;
        }

        public decimal getPrecio()
        {
            return precio;
        }

        public void setPrecio(decimal precio)
        {
            this.precio = precio;
        }

        public bool isDisponible()
        {
            return disponible;
        }

        public void setDisponible(bool disponible)
        {
            this.disponible = disponible;
        }

        public bool isBorrado()
        {
            return borrado;
        }

        public void setBorrado(bool borrado)
        {
            this.borrado = borrado;
        }

        public string getInformacionLibro()
        {
            string infoLibro = $"\n\n********************************\n" +
                $"*** Informacion del libro ***\n" +
                $"********************************\n" +
                $"Codigo: {codigo}\n" +
                $"Titulo: {titulo}\n" +
                $"Autor: {autor}\n" +
                $"Año de Publicacion: {añoPublicacion}\n" +
                $"Editorial: {editorial}\n" +
                $"Precio: {precio} colones\n" +
                $"Disponible: {disponible}\n" +
                $"Borrado: {borrado}\n" +
                $"********************************\n\n";
            return infoLibro;
        }


        public void setDisponibilidadYPrecio(bool disponible, decimal precio)
        {
            this.disponible = disponible;
            this.precio = precio;
        }

        public (string, string) getTituloYAutor()
        {
            return (titulo, autor);
        }

        public (int, bool) getCodigoYDisponibilidad()
        {
            return (codigo, disponible);
        }

        public void actualizarInformacion(string nuevoTitulo, string nuevoAutor, int nuevoAñoPublicacion, string nuevaEditorial)
        {
            titulo = nuevoTitulo;
            autor = nuevoAutor;
            añoPublicacion = nuevoAñoPublicacion;
            editorial = nuevaEditorial;
        }

        public void modificarPrecioDisponibilidad(decimal nuevoPrecio, bool nuevaDisponibilidad)
        {
            precio = nuevoPrecio;
            disponible = nuevaDisponibilidad;
        }

        // Este sirve para verificar si el libro está disponible para préstamo
        public bool EstaDisponibleParaPrestamo()
        {
            // Si el libro está disponible y no está marcado como borrado
            if (disponible && !borrado)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Este método sirve para calcular el precio total de una determinada cantidad de libros
        public decimal CalcularPrecioTotal(int cantidad)
        {
            decimal precioTotal = precio * cantidad;
            return precioTotal;
        }

        
        public decimal CalcularPrecioTotal(int cantidad, decimal descuento)
        {
            decimal precioDescuento = precio - (precio * descuento);
            decimal precioTotal = precioDescuento * cantidad;
            return precioTotal;
        }

        //calcula el precio total de una determinada cantidad de libros con descuento y envío gratis
        public decimal CalcularPrecioTotal(int cantidad, decimal descuento, bool envioGratis)
        {
            decimal precioDescuento = precio - (precio * descuento);
            if (envioGratis)
            {
                return precioDescuento * cantidad;
            }
            else
            {
                return (precioDescuento * cantidad) + 2500; // Costo del envío
            }
        }
    }
}
