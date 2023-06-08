using System;
using System.Collections.Generic;
using System.Text;
using Capa_Entidades;

namespace Capa_AccesoDatos_03
{
    internal class DA_Productos
    {
        private int _id_Producto;
        private string _descripcion;
        private decimal _precio_Compra;
        private decimal _precio_Venta;
        private string _gravado;

        public int Id_Producto { get => _id_Producto; set => _id_Producto = value; }
        public string Descripcion { get => _descripcion; set => _descripcion = value; }
        public decimal Precio_Compra { get => _precio_Compra; set => _precio_Compra = value; }
        public decimal Precio_Venta { get => _precio_Venta; set => _precio_Venta = value; }
        public string Gravado { get => _gravado; set => _gravado = value; }

        public DA_Productos()
        {
            _id_Producto = 0;
            _descripcion = string.Empty;
            _precio_Compra = decimal.MinValue;
            _precio_Venta = decimal.MinValue;
            _gravado = string.Empty;
        }

        public DA_Productos(int id_Producto, string descripcion, decimal precio_Compra, decimal precio_Venta, string gravado)
        {
            this._id_Producto = id_Producto;
            this._descripcion = descripcion;
            this.Precio_Compra = _precio_Compra;
            this.Precio_Venta = _precio_Venta;
            this.Gravado = gravado;
        }
    }
}
