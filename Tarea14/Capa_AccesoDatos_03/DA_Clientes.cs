using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using Capa_Entidades;
using System.Linq;

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

        public List<Entidad_Clientes> ListaClientes(string condicion = "")
        {
            DataSet elDataSet = new DataSet();
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlDataAdapter adapter;
            List<Entidad_Clientes> listaClientes;

            string instruccionDB = "SELECT ID_CLIENTE, NOMBRE, TELEFONO, DIRECCION FROM CLIENTES";

            if (!string.IsNullOrEmpty(condicion))
            {
                instruccionDB = string.Format("{0} WHERE {1}", instruccionDB, condicion);
            }
            try
            {
                adapter = new SqlDataAdapter(instruccionDB, conexion);
                adapter.Fill(elDataSet, "CLIENTES");
                listaClientes = (from DataRow unaFila in elDataSet.Tables["CLIENTES"].Rows
                                 select new Entidad_Clientes()
                                 {
                                     Id_Cliente = (int)unaFila[0],
                                     Nombre = unaFila[1].ToString(),
                                     Telefono = unaFila[2].ToString(),
                                     Direccion = unaFila[3].ToString()
                                 }).ToList();
            }
            catch (Exception)
            {
                throw;
            }
            return listaClientes;
        }

        public Entidad_Clientes ObtenerCliente(int id)
        {
            Entidad_Clientes cliente = null;
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand comando = new SqlCommand();
            SqlDataReader dataReader;
            string sentencia = string.Format("SELECT ID_CLIENTE,NOMBRE,TELEFONO,DIRECCION FROM CLIENTES WHERE ID_CLIENTE ={0}", id);
            comando.Connection = conexion;
            comando.CommandText = sentencia;
            try
            {
                conexion.Open();
                dataReader = comando.ExecuteReader();
                if (dataReader.HasRows)
                {
                    cliente = new Entidad_Clientes();
                    dataReader.Read();
                    cliente.Id_Cliente = dataReader.GetInt32(0);
                    cliente.Nombre = dataReader.GetString(1);
                    cliente.Telefono = dataReader.GetString(2);
                    cliente.Direccion = dataReader.GetString(3);                    
                }
                conexion.Close();
            }
            catch (Exception) { throw; }
            return cliente;
        }

    }
}
