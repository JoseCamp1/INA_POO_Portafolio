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
    public partial class Frm_MenuProductos : System.Web.UI.Page
    {
        String mensajeScript;
        public void CargarListaProductos(string condicion = "")
        {
            BL_Producto logicaBuscar = new BL_Producto(Cls_Configuracion.getConnectionString);
            List<Entidad_Productos> listaProductos;
            try
            {
                listaProductos = logicaBuscar.ListaProductos(condicion);
                if (listaProductos.Count > 0)
                {
                    grdProductos.DataSource = listaProductos;
                }
                grdProductos.DataBind();
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
                    CargarListaProductos();
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

        protected void grdProductos_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grdProductos.PageIndex = e.NewPageIndex;
            CargarListaProductos();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                string condicion = string.Format("DESCRIPCION LIKE '%{0}%'", txtDescripcion.Text);
                CargarListaProductos(condicion);
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
            BL_Producto logica = new BL_Producto(Cls_Configuracion.getConnectionString);
            Entidad_Productos producto;
            try
            {
                producto = logica.ObtenerProducto(id);
                if (producto.Existe)
                {
                    if (logica.EliminarsinSP(producto) > 0)
                    {
                        mensajeScript = string.Format("javascript:mostrarMensaje('Cliente eliminado con exito')");
                        ScriptManager.RegisterStartupScript(this, typeof(string), "MensajeRetorno", mensajeScript, true);
                        CargarListaProductos();
                        txtDescripcion.Text = "";
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
    }
}