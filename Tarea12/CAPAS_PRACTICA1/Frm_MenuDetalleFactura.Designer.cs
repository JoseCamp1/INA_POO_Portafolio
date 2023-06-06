namespace Capa_Presentacion_01
{
    partial class Frm_MenuDetalleFactura
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
            ID_FACTURA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ID_PRODUCTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            CANTIDAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { ID_FACTURA, ID_PRODUCTO, CANTIDAD });
            dataGridView1.Location = new System.Drawing.Point(54, 44);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new System.Drawing.Size(675, 150);
            dataGridView1.TabIndex = 0;
            // 
            // ID_FACTURA
            // 
            ID_FACTURA.DataPropertyName = "ID_FACTURA";
            ID_FACTURA.HeaderText = "Factura";
            ID_FACTURA.Name = "ID_FACTURA";
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
            // Frm_MenuDetalleFactura
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(dataGridView1);
            Name = "Frm_MenuDetalleFactura";
            Text = "Frm_MenuDetalleFactura";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_FACTURA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_PRODUCTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CANTIDAD;
    }
}