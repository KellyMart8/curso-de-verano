namespace Practica_ListView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ListViewItem lista = new ListViewItem(txtClave.Text);  // ese pq es el primero
            lista.SubItems.Add(txtName.Text);
            lista.SubItems.Add(txtApe.Text);
            lvTabla.Items.Add(lista);  //Para que se muestre en la tabla 
            Limpiar();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            //Foreach para recorrer y eliminar un campo
            foreach (ListViewItem lis in lvTabla.SelectedItems)
            {
                lis.Remove();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mtbClave_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtClave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar) && (e.KeyChar != (char)Keys.Back)))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia"
                    , MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        public void Limpiar()
        {
            txtClave.Clear();
            txtName.Clear();
            txtApe.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}