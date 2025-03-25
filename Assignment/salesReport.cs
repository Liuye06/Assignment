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
        private string connectionString;

        public salesReport()
        {
            InitializeComponent();
            LoadMenuItems();
            LoadMonths();
        }

        private void LoadMenuItems()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT DISTINCT item FROM Menu";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                comboBox2.DataSource = dt;
                comboBox2.DisplayMember = "Item";
            }
        }

        private void LoadMonths()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT DISTINCT FORMAT(date, 'MMMM') AS Payment_date FROM Payment";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                comboBox1.DataSource = dt;
                comboBox1.DisplayMember = "Payment_date";
            }
        }

        private void salesReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet3.Payment' table. You can move, or remove it, as needed.
            this.paymentTableAdapter1.Fill(this.database1DataSet3.Payment);

            this.paymentTableAdapter.Fill(this.database1DataSet1.Payment);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string select_item = comboBox2.SelectedItem.ToString();
            string select_Month = comboBox1.SelectedItem.ToString();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Payment WHERE Order_ID IN (SELECT Order_ID FROM Orders WHERE Item = @Item) AND FORMAT(date, 'MMMM') = @Month";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddWithValue("@Item", select_item);
                da.SelectCommand.Parameters.AddWithValue("@Month", select_Month);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }
    }
}
