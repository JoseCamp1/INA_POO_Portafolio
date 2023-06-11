namespace Capa_Presentacion_01
{
    partial class Frm_BuscarCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_BuscarCliente));
            grdClientes = new System.Windows.Forms.DataGridView();
            ID_CLIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            NOMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            TELEFONO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            DIRECCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            txtBuscarNombre = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            btnCancelar = new System.Windows.Forms.Button();
            btnAceptar = new System.Windows.Forms.Button();
            btnBuscarCliente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)grdClientes).BeginInit();
            SuspendLayout();
            // 
            // grdClientes
            // 
            grdClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { ID_CLIENTE, NOMBRE, TELEFONO, DIRECCION });
            grdClientes.Location = new System.Drawing.Point(44, 114);
            grdClientes.Name = "grdClientes";
            grdClientes.RowTemplate.Height = 25;
            grdClientes.Size = new System.Drawing.Size(712, 303);
            grdClientes.TabIndex = 1;
            grdClientes.DoubleClick += grdClientes_DoubleClick;
            // 
            // ID_CLIENTE
            // 
            ID_CLIENTE.DataPropertyName = "ID_CLIENTE";
            ID_CLIENTE.HeaderText = "Cliente";
            ID_CLIENTE.Name = "ID_CLIENTE";
            ID_CLIENTE.Width = 150;
            // 
            // NOMBRE
            // 
            NOMBRE.DataPropertyName = "NOMBRE";
            NOMBRE.HeaderText = "Nombre";
            NOMBRE.Name = "NOMBRE";
            NOMBRE.Width = 150;
            // 
            // TELEFONO
            // 
            TELEFONO.DataPropertyName = "TELEFONO";
            TELEFONO.HeaderText = "Telefono";
            TELEFONO.Name = "TELEFONO";
            TELEFONO.Width = 150;
            // 
            // DIRECCION
            // 
            DIRECCION.DataPropertyName = "DIRECCION";
            DIRECCION.HeaderText = "Direccion";
            DIRECCION.Name = "DIRECCION";
            DIRECCION.Width = 200;
            // 
            // txtBuscarNombre
            // 
            txtBuscarNombre.Location = new System.Drawing.Point(44, 64);
            txtBuscarNombre.Name = "txtBuscarNombre";
            txtBuscarNombre.Size = new System.Drawing.Size(160, 23);
            txtBuscarNombre.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(44, 32);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(82, 15);
            label2.TabIndex = 12;
            label2.Text = "Buscar Cliente";
            // 
            // btnCancelar
            // 
            btnCancelar.Image = Properties.Resources._1487086345_cross_81577;
            btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            btnCancelar.Location = new System.Drawing.Point(681, 442);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new System.Drawing.Size(75, 70);
            btnCancelar.TabIndex = 15;
            btnCancelar.Text = "&Cancelar";
            btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnAceptar.Image = Properties.Resources._4115228_accept_checklist_checkmark_yes_114037;
            btnAceptar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            btnAceptar.Location = new System.Drawing.Point(574, 442);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new System.Drawing.Size(75, 70);
            btnAceptar.TabIndex = 14;
            btnAceptar.Text = "&Aceptar";
            btnAceptar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnBuscarCliente
            // 
            btnBuscarCliente.Image = (System.Drawing.Image)resources.GetObject("btnBuscarCliente.Image");
            btnBuscarCliente.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            btnBuscarCliente.Location = new System.Drawing.Point(681, 32);
            btnBuscarCliente.Name = "btnBuscarCliente";
            btnBuscarCliente.Size = new System.Drawing.Size(75, 70);
            btnBuscarCliente.TabIndex = 16;
            btnBuscarCliente.Text = "&Buscar";
            btnBuscarCliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnBuscarCliente.UseVisualStyleBackColor = true;
            btnBuscarCliente.Click += btnBuscarCliente_Click;
            // 
            // Frm_BuscarCliente
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._093da596df704fbb86507e0f2ad358fa;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(800, 541);
            Controls.Add(btnBuscarCliente);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(txtBuscarNombre);
            Controls.Add(label2);
            Controls.Add(grdClientes);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Frm_BuscarCliente";
            Text = "Frm_BuscarCliente";
            Load += Frm_BuscarCliente_Load;
            ((System.ComponentModel.ISupportInitialize)grdClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView grdClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_CLIENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE;
        private System.Windows.Forms.DataGridViewTextBoxColumn TELEFONO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIRECCION;
        private System.Windows.Forms.TextBox txtBuscarNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnBuscarCliente;
    }
}