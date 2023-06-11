namespace Capa_Presentacion_01
{
    partial class Frm_MenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_MenuPrincipal));
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            facturasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { clientesToolStripMenuItem, productosToolStripMenuItem, facturasToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(890, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // clientesToolStripMenuItem
            // 
            clientesToolStripMenuItem.Image = Properties.Resources.users_people_workers_customers_icon_124243;
            clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            clientesToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            clientesToolStripMenuItem.Text = "Clientes";
            clientesToolStripMenuItem.Click += clientesToolStripMenuItem_Click;
            // 
            // productosToolStripMenuItem
            // 
            productosToolStripMenuItem.Image = Properties.Resources.products_new_cube_product_design_icon_153845;
            productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            productosToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            productosToolStripMenuItem.Text = "Productos";
            productosToolStripMenuItem.Click += productosToolStripMenuItem_Click;
            // 
            // facturasToolStripMenuItem
            // 
            facturasToolStripMenuItem.Image = Properties.Resources.dollar_dollars_money_bills_icon_178114;
            facturasToolStripMenuItem.Name = "facturasToolStripMenuItem";
            facturasToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            facturasToolStripMenuItem.Text = "Facturas";
            facturasToolStripMenuItem.Click += facturasToolStripMenuItem_Click;
            // 
            // Frm_MenuPrincipal
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._093da596df704fbb86507e0f2ad358fa;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(890, 572);
            Controls.Add(menuStrip1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Frm_MenuPrincipal";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Frm_MenuPrincipal";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturasToolStripMenuItem;
    }
}