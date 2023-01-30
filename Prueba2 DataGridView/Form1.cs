using System.Data;

namespace Prueba2_DataGridView_
{
    public partial class Form1 : Form
    {
        DataTable table = new DataTable("Table");
        int index;
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            table.Columns.Add("ID", Type.GetType("System.Int32"));
            table.Columns.Add("Nombre", Type.GetType("System.String"));
            table.Columns.Add("Apellido", Type.GetType("System.String"));
            table.Columns.Add("Sum", Type.GetType("System.Double"));
            dataGridView1.DataSource = table;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*en sus propiedades se selecciona AutoZiseColumnsMode "Fill" para que la tabla se
             * adapte al tamaño de los items
             * 
             * Para desaparecer la primera fila en blanco que aparece por defecto, se selecciona la 
             * propiedad  AllowUserToAddRows en "false"
             */
        }

        private void button1_Click(object sender, EventArgs e)
        {
            table.Rows.Add(txtId.Text, txtName.Text, txtApellido.Text, txtSum.Text);
            Limpiar();
        }

        public void Limpiar()
        {
            txtId.Clear();
            txtName.Clear();
            txtApellido.Clear();
            txtSum.Clear();
        }

        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar) && (e.KeyChar != (char)Keys.Back)))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtSum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar) && (e.KeyChar != (char)Keys.Back)))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[index];
            txtId.Text = row.Cells[0].Value.ToString();
            txtName.Text = row.Cells[1].Value.ToString();
            txtApellido.Text = row.Cells[2].Value.ToString();
            txtSum.Text = row.Cells[3].Value.ToString();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            DataGridViewRow newData = dataGridView1.Rows[index];
            newData.Cells[0].Value = txtId.Text;
            newData.Cells[1].Value = txtName.Text;
            newData.Cells[2].Value = txtApellido.Text;
            newData.Cells[3].Value = txtSum.Text;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            index = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(index);
        }
    }
}