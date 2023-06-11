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
    public partial class Frm_MenuClientes : Form
    {
        public Frm_MenuClientes()
        {
            InitializeComponent();
        }

        //crea un objeto con los datos ingresados en las casillas de texto
        public Entidad_Clientes generaCliente()
        {
            Entidad_Clientes unCliente = new Entidad_Clientes();
            unCliente.Nombre = txtNombre.Text;
            unCliente.Telefono = txtTelefono.Text;
            unCliente.Direccion = txtDireccion.Text;

            return unCliente;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Entidad_Clientes UnCliente = new Entidad_Clientes();
            BL_Cliente logicaCliente = new BL_Cliente(Configuracion.getConnectionString);
            int resultado;
            try
            {
                if (string.IsNullOrEmpty(txtNombre.Text) | string.IsNullOrEmpty(txtTelefono.Text) | string.IsNullOrEmpty(txtDireccion.Text))
                {
                    MessageBox.Show("ooops! Faltan datos", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    UnCliente = generaCliente();
                    resultado = logicaCliente.InsertarCliente(UnCliente);
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
            txtCliente.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            txtDireccion.Text = string.Empty;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarCasillas();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
