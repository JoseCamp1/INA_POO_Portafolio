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

        
    }
}