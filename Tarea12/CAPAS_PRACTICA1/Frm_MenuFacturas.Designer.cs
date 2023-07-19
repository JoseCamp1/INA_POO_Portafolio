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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID_FACTURA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_CLIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SUBTOTAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IMPUESTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MONTODESCUENTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.txtFactura = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMontoDescuento = new System.Windows.Forms.TextBox();
            this.txtImpuesto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.ID_FACTURA2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_PRODUCTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CANTIDAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnNuevo2 = new System.Windows.Forms.Button();
            this.btnEliminar2 = new System.Windows.Forms.Button();
            this.btnGuardar2 = new System.Windows.Forms.Button();
            this.btnBuscar2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_FACTURA,
            this.FECHA,
            this.ID_CLIENTE,
            this.SUBTOTAL,
            this.IMPUESTO,
            this.MONTODESCUENTO});
            this.dataGridView1.Location = new System.Drawing.Point(77, 131);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(713, 197);
            this.dataGridView1.TabIndex = 0;
            // 
            // ID_FACTURA
            // 
            this.ID_FACTURA.DataPropertyName = "ID_FACTURA";
            this.ID_FACTURA.HeaderText = "Factura";
            this.ID_FACTURA.Name = "ID_FACTURA";
            // 
            // FECHA
            // 
            this.FECHA.DataPropertyName = "FECHA";
            this.FECHA.HeaderText = "Fecha";
            this.FECHA.Name = "FECHA";
            // 
            // ID_CLIENTE
            // 
            this.ID_CLIENTE.DataPropertyName = "ID_CLIENTE";
            this.ID_CLIENTE.HeaderText = "Cliente";
            this.ID_CLIENTE.Name = "ID_CLIENTE";
            // 
            // SUBTOTAL
            // 
            this.SUBTOTAL.DataPropertyName = "SUBTOTAL";
            this.SUBTOTAL.HeaderText = "Subtotal";
            this.SUBTOTAL.Name = "SUBTOTAL";
            // 
            // IMPUESTO
            // 
            this.IMPUESTO.DataPropertyName = "IMPUESTO";
            this.IMPUESTO.HeaderText = "Impuesto";
            this.IMPUESTO.Name = "IMPUESTO";
            // 
            // MONTODESCUENTO
            // 
            this.MONTODESCUENTO.DataPropertyName = "MONTODESCUENTO";
            this.MONTODESCUENTO.HeaderText = "Monto del Descuento";
            this.MONTODESCUENTO.Name = "MONTODESCUENTO";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNuevo.Location = new System.Drawing.Point(250, 334);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 60);
            this.btnNuevo.TabIndex = 10;
            this.btnNuevo.Text = "&Nuevo";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalir.Location = new System.Drawing.Point(783, 606);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 60);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEliminar.Location = new System.Drawing.Point(457, 334);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 60);
            this.btnEliminar.TabIndex = 8;
            this.btnEliminar.Text = "&Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = global::Capa_Presentacion_01.Properties.Resources.save_48;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGuardar.Location = new System.Drawing.Point(350, 334);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 60);
            this.btnGuardar.TabIndex = 7;
            this.btnGuardar.Text = "&Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = global::Capa_Presentacion_01.Properties.Resources.Search_48x48;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBuscar.Location = new System.Drawing.Point(155, 334);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 60);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "&Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Enabled = false;
            this.txtSubtotal.Location = new System.Drawing.Point(430, 68);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(100, 23);
            this.txtSubtotal.TabIndex = 21;
            // 
            // txtCliente
            // 
            this.txtCliente.Enabled = false;
            this.txtCliente.Location = new System.Drawing.Point(311, 68);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(100, 23);
            this.txtCliente.TabIndex = 20;
            // 
            // txtFecha
            // 
            this.txtFecha.Enabled = false;
            this.txtFecha.Location = new System.Drawing.Point(199, 68);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(100, 23);
            this.txtFecha.TabIndex = 19;
            // 
            // txtFactura
            // 
            this.txtFactura.Enabled = false;
            this.txtFactura.Location = new System.Drawing.Point(79, 68);
            this.txtFactura.Name = "txtFactura";
            this.txtFactura.Size = new System.Drawing.Size(100, 23);
            this.txtFactura.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(430, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 15);
            this.label4.TabIndex = 17;
            this.label4.Text = "Subtotal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(311, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(199, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 15;
            this.label2.Text = "Fecha";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "Factura";
            // 
            // txtMontoDescuento
            // 
            this.txtMontoDescuento.Enabled = false;
            this.txtMontoDescuento.Location = new System.Drawing.Point(677, 68);
            this.txtMontoDescuento.Name = "txtMontoDescuento";
            this.txtMontoDescuento.Size = new System.Drawing.Size(100, 23);
            this.txtMontoDescuento.TabIndex = 25;
            // 
            // txtImpuesto
            // 
            this.txtImpuesto.Enabled = false;
            this.txtImpuesto.Location = new System.Drawing.Point(558, 68);
            this.txtImpuesto.Name = "txtImpuesto";
            this.txtImpuesto.Size = new System.Drawing.Size(100, 23);
            this.txtImpuesto.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(677, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 15);
            this.label5.TabIndex = 23;
            this.label5.Text = "Monto del Descuento";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(558, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 15);
            this.label6.TabIndex = 22;
            this.label6.Text = "Impuesto";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_FACTURA2,
            this.ID_PRODUCTO,
            this.CANTIDAD});
            this.dataGridView2.Location = new System.Drawing.Point(181, 400);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.Size = new System.Drawing.Size(349, 172);
            this.dataGridView2.TabIndex = 26;
            // 
            // ID_FACTURA2
            // 
            this.ID_FACTURA2.DataPropertyName = "ID_FACTURA2";
            this.ID_FACTURA2.HeaderText = "Factura";
            this.ID_FACTURA2.Name = "ID_FACTURA2";
            // 
            // ID_PRODUCTO
            // 
            this.ID_PRODUCTO.DataPropertyName = "ID_PRODUCTO";
            this.ID_PRODUCTO.HeaderText = "Producto";
            this.ID_PRODUCTO.Name = "ID_PRODUCTO";
            // 
            // CANTIDAD
            // 
            this.CANTIDAD.DataPropertyName = "CANTIDAD";
            this.CANTIDAD.HeaderText = "Cantidad";
            this.CANTIDAD.Name = "CANTIDAD";
            // 
            // btnNuevo2
            // 
            this.btnNuevo2.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo2.Image")));
            this.btnNuevo2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNuevo2.Location = new System.Drawing.Point(250, 578);
            this.btnNuevo2.Name = "btnNuevo2";
            this.btnNuevo2.Size = new System.Drawing.Size(75, 60);
            this.btnNuevo2.TabIndex = 30;
            this.btnNuevo2.Text = "&Nuevo";
            this.btnNuevo2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNuevo2.UseVisualStyleBackColor = true;
            // 
            // btnEliminar2
            // 
            this.btnEliminar2.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar2.Image")));
            this.btnEliminar2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEliminar2.Location = new System.Drawing.Point(457, 578);
            this.btnEliminar2.Name = "btnEliminar2";
            this.btnEliminar2.Size = new System.Drawing.Size(75, 60);
            this.btnEliminar2.TabIndex = 29;
            this.btnEliminar2.Text = "&Eliminar";
            this.btnEliminar2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEliminar2.UseVisualStyleBackColor = true;
            // 
            // btnGuardar2
            // 
            this.btnGuardar2.Image = global::Capa_Presentacion_01.Properties.Resources.save_48;
            this.btnGuardar2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGuardar2.Location = new System.Drawing.Point(350, 578);
            this.btnGuardar2.Name = "btnGuardar2";
            this.btnGuardar2.Size = new System.Drawing.Size(75, 60);
            this.btnGuardar2.TabIndex = 28;
            this.btnGuardar2.Text = "&Guardar";
            this.btnGuardar2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGuardar2.UseVisualStyleBackColor = true;
            // 
            // btnBuscar2
            // 
            this.btnBuscar2.Image = global::Capa_Presentacion_01.Properties.Resources.Search_48x48;
            this.btnBuscar2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBuscar2.Location = new System.Drawing.Point(155, 578);
            this.btnBuscar2.Name = "btnBuscar2";
            this.btnBuscar2.Size = new System.Drawing.Size(75, 60);
            this.btnBuscar2.TabIndex = 27;
            this.btnBuscar2.Text = "&Buscar";
            this.btnBuscar2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBuscar2.UseVisualStyleBackColor = true;
            // 
            // Frm_MenuFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Capa_Presentacion_01.Properties.Resources._212a40d0af2ac7285fa9b8416da44795;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(873, 678);
            this.Controls.Add(this.btnNuevo2);
            this.Controls.Add(this.btnEliminar2);
            this.Controls.Add(this.btnGuardar2);
            this.Controls.Add(this.btnBuscar2);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.txtMontoDescuento);
            this.Controls.Add(this.txtImpuesto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSubtotal);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.txtFactura);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dataGridView1);
            this.DoubleBuffered = true;
            this.Name = "Frm_MenuFacturas";
            this.Text = "Frm_MenuFacturacion";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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