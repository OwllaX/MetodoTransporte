using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetodoTransporte.Forms
{
    public partial class FrmSimulacion : Form
    {
        public FrmSimulacion()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private DataGridView DgvMetodo; //Se Utiliza para dar 

        public void RecibirDatos(DataGridView i)
        {
            this.DgvMetodo = i;
        }

        private double PrecioKm = 0;

        public void RecibirPrecioKM(double i)
        {
            this.PrecioKm = i;
        }

        //SOLO PARA TEST
        private void btnPrueba_Click(object sender, EventArgs e)
        {
            //for (int i = 0; i < DgvMetodo.ColumnCount; i++)
            //{
            //    foreach (DataGridViewRow item in DgvMetodo.Rows)
            //    {
            //        MessageBox.Show(Convert.ToString(item.Cells[i].Value));
            //    }
            //}
            //MessageBox.Show(Convert.ToString(this.PrecioKm));

            //SUMA DE LA DEMANDA
            int a = 0;
            foreach (DataGridViewColumn item in DgvMetodo.Columns)
            {
                if (item.Index < (DgvMetodo.ColumnCount - 1) && item.Index != 0)
                {
                    a += Convert.ToInt32(DgvMetodo.Rows[(DgvMetodo.RowCount - 1)].Cells[item.Index].Value);
                }
            }

            int b = 0;
            //SUMA DE LA DISPONIBILIDAD
            foreach (DataGridViewRow item in DgvMetodo.Rows)
            {
                if (item.Index < (DgvMetodo.RowCount - 1))
                {
                    b += Convert.ToInt32(item.Cells[(DgvMetodo.ColumnCount - 1)].Value);
                }
            }

            //"If" agrega la fila con la disponibilidad faltante
            if (a > b)
            {
                DgvMetodo.Rows.Add();
                DgvMetodo.Rows[(DgvMetodo.RowCount - 1)].Cells[(DgvMetodo.ColumnCount - 1)].Value = (a - b);
                DgvMetodo.Rows[(DgvMetodo.RowCount - 1)].Cells[0].Value = "BodegaFIC";
                DgvMetodo.Rows.AddCopy((DgvMetodo.RowCount - 2));
                foreach (DataGridViewColumn item in DgvMetodo.Columns)
                {
                    DgvMetodo.Rows[(DgvMetodo.RowCount - 1)].Cells[item.Index].Value = DgvMetodo.Rows[(DgvMetodo.RowCount - 3)].Cells[item.Index].Value;
                }
                DgvMetodo.Rows.RemoveAt((DgvMetodo.RowCount - 3));
            }

            List<int> DemandaCol = new List<int>();
            List<int> DisponibilidadFil = new List<int>();
            
            //Guarda la Disponibilidad en una lista
            foreach (DataGridViewRow item in DgvMetodo.Rows)
            {
                if (item.Index < (DgvMetodo.RowCount - 1))
                {
                    DisponibilidadFil.Add(Convert.ToInt32(item.Cells[(DgvMetodo.ColumnCount - 1)].Value));
                }
            }

            //Guarda la Demanda en una lista
            foreach (DataGridViewColumn item in DgvMetodo.Columns)
            {
                if (item.Index != 0 && item.Index < (DgvMetodo.ColumnCount - 1))
                {
                    DemandaCol.Add(Convert.ToInt32(DgvMetodo.Rows[(DgvMetodo.RowCount - 1)].Cells[item.Index].Value));
                }
            }

            List<String> Coordenadas = new List<string>();

            for (int i = 0; i < DemandaCol.Count; i++)
            {
                for (int x = 0; x < DisponibilidadFil.Count; x++)
                {
                    if (DemandaCol.ElementAt(i) > DisponibilidadFil.ElementAt(x) && DisponibilidadFil.ElementAt(x) != 0)
                    {
                        DemandaCol.Insert(i, (DemandaCol.ElementAt(i) - DisponibilidadFil.ElementAt(x)));
                        DemandaCol.RemoveAt((i + 1));

                        DisponibilidadFil.Insert(x, 0);
                        DisponibilidadFil.RemoveAt((x + 1));

                        Coordenadas.Add(i + "," + x);
                    }
                    else if (DemandaCol.ElementAt(i) < DisponibilidadFil.ElementAt(x) && DemandaCol.ElementAt(i) != 0)
                    {
                        DisponibilidadFil.Insert(x, (DisponibilidadFil.ElementAt(x) - DemandaCol.ElementAt(i)));
                        DisponibilidadFil.RemoveAt(x + 1);

                        DemandaCol.Insert(i, 0);
                        DemandaCol.RemoveAt((i + 1));

                        Coordenadas.Add(i + "," + x);

                        x = DisponibilidadFil.Count;
                    }
                    else if (DemandaCol.ElementAt(i) == DisponibilidadFil.ElementAt(x) && DisponibilidadFil.ElementAt(x) != 0 && DemandaCol.ElementAt(i) != 0)
                    { 
                        DisponibilidadFil.Insert(x, 0);
                        DisponibilidadFil.RemoveAt((x + 1));

                        DemandaCol.Insert(i, 0);
                        DemandaCol.RemoveAt((i + 1));

                        Coordenadas.Add(i + "," + x);

                        x = DisponibilidadFil.Count;
                    }
                }
            }            

            for (int i = 0; i < Coordenadas.Count; i++)
            {
                MessageBox.Show(Coordenadas.ElementAt(i));
            }
        }
    }
}
