using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Capa_LogicaNegocio_02;
using Capa_Entidades;

namespace Capa_Presentacion_01
{
    public partial class Frm_MenuProductos : Form
    {
        public Frm_MenuProductos()
        {
            InitializeComponent();
        }
        Frm_BuscarProductos formularioBuscar; //variable global

        //variable global, esto si el campo txtIdcliente.text tiene algun valor, significa que el producto existe
        //no se debe insertar se debe modificar
        Entidad_Productos productoRegistrado;

        //crea un objeto con los datos ingresados en las casillas de texto
        public Entidad_Productos generaProducto()
        {
            Entidad_Productos producto;
            if (!string.IsNullOrEmpty(txtProducto.Text))
            {
                producto = productoRegistrado;
            }
            else
            {
                producto = new Entidad_Productos();
            }
            producto.Descripcion = txtDescripcion.Text;
            producto.Precio_Compra = Convert.ToSingle( txtPrecioCompra.Text);
            producto.Precio_Venta = Convert.ToSingle(txtPrecioVenta.Text);
            producto.Gravado = txtGravado.Text;            
            return producto;
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            Entidad_Productos producto = new Entidad_Productos();
            BL_Producto logica = new BL_Producto(Configuracion.getConnectionString);
            int resultado;
            try
            {
                if (!string.IsNullOrEmpty(txtDescripcion.Text) && !string.IsNullOrEmpty(txtPrecioCompra.Text) && !string.IsNullOrEmpty(txtPrecioVenta.Text) && !string.IsNullOrEmpty(txtGravado.Text))
                {
                    producto = generaProducto();
                    if (!producto.Existe)
                    {
                        resultado = logica.InsertarProducto(producto);
                    }
                    else
                    {
                        resultado = logica.Modificar(producto);
                    }
                    if (resultado > 0)
                    {
                        LimpiarCasillas();
                        MessageBox.Show("Operacion realizada con exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarListaProductos();
                    }
                    else
                    {
                        MessageBox.Show("No se Realizaron cambios", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Los datos son obligatorios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarCasillas()
        {
            txtDescripcion.Text = string.Empty;
            txtPrecioCompra.Text = string.Empty;
            txtPrecioVenta.Text = string.Empty;
            txtGravado.Text = string.Empty;
            txtProducto.Text = string.Empty;
            txtDescripcion.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarCasillas();
        }
        // Cargar los datos
        public void CargarListaProductos(string condicion = "")
        {
            BL_Producto logicaBuscar = new BL_Producto(Configuracion.getConnectionString);
            List<Entidad_Productos> listaProductos;
            try
            {
                listaProductos = logicaBuscar.ListaProductos(condicion);
                if (listaProductos.Count > 0)
                {
                    grdProductos.DataSource = listaProductos;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Frm_MenuProductos_Load(object sender, EventArgs e)
        {
            CargarListaProductos();
        }

        private void Aceptar(object id, EventArgs e)
        {
            try
            {
                int idProducto = (int)id;
                if (idProducto != -1) // seleccionó cancelar o no seleccionó nada
                {
                    //MessageBox.Show(idProducto.ToString());
                    CargarProducto(idProducto);
                }
                else
                {
                    LimpiarCasillas();
                }

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarProducto(int id)
        {
            Entidad_Productos producto = new Entidad_Productos();
            BL_Producto traerProducto = new BL_Producto(Configuracion.getConnectionString);
            try
            {
                producto = traerProducto.ObtenerProducto(id);
                if (producto != null)
                {
                    txtProducto.Text = producto.Id_Producto.ToString();
                    txtDescripcion.Text = producto.Descripcion;
                    txtPrecioCompra.Text = producto.Precio_Compra.ToString();
                    txtPrecioVenta.Text = producto.Precio_Venta.ToString();
                    txtGravado.Text = producto.Gravado.ToString();
                    //se asigna la entidad producto local a la variable global clienteRegistrado
                    productoRegistrado = producto;
                }
                else
                {
                    MessageBox.Show("El producto no se encuentra en la base de datos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    CargarListaProductos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            formularioBuscar = new Frm_BuscarProductos();
            formularioBuscar.Aceptar += new EventHandler(Aceptar);
            formularioBuscar.ShowDialog();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Entidad_Productos producto;
            int resultado;
            BL_Producto logica = new BL_Producto(Configuracion.getConnectionString);
            try
            {
                if (!string.IsNullOrEmpty(txtProducto.Text))
                {
                    //busca primero el producto antees de borrarlo para ver si existe
                    producto = logica.ObtenerProducto(int.Parse(txtProducto.Text));
                    if (producto != null)
                    {
                        //Eliminar sin procedimiento almacenado 
                        resultado = logica.EliminarsinSP(producto);
                        MessageBox.Show("Eliminado sin SP", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarCasillas();
                        CargarListaProductos();

                    }
                    else
                    {
                        MessageBox.Show("El producto no existe", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        LimpiarCasillas();
                        CargarListaProductos();
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un producto antes de eliminar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
