using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Capa_LogicaNegocio_02;
using Capa_Entidades;
using Capa_AccesoDatos_03;
using System;

namespace Capa_Presentacion_01
{
    public partial class Frm_MenuClientes : Form
    {
        Frm_BuscarCliente formularioBuscar; //variable global
        public Frm_MenuClientes()
        {
            InitializeComponent();
        }
        //variable global, esto si el campo txtIdcliente.text tiene algun valor, significa que el cliente existe
        //no se debe insertar se debe modificar
        Entidad_Clientes clienteRegistrado;

        //crea un objeto con los datos ingresados en las casillas de texto
        public Entidad_Clientes generaCliente()
        {
            Entidad_Clientes cliente;
            if (!string.IsNullOrEmpty(txtCliente.Text))
            {
                cliente = clienteRegistrado;
            }
            else
            {
                cliente = new Entidad_Clientes();
            }
            cliente.Nombre = txtNombre.Text;
            cliente.Telefono = txtTelefono.Text;
            cliente.Direccion = txtDireccion.Text;
            //EntidadCliente cliente = new EntidadCliente();
            //cliente.Nombre = txtNombre.Text;
            //cliente.Telefono = txtTelefono.Text;
            //cliente.Direccion = txtDireccion.Text;

            //cliente.set_Nombre(txtNombre.Text);
            //cliente.set_Telefono(txtTelefono.Text);
            //cliente.set_Direccion.(txtDireccion.Text);
            return cliente;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Entidad_Clientes cliente = new Entidad_Clientes();
            BL_Cliente logica = new BL_Cliente(Configuracion.getConnectionString);
            int resultado;
            try
            {
                if (!string.IsNullOrEmpty(txtNombre.Text) && !string.IsNullOrEmpty(txtTelefono.Text) && !string.IsNullOrEmpty(txtDireccion.Text))
                {
                    cliente = generaCliente();
                    if (!cliente.Existe)
                    {
                        resultado = logica.InsertarCliente(cliente);
                        //MessageBox.Show("No existe!");
                    }
                    else
                    {
                        resultado = logica.Modificar(cliente);
                        //MessageBox.Show("Existe!");
                    }
                    if (resultado > 0)
                    {
                        LimpiarCasillas();
                        MessageBox.Show("Operacion realizada con exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarListaClientes();
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
            txtCliente.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtNombre.Focus();
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
                    //se asigna la entidad cliente local a la variable global clienteRegistrado
                    clienteRegistrado = cliente;
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Entidad_Clientes cliente;
            int resultado;
            BL_Cliente logica = new BL_Cliente(Configuracion.getConnectionString);
            try
            {
                if (!string.IsNullOrEmpty(txtCliente.Text))
                {
                    //busca primero el cliente antees de borrarlo para ver si existe
                    cliente = logica.ObtenerCliente(int.Parse(txtCliente.Text));
                    if (cliente != null)
                    {
                        //Eliminar sin procedimiento almacenado 
                        resultado = logica.EliminarsinSP(cliente);
                        MessageBox.Show("Eliminado sin SP", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarCasillas();
                        CargarListaClientes();

                    }
                    else
                    {
                        MessageBox.Show("El cliente no existe", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        LimpiarCasillas();
                        CargarListaClientes();
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un cliente antes de eliminar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void grdClientes_DoubleClick(object sender, EventArgs e)
        {
            int id = 0;
            try
            {
                //se recupero el id
                id = (int)grdClientes.SelectedRows[0].Cells[0].Value;
                //ya con el id recuperado se puede llamar a la funcion que carga el cliente desde la base de datos
                //en el formulario
                CargarCliente(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

