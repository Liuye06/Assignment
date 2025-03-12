using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Assignment
{
    public partial class Inventory: Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\source\repos\Liuye06\Assignment\Assignment\Assignmentdb.mdf;Integrated Security=True");
        public Inventory()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Inventory_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'assignmentdbDataSet.Stock' table. You can move, or remove it, as needed.
            this.stockTableAdapter.Fill(this.assignmentdbDataSet.Stock);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_i_back_Click(object sender, EventArgs e)
        {
            Chef chef = new Chef();
            chef.Show();
        }
    }
}
