namespace Practica_CheckBoxs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ckbMostrarC_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbMostrarC.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtPassword.Clear();
            txtUsuario.Clear();
            txtUsuario.Focus();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string usuario = "Kelly08", passw = "1234";

            passw = txtPassword.Text;
            usuario = txtUsuario.Text;

            if (txtUsuario.Text == "Kelly08" && txtPassword.Text == "1234")
            {
                progressBar1.Maximum = 100;
                progressBar1.Minimum = 0;

                for (int i = 0; i < 100; i++)
                {
                    progressBar1.Value = i;
                }
            }
            else if (txtUsuario.Text != "Kelly08" && txtPassword.Text != "1234")
            {
                MessageBox.Show("Rellene los campos correctamente", "ADVERTENCIA");
                txtPassword.Clear();
                txtUsuario.Clear();
                txtUsuario.Focus();
            }
            else if (txtUsuario.Text == "" && txtPassword.Text == "")
            {
                MessageBox.Show("Rellene todos los campos");
            }

        }
    }
}
