using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetodoTransporte
{
    public partial class FrmBodegasClientes : Form
    {
        public FrmBodegasClientes()
        {
            DgvMetodo = new DataGridView();
            InitializeComponent();
        }

        private void FrmBodegasClientes_Load(object sender, EventArgs e)
        {

        }

        //Hace que se cierre sin liberar recursos el formulario
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (ValidarCierre())
            {
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("No se han ingresado todos los datos.", "Datos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }            
        }

        //Permite que solo se inserte números en los campos
        private void TxtBodegas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        //Permite que solo se inserte números en los campos
        private void TxtCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        //Agrega la cantidad de Bodegas en el DataGridView
        private void BtnBodega_Click(object sender, EventArgs e)
        {
            if (TxtBodegas.Text != "")
            {
                BtnBodega.Enabled = false;
                int Bod = int.Parse(TxtBodegas.Text);
                TxtBodegas.Text = "";
                if (DgvMetodo.Columns.Count == 0) //Determina si existe al menos una columna
                {
                    DgvMetodo.Columns.Add("ColTabla", "_________|"); //Agrega la columna divisoria
                    for (int i = 1; i <= Bod; i++)
                    {
                        DgvMetodo.Rows.Add("Bodega" + i); //Agrega la cantidad de Bodegas
                    }
                    DgvMetodo.Rows.Add("Demanda"); //Y crea una exclusiva para Demanda de los Clientes
                } else
                {
                    for (int i = 0; i < Bod; i++)
                    {
                        DgvMetodo.Rows.Add("Bodega" + (i + 1)); //Agrega la cantidad de Bodegas
                    }
                    DgvMetodo.Rows.Add("Demanda"); //Y crea una exclusiva para Demanda de los Clientes
                }
            }
            DgvMetodo.Columns[0].ReadOnly = true; //La primera columna es la única que no puede editarse

            //Hace que las columnas no puedan ser reorganizadas
            foreach (DataGridViewColumn item in DgvMetodo.Columns)
            {
                item.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            NoEditarCeldaSureste();
            CeldasNegrita();
        }

        //Agrega la cantidad de Clientes en el DataGridView
        private void BtnCliente_Click(object sender, EventArgs e)
        {
            if (TxtCliente.Text != "")
            {
                BtnCliente.Enabled = false;
                int Cli = int.Parse(TxtCliente.Text);
                TxtCliente.Text = "";
                if (DgvMetodo.Columns.Count == 0) //Determina si existe al menos una columna
                {
                    DgvMetodo.Columns.Add("ColTabla", "_________|"); //Agrega la columna divisoria
                    for (int i = 1; i <= Cli; i++)
                    {
                        DgvMetodo.Columns.Add("Cli" + i, "Cliente" + i); //Agrega las columnas clientes
                    }
                    DgvMetodo.Columns.Add("Dis", "Disponibilidad"); //Agrega la columna Disponibilidad de las Bodegas
                } 
                else
                {
                    for (int i = 1; i <= Cli; i++)
                    {
                        DgvMetodo.Columns.Add("Cli" + i, "Cliente" + i); //Agrega las columnas clientes
                    }
                    DgvMetodo.Columns.Add("Dis", "Disponibilidad"); //Agrega la columna Disponibilidad de las Bodegas
                }
            }
            DgvMetodo.Columns[0].ReadOnly = true; //La primera columna es la única que no puede editarse

            //Hace que las columnas no puedan ser reorganizadas
            foreach (DataGridViewColumn item in DgvMetodo.Columns)
            {
                item.SortMode = DataGridViewColumnSortMode.NotSortable;
            }            

            NoEditarCeldaSureste();
            CeldasNegrita();
        }

        //En el campo solo pueden digitar números con decimales
        private void TxtPrecioKm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            //Solo se permite un punto decimal
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private double PrecioKm = 0;

        //Agrega el precio por kilometro establecido en el label
        private void BtnPrecioKm_Click(object sender, EventArgs e)
        {
            if (TxtPrecioKm.Text != "")
            {
                PrecioKm = double.Parse(TxtPrecioKm.Text);
                TxtPrecioKm.Text = "";
                LPrecioKm.Text = "Precio/KM: " + PrecioKm;
            }
        }

        //Restaura todos los controles del formulario
        private void BtnRestaurar_Click(object sender, EventArgs e)
        {
            BtnBodega.Enabled = true;
            BtnCliente.Enabled = true;
            if (DgvMetodo.ColumnCount > 0)
            {
                DgvMetodo.Columns.Clear();
            }
            if (DgvMetodo.RowCount > 0)
            {
                DgvMetodo.Rows.Clear();
            }
            LPrecioKm.Text = "Precio/KM: 0";
        }

        //Convierte la celda sureste en ReadOnly
        private void NoEditarCeldaSureste()
        {
            try
            {
                if (DgvMetodo.ColumnCount > 1 && DgvMetodo.RowCount > 0)
                {
                    foreach (DataGridViewColumn item in this.DgvMetodo.Columns)
                    {
                        foreach (DataGridViewRow i in this.DgvMetodo.Rows)
                        {
                            if (item.Index == (DgvMetodo.ColumnCount - 1) && i.Index == (DgvMetodo.RowCount - 1))
                            {
                                i.Cells["Dis"].ReadOnly = true;
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        //Pone en negrita todas las celdas de Demanda y Disponibilidad
        private void CeldasNegrita()
        {
            try
            {
                if (DgvMetodo.ColumnCount > 1 && DgvMetodo.RowCount > 0)
                {
                    for (int i = 0; i < DgvMetodo.ColumnCount; i++)
                    {
                        foreach (DataGridViewRow item in DgvMetodo.Rows)
                        {
                            //Cambia la fuente en las celdas de la fila final
                            if ((DgvMetodo.RowCount - 1 == item.Index))
                            {
                                if (Convert.ToString(item.Cells[i].Value) == "Demanda")
                                {
                                    item.Cells[i].Style.Font = new Font("Arial", 10F, FontStyle.Bold);
                                }
                                else
                                {
                                    item.Cells[i].Style.Font = new Font("Arial", 10F, FontStyle.Bold);
                                    item.Cells[i].Style.BackColor = Color.Blue;
                                    item.Cells[i].Style.ForeColor = Color.White;
                                }
                            }
                            //Cambia la fuente en las celdas de la columna final
                            if (i == (DgvMetodo.ColumnCount - 1))
                            {
                                if (item.Index == (DgvMetodo.RowCount - 1))
                                {
                                    item.Cells[i].Style.Font = new Font("Arial", 10F, FontStyle.Bold);
                                    item.Cells[i].Value = "|____________";
                                    item.Cells[i].Style.BackColor = Color.White;
                                    item.Cells[i].Style.ForeColor = Color.Black;
                                }
                                else
                                {
                                    item.Cells[i].Style.Font = new Font("Arial", 10F, FontStyle.Bold);
                                    item.Cells[i].Style.BackColor = Color.Blue;
                                    item.Cells[i].Style.ForeColor = Color.White;
                                }                                
                            }
                        }
                        
                    }
                }

                if (DgvMetodo.RowCount > 0)
                {
                    //Agrega la fuente negrita en los datos de la primera columna
                    DataGridViewCellStyle style = new DataGridViewCellStyle();
                    style.Font = new Font("Arial", 10F, FontStyle.Bold);
                    DgvMetodo.Columns[0].DefaultCellStyle = style;
                }

                if (DgvMetodo.ColumnCount >= 1)
                {
                    //Agrega la fuente negrita a los encabezados;
                    DgvMetodo.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10F, FontStyle.Bold); //Los encabezados de las columnas en negrita
                }                
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataGridView DatosTabla => DgvMetodo;

        public double varPrecioKM => this.PrecioKm;

        private void DgvMetodo_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int a;
            if (!int.TryParse(Convert.ToString(DgvMetodo.Rows[e.RowIndex].Cells[e.ColumnIndex].Value),out a) && Convert.ToString(DgvMetodo.Rows[e.RowIndex].Cells[e.ColumnIndex].Value) != "|____________" && e.ColumnIndex != 0)
            {
                DgvMetodo.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = 0;
            }
        }

        /// <summary>
        /// Método que valida el registro de todos los datos.
        /// </summary>
        /// <returns></returns>
        private bool ValidarCierre()
        {
            if (DgvMetodo.Rows.Count != 0 && DgvMetodo.Columns.Count != 0 && PrecioKm != 0 && ValidarRegistroDGV())
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        /// <summary>
        /// Método que revisa el registro de todas las celdas.
        /// </summary>
        /// <returns></returns>
        private bool ValidarRegistroDGV()
        {
            for (int i = 0; i < DgvMetodo.ColumnCount; i++)
            {
                foreach (DataGridViewRow item in DgvMetodo.Rows)
                {
                    if (Convert.ToString(item.Cells[i].Value) == "")
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
