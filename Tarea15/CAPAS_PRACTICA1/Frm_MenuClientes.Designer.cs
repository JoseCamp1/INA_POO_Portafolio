namespace Capa_Presentacion_01
{
    partial class Frm_MenuClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_MenuClientes));
            grdClientes = new System.Windows.Forms.DataGridView();
            ID_CLIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            NOMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            TELEFONO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            DIRECCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            btnBuscar = new System.Windows.Forms.Button();
            btnGuardar = new System.Windows.Forms.Button();
            btnEliminar = new System.Windows.Forms.Button();
            btnSalir = new System.Windows.Forms.Button();
            btnNuevo = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            txtCliente = new System.Windows.Forms.TextBox();
            txtNombre = new System.Windows.Forms.TextBox();
            txtTelefono = new System.Windows.Forms.TextBox();
            txtDireccion = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)grdClientes).BeginInit();
            SuspendLayout();
            // 
            // grdClientes
            // 
            grdClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { ID_CLIENTE, NOMBRE, TELEFONO, DIRECCION });
            grdClientes.Location = new System.Drawing.Point(2, 58);
            grdClientes.Name = "grdClientes";
            grdClientes.RowTemplate.Height = 25;
            grdClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            grdClientes.Size = new System.Drawing.Size(712, 263);
            grdClientes.TabIndex = 0;
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
            // btnBuscar
            // 
            btnBuscar.Image = (System.Drawing.Image)resources.GetObject("btnBuscar.Image");
            btnBuscar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            btnBuscar.Location = new System.Drawing.Point(111, 327);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new System.Drawing.Size(75, 70);
            btnBuscar.TabIndex = 1;
            btnBuscar.Text = "&Buscar";
            btnBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Image = Properties.Resources._1904659_arrow_backup_down_download_save_storage_transfer_122509;
            btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            btnGuardar.Location = new System.Drawing.Point(303, 327);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new System.Drawing.Size(75, 70);
            btnGuardar.TabIndex = 2;
            btnGuardar.Text = "&Guardar";
            btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Image = Properties.Resources._1487086345_cross_81577;
            btnEliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            btnEliminar.Location = new System.Drawing.Point(394, 327);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new System.Drawing.Size(75, 70);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "&Eliminar";
            btnEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = System.Drawing.SystemColors.Control;
            btnSalir.Image = Properties.Resources._4115235_exit_logout_sign_out_114030;
            btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            btnSalir.Location = new System.Drawing.Point(487, 327);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new System.Drawing.Size(75, 70);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "&Salir";
            btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.Image = Properties.Resources._1490129329_rounded38_82203;
            btnNuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            btnNuevo.Location = new System.Drawing.Point(207, 327);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new System.Drawing.Size(75, 70);
            btnNuevo.TabIndex = 5;
            btnNuevo.Text = "&Nuevo";
            btnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(111, 11);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(58, 15);
            label1.TabIndex = 6;
            label1.Text = "ID Cliente";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(231, 11);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(51, 15);
            label2.TabIndex = 7;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(343, 11);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(52, 15);
            label3.TabIndex = 8;
            label3.Text = "Telefono";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(462, 11);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(57, 15);
            label4.TabIndex = 9;
            label4.Text = "Direccion";
            // 
            // txtCliente
            // 
            txtCliente.Enabled = false;
            txtCliente.Location = new System.Drawing.Point(111, 29);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new System.Drawing.Size(100, 23);
            txtCliente.TabIndex = 10;
            // 
            // txtNombre
            // 
            txtNombre.Location = new System.Drawing.Point(231, 29);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new System.Drawing.Size(100, 23);
            txtNombre.TabIndex = 11;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new System.Drawing.Point(343, 29);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new System.Drawing.Size(100, 23);
            txtTelefono.TabIndex = 12;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new System.Drawing.Point(462, 29);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new System.Drawing.Size(100, 23);
            txtDireccion.TabIndex = 13;
            // 
            // Frm_MenuClientes
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._212a40d0af2ac7285fa9b8416da447951;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(714, 413);
            Controls.Add(txtDireccion);
            Controls.Add(txtTelefono);
            Controls.Add(txtNombre);
            Controls.Add(txtCliente);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnNuevo);
            Controls.Add(btnSalir);
            Controls.Add(btnEliminar);
            Controls.Add(btnGuardar);
            Controls.Add(btnBuscar);
            Controls.Add(grdClientes);
            DoubleBuffered = true;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Frm_MenuClientes";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Frm_MenuClientes";
            Load += Frm_MenuClientes_Load;
            ((System.ComponentModel.ISupportInitialize)grdClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView grdClientes;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_CLIENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE;
        private System.Windows.Forms.DataGridViewTextBoxColumn TELEFONO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIRECCION;
    }
}