using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Windows.Forms;
using System.IO;

namespace Assignment
{
    internal class RersevationCoordinator
    {
        private static readonly string connectionString = ConfigurationManager.ConnectionStrings["myCS"].ConnectionString;
        public static bool UpdateRCProfile(string username, string realName, string dob, string gender, string email, string password)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE [User] SET Real_Name = @Real_Name, DOB = @DOB, Gender = @Gender, Email = @Email, Password = @Password WHERE Username = @Username";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Real_Name", realName);
                    cmd.Parameters.AddWithValue("@DOB", Convert.ToDateTime(dob));
                    cmd.Parameters.AddWithValue("@Gender", gender);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Password", password);
                    cmd.Parameters.AddWithValue("@Username", username);

                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        // update profile
        public static bool UpdateRCProfilePic(string username, string imagePath)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE [User] SET Profile_Pic = @Profile_Pic WHERE Username = @Username";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    byte[] imageBytes = File.ReadAllBytes(imagePath);
                    cmd.Parameters.AddWithValue("@Profile_Pic", imageBytes);

                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
        public static DataTable GetRCData(string username)//get the RC data
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT Real_Name, DOB, Gender, Email, Username, Password, Profile_Pic FROM [User] WHERE Username = @Username";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }
            return dt;
        }
        public static DataTable GetRCData()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT User_ID, Real_Name, Email,DOB, Gender,Role, Username, Password FROM [User] WHERE Role = 'Reservation Coordinator'";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading customer data: " + ex.Message,
                                  "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return dt;
        }
        public static DataTable GetRequestData()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    // Fix: Added square brackets around Function
                    string query = "SELECT R_Req_ID, User_ID, Request, [Function], Head_Count, Start_Date, End_Date, R_Date, Status FROM [R_Request]";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading Request Data: " + ex.Message,
                                  "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return dt;
        }

        public static void RefreshDataGridView(DataGridView dataGridView)
        {
            if (dataGridView == null || dataGridView.IsDisposed) return;

            try
            {
                dataGridView.DataSource = GetRequestData();
                dataGridView.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error refreshing grid: " + ex.Message,
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // get all User_ID excluding duplication
        public static DataTable GetUniqueUserIDs()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT DISTINCT User_ID FROM [R_Request] WHERE Status IS NULL OR Status = ''";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    adapter.Fill(dt);
                }
            }
            return dt;
        }
        public static void UpdateRequestStatus(int userID, string status)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE [R_Request] SET Status = @Status WHERE User_ID = @UserID";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Status", status);
                        cmd.Parameters.AddWithValue("@UserID", userID);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating status: " + ex.Message,
                                  "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        // insect to R_Request database
        public static bool InsertReply(string userID, string status)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO [R_Request] (User_ID, Status) VALUES (@User_ID, @Status)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@User_ID", userID);
                    cmd.Parameters.AddWithValue("@Status", status);
                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public static bool AddReservation(string hallID, string requestID)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO [Reservation] (Hall_ID, R_Req_ID, Status) VALUES (@Hall_ID, @R_Req_ID, 'In Progress')";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Hall_ID", hallID);
                    try
                    {
                        conn.Open();
                        return cmd.ExecuteNonQuery() > 0;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error adding reservation: " + ex.Message,
                                      "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
        }
        public static DataTable GetReservationData()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT Reservation_ID, Hall_ID, User_ID, R_Req_ID, Status FROM [Reservation]";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }

                    if (dt.Rows.Count == 0)
                    {
                        return null; 
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading Reservation Data: " + ex.Message,
                                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return dt;
        }

        public static DataTable GetReservationIDs()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT Reservation_ID FROM [Reservation]";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    adapter.Fill(dt);
                }
            }
            return dt;
        }
        public static bool DeleteReservation(int reservationID)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "DELETE FROM [Reservation] WHERE Reservation_ID = @ReservationID";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ReservationID", reservationID);
                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting reservation: " + ex.Message,
                                  "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }
        public static DataTable GetAvailableHalls()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT Hall_ID, Hall_Name, Capacity, Price_P_Day FROM [Hall] " +
                                  "WHERE Hall_ID NOT IN (SELECT Hall_ID FROM [Reservation])";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading Hall Data: " + ex.Message,
                                  "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return dt;
        }

        public static DataTable GetPendingRequests()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT User_ID, Start_Date FROM [R_Request] " +
                              "WHERE Status = 'In Progress'";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    adapter.Fill(dt);
                }
            }
            return dt;
        }
        public static bool CheckHallAvailability(int hallID)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM [Reservation] WHERE Hall_ID = @HallID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@HallID", hallID);
                    conn.Open();
                    int count = (int)cmd.ExecuteScalar();
                    return count == 0;
                }
            }
        }

        public static bool CheckRequestStatus(int userID)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT Status FROM [R_Request] WHERE User_ID = @UserID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@UserID", userID);
                    conn.Open();
                    string status = (string)cmd.ExecuteScalar();
                    return status == "In Progress";
                }
            }
        }
        public static bool CreateReservation(int hallID, int userID, DateTime startDate)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Check if hall is already reserved
                    if (!CheckHallAvailability(hallID))
                    {
                        MessageBox.Show("This hall is already reserved.", "Error",
                                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }

                    // Check if request status is valid
                    if (!CheckRequestStatus(userID))
                    {
                        MessageBox.Show("The selected request is not in 'In Progress' status.", "Error",
                                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }

                    // Create new reservation
                    string query = "INSERT INTO [Reservation] (Hall_ID, User_ID, R_Req_ID, Status) " +
                                  "VALUES (@HallID, @UserID, " +
                                  "(SELECT R_Req_ID FROM [R_Request] WHERE User_ID = @UserID), 'Booked')";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@HallID", hallID);
                        cmd.Parameters.AddWithValue("@UserID", userID);
                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error creating reservation: " + ex.Message,
                                  "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }
    }
}
