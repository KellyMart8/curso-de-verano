namespace Practica_radiobutton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int v1 = int.Parse(txtN1.Text);
            int v2 = int.Parse(txtN2.Text);

            if (rbSuma.Checked == true)
            {
                int suma = v1 + v2;
                txtResultado.Text = suma.ToString();
            }
            else if(rbMulti.Checked == true)
            {
                int mult = v1 * v2;
                txtResultado.Text = mult.ToString();    
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtResultado.Enabled = false;
        }

        public void Limpiar()
        {
            txtResultado.Clear();
            txtN2.Clear();
            txtN1.Clear();
        }
    }
}