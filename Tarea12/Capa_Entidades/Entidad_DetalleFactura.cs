﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Capa_Entidades
{
    public class Entidad_DetalleFactura
    {
        private int _id_Factura;
        private int _id_Producto;
        private int _cantidad;

        public int Id_Factura { get => _id_Factura; set => _id_Factura = value; }
        public int Id_Producto { get => _id_Producto; set => _id_Producto = value; }
        public int Cantidad { get => _cantidad; set => _cantidad = value; }

        public Entidad_DetalleFactura()
        {
            _id_Factura = 0;
            _id_Producto = 0;
            _cantidad = 0;

        }
        public Entidad_DetalleFactura(int id_Factura, int id_Producto, int cantidad)
        {            
            _id_Factura = id_Factura;
            _id_Producto = id_Producto;
            _cantidad = cantidad;
        }        
    }
}
