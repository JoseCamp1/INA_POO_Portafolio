using System;
using System.Collections.Generic;
using System.Text;
using Capa_AccesoDatos_03;
using Capa_Entidades;


namespace Capa_LogicaNegocio_02
{
    public class BL_Producto
    {
        // atributos
        private string _cadenaConexion;
        private string _mensaje;

        // propiedades
        public string Mensaje
        {
            get => _mensaje;
        }

        // constructor
        public BL_Producto(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            _mensaje = string.Empty;
        }

        // método para llamar al método InsertarProducto de la capa de acceso a datos
        public int InsertarProducto(Entidad_Productos producto)
        {
            int id_producto = 0;
            DA_Productos accesoDatos = new DA_Productos(_cadenaConexion);
            try
            {
                id_producto = accesoDatos.InsertarProducto(producto);
            }
            catch (Exception)
            {
                throw;
            }
            return id_producto;
        }

        // método para llamar al método ListaProductos de la capa de acceso a datos
        public List<Entidad_Productos> ListaProductos(string condicion = "")
        {
            List<Entidad_Productos> listaProductos;
            DA_Productos accesoDatos = new DA_Productos(_cadenaConexion);
            try
            {
                listaProductos = accesoDatos.ListaProductos(condicion);
            }
            catch (Exception)
            {
                throw;
            }
            return listaProductos;
        }

        // método para llamar al método ObtenerProducto de la capa de acceso a datos
        public Entidad_Productos ObtenerProducto(int id)
        {
            Entidad_Productos producto;
            DA_Productos accesoDatos = new DA_Productos(_cadenaConexion);
            try
            {
                producto = accesoDatos.ObtenerProducto(id);
            }
            catch (Exception)
            {
                throw;
            }
            return producto;
        }

        public int EliminarsinSP(Entidad_Productos producto)
        {
            int resultado;
            DA_Productos accesoDatos = new DA_Productos(_cadenaConexion);
            try
            {
                resultado = accesoDatos.EliminarProducto(producto);
            }
            catch (Exception)
            {
                throw;
            }
            return resultado;
        }//eliminarconsp fin

        public int Modificar(Entidad_Productos producto)
        {
            int filasAfectadas = 0;
            DA_Productos accesoDatos = new DA_Productos(_cadenaConexion);
            try
            {
                filasAfectadas = accesoDatos.Modificar(producto);
            }
            catch (Exception)
            {
                throw;
            }
            return filasAfectadas;
        }//finmodificar
    }
}

