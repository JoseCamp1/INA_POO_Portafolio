using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Capa_Entidades;


namespace Capa_AccesoDatos_03
{
    public class DA_Productos
    {
        private string _cadenaConexion;
        private string _mensaje;

        public string Mensaje { get => _mensaje; }

        public DA_Productos(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            _mensaje = string.Empty;
        }

        public int InsertarProducto(Entidad_Productos producto)
        {
            int id = 0;
            SqlConnection cnx = new SqlConnection(_cadenaConexion);
            SqlCommand comando = new SqlCommand();
            comando.Connection = cnx;
            string instruccion = "INSERT INTO PRODUCTOS (DESCRIPCION, PRECIOCOMPRA, PRECIOVENTA, GRAVADO) " +
                "VALUES(@DESCRIPCION, @PRECIOCOMPRA, @PRECIOVENTA, @GRAVADO); SELECT @@IDENTITY";
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

        public List<Entidad_Productos> ListaProductos(string condicion = "")
        {
            DataSet elDataSet = new DataSet();
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlDataAdapter adapter;
            List<Entidad_Productos> listaProductos;

            string instruccionDB = "SELECT ID_PRODUCTO, DESCRIPCION, PRECIOCOMPRA, PRECIOVENTA, GRAVADO FROM PRODUCTOS";

            if (!string.IsNullOrEmpty(condicion))
            {
                instruccionDB = string.Format("{0} WHERE {1}", instruccionDB, condicion);
            }
            try
            {
                adapter = new SqlDataAdapter(instruccionDB, conexion);
                adapter.Fill(elDataSet, "Productos");
                listaProductos = (from DataRow unaFila in elDataSet.Tables["Productos"].Rows
                                  select new Entidad_Productos()
                                  {
                                      Id_Producto = (int)unaFila[0],
                                      Descripcion = unaFila[1].ToString(),
                                      Precio_Compra = Convert.ToSingle(unaFila[2]),
                                      Precio_Venta = Convert.ToSingle(unaFila[3]),
                                      Gravado = unaFila[4].ToString()
                                  }).ToList();
            }
            catch (Exception)
            {
                throw;
            }
            return listaProductos;
        }

        public Entidad_Productos ObtenerProducto(int id)
        {
            Entidad_Productos producto = null;
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand comando = new SqlCommand();
            SqlDataReader dataReader;
            string sentencia = string.Format("SELECT ID_PRODUCTO, DESCRIPCION, PRECIOCOMPRA, PRECIOVENTA, GRAVADO " +
                "FROM PRODUCTOS WHERE ID_PRODUCTO = {0}", id);
            comando.Connection = conexion;
            comando.CommandText = sentencia;
            try
            {
                conexion.Open();
                dataReader = comando.ExecuteReader();
                if (dataReader.HasRows)
                {
                    producto = new Entidad_Productos();
                    dataReader.Read();
                    producto.Id_Producto = dataReader.GetInt32(0);
                    producto.Descripcion = dataReader.GetString(1);
                    producto.Precio_Compra = Convert.ToSingle(dataReader.GetDouble(2));
                    producto.Precio_Venta = Convert.ToSingle(dataReader.GetDouble(3));
                    producto.Gravado = dataReader.GetString(4);
                    producto.Existe = true;
                }
                conexion.Close();
            }
            catch (Exception)
            {
                throw;
            }
            return producto;
        }

        //este metodo sirve para eliminar un cliente pero sin llamar a un SP
        public int EliminarProducto(Entidad_Productos producto)
        {
            int afectado = -1;
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand comando = new SqlCommand();
            string sentencia = "DELETE FROM PRODUCTOS";
            sentencia = string.Format("{0} WHERE ID_PRODUCTO ={1}", sentencia, producto.Id_Producto);
            comando.CommandText = sentencia;
            comando.Connection = conexion;
            try
            {
                conexion.Open();
                afectado = comando.ExecuteNonQuery();
                conexion.Close();
            }
            catch (Exception) { throw; }
            finally
            {
                conexion.Dispose();
                comando.Dispose();
            }
            return afectado;
        }

        public int Modificar(Entidad_Productos producto)
        {
            int filasAfectadas = -1;
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand comando = new SqlCommand();
            string sentencia = "UPDATE PRODUCTOS SET DESCRIPCION=@DESCRIPCION,PRECIOCOMPRA=@PRECIOCOMPRA,PRECIOVENTA=@PRECIOVENTA,GRAVADO=@GRAVADO WHERE ID_PRODUCTO=@ID_PRODUCTO";
            comando.CommandText = sentencia;
            comando.Connection = conexion;
            comando.Parameters.AddWithValue("@ID_PRODUCTO", producto.Id_Producto);
            comando.Parameters.AddWithValue("@DESCRIPCION", producto.Descripcion);
            comando.Parameters.AddWithValue("@PRECIOCOMPRA", producto.Precio_Compra);
            comando.Parameters.AddWithValue("@PRECIOVENTA", producto.Precio_Venta);
            comando.Parameters.AddWithValue("@GRAVADO", producto.Gravado);
            try
            {
                conexion.Open();
                filasAfectadas = comando.ExecuteNonQuery();
                conexion.Close();
            }
            catch (Exception) { throw; }
            finally
            {
                conexion.Dispose();
                comando.Dispose();
            }
            return filasAfectadas;

        }//fin modificar

        
    }
}
