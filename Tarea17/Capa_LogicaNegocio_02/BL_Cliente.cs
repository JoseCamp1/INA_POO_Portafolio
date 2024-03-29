﻿using System;
using System.Collections.Generic;
using System.Text;
using Capa_AccesoDatos_03;
using Capa_Entidades;

namespace Capa_LogicaNegocio_02
{
    public class BL_Cliente
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
        public BL_Cliente(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            _mensaje = string.Empty;
        }

        //metodo para llamar al metodo insertar de la capa3accesodatos
        public int InsertarCliente(Entidad_Clientes cliente)
        {
            int id_cliente = 0;
            DA_Clientes accesoDatos = new DA_Clientes(_cadenaConexion);
            try
            {
                id_cliente = accesoDatos.InsertarCliente(cliente);
            }
            catch (Exception)
            {
                throw;
            }
            return id_cliente;
        }// fin de la clase insertar


        //metodo para llamarlistar
        public List<Entidad_Clientes> llamarListaClientes(string condicion = "")
        {
            List<Entidad_Clientes> listaClientes;
            DA_Clientes accesoDatos = new DA_Clientes(_cadenaConexion);
            try
            {
                listaClientes = accesoDatos.ListaClientes(condicion);
            }
            catch (Exception)
            {
                throw;
            }

            return listaClientes;
        }

        public Entidad_Clientes ObtenerCliente(int id)
        {
            Entidad_Clientes cliente;
            DA_Clientes accesoDatos = new DA_Clientes(_cadenaConexion);
            try
            {
                cliente = accesoDatos.ObtenerCliente(id);
            }
            catch (Exception)
            {
                throw;
            }
            return cliente;
        }

        public int EliminarsinSP(Entidad_Clientes cliente)
        {
            int resultado;
            DA_Clientes accesoDatos = new DA_Clientes(_cadenaConexion);
            try
            {
                resultado = accesoDatos.EliminarCliente(cliente);
            }
            catch (Exception)
            {
                throw;
            }
            return resultado;
        }//eliminarconsp fin

        public int Modificar(Entidad_Clientes cliente)
        {
            int filasAfectadas = 0;
            DA_Clientes accesoDatos = new DA_Clientes(_cadenaConexion);
            try
            {
                filasAfectadas = accesoDatos.Modificar(cliente);
            }
            catch (Exception)
            {
                throw;
            }
            return filasAfectadas;
        }//finmodificar

        //**
        //metodo para eliminar un cliente utilizando un proceso almacenado
        public int EliminarConSP(Entidad_Clientes cliente)
        {
            int resultado;
            DA_Clientes accesoDatos = new DA_Clientes(_cadenaConexion);
            try
            {
                // aqui antes de eliminar se podria verificar si es posible eliminar
                resultado = accesoDatos.EliminarRegistroConSP(cliente);
                _mensaje = accesoDatos.Mensaje;
            }
            catch (Exception)
            {

                throw;
            }
            return resultado;
        }//EliminarConSP
        //**
    }


}
