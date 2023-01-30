using System.Data;

namespace Prueba_DataGridView
{
    public partial class Form1 : Form
    {
        DataTable table = new DataTable("Table");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            table.Columns.Add("ID", Type.GetType("System.Int32"));
            table.Columns.Add("Nombre", Type.GetType("System.String"));
            table.Columns.Add("Apellido", Type.GetType("System.String"));
            table.Columns.Add("Sum", Type.GetType("System.Double"));
            dataGridView1.DataSource = table;
        }
    }
}