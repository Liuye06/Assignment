using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    public partial class salesReport : Form
    {
        public salesReport()
        {
            InitializeComponent();
        }
        private void salesReport_Load(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-NV6DCAO;Initial Catalog=DATABASE1;User Id=sa;Password=peb109318051@APU";
            string query = "SELECT Payment_ID, Amount, Order_ID, Reservation_ID, Status FROM Payment";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // Debugging: Print values to see if Order_ID and Status exist
                    foreach (DataRow row in dt.Rows)
                    {
                        Console.WriteLine($"Order_ID: {row["Order_ID"]}, Status: {row["Status"]}");
                    }

                    dataGridView1.AutoGenerateColumns = true;
                    dataGridView1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

            // get Menu Item data
            comboBox2.DataSource = AdminClass.GetMenuItems();
            comboBox1.DataSource = AdminClass.GetPaymentMonths();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null || comboBox2.SelectedItem == null)
            {
                MessageBox.Show("Please select both a Menu Item and a Month.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedItem = comboBox2.SelectedItem.ToString();
            string selectedMonth = comboBox1.SelectedItem.ToString();

            dataGridView1.DataSource = AdminClass.SearchPayments(selectedItem, selectedMonth);
        }

        private void lbl_salesR_Click(object sender, EventArgs e)
        {

        }
    }
}
