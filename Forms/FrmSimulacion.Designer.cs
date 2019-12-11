namespace MetodoTransporte.Forms
{
    partial class FrmSimulacion
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
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnPrueba = new System.Windows.Forms.Button();
            this.TxtSimulacion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtCostoRuta = new System.Windows.Forms.TextBox();
            this.TxtInventario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LInventario = new System.Windows.Forms.Label();
            this.TxtTotal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Red;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCerrar.ForeColor = System.Drawing.SystemColors.Window;
            this.btnCerrar.Location = new System.Drawing.Point(12, 12);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnPrueba
            // 
            this.btnPrueba.Location = new System.Drawing.Point(12, 68);
            this.btnPrueba.Name = "btnPrueba";
            this.btnPrueba.Size = new System.Drawing.Size(75, 23);
            this.btnPrueba.TabIndex = 2;
            this.btnPrueba.Text = "btnPrueba";
            this.btnPrueba.UseVisualStyleBackColor = true;
            this.btnPrueba.Click += new System.EventHandler(this.btnPrueba_Click);
            // 
            // TxtSimulacion
            // 
            this.TxtSimulacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSimulacion.Location = new System.Drawing.Point(221, 105);
            this.TxtSimulacion.Multiline = true;
            this.TxtSimulacion.Name = "TxtSimulacion";
            this.TxtSimulacion.Size = new System.Drawing.Size(865, 419);
            this.TxtSimulacion.TabIndex = 3;
            this.TxtSimulacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(336, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 42);
            this.label1.TabIndex = 4;
            this.label1.Text = "Simulación";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(218, 558);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "El costo de ruta es de:";
            // 
            // TxtCostoRuta
            // 
            this.TxtCostoRuta.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCostoRuta.Location = new System.Drawing.Point(403, 551);
            this.TxtCostoRuta.Name = "TxtCostoRuta";
            this.TxtCostoRuta.Size = new System.Drawing.Size(100, 26);
            this.TxtCostoRuta.TabIndex = 6;
            // 
            // TxtInventario
            // 
            this.TxtInventario.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtInventario.Location = new System.Drawing.Point(403, 596);
            this.TxtInventario.Name = "TxtInventario";
            this.TxtInventario.Size = new System.Drawing.Size(100, 26);
            this.TxtInventario.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(242, 599);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "El inventario es de:";
            // 
            // LInventario
            // 
            this.LInventario.AutoSize = true;
            this.LInventario.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LInventario.Location = new System.Drawing.Point(509, 602);
            this.LInventario.Name = "LInventario";
            this.LInventario.Size = new System.Drawing.Size(176, 16);
            this.LInventario.TabIndex = 9;
            this.LInventario.Text = "... esperando resultados ...";
            // 
            // TxtTotal
            // 
            this.TxtTotal.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTotal.Location = new System.Drawing.Point(403, 641);
            this.TxtTotal.Name = "TxtTotal";
            this.TxtTotal.Size = new System.Drawing.Size(100, 26);
            this.TxtTotal.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(238, 648);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "El costo total es de:";
            // 
            // FrmSimulacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1924, 1041);
            this.ControlBox = false;
            this.Controls.Add(this.TxtTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LInventario);
            this.Controls.Add(this.TxtInventario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtCostoRuta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtSimulacion);
            this.Controls.Add(this.btnPrueba);
            this.Controls.Add(this.btnCerrar);
            this.Name = "FrmSimulacion";
            this.Text = "Simulación";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnPrueba;
        private System.Windows.Forms.TextBox TxtSimulacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtCostoRuta;
        private System.Windows.Forms.TextBox TxtInventario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LInventario;
        private System.Windows.Forms.TextBox TxtTotal;
        private System.Windows.Forms.Label label4;
    }
}