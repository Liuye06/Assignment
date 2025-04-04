using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace Assignment
{
    public class RequestHandler
    {
        private static readonly string connectionString = ConfigurationManager.ConnectionStrings["MyDBConnection"].ConnectionString;

        public void LoadRequests(DataGridView dgv)
        {
            string query = "SELECT R_Req_ID, User_ID, Request, [Function], Head_Count, Start_Date, End_Date, R_Date, Status FROM R_Request";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                {
                    DataTable dt = new DataTable();
                    try
                    {
                        conn.Open();
                        adapter.Fill(dt);
                        dgv.DataSource = dt; // Bind data to DataGridView
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }

        public bool UpdateRequestStatus(int requestID, string newStatus)
        {
            string query = "UPDATE R_Request SET Status = @Status WHERE R_Req_ID = @RequestID";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Status", newStatus);
                    cmd.Parameters.AddWithValue("@RequestID", requestID);

                    try
                    {
                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0; // Return true if update was successful
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                        return false;
                    }
                }
            }
        }

        public bool AddToReservation(int? hallID, int userID, int requestID, string status)
        {
            string query = "INSERT INTO Reservation (Hall_ID, User_ID, R_Req_ID, Status) VALUES (@Hall_ID, @User_ID, @R_Req_ID, @Status)";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Hall_ID", (object)hallID ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@User_ID", userID);
                    cmd.Parameters.AddWithValue("@R_Req_ID", requestID);
                    cmd.Parameters.AddWithValue("@Status", status);

                    try
                    {
                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0; // Success
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}");
                        return false;
                    }
                }
            }
        }

        public bool CheckIfRequestExistsInReservation(int requestID)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM Reservation WHERE Request_ID = @RequestID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@RequestID", requestID);
                    conn.Open();
                    int count = (int)cmd.ExecuteScalar();
                    return count > 0; // If count > 0, request already exists
                }
            }
        }
    }
}


