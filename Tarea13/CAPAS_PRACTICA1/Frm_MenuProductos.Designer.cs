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
            btnNuevo = new System.Windows.Forms.Button();
            btnEliminar = new System.Windows.Forms.Button();
            btnGuardar = new System.Windows.Forms.Button();
            btnBuscar = new System.Windows.Forms.Button();
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
            // btnNuevo
            // 
            btnNuevo.Image = (System.Drawing.Image)resources.GetObject("btnNuevo.Image");
            btnNuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            btnNuevo.Location = new System.Drawing.Point(142, 336);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new System.Drawing.Size(75, 60);
            btnNuevo.TabIndex = 36;
            btnNuevo.Text = "&Nuevo";
            btnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Image = (System.Drawing.Image)resources.GetObject("btnEliminar.Image");
            btnEliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            btnEliminar.Location = new System.Drawing.Point(364, 336);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new System.Drawing.Size(75, 60);
            btnEliminar.TabIndex = 35;
            btnEliminar.Text = "&Eliminar";
            btnEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.Image = Properties.Resources.save_48;
            btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            btnGuardar.Location = new System.Drawing.Point(245, 336);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new System.Drawing.Size(75, 60);
            btnGuardar.TabIndex = 34;
            btnGuardar.Text = "&Guardar";
            btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click_1;
            // 
            // btnBuscar
            // 
            btnBuscar.Image = Properties.Resources.Search_48x48;
            btnBuscar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            btnBuscar.Location = new System.Drawing.Point(13, 336);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new System.Drawing.Size(75, 60);
            btnBuscar.TabIndex = 33;
            btnBuscar.Text = "&Buscar";
            btnBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnBuscar.UseVisualStyleBackColor = true;
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
            btnSalir.Click += btnSalir_Click;
            // 
            // txtPrecioVenta
            // 
            txtPrecioVenta.Location = new System.Drawing.Point(364, 57);
            txtPrecioVenta.Name = "txtPrecioVenta";
            txtPrecioVenta.Size = new System.Drawing.Size(100, 23);
            txtPrecioVenta.TabIndex = 44;
            // 
            // txtPrecioCompra
            // 
            txtPrecioCompra.Location = new System.Drawing.Point(245, 57);
            txtPrecioCompra.Name = "txtPrecioCompra";
            txtPrecioCompra.Size = new System.Drawing.Size(100, 23);
            txtPrecioCompra.TabIndex = 43;
            // 
            // txtDescripcion
            // 
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
            Controls.Add(btnNuevo);
            Controls.Add(btnEliminar);
            Controls.Add(btnGuardar);
            Controls.Add(btnBuscar);
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
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnBuscar;
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