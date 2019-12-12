namespace MetodoTransporte
{
    partial class FrmBodegasClientes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtBodegas = new System.Windows.Forms.TextBox();
            this.BtnBodega = new System.Windows.Forms.Button();
            this.BtnCliente = new System.Windows.Forms.Button();
            this.TxtCliente = new System.Windows.Forms.TextBox();
            this.DgvMetodo = new System.Windows.Forms.DataGridView();
            this.TxtPrecioKm = new System.Windows.Forms.TextBox();
            this.BtnPrecioKm = new System.Windows.Forms.Button();
            this.LPrecioKm = new System.Windows.Forms.Label();
            this.BtnRestaurar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvMetodo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Red;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.SystemColors.Window;
            this.btnCerrar.Location = new System.Drawing.Point(12, 12);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(337, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(359, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bodegas y Clientes";
            // 
            // TxtBodegas
            // 
            this.TxtBodegas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBodegas.Location = new System.Drawing.Point(129, 107);
            this.TxtBodegas.Name = "TxtBodegas";
            this.TxtBodegas.Size = new System.Drawing.Size(100, 29);
            this.TxtBodegas.TabIndex = 2;
            this.TxtBodegas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBodegas_KeyPress);
            // 
            // BtnBodega
            // 
            this.BtnBodega.BackColor = System.Drawing.SystemColors.Desktop;
            this.BtnBodega.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnBodega.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBodega.Location = new System.Drawing.Point(235, 103);
            this.BtnBodega.Name = "BtnBodega";
            this.BtnBodega.Size = new System.Drawing.Size(179, 38);
            this.BtnBodega.TabIndex = 3;
            this.BtnBodega.Text = "Agregar Bodega";
            this.BtnBodega.UseVisualStyleBackColor = false;
            this.BtnBodega.Click += new System.EventHandler(this.BtnBodega_Click);
            // 
            // BtnCliente
            // 
            this.BtnCliente.BackColor = System.Drawing.SystemColors.Desktop;
            this.BtnCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCliente.Location = new System.Drawing.Point(235, 159);
            this.BtnCliente.Name = "BtnCliente";
            this.BtnCliente.Size = new System.Drawing.Size(179, 38);
            this.BtnCliente.TabIndex = 5;
            this.BtnCliente.Text = "Agregar Cliente";
            this.BtnCliente.UseVisualStyleBackColor = false;
            this.BtnCliente.Click += new System.EventHandler(this.BtnCliente_Click);
            // 
            // TxtCliente
            // 
            this.TxtCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCliente.Location = new System.Drawing.Point(129, 163);
            this.TxtCliente.Name = "TxtCliente";
            this.TxtCliente.Size = new System.Drawing.Size(100, 29);
            this.TxtCliente.TabIndex = 4;
            this.TxtCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCliente_KeyPress);
            // 
            // DgvMetodo
            // 
            this.DgvMetodo.AllowUserToAddRows = false;
            this.DgvMetodo.AllowUserToDeleteRows = false;
            this.DgvMetodo.AllowUserToResizeColumns = false;
            this.DgvMetodo.AllowUserToResizeRows = false;
            this.DgvMetodo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvMetodo.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvMetodo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvMetodo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvMetodo.Location = new System.Drawing.Point(129, 241);
            this.DgvMetodo.Name = "DgvMetodo";
            this.DgvMetodo.Size = new System.Drawing.Size(1640, 569);
            this.DgvMetodo.TabIndex = 6;
            this.DgvMetodo.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvMetodo_CellValueChanged);
            // 
            // TxtPrecioKm
            // 
            this.TxtPrecioKm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPrecioKm.Location = new System.Drawing.Point(638, 107);
            this.TxtPrecioKm.Name = "TxtPrecioKm";
            this.TxtPrecioKm.Size = new System.Drawing.Size(100, 29);
            this.TxtPrecioKm.TabIndex = 7;
            this.TxtPrecioKm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPrecioKm_KeyPress);
            // 
            // BtnPrecioKm
            // 
            this.BtnPrecioKm.BackColor = System.Drawing.SystemColors.Desktop;
            this.BtnPrecioKm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnPrecioKm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPrecioKm.Location = new System.Drawing.Point(599, 142);
            this.BtnPrecioKm.Name = "BtnPrecioKm";
            this.BtnPrecioKm.Size = new System.Drawing.Size(179, 38);
            this.BtnPrecioKm.TabIndex = 8;
            this.BtnPrecioKm.Text = "Fijar Precio/KM";
            this.BtnPrecioKm.UseVisualStyleBackColor = false;
            this.BtnPrecioKm.Click += new System.EventHandler(this.BtnPrecioKm_Click);
            // 
            // LPrecioKm
            // 
            this.LPrecioKm.AutoSize = true;
            this.LPrecioKm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LPrecioKm.Location = new System.Drawing.Point(635, 183);
            this.LPrecioKm.Name = "LPrecioKm";
            this.LPrecioKm.Size = new System.Drawing.Size(82, 13);
            this.LPrecioKm.TabIndex = 9;
            this.LPrecioKm.Text = "Precio/KM: 0";
            // 
            // BtnRestaurar
            // 
            this.BtnRestaurar.BackColor = System.Drawing.Color.Yellow;
            this.BtnRestaurar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnRestaurar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRestaurar.Image = global::MetodoTransporte.Properties.Resources.iconfinder_ui_26_5344426;
            this.BtnRestaurar.Location = new System.Drawing.Point(912, 125);
            this.BtnRestaurar.Name = "BtnRestaurar";
            this.BtnRestaurar.Size = new System.Drawing.Size(179, 55);
            this.BtnRestaurar.TabIndex = 10;
            this.BtnRestaurar.Text = "Restaurar";
            this.BtnRestaurar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnRestaurar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnRestaurar.UseVisualStyleBackColor = false;
            this.BtnRestaurar.Click += new System.EventHandler(this.BtnRestaurar_Click);
            // 
            // FrmBodegasClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1924, 1041);
            this.ControlBox = false;
            this.Controls.Add(this.BtnRestaurar);
            this.Controls.Add(this.LPrecioKm);
            this.Controls.Add(this.BtnPrecioKm);
            this.Controls.Add(this.TxtPrecioKm);
            this.Controls.Add(this.DgvMetodo);
            this.Controls.Add(this.BtnCliente);
            this.Controls.Add(this.TxtCliente);
            this.Controls.Add(this.BtnBodega);
            this.Controls.Add(this.TxtBodegas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCerrar);
            this.Name = "FrmBodegasClientes";
            this.Text = "Bodegas/Clientes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmBodegasClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvMetodo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtBodegas;
        private System.Windows.Forms.Button BtnBodega;
        private System.Windows.Forms.Button BtnCliente;
        private System.Windows.Forms.TextBox TxtCliente;
        private System.Windows.Forms.DataGridView DgvMetodo;
        private System.Windows.Forms.TextBox TxtPrecioKm;
        private System.Windows.Forms.Button BtnPrecioKm;
        private System.Windows.Forms.Label LPrecioKm;
        private System.Windows.Forms.Button BtnRestaurar;
    }
}