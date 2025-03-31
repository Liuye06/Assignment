using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    public class CustomerReservationManager
    {
        private static readonly string connectionString = ConfigurationManager.ConnectionStrings["MyDBConnection"].ConnectionString;


        public static bool SubmitReservation(int userId, string request, string function, int headCount, DateTime startDate, DateTime endDate)
        {
            DateTime requestDate = DateTime.Now;
            string status = "Pending"; // Default status

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"INSERT INTO R_Request (User_ID, Request, [Function], Head_Count, Start_Date, End_Date, R_Date, Status) 
                                     VALUES (@UserId, @Request, @Function, @HeadCount, @StartDate, @EndDate, @RDate, @Status)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@UserId", userId);
                        cmd.Parameters.AddWithValue("@Request", string.IsNullOrEmpty(request) ? (object)DBNull.Value : request);
                        cmd.Parameters.AddWithValue("@Function", function);
                        cmd.Parameters.AddWithValue("@HeadCount", headCount);
                        cmd.Parameters.AddWithValue("@StartDate", startDate);
                        cmd.Parameters.AddWithValue("@EndDate", endDate);
                        cmd.Parameters.AddWithValue("@RDate", requestDate);
                        cmd.Parameters.AddWithValue("@Status", status);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving reservation: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
