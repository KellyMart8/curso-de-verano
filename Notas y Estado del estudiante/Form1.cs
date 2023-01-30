using System.Windows.Forms;

namespace Notas_y_Estado_del_estudiante
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtNF.Enabled = false;
            txtEstado.Enabled = false;  
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int NF, n1, n2, n3, n4;

            n1 = int.Parse(mtN1.Text);
            n2 = int.Parse(mtN2.Text);
            n3 = int.Parse(mtN3.Text);
            n4 = int.Parse(mtN4.Text);


            if (n1 < 0 || n1 > 25)
            {
                MessageBox.Show("El rango debe estar entre 0 y 25 ");
                mtN1.Text = "";
                mtN1.Focus();
            }
            if (n2 < 0 || n2 > 25)
            {
                MessageBox.Show("El rango debe estar entre 0 y 25 ");
                mtN2.Text = "";
                mtN2.Focus();
            }
            if (n3 < 0 || n3 > 25)
            {
                MessageBox.Show("El rango debe estar entre 0 y 25 ");
                mtN3.Text = "";
                mtN3.Focus();
            }
            if (n4 < 0 || n4 > 25)
            {
                MessageBox.Show("El rango debe estar entre 0 y 25 ");
                mtN4.Text = "";
                mtN4.Focus();
            }

            NF = n1 + n2 + n3 + n4;
            string a = "APROBADO", r = "REPROBADO";

            if (NF > 60)
            {
                txtEstado.Text = a;
            }
            else { txtEstado.Text = r; }

            txtNF.Text = NF.ToString();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            mtN1.Clear();
            mtN2.Clear();
            mtN3.Clear();
            mtN4.Clear();
            txtEstado.Clear();
            txtNF.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}