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
            dataGridView1 = new System.Windows.Forms.DataGridView();
            ID_PRODUCTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            DESCRIPCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            PRECIO_COMPRA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            PRECIO_VENTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            GRAVADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { ID_PRODUCTO, DESCRIPCION, PRECIO_COMPRA, PRECIO_VENTA, GRAVADO });
            dataGridView1.Location = new System.Drawing.Point(112, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new System.Drawing.Size(557, 150);
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
            // Frm_MenuProductos
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 314);
            Controls.Add(dataGridView1);
            Name = "Frm_MenuProductos";
            Text = "Frm_MenuProductos";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_PRODUCTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPCION;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRECIO_COMPRA;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRECIO_VENTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn GRAVADO;
    }
}