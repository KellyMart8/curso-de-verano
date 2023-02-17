using System.Transactions;

namespace Practica_TreeView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int n;
        double subt, ingr, total;

        private void btnDelete1_Click(object sender, EventArgs e)
        {
            if (n != -1)
            {
                dataGridView1.Rows.RemoveAt(n);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            //Validamos
            if (treeView1.SelectedNode.Text.Equals(""))
            {
                MessageBox.Show("Debe seleccionar una deduccion");
                treeView1.Focus();
            }
            else if (mtNInss.Text == "" || mtIngresoM.Text == "")
            {
                MessageBox.Show("Rellene los campos");
                mtNInss.Focus();
            }
            else
                ingr = Convert.ToDouble(mtIngresoM.Text);
            if (treeView1.SelectedNode.Text.Equals("Inss Laboral"))
            {
                if (ingr >= 6000 || ingr <= 500000)
                {
                    subt = Convert.ToDouble(mtIngresoM.Text) * 0.07;
                    total = Convert.ToDouble(mtIngresoM.Text) - subt;
                    txtTotal.Text = total.ToString();

                    int n = dataGridView1.Rows.Add();

                    dataGridView1.Rows[n].Cells[0].Value = mtNInss.Text;
                    dataGridView1.Rows[n].Cells[1].Value = mtIngresoM.Text;
                    //inss laboral
                    dataGridView1.Rows[n].Cells[2].Value = subt.ToString();
                    dataGridView1.Rows[n].Cells[5].Value = txtTotal.Text;
                }
                else
                {
                    MessageBox.Show("El rango de ingresos debe estar entre a 6000 a 500000");
                }
            }
            else if (treeView1.SelectedNode.Text.Equals("Inss Patronal"))
            {
                if (ingr >= 6000 || ingr <= 500000)
                {
                    subt = Convert.ToDouble(mtIngresoM.Text) * 0.22;
                    total = Convert.ToDouble(mtIngresoM.Text) - subt;
                    txtTotal.Text = total.ToString();

                    int n = dataGridView1.Rows.Add();

                    dataGridView1.Rows[n].Cells[0].Value = mtNInss.Text;
                    dataGridView1.Rows[n].Cells[1].Value = mtIngresoM.Text;
                    //inss laboral
                    dataGridView1.Rows[n].Cells[3].Value = subt.ToString();
                    dataGridView1.Rows[n].Cells[5].Value = mtIngresoM.Text;
                }
                else
                {
                    MessageBox.Show("El rango de ingresos debe estar entre a 6000 a 500000");
                }
            }
            else if (treeView1.SelectedNode.Text.Equals("IR"))
            {
                if (ingr >= 6000 || ingr <= 500000)
                {
                    subt = Convert.ToDouble(mtIngresoM.Text) * 0.11;
                    total = Convert.ToDouble(mtIngresoM.Text) - subt;
                    txtTotal.Text = total.ToString();

                    int n = dataGridView1.Rows.Add();

                    dataGridView1.Rows[n].Cells[0].Value = mtNInss.Text;
                    dataGridView1.Rows[n].Cells[1].Value = mtIngresoM.Text;
                    //inss laboral
                    dataGridView1.Rows[n].Cells[4].Value = subt.ToString();
                    dataGridView1.Rows[n].Cells[5].Value = txtTotal.Text;
                }
                else
                {
                    MessageBox.Show("El rango de ingresos debe estar entre a 6000 a 500000");
                }
            }

            LimpiarCampos();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //n = e.RowIndex;
            ////con esto podemos leer el contenido 
            //if (n != -1)
            //{
            //    lblInformacion.Text = (string)dataGridView1.Rows[n].Cells[1].Value;
            //}
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int n = dataGridView1.Rows.Add();

            dataGridView1.Rows[n].Cells[0].Value = mtNInss.Text;
            dataGridView1.Rows[n].Cells[1].Value = mtIngresoM.Text;
            //inss laboral
            dataGridView1.Rows[n].Cells[2].Value = Convert.ToDouble(mtIngresoM.Text) - (Convert.ToDouble(mtIngresoM.Text) * 1.07);
        }

        public void LimpiarCampos()
        {
            txtTotal.Clear();
            mtIngresoM.Clear();
            mtNInss.Clear();
        }
    }
}