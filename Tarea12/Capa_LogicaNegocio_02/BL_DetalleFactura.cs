using System;
using System.Collections.Generic;
using System.Text;
using Capa_AccesoDatos_03;
using Capa_Entidades;

namespace Capa_LogicaNegocio_02
{
    internal class BL_DetalleFactura
    {
        private int _id_Factura;
        private int _id_Producto;
        private int _cantidad;

        public int Id_Factura { get => _id_Factura; set => _id_Factura = value; }
        public int Id_Producto { get => _id_Producto; set => _id_Producto = value; }
        public int Cantidad { get => _cantidad; set => _cantidad = value; }

        public BL_DetalleFactura()
        {
            _id_Factura = 0;
            _id_Producto = 0;
            _cantidad = 0;

        }
        public BL_DetalleFactura(int id_Factura, int id_Producto, int cantidad)
        {
            _id_Factura = id_Factura;
            _id_Producto = id_Producto;
            _cantidad = cantidad;
        }
    }
}
