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
    public partial class Frm_BuscarCliente : Form
    {
        public Frm_BuscarCliente()
        {
            InitializeComponent();
        }

        public EventHandler Aceptar;//evento 

        int global_id_Cliente;



        public void CargarListaClientes(string condicion = "")
        {
            BL_Cliente logicaBuscar = new BL_Cliente(Configuracion.getConnectionString);
            List<Entidad_Clientes> listarClientes;
            try
            {
                listarClientes = logicaBuscar.llamarListaClientes(condicion);
                if (listarClientes.Count > 0)
                {
                    grdClientes.DataSource = listarClientes;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Frm_BuscarCliente_Load(object sender, EventArgs e)
        {
            CargarListaClientes();
        }


        private void Seleccionar()
        {
            if (grdClientes.SelectedRows.Count > 0)
            {
                global_id_Cliente = (int)grdClientes.SelectedRows[0].Cells[0].Value;
                Aceptar(global_id_Cliente, null);
                Close();
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Seleccionar();

        }

        private void grdClientes_DoubleClick(object sender, EventArgs e)
        {
            Seleccionar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Aceptar(-1, null);
            Close();
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            string condicion = "";
            try
            {
                if (!string.IsNullOrEmpty(txtBuscarNombre.Text))
                {
                    condicion = string.Format("Nombre LIKE '%{0}%'", txtBuscarNombre.Text.Trim());
                }
                else
                {
                    MessageBox.Show("Debe escribir algo antes de buscar", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtBuscarNombre.Focus();
                }
                CargarListaClientes(condicion);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
