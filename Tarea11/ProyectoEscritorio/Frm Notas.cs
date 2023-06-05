using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using LógicaNegocio;



namespace ProyectoEscritorio
{
    public partial class Frm_Notas : Form
    {
        public Frm_Notas()
        {
            InitializeComponent();
        }

        public void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void LimpiarResultadoPromedio()
        {
            txtPromedio.BackColor = SystemColors.Info;
            txtPromedio.Text = string.Empty;
        }

        public static double CalcularSumaNotas(ListView.ListViewItemCollection notas)
        {
            double suma = 0;
            foreach (ListViewItem item in notas)
            {
                if (double.TryParse(item.Text, out double nota))
                {
                    suma += nota;
                }
            }
            return suma;
        }

        public void btnAgregar_Click(object sender, EventArgs e)
        {
            string notaText = txtNota.Text;

            // Valida que se haya indicado una nota
            if (string.IsNullOrWhiteSpace(notaText))
            {
                MessageBox.Show("Debe indicar una nota.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Valida que la nota sea un valor numérico
            if (!double.TryParse(notaText, out double nota))
            {
                MessageBox.Show("La nota debe ser un valor numérico.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNota.Text = string.Empty;
                return;
            }

            // Valida que la nota no sea superior a 100
            if (nota > 100)
            {
                MessageBox.Show("La nota no puede ser superior a 100.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNota.Text = string.Empty;
                return;
            }

            // Agrega la nota a la lista de notas
            listaNotas.Items.Add(nota.ToString());

            // Llama al procedimiento que limpia el resultado del promedio
            LimpiarResultadoPromedio();

            // Limpia el cuadro de texto de la nota
            txtNota.Text = string.Empty;
        }

        public void listaNotas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listaNotas.SelectedItems.Count > 0)
            {
                string notaSeleccionada = listaNotas.SelectedItems[0].Text;
                txtNotaSeleccionada.Text = notaSeleccionada;
            }
        }

        public void btnEliminarSeleccionado_Click(object sender, EventArgs e)
        {
            if (listaNotas.SelectedItems.Count > 0)
            {
                ListViewItem notaSeleccionada = listaNotas.SelectedItems[0];
                listaNotas.Items.Remove(notaSeleccionada);
                // Limpia el campo de texto de la nota seleccionada
                txtNotaSeleccionada.Text = string.Empty;
                // Llama al procedimiento que limpia los datos del promedio
                LimpiarResultadoPromedio();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una nota de la lista.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void btnLimpiarListadeNotas_Click(object sender, EventArgs e)
        {
            listaNotas.Items.Clear(); // Limpia la lista de notas
            txtNotaSeleccionada.Text = string.Empty; // Limpia el cuadro de texto de la nota seleccionada
            txtNota.Text = string.Empty; // Limpia el cuadro de texto de la nota digitada
            LimpiarResultadoPromedio(); // Llama al procedimiento que limpia los datos del promedio
        }

        public void btnVerResultado_Click(object sender, EventArgs e)
        {
            // Comprueba si no hay notas en la lista
            if (listaNotas.Items.Count == 0)
            {
                MessageBox.Show("No hay notas registradas para calcular el promedio.", "Atención", MessageBoxButtons.OK);
                return;
            }

            // Calcula la suma de las notas
            double sumaNotas = CalcularSumaNotas(listaNotas.Items);

            // Crear una instancia de la clase ClsPromedio
            ClsPromedio promedioCalculado = new ClsPromedio();

            // Calcular el promedio
            int cantidadNotas = listaNotas.Items.Count;
            promedioCalculado.CalcularPromedio(sumaNotas, cantidadNotas);

            // Obtener la condición
            promedioCalculado.CalcularCondición();

            // Cambiar el color de txtPromedio según la condición
            if (promedioCalculado.Color == "Verde")
            {
                txtPromedio.ForeColor = Color.Green;
            }
            else if (promedioCalculado.Color == "Rojo")
            {
                txtPromedio.ForeColor = Color.Red;
            }

            // Mostrar el promedio y la condición en el TextBox txtPromedio
            txtPromedio.Text = $"{promedioCalculado.Promedio} - {promedioCalculado.Condición}";
        }

    }
}
