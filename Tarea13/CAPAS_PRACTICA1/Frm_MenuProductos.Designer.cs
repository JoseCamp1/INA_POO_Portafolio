namespace Capa_Presentacion_01
{
    partial class Frm_MenuProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_MenuProductos));
            dataGridView1 = new System.Windows.Forms.DataGridView();
            ID_PRODUCTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            DESCRIPCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            PRECIO_COMPRA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            PRECIO_VENTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            GRAVADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            btnNuevo2 = new System.Windows.Forms.Button();
            btnEliminar2 = new System.Windows.Forms.Button();
            btnGuardar2 = new System.Windows.Forms.Button();
            btnBuscar2 = new System.Windows.Forms.Button();
            btnSalir = new System.Windows.Forms.Button();
            txtPrecioVenta = new System.Windows.Forms.TextBox();
            txtPrecioCompra = new System.Windows.Forms.TextBox();
            txtDescripcion = new System.Windows.Forms.TextBox();
            txtProducto = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            txtGravado = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { ID_PRODUCTO, DESCRIPCION, PRECIO_COMPRA, PRECIO_VENTA, GRAVADO });
            dataGridView1.Location = new System.Drawing.Point(14, 86);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new System.Drawing.Size(557, 244);
            dataGridView1.TabIndex = 0;
            // 
            // ID_PRODUCTO
            // 
            ID_PRODUCTO.DataPropertyName = "ID_PRODUCTO";
            ID_PRODUCTO.HeaderText = "Producto";
            ID_PRODUCTO.Name = "ID_PRODUCTO";
            // 
            // DESCRIPCION
            // 
            DESCRIPCION.DataPropertyName = "DESCRIPCION";
            DESCRIPCION.HeaderText = "Descripcion";
            DESCRIPCION.Name = "DESCRIPCION";
            // 
            // PRECIO_COMPRA
            // 
            PRECIO_COMPRA.DataPropertyName = "PRECIO_COMPRA";
            PRECIO_COMPRA.HeaderText = "Precio Compra";
            PRECIO_COMPRA.Name = "PRECIO_COMPRA";
            // 
            // PRECIO_VENTA
            // 
            PRECIO_VENTA.DataPropertyName = "PRECIO_VENTA";
            PRECIO_VENTA.HeaderText = "Precio Venta";
            PRECIO_VENTA.Name = "PRECIO_VENTA";
            // 
            // GRAVADO
            // 
            GRAVADO.DataPropertyName = "GRAVADO";
            GRAVADO.HeaderText = "Gravado";
            GRAVADO.Name = "GRAVADO";
            // 
            // btnNuevo2
            // 
            btnNuevo2.Image = (System.Drawing.Image)resources.GetObject("btnNuevo2.Image");
            btnNuevo2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            btnNuevo2.Location = new System.Drawing.Point(142, 336);
            btnNuevo2.Name = "btnNuevo2";
            btnNuevo2.Size = new System.Drawing.Size(75, 60);
            btnNuevo2.TabIndex = 36;
            btnNuevo2.Text = "&Nuevo";
            btnNuevo2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnNuevo2.UseVisualStyleBackColor = true;
            // 
            // btnEliminar2
            // 
            btnEliminar2.Image = (System.Drawing.Image)resources.GetObject("btnEliminar2.Image");
            btnEliminar2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            btnEliminar2.Location = new System.Drawing.Point(364, 336);
            btnEliminar2.Name = "btnEliminar2";
            btnEliminar2.Size = new System.Drawing.Size(75, 60);
            btnEliminar2.TabIndex = 35;
            btnEliminar2.Text = "&Eliminar";
            btnEliminar2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnEliminar2.UseVisualStyleBackColor = true;
            // 
            // btnGuardar2
            // 
            btnGuardar2.Image = Properties.Resources.save_48;
            btnGuardar2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            btnGuardar2.Location = new System.Drawing.Point(245, 336);
            btnGuardar2.Name = "btnGuardar2";
            btnGuardar2.Size = new System.Drawing.Size(75, 60);
            btnGuardar2.TabIndex = 34;
            btnGuardar2.Text = "&Guardar";
            btnGuardar2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnGuardar2.UseVisualStyleBackColor = true;
            // 
            // btnBuscar2
            // 
            btnBuscar2.Image = Properties.Resources.Search_48x48;
            btnBuscar2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            btnBuscar2.Location = new System.Drawing.Point(13, 336);
            btnBuscar2.Name = "btnBuscar2";
            btnBuscar2.Size = new System.Drawing.Size(75, 60);
            btnBuscar2.TabIndex = 33;
            btnBuscar2.Text = "&Buscar";
            btnBuscar2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnBuscar2.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            btnSalir.Image = (System.Drawing.Image)resources.GetObject("btnSalir.Image");
            btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            btnSalir.Location = new System.Drawing.Point(486, 336);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new System.Drawing.Size(75, 60);
            btnSalir.TabIndex = 32;
            btnSalir.Text = "&Salir";
            btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // txtPrecioVenta
            // 
            txtPrecioVenta.Enabled = false;
            txtPrecioVenta.Location = new System.Drawing.Point(364, 57);
            txtPrecioVenta.Name = "txtPrecioVenta";
            txtPrecioVenta.Size = new System.Drawing.Size(100, 23);
            txtPrecioVenta.TabIndex = 44;
            // 
            // txtPrecioCompra
            // 
            txtPrecioCompra.Enabled = false;
            txtPrecioCompra.Location = new System.Drawing.Point(245, 57);
            txtPrecioCompra.Name = "txtPrecioCompra";
            txtPrecioCompra.Size = new System.Drawing.Size(100, 23);
            txtPrecioCompra.TabIndex = 43;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Enabled = false;
            txtDescripcion.Location = new System.Drawing.Point(133, 57);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new System.Drawing.Size(100, 23);
            txtDescripcion.TabIndex = 42;
            // 
            // txtProducto
            // 
            txtProducto.Enabled = false;
            txtProducto.Location = new System.Drawing.Point(13, 57);
            txtProducto.Name = "txtProducto";
            txtProducto.Size = new System.Drawing.Size(100, 23);
            txtProducto.TabIndex = 41;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(364, 20);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(72, 15);
            label4.TabIndex = 40;
            label4.Text = "Precio Venta";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(245, 20);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(86, 15);
            label3.TabIndex = 39;
            label3.Text = "Precio Compra";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(133, 20);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(69, 15);
            label2.TabIndex = 38;
            label2.Text = "Descripcion";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(13, 20);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(70, 15);
            label1.TabIndex = 37;
            label1.Text = "ID Producto";
            // 
            // txtGravado
            // 
            txtGravado.Enabled = false;
            txtGravado.Location = new System.Drawing.Point(471, 57);
            txtGravado.Name = "txtGravado";
            txtGravado.Size = new System.Drawing.Size(100, 23);
            txtGravado.TabIndex = 46;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(471, 20);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(58, 15);
            label5.TabIndex = 45;
            label5.Text = "Gravando";
            // 
            // Frm_MenuProductos
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(582, 408);
            Controls.Add(txtGravado);
            Controls.Add(label5);
            Controls.Add(txtPrecioVenta);
            Controls.Add(txtPrecioCompra);
            Controls.Add(txtDescripcion);
            Controls.Add(txtProducto);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnNuevo2);
            Controls.Add(btnEliminar2);
            Controls.Add(btnGuardar2);
            Controls.Add(btnBuscar2);
            Controls.Add(btnSalir);
            Controls.Add(dataGridView1);
            Name = "Frm_MenuProductos";
            Text = "Frm_MenuProductos";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_PRODUCTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPCION;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRECIO_COMPRA;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRECIO_VENTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn GRAVADO;
        private System.Windows.Forms.Button btnNuevo2;
        private System.Windows.Forms.Button btnEliminar2;
        private System.Windows.Forms.Button btnGuardar2;
        private System.Windows.Forms.Button btnBuscar2;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txtPrecioVenta;
        private System.Windows.Forms.TextBox txtPrecioCompra;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGravado;
        private System.Windows.Forms.Label label5;
    }
}