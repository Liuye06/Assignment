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
using Assignment;

namespace Assignment
{
    public partial class Admin_salesReport : Form
    {
        // Database connection string
        string connectionString = "Data Source=DESKTOP-NV6DCAO;Initial Catalog=DATABASE1;User Id=sa;Password=peb109318051@APU";

        private int currentUserID;

        // Constructor to initialize the form with current user ID
        public Admin_salesReport(int userID)
        {
            InitializeComponent();
            currentUserID = userID;
        }

        // Form load event to populate ComboBoxes and load initial sales data
        private void salesReport_Load(object sender, EventArgs e)
        {
            // Disable automatic column generation
            dataGridView1.AutoGenerateColumns = false;

            // Clear existing columns
            dataGridView1.Columns.Clear();

            // Add columns manually
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Payment_ID",
                HeaderText = "Payment ID",
                DataPropertyName = "Payment_ID",
                Width = 100
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Payment_date",
                HeaderText = "Payment Date",
                DataPropertyName = "Payment_date",
                Width = 150,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "yyyy-MM-dd HH:mm:ss" }
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Amount",
                HeaderText = "Amount (RM)",
                DataPropertyName = "Amount",
                Width = 100,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "C2" } // Currency format
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Order_ID",
                HeaderText = "Order ID",
                DataPropertyName = "Order_ID",
                Width = 100
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Reservation_ID",
                HeaderText = "Reservation ID",
                DataPropertyName = "Reservation_ID",
                Width = 120
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Status",
                HeaderText = "Status",
                DataPropertyName = "Status",
                Width = 120
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "ChefName",
                HeaderText = "Chef Name",
                DataPropertyName = "ChefName",
                Width = 150
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Reservation_Coordinator_Name",
                HeaderText = "Reservation Coordinator",
                DataPropertyName = "Reservation_Coordinator_Name",
                Width = 180
            });

            // Populate filters
            cmbTransactionType.DataSource = AdminClass.GetTransactionTypes();
            cmbMonth.DataSource = AdminClass.GetPaymentMonths();
            cmbUserName.DataSource = AdminClass.GetChefs();

            // Load sales data
            LoadSalesData();
        }


        // Method to load the initial sales data without any filters
        private void LoadSalesData()
        {
            string query = "SELECT p.Payment_ID, p.Payment_date, p.Amount, " +
                   "p.Order_ID, p.Reservation_ID, p.Status, " +
                   "COALESCE(u1.Real_Name, 'N/A') AS ChefName, " +
                   "COALESCE(u2.Real_Name, 'N/A') AS Reservation_Coordinator_Name " +
                   "FROM Payment p " +
                   "LEFT JOIN Chef_InCharge cic ON p.Order_ID = cic.Order_ID " +
                   "LEFT JOIN [User] u1 ON cic.User_ID = u1.User_ID AND u1.Role = 'Chef' " +
                   "LEFT JOIN Reservation r ON p.Reservation_ID = r.Reservation_ID " +
                   "LEFT JOIN [User] u2 ON r.User_ID = u2.User_ID AND u2.Role = 'Reservation Coordinator'";

            // **Pass an empty dictionary since no filters are needed**
            DataTable salesData = AdminClass.GetSalesReportData(query, new Dictionary<string, object>());

            if (salesData.Rows.Count == 0)
            {
                MessageBox.Show("No records found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            dataGridView1.DataSource = salesData;
        }


        // Method to filter sales data based on selected filters
        private void FilterSalesData()
        {
            string selectedTransactionType = cmbTransactionType.SelectedItem?.ToString();
            string selectedMonth = cmbMonth.SelectedItem?.ToString();  // This line gets the month from the ComboBox
            string selectedChef = cmbUserName.SelectedItem?.ToString();


            string query = "SELECT p.Payment_ID, p.Payment_date, p.Amount, " +
                           "p.Order_ID, p.Reservation_ID, p.Status, " +
                           "COALESCE(u1.Real_Name, 'N/A') AS ChefName, " +
                           "COALESCE(u2.Real_Name, 'N/A') AS Reservation_Coordinator_Name " +
                           "FROM Payment p " +
                           "LEFT JOIN Chef_InCharge cic ON p.Order_ID = cic.Order_ID " +
                           "LEFT JOIN [User] u1 ON cic.User_ID = u1.User_ID AND u1.Role = 'Chef' " +
                           "LEFT JOIN Reservation r ON p.Reservation_ID = r.Reservation_ID " +
                           "LEFT JOIN [User] u2 ON r.User_ID = u2.User_ID AND u2.Role = 'Reservation Coordinator' WHERE 1=1";

            // Dictionary to hold SQL parameters
            Dictionary<string, object> sqlParams = new Dictionary<string, object>();

            // Apply transaction type filter
            if (!string.IsNullOrEmpty(selectedTransactionType))
            {
                if (selectedTransactionType == "Order")
                {
                    query += " AND p.Order_ID IS NOT NULL";
                }
                else if (selectedTransactionType == "Reservation")
                {
                    query += " AND p.Reservation_ID IS NOT NULL";
                }
            }

            // Check if selectedMonth has a valid value, then convert it to a month number
            if (!string.IsNullOrEmpty(selectedMonth))
            {
                int monthNumber = GetMonthNumber(selectedMonth);
                if (monthNumber != -1)
                {
                    query += " AND MONTH(p.Payment_date) = @Month";
                    sqlParams["@Month"] = monthNumber; // Assign the month number as a parameter for SQL
                }
            }

            // Apply chef filter
            if (!string.IsNullOrEmpty(selectedChef))
            {
                query += " AND u1.Real_Name = @Chef";
                sqlParams["@Chef"] = selectedChef;
            }

            // Get filtered sales data
            DataTable filteredSalesData = AdminClass.GetSalesReportData(query, sqlParams);

            dataGridView1.DataSource = filteredSalesData;
        }

        private int GetMonthNumber(string monthName)
        {
            Dictionary<string, int> monthMap = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase)
            {
                { "January", 1 }, { "February", 2 }, { "March", 3 },
                { "April", 4 }, { "May", 5 }, { "June", 6 },
                { "July", 7 }, { "August", 8 }, { "September", 9 },
                { "October", 10 }, { "November", 11 }, { "December", 12 }
            };

            return monthMap.TryGetValue(monthName, out int monthNumber) ? monthNumber : -1;
        }

        // ComboBox change event to filter data based on selected values
        private void cmbTransactionType_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterSalesData();
        }

        private void cmbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterSalesData();
        }

        private void cmbUserName_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterSalesData();
        }

        // Reset button event to clear filters and reload all sales data
        private void btnResetSearch_Click_1(object sender, EventArgs e)
        {
            if (cmbTransactionType.Items.Count > 0) cmbTransactionType.SelectedIndex = -1;
            if (cmbMonth.Items.Count > 0) cmbMonth.SelectedIndex = -1;
            if (cmbUserName.Items.Count > 0) cmbUserName.SelectedIndex = -1;

            LoadSalesData();
        }

        // Cancel button event to close the report form
        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            Admin_Homepage adminForm = new Admin_Homepage(currentUserID);
            adminForm.Show();
            this.Close();
        }
    }
}
