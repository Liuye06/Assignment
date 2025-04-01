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
    public class ReservationDetails
    {
        private static readonly string connectionString = ConfigurationManager.ConnectionStrings["MyDBConnection"].ConnectionString;

        public int R_Req_ID { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int TotalDays { get; set; }
        public string Function { get; set; }
        public string Request { get; set; }
        public int HeadCount { get; set; }
        public DateTime RequestDate { get; set; }
        public string Status { get; set; }
        public string HallID { get; set; } // Nullable, will be assigned only when approved

        public ReservationDetails(int r_Req_ID, DateTime startDate, DateTime endDate, int totalDays, string function, string request, int headCount, DateTime requestDate, string status, string hallID)
        {
            R_Req_ID = r_Req_ID;
            StartDate = startDate;
            EndDate = endDate;
            TotalDays = totalDays;
            Function = function;
            Request = request;
            HeadCount = headCount;
            RequestDate = requestDate;
            Status = status;
            HallID = hallID;
        }

        // Fetch reservations with R_Req_ID and Hall_ID (if approved)
        public static List<ReservationDetails> GetReservations(int userId)
        {
            List<ReservationDetails> reservationList = new List<ReservationDetails>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"
                    SELECT 
                        RR.R_Req_ID,
                        RR.Start_Date,
                        RR.End_Date,
                        DATEDIFF(day, RR.Start_Date, RR.End_Date) AS TotalDays,
                        RR.[Function],
                        RR.Request,
                        RR.Head_Count,
                        RR.R_Date AS Request_Date,
                        RR.Status,
                        ISNULL(R.Hall_ID, '-') AS Hall_ID  -- Show '-' if Hall_ID is NULL
                    FROM [dbo].[R_Request] RR
                    LEFT JOIN [dbo].[Reservation] R ON RR.R_Req_ID = R.R_Req_ID
                    WHERE RR.User_ID = @UserID;";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@UserID", userId);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int r_Req_ID = reader.GetInt32(0);
                            DateTime startDate = reader.GetDateTime(1);
                            DateTime endDate = reader.GetDateTime(2);
                            int totalDays = reader.GetInt32(3);
                            string function = reader.GetString(4);
                            string request = reader.IsDBNull(5) ? "" : reader.GetString(5);
                            int headCount = reader.GetInt32(6);
                            DateTime requestDate = reader.GetDateTime(7);
                            string status = reader.GetString(8);
                            string hallID = reader.IsDBNull(9) ? "-" : reader.GetInt32(9).ToString();

                            reservationList.Add(new ReservationDetails(r_Req_ID, startDate, endDate, totalDays, function, request, headCount, requestDate, status, hallID));
                        }
                    }
                }
            }

            return reservationList;
        }

        // Approve a reservation request and insert into Reservation table
        public static bool ApproveReservation(int r_Req_ID, int hallID)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlTransaction transaction = conn.BeginTransaction())
                    {
                        try
                        {
                            // Update R_Request status to 'Approved'
                            string updateRequestQuery = "UPDATE R_Request SET Status = 'Approved' WHERE R_Req_ID = @R_Req_ID";
                            using (SqlCommand cmdUpdate = new SqlCommand(updateRequestQuery, conn, transaction))
                            {
                                cmdUpdate.Parameters.AddWithValue("@R_Req_ID", r_Req_ID);
                                cmdUpdate.ExecuteNonQuery();
                            }

                            // Insert into Reservation table
                            string insertReservationQuery = @" INSERT INTO Reservation (Hall_ID, User_ID, R_Req_ID, Status) 
                                                                SELECT @HallID, User_ID, @R_Req_ID, 'Approved' 
                                                                FROM R_Request 
                                                                WHERE R_Req_ID = @R_Req_ID";
                            using (SqlCommand cmdInsert = new SqlCommand(insertReservationQuery, conn, transaction))
                            {
                                cmdInsert.Parameters.AddWithValue("@HallID", hallID);
                                cmdInsert.Parameters.AddWithValue("@R_Req_ID", r_Req_ID);
                                cmdInsert.ExecuteNonQuery();
                            }

                            transaction.Commit();
                            return true;
                        }
                        catch
                        {
                            transaction.Rollback();
                            throw;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error approving reservation: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}


