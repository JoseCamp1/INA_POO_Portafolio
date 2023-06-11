using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Capa_LogicaNegocio_02;
using Capa_Entidades;
using Capa_AccesoDatos_03;

namespace Capa_Presentacion_01
{
    public partial class Frm_MenuClientes : Form
    {
        Frm_BuscarCliente formularioBuscar; //variable global
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

        //Cargar los datos
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

        private void Frm_MenuClientes_Load(object sender, EventArgs e)
        {
            CargarListaClientes();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            formularioBuscar = new Frm_BuscarCliente();
            formularioBuscar.Aceptar += new EventHandler(Aceptar);
            formularioBuscar.ShowDialog();
        }

        private void Aceptar(object id, EventArgs e)
        {
            try
            {
                int idCliente = (int)id;
                if (idCliente != -1)//seleciono cancelar o no seleciono nada
                {
                    //MessageBox.Show(idCliente.ToString());
                    CargarCliente(idCliente);
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

        private void CargarCliente(int id)
        {
            Entidad_Clientes cliente = new Entidad_Clientes();
            BL_Cliente traerCliente = new BL_Cliente(Configuracion.getConnectionString);
            try
            {
                cliente = traerCliente.ObtenerCliente(id);
                if (cliente != null)
                {
                    txtCliente.Text = cliente.Id_Cliente.ToString();
                    txtNombre.Text = cliente.Nombre;
                    txtTelefono.Text = cliente.Telefono;
                    txtDireccion.Text = cliente.Direccion;
                }
                else
                {
                    MessageBox.Show("el cliente nose encuentra en la base de datos", "aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    CargarListaClientes();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
