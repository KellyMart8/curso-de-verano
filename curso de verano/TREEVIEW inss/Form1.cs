namespace TREEVIEW_inss
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double inss, ing, total, cobrado, Ni;
        private void btnCalc_Click(object sender, EventArgs e)
        {
            //validamos

            if (treeView1.SelectedNode.Text.Equals(""))
            {
                MessageBox.Show("Seleccione una deduccion");

            }else if(mtIngresos.Text == "" || mtNinss.Text == "")
            {
                MessageBox.Show("Rellene todos los campos", "ADVERTENCIA");
                mtNinss.Focus();

            }else
            {
                ing = Convert.ToDouble(mtIngresos.Text);
                Ni = Convert.ToDouble(mtNinss.Text);

                if (treeView1.SelectedNode.Text.Equals("Inss laboral"))
                {
                    if (ing > 6000 || ing <= 500000)
                    {
                        inss = ing * 0.07;
                        txtInssCobrado.Text = inss.ToString();
                        //Calculamos el total 
                        total = ing - inss;
                        txtTotal.Text = total.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Rango entre 6000 y 500000", "ERROR");
                    }
                }
                else if (treeView1.SelectedNode.Text.Equals("Inss patronal"))
                {
                    if (ing > 6000 && ing <= 500000)
                    {
                        inss = ing * 0.22;
                        txtInssCobrado.Text = inss.ToString();
                        //Calculamos el total 
                        total = ing - inss;
                        txtTotal.Text = ing.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Rango entre 6000 y 500000", "ERROR");
                    }
                }
                else if (treeView1.SelectedNode.Text.Equals("IR"))
                {
                    if (ing > 6000 && ing <= 500000)
                    {
                        inss = ing * 0.11;
                        txtInssCobrado.Text = inss.ToString();
                        //Calculamos el total 
                        total = ing - inss;
                        txtTotal.Text = total.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Rango entre 6000 y 500000", "ERROR");
                    }
                } 
            }
        }
    }
}