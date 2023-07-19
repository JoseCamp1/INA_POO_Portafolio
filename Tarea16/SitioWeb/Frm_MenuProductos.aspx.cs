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
    }
}