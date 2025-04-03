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


        // ✅ Assign an available hall based on start & end time
        private static int? AssignHall(DateTime startDateTime, DateTime endDateTime)
        {
            int? hallID = null;
            string query = @"
            SELECT TOP 1 Hall_ID 
            FROM Hall 
            WHERE Hall_ID NOT IN (
                SELECT Hall_ID FROM Reservation 
                WHERE (@StartDateTime BETWEEN Start_DateTime AND End_DateTime)
                OR (@EndDateTime BETWEEN Start_DateTime AND End_DateTime)
            )
            ORDER BY Hall_ID ASC"; // Pick the first available hall

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@StartDateTime", startDateTime);
                    cmd.Parameters.AddWithValue("@EndDateTime", endDateTime);

                    try
                    {
                        conn.Open();
                        object result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            hallID = Convert.ToInt32(result);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
            return hallID;
        }

        // ✅ Add a reservation (Assigns a hall automatically)
        public static bool AddReservation(int userID, int requestID, DateTime startDateTime, DateTime endDateTime)
        {
            int? hallID = AssignHall(startDateTime, endDateTime);

            if (hallID == null)
            {
                MessageBox.Show("No available hall for the selected date.");
                return false;
            }

            string query = "INSERT INTO Reservation (Hall_ID, User_ID, R_Req_ID, Status) VALUES (@HallID, @UserID, @RequestID, 'Confirmed')";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@HallID", hallID);
                    cmd.Parameters.AddWithValue("@UserID", userID);
                    cmd.Parameters.AddWithValue("@RequestID", requestID);

                    try
                    {
                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                        return false;
                    }
                }
            }
        }

        // ✅ Edit a reservation (Change status)
        public static bool EditReservation(int reservationID, string newStatus)
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
                        return rowsAffected > 0;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                        return false;
                    }
                }
            }
        }

        // ✅ Delete a reservation
        public static bool DeleteReservation(int reservationID)
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
                        return rowsAffected > 0;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                        return false;
                    }
                }
            }
        }

        // ✅ Load reservations into DataGridView
        public static void LoadReservations(DataGridView dgv)
        {
            string query = "SELECT Reservation_ID, Hall_ID, User_ID, R_Req_ID, Status FROM Reservation";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                {
                    DataTable dt = new DataTable();
                    try
                    {
                        conn.Open();
                        adapter.Fill(dt);
                        dgv.DataSource = dt;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }
    }
}