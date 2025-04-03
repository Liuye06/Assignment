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

        public ReservationDetails(int r_Req_ID, DateTime startDate, DateTime endDate, int totalDays, string function, string request, int headCount, DateTime requestDate, string status)
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
                        RR.Status
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

                            reservationList.Add(new ReservationDetails(r_Req_ID, startDate, endDate, totalDays, function, request, headCount, requestDate, status));
                        }
                    }
                }
            }

            return reservationList;
        }
    }
}


