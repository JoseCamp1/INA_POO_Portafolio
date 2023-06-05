using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Capa_Presentacion_01
{
    public partial class Frm_MenuClientes : Form
    {
        //cadena de coneccion
        string cadenaConeccion = "Data Source=JOSEPC\\SQLEXPRESS;initial Catalog=CAPAS_PRACTICA1;Integrated Security=True";
        public Frm_MenuClientes()
        {
            InitializeComponent();
        }
    }
}
