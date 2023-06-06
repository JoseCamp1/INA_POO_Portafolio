namespace ProyectoEscritorio
{
    partial class Frm_Notas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Notas));
            registrosNotas = new System.Windows.Forms.GroupBox();
            txtPromedio = new System.Windows.Forms.Label();
            listaNotas = new System.Windows.Forms.ListView();
            label3 = new System.Windows.Forms.Label();
            btnVerResultado = new System.Windows.Forms.Button();
            btnLimpiarListadeNotas = new System.Windows.Forms.Button();
            btnEliminarSeleccionado = new System.Windows.Forms.Button();
            txtNotaSeleccionada = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            btnAgregar = new System.Windows.Forms.Button();
            txtNota = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            btnSalir = new System.Windows.Forms.Button();
            registrosNotas.SuspendLayout();
            SuspendLayout();
            // 
            // registrosNotas
            // 
            registrosNotas.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            registrosNotas.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            registrosNotas.Controls.Add(txtPromedio);
            registrosNotas.Controls.Add(listaNotas);
            registrosNotas.Controls.Add(label3);
            registrosNotas.Controls.Add(btnVerResultado);
            registrosNotas.Controls.Add(btnLimpiarListadeNotas);
            registrosNotas.Controls.Add(btnEliminarSeleccionado);
            registrosNotas.Controls.Add(txtNotaSeleccionada);
            registrosNotas.Controls.Add(label2);
            registrosNotas.Controls.Add(btnAgregar);
            registrosNotas.Controls.Add(txtNota);
            registrosNotas.Controls.Add(label1);
            registrosNotas.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            registrosNotas.Location = new System.Drawing.Point(15, 13);
            registrosNotas.Name = "registrosNotas";
            registrosNotas.Size = new System.Drawing.Size(526, 439);
            registrosNotas.TabIndex = 0;
            registrosNotas.TabStop = false;
            registrosNotas.Text = "Registros de Notas";
            registrosNotas.UseWaitCursor = true;
            // 
            // txtPromedio
            // 
            txtPromedio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtPromedio.Location = new System.Drawing.Point(7, 335);
            txtPromedio.Name = "txtPromedio";
            txtPromedio.Size = new System.Drawing.Size(307, 85);
            txtPromedio.TabIndex = 11;
            txtPromedio.UseWaitCursor = true;
            // 
            // listaNotas
            // 
            listaNotas.HideSelection = false;
            listaNotas.Location = new System.Drawing.Point(321, 23);
            listaNotas.Name = "listaNotas";
            listaNotas.Size = new System.Drawing.Size(187, 397);
            listaNotas.TabIndex = 10;
            listaNotas.UseCompatibleStateImageBehavior = false;
            listaNotas.UseWaitCursor = true;
            listaNotas.View = System.Windows.Forms.View.List;
            listaNotas.SelectedIndexChanged += listaNotas_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(57, 384);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(0, 17);
            label3.TabIndex = 8;
            label3.UseWaitCursor = true;
            // 
            // btnVerResultado
            // 
            btnVerResultado.Location = new System.Drawing.Point(200, 295);
            btnVerResultado.Name = "btnVerResultado";
            btnVerResultado.Size = new System.Drawing.Size(114, 33);
            btnVerResultado.TabIndex = 7;
            btnVerResultado.Text = "&Ver Resultado";
            btnVerResultado.UseVisualStyleBackColor = true;
            btnVerResultado.UseWaitCursor = true;
            btnVerResultado.Click += btnVerResultado_Click;
            // 
            // btnLimpiarListadeNotas
            // 
            btnLimpiarListadeNotas.Location = new System.Drawing.Point(7, 239);
            btnLimpiarListadeNotas.Name = "btnLimpiarListadeNotas";
            btnLimpiarListadeNotas.Size = new System.Drawing.Size(177, 37);
            btnLimpiarListadeNotas.TabIndex = 6;
            btnLimpiarListadeNotas.Text = "&Limpiar Lista de Notas";
            btnLimpiarListadeNotas.UseVisualStyleBackColor = true;
            btnLimpiarListadeNotas.UseWaitCursor = true;
            btnLimpiarListadeNotas.Click += btnLimpiarListadeNotas_Click;
            // 
            // btnEliminarSeleccionado
            // 
            btnEliminarSeleccionado.Location = new System.Drawing.Point(7, 187);
            btnEliminarSeleccionado.Name = "btnEliminarSeleccionado";
            btnEliminarSeleccionado.Size = new System.Drawing.Size(177, 34);
            btnEliminarSeleccionado.TabIndex = 5;
            btnEliminarSeleccionado.Text = "&Eliminar Seleccionado";
            btnEliminarSeleccionado.UseVisualStyleBackColor = true;
            btnEliminarSeleccionado.UseWaitCursor = true;
            btnEliminarSeleccionado.Click += btnEliminarSeleccionado_Click;
            // 
            // txtNotaSeleccionada
            // 
            txtNotaSeleccionada.BackColor = System.Drawing.SystemColors.Info;
            txtNotaSeleccionada.Enabled = false;
            txtNotaSeleccionada.Location = new System.Drawing.Point(180, 111);
            txtNotaSeleccionada.Name = "txtNotaSeleccionada";
            txtNotaSeleccionada.Size = new System.Drawing.Size(114, 24);
            txtNotaSeleccionada.TabIndex = 4;
            txtNotaSeleccionada.UseWaitCursor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(7, 114);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(141, 17);
            label2.TabIndex = 3;
            label2.Text = "Nota Seleccionada:";
            label2.UseWaitCursor = true;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new System.Drawing.Point(229, 27);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new System.Drawing.Size(86, 35);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "&Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.UseWaitCursor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // txtNota
            // 
            txtNota.Location = new System.Drawing.Point(121, 28);
            txtNota.MaxLength = 3;
            txtNota.Name = "txtNota";
            txtNota.Size = new System.Drawing.Size(102, 24);
            txtNota.TabIndex = 1;
            txtNota.UseWaitCursor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(7, 31);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(108, 17);
            label1.TabIndex = 0;
            label1.Text = "Digite la Nota:";
            label1.UseWaitCursor = true;
            // 
            // btnSalir
            // 
            btnSalir.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnSalir.Location = new System.Drawing.Point(436, 458);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new System.Drawing.Size(86, 30);
            btnSalir.TabIndex = 9;
            btnSalir.Text = "&Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // Frm_Notas
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            BackColor = System.Drawing.SystemColors.ButtonHighlight;
            ClientSize = new System.Drawing.Size(553, 492);
            Controls.Add(btnSalir);
            Controls.Add(registrosNotas);
            Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Frm_Notas";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Registro de Notas";
            registrosNotas.ResumeLayout(false);
            registrosNotas.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox registrosNotas;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtNota;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNotaSeleccionada;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnVerResultado;
        private System.Windows.Forms.Button btnLimpiarListadeNotas;
        private System.Windows.Forms.Button btnEliminarSeleccionado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ListView listaNotas;
        private System.Windows.Forms.Label txtPromedio;
    }
}