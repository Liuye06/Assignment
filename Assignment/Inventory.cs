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
        public Inventory()
        {
            InitializeComponent();
        }

        private void InventoryDB(object sender, EventArgs e)
        {
            string connectionString = "Server=your_server; Database=Assignmentdb;";

            // SQL query to fetch data from the Inventory table
            string query = "SELECT * FROM Stock";  // Assuming your table name is 'Inventory'

            // Create a connection to the database
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    // Open the connection
                    conn.Open();

                    // Create a DataAdapter to retrieve data
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conn);

                    // Create a DataTable to hold the fetched data
                    DataTable dataTable = new DataTable();

                    // Fill the DataTable with data from the Inventory table
                    dataAdapter.Fill(dataTable);

                    // Bind the DataTable to the DataGridView
                    dataGridView1.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    // Show an error message if the connection fails
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Inventory_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
