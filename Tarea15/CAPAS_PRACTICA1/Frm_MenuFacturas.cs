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
    public partial class Frm_MenuFacturas : Form
    {
        public Frm_MenuFacturas()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
