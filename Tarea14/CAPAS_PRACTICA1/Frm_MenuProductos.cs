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

        //crea un objeto con los datos ingresados en las casillas de texto
        public Entidad_Productos generaProducto()
        {
            Entidad_Productos unProducto = new Entidad_Productos();
            decimal aux = 0;
            unProducto.Descripcion = txtDescripcion.Text;
            if (decimal.TryParse(txtPrecioCompra.Text, out aux))
            {
                unProducto.Precio_Compra = aux;
            }
            if (decimal.TryParse(txtPrecioVenta.Text, out aux))
            {
                unProducto.Precio_Venta = aux;
            }
            if (!string.IsNullOrEmpty(txtGravado.Text))
            {
                unProducto.Gravado = txtGravado.Text; // Assigning the first character
            }
            return unProducto;
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            Entidad_Productos producto = new Entidad_Productos();
            BL_Productos logica = new BL_Productos(Configuracion.getConnectionString);
            int resultado;
            try
            {
                if (string.IsNullOrEmpty(txtDescripcion.Text) | string.IsNullOrEmpty(txtPrecioCompra.Text) | string.IsNullOrEmpty(txtPrecioVenta.Text) | string.IsNullOrEmpty(txtGravado.Text))
                {
                    MessageBox.Show("ooops! Faltan datos", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    producto = generaProducto();
                    resultado = logica.LlamarMetodoInsertar(producto);
                    LimpiarCasillas();
                    MessageBox.Show("operacion fue exitosa", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarCasillas();
        }
    }
}
