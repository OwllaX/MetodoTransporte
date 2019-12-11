using MetodoTransporte.Forms;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MetodoTransporte
{
    public partial class Form1 : Form
    {
        FrmBodegasClientes FrmBodCli = new FrmBodegasClientes();
        FrmSimulacion FrmSim = new FrmSimulacion();

        public Form1()
        {
            InitializeComponent();
        }

        Control ctl = new Control(); //Variable usada para cambiar el backcolor del MdiClient

        private void Form1_Load(object sender, EventArgs e)
        {
            //Se encarga de cambiar el color del MdiClient
            foreach (Control ctl in this.Controls)
            {
                try
                {
                    if (ctl is MdiClient)
                    {
                        ctl.BackColor = Color.White;
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }

            this.FrmBodCli.MdiParent = this;
            this.FrmSim.MdiParent = this;
            FrmBodCli.Show();
        }

        /// <summary>
        /// Valida si los tres formularios están cerrados.
        /// </summary>
        /// <returns></returns>
        private Boolean Cerrado()
        {
            bool Cerrado;
            if (!this.FrmBodCli.Visible && !this.FrmSim.Visible)
            {
                Cerrado = true;
            }
            else
            {
                Cerrado = false;
            }

            return Cerrado;
        }

        //Abre formulario
        private void bodegasClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Cerrado())
            {
                this.FrmBodCli.Visible = true;
            }
        }

        //Abre formulario
        private void simulaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Cerrado())
            {
                this.FrmSim.RecibirPrecioKM(this.FrmBodCli.varPrecioKM);
                this.FrmSim.RecibirDatos(this.FrmBodCli.DatosTabla);
                this.FrmSim.Visible = true;
            }
        }
    }
}
