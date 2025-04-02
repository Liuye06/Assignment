using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Assignment
{
    public class ReplyRequestDetails
    {
        // Connection string to your database
        private static readonly string connectionString = ConfigurationManager.ConnectionStrings["MyDBConnection"].ConnectionString;

        // Properties representing the columns in the R_Request table
        public int R_Req_ID { get; set; }
        public int User_ID { get; set; }
        public string Request { get; set; }
        public string Function { get; set; }
        public int HeadCount { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime RequestDate { get; set; }
        public string Status { get; set; }

        // Constructor to initialize a reservation
        public ReplyRequestDetails(int r_Req_ID, int user_ID, string request, string function, int headCount, DateTime startDate, DateTime endDate, DateTime requestDate, string status)
        {
            R_Req_ID = r_Req_ID;
            User_ID = user_ID;
            Request = request;
            Function = function;
            HeadCount = headCount;
            StartDate = startDate;
            EndDate = endDate;
            RequestDate = requestDate;
            Status = status;
        }

        // Method to load reservation requests into DataGridView
        public static void LoadReservationsRequest(DataGridView dataGridViewReservations)
        {
            // Make sure the DataGridView is initialized
            if (dataGridViewReservations == null)
            {
                MessageBox.Show("DataGridView is not initialized.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Clear existing columns if any
            dataGridViewReservations.Columns.Clear();

            // Create a connection to the database
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    // Open the connection
                    conn.Open();

                    // Define the SQL query to fetch reservation data
                    string query = @"
                SELECT 
                    R_Req_ID, 
                    User_ID, 
                    Request, 
                    [Function], 
                    Head_Count, 
                    Start_Date, 
                    End_Date, 
                    R_Date, 
                    Status
                FROM
                    [dbo].[R_Request] ";

            // Create a command to execute the query
            using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Execute the command and retrieve the data into a DataReader
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            // Create a DataTable to hold the result set
                            DataTable dataTable = new DataTable();

                            // Load the data from the DataReader into the DataTable
                            dataTable.Load(reader);

                            // Bind the DataTable to the DataGridView
                            dataGridViewReservations.DataSource = dataTable;

                            // Add a ComboBox column to the DataGridView for status selection
                            DataGridViewComboBoxColumn statusColumn = new DataGridViewComboBoxColumn();
                            statusColumn.HeaderText = "Status";
                            statusColumn.Name = "StatusColumn";
                            statusColumn.Items.AddRange("Approved", "Not Approved");
                            dataGridViewReservations.Columns.Add(statusColumn);

                            // Optionally, set the current status in the ComboBox
                            foreach (DataGridViewRow row in dataGridViewReservations.Rows)
                            {
                                row.Cells["StatusColumn"].Value = row.Cells["Status"].Value.ToString(); // Set initial status
                            }

                            // Handle the cell value change event for the ComboBox column
                            dataGridViewReservations.CellValueChanged += (sender, e) =>
                            {
                                if (e.ColumnIndex == dataGridViewReservations.Columns["StatusColumn"].Index && e.RowIndex >= 0)
                                {
                                    string newStatus = dataGridViewReservations.Rows[e.RowIndex].Cells["StatusColumn"].Value.ToString();
                                    int reservationID = Convert.ToInt32(dataGridViewReservations.Rows[e.RowIndex].Cells["R_Req_ID"].Value);

                                    // Call method to update status in the database
                                    UpdateReservationStatus(reservationID, newStatus);
                                }
                            };
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading reservations: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Method to update reservation status in the database
        public static void UpdateReservationStatus(int r_Req_ID, string newStatus)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "UPDATE R_Request SET Status = @Status WHERE R_Req_ID = @R_Req_ID";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Status", newStatus);
                        cmd.Parameters.AddWithValue("@R_Req_ID", r_Req_ID);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Status updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Failed to update status.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating status: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}