namespace Practica_ListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Adicionar elementos
            lbxFrutas.Items.Add("Banana");
            lbxFrutas.Items.Add("Durazno");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lbxFrutas.Items.Add(txtFrutaAd.Text);
            txtFrutaAd.Clear();
        }

        private void lbxFrutas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbxFrutas.SelectedIndex != -1)
            {
                lblFrutas.Text = (string)lbxFrutas.Items[lbxFrutas.SelectedIndex]; 
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int i = lbxFrutas.SelectedIndex;

            if (i != -1)
            {
                lbxFrutas.Items.RemoveAt(i);
            }
        }
    }
}