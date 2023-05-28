using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portafolio_09_JoseCamposChaves
{
    public class Cliente
    {
        //atributos
        private int idCliente;
        private string nombre;
        private string apellido;
        private string correoElectronico;
        private string direccion;
        private string telefono;
        private DateTime fechaRegistro;
        private bool activo;
        private bool borrado;

        //metodos

        //constructores
        public Cliente()
        {
            idCliente = 1;
            nombre = string.Empty;
            apellido = string.Empty;
            correoElectronico = string.Empty;
            direccion = string.Empty;
            telefono = string.Empty;
            fechaRegistro = DateTime.Now;
            activo = true;
            borrado = false;
        }

        public Cliente(int idCliente, string nombre, string apellido, string correoElectronico, string direccion, string telefono, DateTime fechaRegistro)
        {
            this.idCliente = idCliente;
            this.nombre = nombre;
            this.apellido = apellido;
            this.correoElectronico = correoElectronico;
            this.direccion = direccion;
            this.telefono = telefono;
            this.fechaRegistro = fechaRegistro;
            activo = true;
            borrado = false;
        }

        public Cliente(int idCliente, string nombre, string apellido, string correoElectronico, string direccion, string telefono, DateTime fechaRegistro, bool activo, bool borrado)
        {
            this.idCliente = idCliente;
            this.nombre = nombre;
            this.apellido = apellido;
            this.correoElectronico = correoElectronico;
            this.direccion = direccion;
            this.telefono = telefono;
            this.fechaRegistro = fechaRegistro;
            this.activo = activo;
            this.borrado = borrado;
        }

       
        //getters y setters
        public int getIdCliente()
        {
            return idCliente;
        }

        public void setIdCliente(int idCliente)
        {
            this.idCliente = idCliente;
        }

        public string getNombre()
        {
            return nombre;
        }

        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public string getApellido()
        {
            return apellido;
        }

        public void setApellido(string apellido)
        {
            this.apellido = apellido;
        }

        public string getCorreoElectronico()
        {
            return correoElectronico;
        }

        public void setCorreoElectronico(string correoElectronico)
        {
            this.correoElectronico = correoElectronico;
        }

        public string getDireccion()
        {
            return direccion;
        }

        public void setDireccion(string direccion)
        {
            this.direccion = direccion;
        }

        public string getTelefono()
        {
            return telefono;
        }

        public void setTelefono(string telefono)
        {
            this.telefono = telefono;
        }

        public DateTime getFechaRegistro()
        {
            return fechaRegistro;
        }

        public void setFechaRegistro(DateTime fechaRegistro)
        {
            this.fechaRegistro = fechaRegistro;
        }

        public bool isActivo()
        {
            return activo;
        }

        public void setActivo(bool activo)
        {
            this.activo = activo;
        }

        public bool isBorrado()
        {
            return borrado;
        }

        public void setBorrado(bool borrado)
        {
            this.borrado = borrado;
        }

        public string GetInformacionCliente()
        {
            string separador = new string('*', 32);
            string infoCliente = $"\n\n********************************\n" +
                                 $"*** Informacion del cliente ***\n" +
                                 $"********************************\n" +
                                 $"ID Cliente:        {idCliente}\n" +
                                 $"Nombre:            {nombre}\n" +
                                 $"Apellido:          {apellido}\n" +
                                 $"Correo Electronico:{correoElectronico}\n" +
                                 $"Direccion:         {direccion}\n" +
                                 $"Telefono:          {telefono}\n" +
                                 $"Fecha de Registro: {fechaRegistro}\n" +
                                 $"Activo:            {activo}\n" +
                                 $"Borrado:           {borrado}\n" +
                                 $"{separador}\n\n";
            return infoCliente;
        }



        public string getNombreCompleto()
        {
            return $"{nombre} {apellido}";
        }
        

        public (string, DateTime) getCorreoYFechaRegistro()
        {
            return (correoElectronico, fechaRegistro);
        }

        public void actualizarDatosPersonales(string nuevoNombre, string nuevoApellido, string nuevoCorreo, string nuevaDireccion, string nuevoTelefono)
        {
            nombre = nuevoNombre;
            apellido = nuevoApellido;
            correoElectronico = nuevoCorreo;
            direccion = nuevaDireccion;
            telefono = nuevoTelefono;
        }

        public void actualizarEstado(bool nuevoActivo, bool nuevoBorrado)
        {
            activo = nuevoActivo;
            borrado = nuevoBorrado;
        }
    }
}
