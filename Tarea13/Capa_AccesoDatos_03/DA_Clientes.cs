using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using Capa_Entidades;

namespace Capa_AccesoDatos_03
{
    public class DA_Clientes
    {
        private string _cadenaConexion;
        private string _mensaje;

        public string Mensaje { get => _mensaje; }

        public DA_Clientes(string cadenaConexion) 
        {
            _cadenaConexion = cadenaConexion;
            _mensaje = string.Empty;
        }

        public int InsertarCliente(Entidad_Clientes cliente)
        {
            int id = 0;
            SqlConnection cnx = new SqlConnection(_cadenaConexion);
            SqlCommand comando = new SqlCommand();
            comando.Connection = cnx;
            string instruccion = "INSERT INTO CLIENTES (NOMBRE ,TELEFONO ,DIRECCION) VALUES(@NOMBRE ,@TELEFONO ,@DIRECCION); SELECT @@IDENTITY";
            comando.Parameters.AddWithValue("@NOMBRE", cliente.Nombre);
            comando.Parameters.AddWithValue("@TELEFONO", cliente.Telefono);
            comando.Parameters.AddWithValue("@DIRECCION", cliente.Direccion);
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
