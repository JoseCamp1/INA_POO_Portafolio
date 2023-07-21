using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Capa_Entidades;
using Capa_LogicaNegocio_02;
using System.Windows;

namespace SitioWeb
{
    public partial class Frm_NuevoCliente : System.Web.UI.Page
    {
        string MensajeScript;

        public void Limpiar()
        {
            txtId.Text = "";
            txtDireccion.Text = "";
            txtNombre.Text = "";
            txtTelefono.Text = "";
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            Entidad_Clientes cliente;
            BL_Cliente logica = new BL_Cliente(Cls_Configuracion.getConnectionString);
            int identificacion;
            try
            {
                if (!Page.IsPostBack)
                {
                    //EI ID es un dato que se genera en el otro formulario
                    //Se pueden enviar datos de un formulario a otro por QueryString o por SESION(existe muchas otras
                    //formas de enviar datos entre päginas Web)
                    //Lo enviaremos por sesiön, vamos a preguntar si lo que viene por sesiön trae algo

                    //Funcionamiento:
                    //EI formulario Default le enviarå por SESION un valor al formulario FrmClientes,
                    //esto permite que de un formulario enviemos valores hasta otro formulario.
                    //En este formulario(FrmClientes) estamos preguntando si en el valor de SESION existe algün valor
                    //llamado "id_del_cliente"
                    //Esto implica que desde el formulario Default(o cualquier otro formulario que invoque a FrmC1ientes)
                    //debemos crear una Variable de SESION y llamarla "id_del_cliente" asignåndole el ID que corresponda.
                    if (Session["id_del_cliente"] != null)
                    {
                        identificacion = int.Parse(Session["id_del_cliente"].ToString());
                        cliente = logica.ObtenerCliente(identificacion);
                        if (cliente.Existe)
                        {
                            txtId.Text = cliente.Id_Cliente.ToString();
                            txtNombre.Text = cliente.Nombre;
                            txtTelefono.Text = cliente.Telefono;
                            txtDireccion.Text = cliente.Direccion;

                            lblid.Visible = true;
                            txtId.Visible = true;
                        }
                        else
                        {
                            MensajeScript = string.Format("javascript:mostrarMensaje" + "('Cliente no encontrado')");
                            ScriptManager.RegisterStartupScript(this, typeof(string), "MensajeRetorno", MensajeScript, true);
                        }
                    }
                    else
                    {
                        Limpiar();
                        txtId.Text = "-1";
                        lblid.Visible = false;
                        txtId.Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MensajeScript = string.Format("javascript:mostrarMensaje('{0}')", ex.Message);
                ScriptManager.RegisterStartupScript(this, typeof(string), "MensajeRetorno", MensajeScript, true);
                Response.Redirect("Default.aspx");
            }
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Frm_MenuClientes.aspx");
        }

        private Entidad_Clientes GenerarEntiedadCliente()
        {
            Entidad_Clientes cliente = new Entidad_Clientes();
            // si hay algo en la variable de sesion
            if (Session["id_del_cliente"] != null)
            {
                cliente.Id_Cliente = int.Parse(Session["id_del_cliente"].ToString());
                cliente.Existe = true;
            }
            //si no hay nada en la variable de sesion, es un cliente nuevo
            else
            {
                cliente.Id_Cliente = -1;
                cliente.Existe = false;
            }
            //los demas datos siempre se toman de los cuadros de texto
            cliente.Nombre = txtNombre.Text;
            cliente.Telefono = txtTelefono.Text;
            cliente.Direccion = txtDireccion.Text;
            return cliente;
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            Entidad_Clientes cliente;
            BL_Cliente logica = new BL_Cliente(Cls_Configuracion.getConnectionString);
            int resultado;
            try
            {
                cliente = GenerarEntiedadCliente();
                //si el cliente ya existe , se modifica 
                if (cliente.Existe)
                {
                    resultado = logica.Modificar(cliente);
                }
                //si el cliente no existe se crea
                else
                {
                    if (!string.IsNullOrEmpty(txtNombre.Text))
                    {
                        resultado = logica.InsertarCliente(cliente);
                    }
                    else
                    {
                        MensajeScript = string.Format("javascript:mostrarMensaje" + "('Debe agregar almenos el nombre del cliente')");
                        ScriptManager.RegisterStartupScript(this, typeof(string), "MensajeRetorno", MensajeScript, true);
                        resultado = -1;
                    }
                }
                if (resultado > 0)
                {
                    MensajeScript = string.Format("javascript:mostrarMensaje" + "('Operacion realizada satisfactoriamente')");
                    ScriptManager.RegisterStartupScript(this, typeof(string), "MensajeRetorno", MensajeScript, true);
                    Response.Redirect("Frm_MenuClientes.aspx");
                }
                else
                {
                    MensajeScript = string.Format("javascript:mostrarMensaje" + "('No se pudo ejecutar la operacion')");
                    ScriptManager.RegisterStartupScript(this, typeof(string), "MensajeRetorno", MensajeScript, true);
                }
            }
            catch (Exception ex)
            {
                MensajeScript = string.Format("javascript:mostrarMensaje('{0}')", ex.Message);
                ScriptManager.RegisterStartupScript(this, typeof(string), "MensajeRetorno", MensajeScript, true);
            }
        }
    }
}