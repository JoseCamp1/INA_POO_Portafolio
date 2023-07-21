namespace Capa_Presentacion_01
{
    partial class Frm_BuscarProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_BuscarProductos));
            btnBuscarCliente = new System.Windows.Forms.Button();
            btnCancelar = new System.Windows.Forms.Button();
            btnAceptar = new System.Windows.Forms.Button();
            txtBuscarNombre = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            grdProductos = new System.Windows.Forms.DataGridView();
            ID_PRODUCTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            DESCRIPCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            PRECIO_COMPRA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            PRECIO_VENTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            GRAVADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)grdProductos).BeginInit();
            SuspendLayout();
            // 
            // btnBuscarCliente
            // 
            btnBuscarCliente.Image = (System.Drawing.Image)resources.GetObject("btnBuscarCliente.Image");
            btnBuscarCliente.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            btnBuscarCliente.Location = new System.Drawing.Point(321, 12);
            btnBuscarCliente.Name = "btnBuscarCliente";
            btnBuscarCliente.Size = new System.Drawing.Size(75, 70);
            btnBuscarCliente.TabIndex = 22;
            btnBuscarCliente.Text = "&Buscar";
            btnBuscarCliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnBuscarCliente.UseVisualStyleBackColor = true;
            btnBuscarCliente.Click += btnBuscarCliente_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Image = Properties.Resources._1487086345_cross_81577;
            btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            btnCancelar.Location = new System.Drawing.Point(503, 12);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new System.Drawing.Size(75, 70);
            btnCancelar.TabIndex = 21;
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
            btnAceptar.Location = new System.Drawing.Point(413, 12);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new System.Drawing.Size(75, 70);
            btnAceptar.TabIndex = 20;
            btnAceptar.Text = "&Aceptar";
            btnAceptar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // txtBuscarNombre
            // 
            txtBuscarNombre.Location = new System.Drawing.Point(21, 32);
            txtBuscarNombre.Name = "txtBuscarNombre";
            txtBuscarNombre.Size = new System.Drawing.Size(160, 23);
            txtBuscarNombre.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(44, -15);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(82, 15);
            label2.TabIndex = 18;
            label2.Text = "Buscar Cliente";
            // 
            // grdProductos
            // 
            grdProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { ID_PRODUCTO, DESCRIPCION, PRECIO_COMPRA, PRECIO_VENTA, GRAVADO });
            grdProductos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            grdProductos.Location = new System.Drawing.Point(21, 88);
            grdProductos.Name = "grdProductos";
            grdProductos.RowTemplate.Height = 25;
            grdProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            grdProductos.Size = new System.Drawing.Size(557, 264);
            grdProductos.TabIndex = 23;
            grdProductos.DoubleClick += grdProductos_DoubleClick;
            // 
            // ID_PRODUCTO
            // 
            ID_PRODUCTO.DataPropertyName = "Id_Producto";
            ID_PRODUCTO.HeaderText = "Producto";
            ID_PRODUCTO.Name = "ID_PRODUCTO";
            // 
            // DESCRIPCION
            // 
            DESCRIPCION.DataPropertyName = "Descripcion";
            DESCRIPCION.HeaderText = "Descripcion";
            DESCRIPCION.Name = "DESCRIPCION";
            // 
            // PRECIO_COMPRA
            // 
            PRECIO_COMPRA.DataPropertyName = "Precio_Compra";
            PRECIO_COMPRA.HeaderText = "Precio Compra";
            PRECIO_COMPRA.Name = "PRECIO_COMPRA";
            // 
            // PRECIO_VENTA
            // 
            PRECIO_VENTA.DataPropertyName = "Precio_Venta";
            PRECIO_VENTA.HeaderText = "Precio Venta";
            PRECIO_VENTA.Name = "PRECIO_VENTA";
            // 
            // GRAVADO
            // 
            GRAVADO.DataPropertyName = "Gravado";
            GRAVADO.HeaderText = "Gravado";
            GRAVADO.Name = "GRAVADO";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(21, 14);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(110, 15);
            label1.TabIndex = 24;
            label1.Text = "Buscar por Nombre";
            // 
            // Frm_BuscarProductos
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._212a40d0af2ac7285fa9b8416da447951;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(597, 371);
            Controls.Add(label1);
            Controls.Add(grdProductos);
            Controls.Add(btnBuscarCliente);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(txtBuscarNombre);
            Controls.Add(label2);
            DoubleBuffered = true;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "Frm_BuscarProductos";
            Text = "Frm_BuscarProductos";
            Load += Frm_BuscarProductos_Load;
            ((System.ComponentModel.ISupportInitialize)grdProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox txtBuscarNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView grdProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_PRODUCTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPCION;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRECIO_COMPRA;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRECIO_VENTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn GRAVADO;
        private System.Windows.Forms.Label label1;
    }
}