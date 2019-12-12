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
            this.DgvMetodo = new DataGridView();
            this.DgvMetodo = i;
        }

        private double PrecioKm = 0; //Guarda el Precio/KM

        public void RecibirPrecioKM(double i)
        {
            this.PrecioKm = i;
        }

        private int inventario = 0; //Guarda el inventario Sobrante

        private List<String> Coordenadas; //Guarda las coordenadas de ruta

        private List<double> InventarioDemanda;

        /// <summary>
        /// Saca el resultado de inventario y descubre las coordenadas de Ruta.
        /// </summary>
        private void InventarioCoordenadas()
        {
            this.Coordenadas = new List<string>();
            this.InventarioDemanda = new List<double>();

            //SUMA DE LA DEMANDA
            int Demanda = 0;
            foreach (DataGridViewColumn item in DgvMetodo.Columns)
            {
                if (item.Index < (DgvMetodo.ColumnCount - 1) && item.Index != 0)
                {
                    Demanda += Convert.ToInt32(DgvMetodo.Rows[(DgvMetodo.RowCount - 1)].Cells[item.Index].Value);
                }
            }

            int Disponibilidad = 0;
            //SUMA DE LA DISPONIBILIDAD
            foreach (DataGridViewRow item in DgvMetodo.Rows)
            {
                if (item.Index < (DgvMetodo.RowCount - 1))
                {
                    Disponibilidad += Convert.ToInt32(item.Cells[(DgvMetodo.ColumnCount - 1)].Value);
                }
            }

            //"If" agrega la fila con la disponibilidad faltante
            if (Demanda > Disponibilidad)
            {
                DgvMetodo.Rows.Add();
                DgvMetodo.Rows[(DgvMetodo.RowCount - 1)].Cells[(DgvMetodo.ColumnCount - 1)].Value = (Demanda - Disponibilidad);
                DgvMetodo.Rows[(DgvMetodo.RowCount - 1)].Cells[(DgvMetodo.ColumnCount - 1)].Style.Font = new Font("Arial", 10F, FontStyle.Bold);
                DgvMetodo.Rows[(DgvMetodo.RowCount - 1)].Cells[(DgvMetodo.ColumnCount - 1)].Style.BackColor = Color.Red;
                DgvMetodo.Rows[(DgvMetodo.RowCount - 1)].Cells[(DgvMetodo.ColumnCount - 1)].Style.ForeColor = Color.White;
                DgvMetodo.Rows[(DgvMetodo.RowCount - 1)].Cells[0].Value = "BodegaFIC";
                DgvMetodo.Rows[(DgvMetodo.RowCount - 1)].Cells[0].Style.Font = new Font("Arial", 10F, FontStyle.Bold);
                for (int i = 0; i < DgvMetodo.ColumnCount; i++)
                {
                    if (Convert.ToString(DgvMetodo.Rows[(DgvMetodo.RowCount - 1)].Cells[i].Value) == "")
                    {
                        DgvMetodo.Rows[(DgvMetodo.RowCount - 1)].Cells[i].Value = 0;
                    }
                    int a;
                    if (int.TryParse(Convert.ToString(DgvMetodo.Rows[(DgvMetodo.RowCount - 1)].Cells[i].Value), out a))
                    {
                        DgvMetodo.Rows[(DgvMetodo.RowCount - 1)].Cells[i].ReadOnly = true;
                    }
                }
                DgvMetodo.Rows.AddCopy((DgvMetodo.RowCount - 2));
                foreach (DataGridViewColumn item in DgvMetodo.Columns)
                {
                    DgvMetodo.Rows[(DgvMetodo.RowCount - 1)].Cells[item.Index].Value = DgvMetodo.Rows[(DgvMetodo.RowCount - 3)].Cells[item.Index].Value;
                }
                DgvMetodo.Rows.RemoveAt((DgvMetodo.RowCount - 3));

                this.inventario = Disponibilidad - Demanda;
            }
            else if (Disponibilidad > Demanda)
            {
                this.inventario = Disponibilidad - Demanda;
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

            //Esto se encarga de guardar las coordenas de ruta en la Lista
            for (int i = 0; i < DemandaCol.Count; i++)
            {
                for (int x = 0; x < DisponibilidadFil.Count; x++)
                {
                    if (DemandaCol.ElementAt(i) > DisponibilidadFil.ElementAt(x) && DisponibilidadFil.ElementAt(x) != 0)
                    {
                        InventarioDemanda.Add(DisponibilidadFil.ElementAt(x));

                        DemandaCol.Insert(i, (DemandaCol.ElementAt(i) - DisponibilidadFil.ElementAt(x)));
                        DemandaCol.RemoveAt((i + 1));

                        DisponibilidadFil.Insert(x, 0);
                        DisponibilidadFil.RemoveAt((x + 1));

                        Coordenadas.Add(x + "," + i);                        
                    }
                    else if (DemandaCol.ElementAt(i) < DisponibilidadFil.ElementAt(x) && DemandaCol.ElementAt(i) != 0)
                    {
                        InventarioDemanda.Add(DisponibilidadFil.ElementAt(x) - (DisponibilidadFil.ElementAt(x) - DemandaCol.ElementAt(i)));

                        DisponibilidadFil.Insert(x, (DisponibilidadFil.ElementAt(x) - DemandaCol.ElementAt(i)));
                        DisponibilidadFil.RemoveAt(x + 1);

                        DemandaCol.Insert(i, 0);
                        DemandaCol.RemoveAt((i + 1));

                        Coordenadas.Add(x + "," + i);                        

                        x = DisponibilidadFil.Count;
                    }
                    else if (DemandaCol.ElementAt(i) == DisponibilidadFil.ElementAt(x) && DisponibilidadFil.ElementAt(x) != 0 && DemandaCol.ElementAt(i) != 0)
                    {
                        InventarioDemanda.Add(DisponibilidadFil.ElementAt(x));

                        DisponibilidadFil.Insert(x, 0);
                        DisponibilidadFil.RemoveAt((x + 1));

                        DemandaCol.Insert(i, 0);
                        DemandaCol.RemoveAt((i + 1));

                        Coordenadas.Add(x + "," + i);                        

                        x = DisponibilidadFil.Count;
                    }
                }
            }
        }

        /// <summary>
        /// Describe la ruta y monta los resultados en txtSimulacion.
        /// </summary>
        private void Ruta()
        {
            List<double> PKilometros = new List<double>();

            TxtSimulacion.Text = "";
            for (int i = 0; i < Coordenadas.Count; i++)
            {
                String[] Coor = Coordenadas.ElementAt(i).Split(',');
                TxtSimulacion.Text += Convert.ToString(DgvMetodo.Rows[Convert.ToInt32(Coor[0])].Cells[0].Value) + "=====>" + Convert.ToString(DgvMetodo.Columns[(Convert.ToInt32(Coor[1]) + 1)].HeaderText) + "\r\n";
                TxtSimulacion.Text += Convert.ToString("Ofrece la cantidad de: " + InventarioDemanda.ElementAt(i)) + "\r\n";
                TxtSimulacion.Text += "_____________________________________" + "\r\n";
                PKilometros.Add((Convert.ToDouble(DgvMetodo.Rows[Convert.ToInt32(Coor[0])].Cells[(Convert.ToInt32(Coor[1]) + 1)].Value) * this.PrecioKm));
            }

            double PK = 0;
            double Total = 0;

            for (int i = 0; i < PKilometros.Count; i++)
            {
                PK += PKilometros.ElementAt(i);
                Total += (PKilometros.ElementAt(i) * InventarioDemanda.ElementAt(i));
            }
            TxtCostoRuta.Text = Convert.ToString(PK);
            TxtTotal.Text = Convert.ToString(Total);

            if (inventario >= 0)
            {
                TxtInventario.Text = Convert.ToString(inventario);
                LInventario.Text = "Satisface la Demanda.";
            } 
            else
            {
                TxtInventario.Text = Convert.ToString(inventario);
                LInventario.Text = "No satisface la Demanda.";
            }
            
        }

        private void BtnSimulacion_Click(object sender, EventArgs e)
        {
            InventarioCoordenadas();
            Ruta();
        }
    }
}
