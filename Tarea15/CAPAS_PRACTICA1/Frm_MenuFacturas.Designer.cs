namespace Capa_Presentacion_01
{
    partial class Frm_MenuFacturas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_MenuFacturas));
            dataGridView1 = new System.Windows.Forms.DataGridView();
            ID_FACTURA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            FECHA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ID_CLIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            SUBTOTAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            IMPUESTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            MONTODESCUENTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            btnNuevo = new System.Windows.Forms.Button();
            btnSalir = new System.Windows.Forms.Button();
            btnEliminar = new System.Windows.Forms.Button();
            btnGuardar = new System.Windows.Forms.Button();
            btnBuscar = new System.Windows.Forms.Button();
            txtSubtotal = new System.Windows.Forms.TextBox();
            txtCliente = new System.Windows.Forms.TextBox();
            txtFecha = new System.Windows.Forms.TextBox();
            txtFactura = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            txtMontoDescuento = new System.Windows.Forms.TextBox();
            txtImpuesto = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            dataGridView2 = new System.Windows.Forms.DataGridView();
            ID_FACTURA2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ID_PRODUCTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            CANTIDAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            btnNuevo2 = new System.Windows.Forms.Button();
            btnEliminar2 = new System.Windows.Forms.Button();
            btnGuardar2 = new System.Windows.Forms.Button();
            btnBuscar2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { ID_FACTURA, FECHA, ID_CLIENTE, SUBTOTAL, IMPUESTO, MONTODESCUENTO });
            dataGridView1.Location = new System.Drawing.Point(77, 131);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new System.Drawing.Size(713, 197);
            dataGridView1.TabIndex = 0;
            // 
            // ID_FACTURA
            // 
            ID_FACTURA.DataPropertyName = "ID_FACTURA";
            ID_FACTURA.HeaderText = "Factura";
            ID_FACTURA.Name = "ID_FACTURA";
            // 
            // FECHA
            // 
            FECHA.DataPropertyName = "FECHA";
            FECHA.HeaderText = "Fecha";
            FECHA.Name = "FECHA";
            // 
            // ID_CLIENTE
            // 
            ID_CLIENTE.DataPropertyName = "ID_CLIENTE";
            ID_CLIENTE.HeaderText = "Cliente";
            ID_CLIENTE.Name = "ID_CLIENTE";
            // 
            // SUBTOTAL
            // 
            SUBTOTAL.DataPropertyName = "SUBTOTAL";
            SUBTOTAL.HeaderText = "Subtotal";
            SUBTOTAL.Name = "SUBTOTAL";
            // 
            // IMPUESTO
            // 
            IMPUESTO.DataPropertyName = "IMPUESTO";
            IMPUESTO.HeaderText = "Impuesto";
            IMPUESTO.Name = "IMPUESTO";
            // 
            // MONTODESCUENTO
            // 
            MONTODESCUENTO.DataPropertyName = "MONTODESCUENTO";
            MONTODESCUENTO.HeaderText = "Monto del Descuento";
            MONTODESCUENTO.Name = "MONTODESCUENTO";
            // 
            // btnNuevo
            // 
            btnNuevo.Image = (System.Drawing.Image)resources.GetObject("btnNuevo.Image");
            btnNuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            btnNuevo.Location = new System.Drawing.Point(250, 334);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new System.Drawing.Size(75, 60);
            btnNuevo.TabIndex = 10;
            btnNuevo.Text = "&Nuevo";
            btnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            btnSalir.Image = (System.Drawing.Image)resources.GetObject("btnSalir.Image");
            btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            btnSalir.Location = new System.Drawing.Point(783, 606);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new System.Drawing.Size(75, 60);
            btnSalir.TabIndex = 9;
            btnSalir.Text = "&Salir";
            btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Image = (System.Drawing.Image)resources.GetObject("btnEliminar.Image");
            btnEliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            btnEliminar.Location = new System.Drawing.Point(457, 334);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new System.Drawing.Size(75, 60);
            btnEliminar.TabIndex = 8;
            btnEliminar.Text = "&Eliminar";
            btnEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.Image = Properties.Resources.save_48;
            btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            btnGuardar.Location = new System.Drawing.Point(350, 334);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new System.Drawing.Size(75, 60);
            btnGuardar.TabIndex = 7;
            btnGuardar.Text = "&Guardar";
            btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            btnBuscar.Image = Properties.Resources.Search_48x48;
            btnBuscar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            btnBuscar.Location = new System.Drawing.Point(155, 334);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new System.Drawing.Size(75, 60);
            btnBuscar.TabIndex = 6;
            btnBuscar.Text = "&Buscar";
            btnBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // txtSubtotal
            // 
            txtSubtotal.Enabled = false;
            txtSubtotal.Location = new System.Drawing.Point(430, 68);
            txtSubtotal.Name = "txtSubtotal";
            txtSubtotal.Size = new System.Drawing.Size(100, 23);
            txtSubtotal.TabIndex = 21;
            // 
            // txtCliente
            // 
            txtCliente.Enabled = false;
            txtCliente.Location = new System.Drawing.Point(311, 68);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new System.Drawing.Size(100, 23);
            txtCliente.TabIndex = 20;
            // 
            // txtFecha
            // 
            txtFecha.Enabled = false;
            txtFecha.Location = new System.Drawing.Point(199, 68);
            txtFecha.Name = "txtFecha";
            txtFecha.Size = new System.Drawing.Size(100, 23);
            txtFecha.TabIndex = 19;
            // 
            // txtFactura
            // 
            txtFactura.Enabled = false;
            txtFactura.Location = new System.Drawing.Point(79, 68);
            txtFactura.Name = "txtFactura";
            txtFactura.Size = new System.Drawing.Size(100, 23);
            txtFactura.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(430, 31);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(51, 15);
            label4.TabIndex = 17;
            label4.Text = "Subtotal";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(311, 31);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(44, 15);
            label3.TabIndex = 16;
            label3.Text = "Cliente";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(199, 31);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(38, 15);
            label2.TabIndex = 15;
            label2.Text = "Fecha";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(79, 31);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(46, 15);
            label1.TabIndex = 14;
            label1.Text = "Factura";
            // 
            // txtMontoDescuento
            // 
            txtMontoDescuento.Enabled = false;
            txtMontoDescuento.Location = new System.Drawing.Point(677, 68);
            txtMontoDescuento.Name = "txtMontoDescuento";
            txtMontoDescuento.Size = new System.Drawing.Size(100, 23);
            txtMontoDescuento.TabIndex = 25;
            // 
            // txtImpuesto
            // 
            txtImpuesto.Enabled = false;
            txtImpuesto.Location = new System.Drawing.Point(558, 68);
            txtImpuesto.Name = "txtImpuesto";
            txtImpuesto.Size = new System.Drawing.Size(100, 23);
            txtImpuesto.TabIndex = 24;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(677, 31);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(121, 15);
            label5.TabIndex = 23;
            label5.Text = "Monto del Descuento";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(558, 31);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(57, 15);
            label6.TabIndex = 22;
            label6.Text = "Impuesto";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { ID_FACTURA2, ID_PRODUCTO, CANTIDAD });
            dataGridView2.Location = new System.Drawing.Point(181, 400);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new System.Drawing.Size(349, 172);
            dataGridView2.TabIndex = 26;
            // 
            // ID_FACTURA2
            // 
            ID_FACTURA2.DataPropertyName = "ID_FACTURA2";
            ID_FACTURA2.HeaderText = "Factura";
            ID_FACTURA2.Name = "ID_FACTURA2";
            // 
            // ID_PRODUCTO
            // 
            ID_PRODUCTO.DataPropertyName = "ID_PRODUCTO";
            ID_PRODUCTO.HeaderText = "Producto";
            ID_PRODUCTO.Name = "ID_PRODUCTO";
            // 
            // CANTIDAD
            // 
            CANTIDAD.DataPropertyName = "CANTIDAD";
            CANTIDAD.HeaderText = "Cantidad";
            CANTIDAD.Name = "CANTIDAD";
            // 
            // btnNuevo2
            // 
            btnNuevo2.Image = (System.Drawing.Image)resources.GetObject("btnNuevo2.Image");
            btnNuevo2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            btnNuevo2.Location = new System.Drawing.Point(250, 578);
            btnNuevo2.Name = "btnNuevo2";
            btnNuevo2.Size = new System.Drawing.Size(75, 60);
            btnNuevo2.TabIndex = 30;
            btnNuevo2.Text = "&Nuevo";
            btnNuevo2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnNuevo2.UseVisualStyleBackColor = true;
            // 
            // btnEliminar2
            // 
            btnEliminar2.Image = (System.Drawing.Image)resources.GetObject("btnEliminar2.Image");
            btnEliminar2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            btnEliminar2.Location = new System.Drawing.Point(457, 578);
            btnEliminar2.Name = "btnEliminar2";
            btnEliminar2.Size = new System.Drawing.Size(75, 60);
            btnEliminar2.TabIndex = 29;
            btnEliminar2.Text = "&Eliminar";
            btnEliminar2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnEliminar2.UseVisualStyleBackColor = true;
            // 
            // btnGuardar2
            // 
            btnGuardar2.Image = Properties.Resources.save_48;
            btnGuardar2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            btnGuardar2.Location = new System.Drawing.Point(350, 578);
            btnGuardar2.Name = "btnGuardar2";
            btnGuardar2.Size = new System.Drawing.Size(75, 60);
            btnGuardar2.TabIndex = 28;
            btnGuardar2.Text = "&Guardar";
            btnGuardar2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnGuardar2.UseVisualStyleBackColor = true;
            // 
            // btnBuscar2
            // 
            btnBuscar2.Image = Properties.Resources.Search_48x48;
            btnBuscar2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            btnBuscar2.Location = new System.Drawing.Point(155, 578);
            btnBuscar2.Name = "btnBuscar2";
            btnBuscar2.Size = new System.Drawing.Size(75, 60);
            btnBuscar2.TabIndex = 27;
            btnBuscar2.Text = "&Buscar";
            btnBuscar2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnBuscar2.UseVisualStyleBackColor = true;
            // 
            // Frm_MenuFacturas
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(870, 678);
            Controls.Add(btnNuevo2);
            Controls.Add(btnEliminar2);
            Controls.Add(btnGuardar2);
            Controls.Add(btnBuscar2);
            Controls.Add(dataGridView2);
            Controls.Add(txtMontoDescuento);
            Controls.Add(txtImpuesto);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(txtSubtotal);
            Controls.Add(txtCliente);
            Controls.Add(txtFecha);
            Controls.Add(txtFactura);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnNuevo);
            Controls.Add(btnSalir);
            Controls.Add(btnEliminar);
            Controls.Add(btnGuardar);
            Controls.Add(btnBuscar);
            Controls.Add(dataGridView1);
            Name = "Frm_MenuFacturas";
            Text = "Frm_MenuFacturacion";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_FACTURA;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_CLIENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn SUBTOTAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn IMPUESTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn MONTODESCUENTO;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.TextBox txtFactura;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMontoDescuento;
        private System.Windows.Forms.TextBox txtImpuesto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_FACTURA2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_PRODUCTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CANTIDAD;
        private System.Windows.Forms.Button btnNuevo2;
        private System.Windows.Forms.Button btnEliminar2;
        private System.Windows.Forms.Button btnGuardar2;
        private System.Windows.Forms.Button btnBuscar2;
    }
}