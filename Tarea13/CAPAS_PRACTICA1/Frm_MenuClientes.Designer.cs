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
            grdClientes.Location = new System.Drawing.Point(81, 100);
            grdClientes.Name = "grdClientes";
            grdClientes.RowTemplate.Height = 25;
            grdClientes.Size = new System.Drawing.Size(448, 242);
            grdClientes.TabIndex = 0;
            // 
            // ID_CLIENTE
            // 
            ID_CLIENTE.DataPropertyName = "ID_CLIENTE";
            ID_CLIENTE.HeaderText = "Cliente";
            ID_CLIENTE.Name = "ID_CLIENTE";
            // 
            // NOMBRE
            // 
            NOMBRE.DataPropertyName = "NOMBRE";
            NOMBRE.HeaderText = "Nombre";
            NOMBRE.Name = "NOMBRE";
            // 
            // TELEFONO
            // 
            TELEFONO.DataPropertyName = "TELEFONO";
            TELEFONO.HeaderText = "Telefono";
            TELEFONO.Name = "TELEFONO";
            // 
            // DIRECCION
            // 
            DIRECCION.DataPropertyName = "DIRECCION";
            DIRECCION.HeaderText = "Direccion";
            DIRECCION.Name = "DIRECCION";
            // 
            // btnBuscar
            // 
            btnBuscar.Image = Properties.Resources.Search_48x48;
            btnBuscar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            btnBuscar.Location = new System.Drawing.Point(78, 376);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new System.Drawing.Size(75, 60);
            btnBuscar.TabIndex = 1;
            btnBuscar.Text = "&Buscar";
            btnBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.Image = Properties.Resources.save_48;
            btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            btnGuardar.Location = new System.Drawing.Point(273, 376);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new System.Drawing.Size(75, 60);
            btnGuardar.TabIndex = 2;
            btnGuardar.Text = "&Guardar";
            btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Image = (System.Drawing.Image)resources.GetObject("btnEliminar.Image");
            btnEliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            btnEliminar.Location = new System.Drawing.Point(380, 376);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new System.Drawing.Size(75, 60);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "&Eliminar";
            btnEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            btnSalir.Image = (System.Drawing.Image)resources.GetObject("btnSalir.Image");
            btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            btnSalir.Location = new System.Drawing.Point(487, 376);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new System.Drawing.Size(75, 60);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "&Salir";
            btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            btnNuevo.Image = (System.Drawing.Image)resources.GetObject("btnNuevo.Image");
            btnNuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            btnNuevo.Location = new System.Drawing.Point(173, 376);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new System.Drawing.Size(75, 60);
            btnNuevo.TabIndex = 5;
            btnNuevo.Text = "&Nuevo";
            btnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnNuevo.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(78, 25);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(58, 15);
            label1.TabIndex = 6;
            label1.Text = "ID Cliente";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(198, 25);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(51, 15);
            label2.TabIndex = 7;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(310, 25);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(52, 15);
            label3.TabIndex = 8;
            label3.Text = "Telefono";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(429, 25);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(57, 15);
            label4.TabIndex = 9;
            label4.Text = "Direccion";
            // 
            // txtCliente
            // 
            txtCliente.Enabled = false;
            txtCliente.Location = new System.Drawing.Point(78, 62);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new System.Drawing.Size(100, 23);
            txtCliente.TabIndex = 10;
            // 
            // txtNombre
            // 
            txtNombre.Enabled = false;
            txtNombre.Location = new System.Drawing.Point(198, 62);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new System.Drawing.Size(100, 23);
            txtNombre.TabIndex = 11;
            // 
            // txtTelefono
            // 
            txtTelefono.Enabled = false;
            txtTelefono.Location = new System.Drawing.Point(310, 62);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new System.Drawing.Size(100, 23);
            txtTelefono.TabIndex = 12;
            // 
            // txtDireccion
            // 
            txtDireccion.Enabled = false;
            txtDireccion.Location = new System.Drawing.Point(429, 62);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new System.Drawing.Size(100, 23);
            txtDireccion.TabIndex = 13;
            // 
            // Frm_MenuClientes
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(667, 481);
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
            Name = "Frm_MenuClientes";
            Text = "Frm_MenuClientes";
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
    }
}