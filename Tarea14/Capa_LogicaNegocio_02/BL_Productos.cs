using System;
using System.Collections.Generic;
using System.Text;
using Capa_AccesoDatos_03;
using Capa_Entidades;

namespace Capa_LogicaNegocio_02
{
    public class BL_Productos
    {
        //atributos
        private string _cadenaConexion;
        private string _mensaje;

        //propiedades
        public string Mensaje
        {
            get => _mensaje;
        }

        // constructor
        public BL_Productos(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            _mensaje = string.Empty;
        }

        //metodo para llamar al metodo insertar de la capa3accesodatos
        public int LlamarMetodoInsertar(Entidad_Productos producto)
        {
            int id_Producto = 0;
            DA_Productos accesoDatos = new DA_Productos(_cadenaConexion);
            try
            {
                id_Producto = accesoDatos.InsertarProducto(producto);
            }
            catch (Exception)
            {
                throw;
            }
            return id_Producto;
        }// fin de la clase insertar
    }
}
