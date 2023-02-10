namespace Flujo_neto_de_efectivo_DATAGRIDVIEW
{
    public partial class Form1 : Form
    {
        int n;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
           
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            double ing, eg, inverI, dep, imp, UAI, UDI;

            inverI = Convert.ToDouble( MTInversionI.Text);
            ing = Convert.ToDouble(MTIngreso.Text);
            eg = Convert.ToDouble( MTEgreso.Text);
            //inversion inicial entre 5000 y 65000

            if (inverI >= 5000 || inverI <= 65000)
            {
                //ingresos entre 500 y 50000
                if (ing >= 500 || ing >= 5000)
                {
                    // egresos menor a ingresos
                    if (eg < ing)
                    {
                        //ingresos y egresos proyectados a 5 años
                        ing = ing * 60;
                        eg = eg * 60;

                        //Calculando depreciacion a la inversion inicial
                        dep = inverI / 5;

                        //Utilidad antes de impuestos UAI = ing - (eg + dep)
                        UAI = ing - (eg + dep);

                        //Calcular Impuestos como el 30% de la UAI
                        imp = UAI * 0.3;
                        //Calcular UDI(Utilidad despues de Impuestos como UDI = UAI - Imp.
                        UDI = UAI - imp;
                        //imprimimos los reultados en los textBox
                        txtUtDesp.Text = UDI.ToString();
                        txtUtAntImp.Text = UAI.ToString();
                        txtDep.Text = dep.ToString();
                        txtImp.Text = imp.ToString();
                    } else MessageBox.Show("Los egresos deben ser menor a los ingresos", "ATENCION");
                }
                else MessageBox.Show("Sus ingresos son aceptados en un renago entre 500 y 5000", "AVISO");
            }else
            {
                MessageBox.Show("La inversion inicial debe estar entre 5000 y 65000", "ATENCION");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Adicionamos nuevo renglon 
            int n = dataGridView1.Rows.Add();

            //Colocamos la informacion 
            dataGridView1.Rows[n].Cells[0].Value = MTInversionI.Text;
            dataGridView1.Rows[n].Cells[1].Value = MTIngreso.Text;
            dataGridView1.Rows[n].Cells[2].Value = MTEgreso.Text;
            dataGridView1.Rows[n].Cells[3].Value = txtUtAntImp.Text;
            dataGridView1.Rows[n].Cells[4].Value = txtUtDesp.Text;
            dataGridView1.Rows[n].Cells[5].Value = txtDep.Text;
            dataGridView1.Rows[n].Cells[6].Value = txtImp.Text;

            //limpiamos
            MTEgreso.Clear();
            MTIngreso.Clear();
            MTInversionI.Clear();
            txtDep.Clear();
            txtImp.Clear();
            txtUtAntImp.Clear();
            txtUtDesp.Clear();
            MTInversionI.Focus();

        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            n = e.RowIndex;
            //con esto podemos leer el contenido 
            if (n != -1)
            {
                lblInformacion.Text = (string)dataGridView1.Rows[n].Cells[1].Value;
            }
        }

        private void btnBorrarElem_Click(object sender, EventArgs e)
        {
            if (n != -1)
            {
                dataGridView1.Rows.RemoveAt(n);
            }
        }

    }
}