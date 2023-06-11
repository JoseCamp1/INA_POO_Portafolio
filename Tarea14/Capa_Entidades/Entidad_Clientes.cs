using System;
using System.Collections.Generic;
using System.Text;

namespace Capa_Entidades
{
    public class Entidad_Clientes
    {
        private int _id_Cliente;
        private string _nombre;
        private string _telefono;
        private string _direccion;

        public Entidad_Clientes() 
        {
            Id_Cliente = 0;
            Nombre = string.Empty;
            Telefono = string.Empty;
            Direccion = string.Empty;
        }

        public Entidad_Clientes(int id_cliente,string nombre,string telefono,string direccion)
        {
            this.Id_Cliente = id_cliente;
            this.Nombre = nombre;
            this.Telefono = telefono;
            this.Direccion= direccion;            
        }

        public int Id_Cliente { get => _id_Cliente; set => _id_Cliente = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Telefono { get => _telefono; set => _telefono = value; }
        public string Direccion { get => _direccion; set => _direccion = value; }
    }
}
