﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using Capa_Entidades;

namespace Capa_AccesoDatos_03
{
    public class DA_Productos
    {
        //Atributos
        private string _cadenaConexion;
        private string _mensaje;

        //Propiedades
        public string Mensaje { get => _mensaje; }

        //Constructor
        public DA_Productos(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            _mensaje = string.Empty;
        }

        //Metodos
        public int InsertarProducto(Entidad_Productos producto)
        {
            int id = 0;
            //Establecer el objeto conexion
            SqlConnection cnx = new SqlConnection(_cadenaConexion);
            //Establecer los comandos sQL
            SqlCommand comando = new SqlCommand();
            comando.Connection = cnx;
            string instruccion = "INSERT INTO PRODUCTOS (DESCRIPCION, PRECIOCOMPRA, PRECIOVENTA, GRAVADO) " +
                "VALUES (@DESCRIPCION, @PRECIOCOMPRA, @PRECIOVENTA, @GRAVADO); SELECT SCOPE_IDENTITY()";
            comando.Parameters.AddWithValue("@DESCRIPCION", producto.Descripcion);
            comando.Parameters.AddWithValue("@PRECIOCOMPRA", producto.Precio_Compra);
            comando.Parameters.AddWithValue("@PRECIOVENTA", producto.Precio_Venta);
            comando.Parameters.AddWithValue("@GRAVADO", producto.Gravado);
            comando.CommandText = instruccion;

            try
            {
                cnx.Open();
                id = Convert.ToInt32(comando.ExecuteScalar());
                cnx.Close();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                cnx.Dispose();
                comando.Dispose();
            }
            return id;
        }

    }
}
