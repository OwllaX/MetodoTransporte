namespace MetodoTransporte
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.bodegasClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.simulaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bodegasClientesToolStripMenuItem,
            this.simulaciónToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // bodegasClientesToolStripMenuItem
            // 
            this.bodegasClientesToolStripMenuItem.Name = "bodegasClientesToolStripMenuItem";
            this.bodegasClientesToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
            this.bodegasClientesToolStripMenuItem.Text = "Bodegas/Clientes";
            this.bodegasClientesToolStripMenuItem.Click += new System.EventHandler(this.bodegasClientesToolStripMenuItem_Click);
            // 
            // simulaciónToolStripMenuItem
            // 
            this.simulaciónToolStripMenuItem.Name = "simulaciónToolStripMenuItem";
            this.simulaciónToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.simulaciónToolStripMenuItem.Text = "Simulación";
            this.simulaciónToolStripMenuItem.Click += new System.EventHandler(this.simulaciónToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "UTN Método de Transporte";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem bodegasClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem simulaciónToolStripMenuItem;
    }
}

