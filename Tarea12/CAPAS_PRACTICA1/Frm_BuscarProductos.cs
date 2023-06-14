using Capa_Entidades;
using Capa_LogicaNegocio_02;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Capa_Presentacion_01
{
    public partial class Frm_BuscarProductos : Form
    {
        public Frm_BuscarProductos()
        {
            InitializeComponent();
        }

        public EventHandler Aceptar; // Evento

        int global_id_Producto;

        public void CargarListaProductos(string condicion = "")
        {
            BL_Producto logicaBuscar = new BL_Producto(Configuracion.getConnectionString);
            List<Entidad_Productos> listarProductos;
            try
            {
                listarProductos = logicaBuscar.ListaProductos(condicion);
                if (listarProductos.Count > 0)
                {
                    grdProductos.DataSource = listarProductos;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Seleccionar()
        {
            if (grdProductos.SelectedRows.Count > 0)
            {
                global_id_Producto = (int)grdProductos.SelectedRows[0].Cells[0].Value;
                Aceptar(global_id_Producto, null);
                Close();
            }
        }

        private void Frm_BuscarProductos_Load(object sender, EventArgs e)
        {
            CargarListaProductos();
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            string condicion = "";
            try
            {
                if (!string.IsNullOrEmpty(txtBuscarNombre.Text))
                {
                    condicion = string.Format("Descripcion LIKE '%{0}%'", txtBuscarNombre.Text.Trim());
                }
                else
                {
                    MessageBox.Show("Debe escribir algo antes de buscar", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtBuscarNombre.Focus();
                }
                CargarListaProductos(condicion);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Aceptar(-1, null);
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Seleccionar();
        }

        private void grdProductos_DoubleClick(object sender, EventArgs e)
        {
            Seleccionar();
        }
    }
}
