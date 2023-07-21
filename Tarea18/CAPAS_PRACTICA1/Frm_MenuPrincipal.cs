using System.Windows.Forms;
using Capa_LogicaNegocio_02;
using Capa_Entidades;

namespace Capa_Presentacion_01
{
    public partial class Frm_MenuPrincipal : Form
    {
        public Frm_MenuPrincipal()
        {
            InitializeComponent();
        }

        private void clientesToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Frm_MenuClientes menuCliente = new Frm_MenuClientes();
            menuCliente.MdiParent = this;
            menuCliente.Show();

        }

        private void facturasToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Frm_MenuFacturas menuFacturacion = new Frm_MenuFacturas();
            menuFacturacion.MdiParent = this;
            menuFacturacion.Show();
        }

        private void productosToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Frm_MenuProductos menuProductos = new Frm_MenuProductos();
            menuProductos.MdiParent = this;
            menuProductos.Show();
        }

        private void detalleToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Frm_MenuFacturas menuDetalleFactura = new Frm_MenuFacturas();
            menuDetalleFactura.MdiParent = this;
            menuDetalleFactura.Show();
        }
    }
}
