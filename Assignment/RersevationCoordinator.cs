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
        private static readonly string connectionString = ConfigurationManager.ConnectionStrings["MyDBConnection"].ConnectionString;

        
        
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
