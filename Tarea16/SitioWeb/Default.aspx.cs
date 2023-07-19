using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SitioWeb
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnClientes_Click(object sender, EventArgs e)
        {
            Response.Redirect("Frm_MenuClientes.aspx");
        }

        protected void btnProductos_Click(object sender, EventArgs e)
        {
            Response.Redirect("Frm_MenuProductos.aspx");
        }

        protected void btnFacturas_Click(object sender, EventArgs e)
        {
            Response.Redirect("Frm_MenuFacturas.aspx");
        }
    }
}