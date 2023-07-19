using System;
using System.Collections.Generic;
using System.Text;

namespace Capa_Entidades
{
    public class Entidad_Productos
    {
        private int _id_Producto;
        private string _descripcion;
        private float _precio_Compra;
        private float _precio_Venta;
        private string _gravado;
        private bool existe;

        public int Id_Producto { get => _id_Producto; set => _id_Producto = value; }
        public string Descripcion { get => _descripcion; set => _descripcion = value; }
        public float Precio_Compra { get => _precio_Compra; set => _precio_Compra = value; }
        public float Precio_Venta { get => _precio_Venta; set => _precio_Venta = value; }
        public string Gravado { get => _gravado; set => _gravado = value; }
        public bool Existe { get => existe; set => existe = value; }

        public Entidad_Productos()
        {
            Id_Producto = 0;
            Descripcion=string.Empty;
            Precio_Compra=float.MinValue;
            Precio_Venta=float.MinValue;
            Gravado=string.Empty;
            existe = false;
        }

        public Entidad_Productos(int id_Producto,string descripcion, float precio_Compra, float precio_Venta, string gravado, bool existe)
        {
            this.Id_Producto=id_Producto;
            this.Descripcion=descripcion;
            this.Precio_Compra=Precio_Compra;
            this.Precio_Venta=Precio_Venta;
            this.Gravado=gravado;
            this.existe = existe;
        }       
    }
}
