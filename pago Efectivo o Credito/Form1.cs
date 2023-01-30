namespace pago_Efectivo_o_Credito
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtCuotaMes.Enabled = false;
            txtIntAnual.Enabled = false;
        }

        private void txtPlazo_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void cboTPrest_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}