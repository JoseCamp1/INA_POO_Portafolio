using System;
using System.Collections.Generic;
using System.Text;

namespace Capa_Entidades
{
    internal class entidad_Encabezado_Factura
    {
        private int _id_Factura;
        private DateTime _fecha;
        private int _id_Cliente;
        private decimal _sub_Total;
        private decimal _impuesto;
        private decimal _montoDescuento;

        public int Id_Factura { get => _id_Factura; set => _id_Factura = value; }
        public DateTime Fecha { get => _fecha; set => _fecha = value; }
        public int Id_Cliente { get => _id_Cliente; set => _id_Cliente = value; }
        public decimal Sub_Total { get => _sub_Total; set => _sub_Total = value; }
        public decimal Impuesto { get => _impuesto; set => _impuesto = value; }
        public decimal MontoDescuento { get => _montoDescuento; set => _montoDescuento = value; }

        public entidad_Encabezado_Factura()
        {
            _id_Factura = 0;
            _fecha = DateTime.MinValue;
            _id_Cliente = 0;
            _sub_Total = 0;
            _impuesto = 0;
            _montoDescuento= 0;            
        }
        public entidad_Encabezado_Factura(int id_Factura, DateTime fecha, int id_Cliente, decimal sub_Total, decimal impuesto, decimal montoDescuento)
        {
            this._id_Factura = id_Factura;
            this._fecha = fecha;
            this._id_Cliente = id_Cliente;
            this._sub_Total = sub_Total;
            this._impuesto = impuesto;
            this._montoDescuento = montoDescuento;
        }
    }
}
