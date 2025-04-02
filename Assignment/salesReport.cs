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
        string connectionString = "Data Source=DESKTOP-NV6DCAO;Initial Catalog=DATABASE1;User Id=sa;Password=peb109318051@APU";

        private int currentUserID;

        public salesReport(int userID)
        {
            // Ensure the form's properties are set correctly for the close button
            this.ControlBox = true;  // Ensure the close button is enabled
            this.FormBorderStyle = FormBorderStyle.Sizable; // Allow resizing and the "X" button to appear
            this.MaximizeBox = true; // Allow maximizing the form
            this.MinimizeBox = true; // Allow minimizing the form

            InitializeComponent();
            currentUserID = userID;
        }
        private void salesReport_Load(object sender, EventArgs e)
        {
            // Populate ComboBoxes with values
            cmbMonth.DataSource = AdminClass.GetPaymentMonths(); // Populate months
            cmbChefName.DataSource = AdminClass.GetChefs(); // Populate chefs

            // Populate the DataGridView initially
            LoadSalesData();
        }

        private void LoadSalesData()
        {
            string query = "SELECT Payment_ID, Amount, Order_ID, Reservation_ID, Status FROM Payment";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.AutoGenerateColumns = true;
                    dataGridView1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string selectedMonth = cmbMonth.SelectedItem?.ToString();
            string selectedChef = cmbChefName.SelectedItem?.ToString();

            // Build the SQL query based on selected filters
            string query = "SELECT Payment.Payment_ID, Payment.Amount, Payment.Order_ID, Payment.Reservation_ID, Payment.Status " +
                           "FROM Payment " +
                           "INNER JOIN Chef_InCharge cic ON Payment.Order_ID = cic.Order_ID " +
                           "INNER JOIN Chefs c ON cic.User_ID = c.User_ID WHERE 1 = 1";

            // Add conditions based on selected filters
            if (!string.IsNullOrEmpty(selectedMonth))
            {
                query += " AND MONTH(Payment.Payment_date) = @Month";
            }
            if (!string.IsNullOrEmpty(selectedChef))
            {
                query += " AND c.ChefName = @Chef";  // Assuming ChefName is in the Chefs table
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);

                    // Add parameters to prevent SQL injection
                    if (!string.IsNullOrEmpty(selectedMonth))
                        cmd.Parameters.AddWithValue("@Month", selectedMonth); // For the month filter
                    if (!string.IsNullOrEmpty(selectedChef))
                        cmd.Parameters.AddWithValue("@Chef", selectedChef); // For chef filter

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // Show data in DataGridView
                    if (dt.Rows.Count > 0)
                    {
                        dataGridView1.DataSource = dt;
                    }
                    else
                    {
                        MessageBox.Show("No records found for the selected criteria.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }


        private void btn_Return_Click(object sender, EventArgs e)
        {
            Admin adminForm = new Admin(currentUserID);
            adminForm.Show();
            this.Close();
        }
    }
}
