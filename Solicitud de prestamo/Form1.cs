using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Solicitud_de_prestamo
{

    // taza de interes de 18% anual
    //  monto requerido entre de 100 a 5000
    public partial class Form1 : Form
    {
        int i, n;
        double tasaMensual;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtCuota.Enabled = false;
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            int ut, ing, egr, mr;

            ing = int.Parse(mtIng.Text);
            egr = int.Parse(mtEgr.Text);
            mr = int.Parse(mtMontoR.Text);

            if (mtEgr.Text == "" && mtIng.Text == "" && mtMontoR.Text == "")
            {

                if (ing > 500)
                {
                    if (egr < ing)
                    {
                        ut = ing - egr;
                    }
                    else
                    {
                        MessageBox.Show("El egreso debe ser menor al ingreso");
                    }
                }
                else
                {
                    MessageBox.Show("EL ingreso debe ser mayor a 500");
                }
            }
            else MessageBox.Show("No deje ningun campo vacio", "ADVERTENCIA");


            string a = "Aceptado", b = "Denegado";

            tasaMensual = 0.18 / int.Parse(cboPlazo.Text);
            double cuotaMensual = (mr * tasaMensual) / (1 - Math.Pow(1 + tasaMensual, -int.Parse(cboPlazo.Text)));

            txtCuota.Text = cuotaMensual.ToString();

            double montoUtilidad = (ing - egr) * 0.35;

            //if(mr > 1000)
            //{
            //    MessageBox.Show("Esperando para calcular");
            //}
            //else
            //{
            //    MessageBox.Show("El monto debe ser mayo a 1000");
            //}

            // saber si es suficiente para cubrir con la cuota
            if (montoUtilidad >= mr)
            {
                txtAprob.Text = "Su solicitud ha sido aprobada";
            }
            else
            {
                txtAprob.Text = "Su solicitud no ha sido aprobada";
            }

        }

        public void Limpiar()
        {
            txtName.Clear();
            txtCuota.Clear();
            mtEgr.Clear();
            mtIng.Clear();
            mtMontoR.Clear();
            cboPlazo.Text = "";
            txtAprob.Text = "";
        }

        private void btnCLear_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int fila;
            int columna;
            double vB;
            double aux;

            dataGridView1.ColumnHeadersVisible = false;
            dataGridView1.RowHeadersVisible = false;

            fila = int.Parse(cboPlazo.Text); columna = 5;
            dataGridView1.ColumnCount = columna;
            dataGridView1.RowCount = fila;


            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                for (int j = 1; j < dataGridView1.RowCount; j++)
                {
                    dataGridView1[i, j].Value = (j + 1);
                    dataGridView1.Rows[n].Cells[0].Value = tasaMensual.ToString();
                    //dataGridView1.Rows[n].Cells[1].Value = MTIngreso.Text;
                }
            }
        }
    }
}


