using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetodoTransporte.Forms;

namespace MetodoTransporte
{   
    public partial class Form1 : Form
    {
        FrmBodegasClientes FrmBodCli = new FrmBodegasClientes();
        FrmSimulacion FrmSim = new FrmSimulacion();
        FrmResultados FrmResult = new FrmResultados();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.FrmBodCli.MdiParent = this;
            this.FrmSim.MdiParent = this;
            this.FrmResult.MdiParent = this;
            FrmBodCli.Show();
        }

        private Boolean Cerrar()
        {
            bool Cerrado;
            if (!this.FrmBodCli.Visible && !this.FrmSim.Visible && !this.FrmResult.Visible)
            {
                Cerrado = true;
            }
            else
            {
                Cerrado = false;
            }

            return Cerrado;
        }

        private void bodegasClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Cerrar())
            {
                this.FrmBodCli.Visible = true;
            }
        }

        private void simulaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Cerrar())
            {
                this.FrmSim.Visible = true;
            }
        }

        private void resultadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Cerrar())
            {
                this.FrmResult.Visible = true;
            }
        }
    }
}
