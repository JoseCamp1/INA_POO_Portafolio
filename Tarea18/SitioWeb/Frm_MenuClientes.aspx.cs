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
    public partial class Frm_MenuClientes : System.Web.UI.Page
    {
        string mensajeScript;
        //Cargar los datos
        public void CargarListaClientes(string condicion = "")
        {
            BL_Cliente logicaBuscar = new BL_Cliente(Cls_Configuracion.getConnectionString);
            List<Entidad_Clientes> listarClientes;
            try
            {
                listarClientes = logicaBuscar.llamarListaClientes(condicion);
                if (listarClientes.Count > 0)
                {
                    grdClientes.DataSource = listarClientes;
                }
                grdClientes.DataBind();
            }
            catch (Exception)
            {
                throw;
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack)
                {
                    CargarListaClientes();
                }                
            }
            catch (Exception)
            {
                //throw;
            }
        }

        protected void btnRegresar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string condicion = string.Format("NOMBRE LIKE '%{0}%'", txtNombre.Text);
                CargarListaClientes(condicion);
            }
            catch (Exception ex)
            {
                mensajeScript = string.Format("javascript:mostrarMensaje('{0}')", ex.Message);
                ScriptManager.RegisterStartupScript(this, typeof(string), "MensajeRetorno", mensajeScript, true);
            }
        }

        protected void InkEliminar_Command(object sender, CommandEventArgs e)
        {
            int id = int.Parse(e.CommandArgument.ToString());
            BL_Cliente logica = new BL_Cliente(Cls_Configuracion.getConnectionString);
            Entidad_Clientes cliente;
            try
            {
                cliente = logica.ObtenerCliente(id);
                if (cliente.Existe)
                {
                    if (logica.EliminarConSP(cliente) > 0)
                    {
                        mensajeScript = string.Format("javascript:mostrarMensaje('Cliente eliminado con exito')");
                        ScriptManager.RegisterStartupScript(this, typeof(string), "MensajeRetorno", mensajeScript, true);
                        CargarListaClientes();
                        txtNombre.Text = "";
                    }
                    else
                    {
                        mensajeScript = string.Format("javascript:mostrarMensaje('{0}')", logica.Mensaje);
                        ScriptManager.RegisterStartupScript(this, typeof(string), "MensajeRetorno", mensajeScript, true);
                    }
                }
            }
            catch (Exception ex)
            {
                mensajeScript = string.Format("javascript:mostrarMensaje('{0}')", ex.Message);
                ScriptManager.RegisterStartupScript(this, typeof(string), "MensajeRetorno", mensajeScript, true);
            }
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            //eliminamos la variable de sesin, asi cuando el otro formulario pregunte si esta vacia
            //determinara que efectivamente esta vacia, lo cual significa que debamos
            //agregar un cliente nuevo
            Session.Remove("id_del_cliente");
            //redireccionamos al otro formulario
            Response.Redirect("Frm_NuevoCliente.aspx");
        }

        protected void grdClientes_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grdClientes.PageIndex = e.NewPageIndex;
            CargarListaClientes();
        }

        protected void InkModificar_Command(object sender, CommandEventArgs e)
        {
            //aqui vamos a asignar el valor de SESION y redireccionar la pagina
            //en el valor de SESION colocamos el valor que contenga el Command
            //(el ID del cliente ) al cual se le dio click
            Session["id_del_cliente"] = e.CommandArgument.ToString();
            //redireccionamos al otro formulario(FrmClientes)
            Response.Redirect("Frm_NuevoCliente.aspx");
        }


    }
}