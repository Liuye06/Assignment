using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    public class ReservationManager
    {
        private static readonly string connectionString = ConfigurationManager.ConnectionStrings["MyDBConnection"].ConnectionString;

        public void LoadHalls(ComboBox comboBox)
        {
            string query = "SELECT Hall_ID, Hall_Name, Capacity FROM Hall";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    try
                    {
                        conn.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            DataTable dt = new DataTable();
                            dt.Load(reader);

                            // Add a new column for display
                            dt.Columns.Add("Display", typeof(string), "Hall_Name + ' (Capacity: ' + Capacity + ')'");

                            comboBox.DataSource = dt;
                            comboBox.DisplayMember = "Display";
                            comboBox.ValueMember = "Hall_ID";
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }

        // Method to load reservations into DataGridView
        public void LoadReservations(DataGridView dgv)
        {
            string query = @"
                SELECT 
                    r.Reservation_ID, 
                    u.Real_Name, 
                    r.Hall_ID, 
                    h.Hall_Name, 
                    r.Status, 
                    rr.Head_Count
                FROM 
                    Reservation r
                JOIN 
                    [User] u ON r.User_ID = u.User_ID
                LEFT JOIN 
                    Hall h ON r.Hall_ID = h.Hall_ID
                JOIN 
                    R_Request rr ON r.R_Req_ID = rr.R_Req_ID";

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

        // Method to update reservation status
        public bool UpdateReservationStatus(int reservationID, string newStatus)
        {
            string query = "UPDATE Reservation SET Status = @Status WHERE Reservation_ID = @ReservationID";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Status", newStatus);
                    cmd.Parameters.AddWithValue("@ReservationID", reservationID);

                    try
                    {
                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0; // Return true if update was successful
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                        return false;
                    }
                }
            }
        }

        // Method to assign hall
        public bool AssignHall(int reservationID, int hallID)
        {
            // Fetch the R_Req_ID from the Reservation table
            int requestID = GetRequestID(reservationID);

            if (requestID == -1)
            {
                MessageBox.Show("Failed to fetch request ID.");
                return false;
            }

            // Fetch the Start_Date and End_Date from the R_Request table
            (DateTime startDate, DateTime endDate) = GetRequestDates(requestID);

            if (startDate == DateTime.MinValue || endDate == DateTime.MinValue)
            {
                MessageBox.Show("Failed to fetch request dates.");
                return false;
            }

            if (!IsHallAvailable(hallID, startDate, endDate))
            {
                MessageBox.Show("The selected hall is already booked for the specified dates.");
                return false;
            }

            string query = "UPDATE Reservation SET Hall_ID = @Hall_ID WHERE Reservation_ID = @ReservationID";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Hall_ID", hallID);
                    cmd.Parameters.AddWithValue("@ReservationID", reservationID);

                    try
                    {
                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0; // Return true if update was successful
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                        return false;
                    }
                }
            }
        }

        private int GetRequestID(int reservationID)
        {
            string query = "SELECT R_Req_ID FROM Reservation WHERE Reservation_ID = @ReservationID";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ReservationID", reservationID);

                    try
                    {
                        conn.Open();
                        object result = cmd.ExecuteScalar();
                        return result != null ? Convert.ToInt32(result) : -1;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                        return -1;
                    }
                }
            }
        }

        private (DateTime, DateTime) GetRequestDates(int requestID)
        {
            string query = "SELECT Start_Date, End_Date FROM R_Request WHERE R_Req_ID = @RequestID";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@RequestID", requestID);

                    try
                    {
                        conn.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                DateTime startDate = reader.GetDateTime(0);
                                DateTime endDate = reader.GetDateTime(1);
                                return (startDate, endDate);
                            }
                            else
                            {
                                return (DateTime.MinValue, DateTime.MinValue);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                        return (DateTime.MinValue, DateTime.MinValue);
                    }
                }
            }
        }

        // Method to check hall availability
        public bool IsHallAvailable(int hallID, DateTime startDate, DateTime endDate)
        {
            string query = @"
                SELECT COUNT(*) 
                FROM Reservation r
                JOIN R_Request rr ON r.R_Req_ID = rr.R_Req_ID
                WHERE r.Hall_ID = @Hall_ID 
                AND ((rr.Start_Date <= @EndDate AND rr.End_Date >= @StartDate))";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Hall_ID", hallID);
                    cmd.Parameters.AddWithValue("@StartDate", startDate);
                    cmd.Parameters.AddWithValue("@EndDate", endDate);

                    try
                    {
                        conn.Open();
                        int count = (int)cmd.ExecuteScalar();
                        return count == 0; // Return true if no overlapping reservations
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                        return false;
                    }
                }
            }
        }

        // Method to add delete button column
        public void AddDeleteButtonColumn(DataGridView dgv)
        {
            DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();
            deleteButtonColumn.Name = "Delete";
            deleteButtonColumn.HeaderText = "Delete";
            deleteButtonColumn.Text = "Delete";
            deleteButtonColumn.UseColumnTextForButtonValue = true;
            dgv.Columns.Add(deleteButtonColumn);
        }

        // Method to delete reservation
        public bool DeleteReservation(int reservationID)
        {
            string query = "DELETE FROM Reservation WHERE Reservation_ID = @ReservationID";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ReservationID", reservationID);

                    try
                    {
                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0; // Return true if deletion was successful
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                        return false;
                    }
                }
            }
        }
    }
}


