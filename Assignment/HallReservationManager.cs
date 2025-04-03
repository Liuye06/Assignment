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
    public class HallReservationManager
    {
        private static readonly string connectionString = ConfigurationManager.ConnectionStrings["MyDBConnection"].ConnectionString;

        public List<Reservation> LoadReservations()
        {
            List<Reservation> reservations = new List<Reservation>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"
                    SELECT rr.Start_Date, u.Real_Name AS CustomerName, h.Hall_Name, rr.[Function], r.Status
                    FROM Reservation r
                    JOIN R_Request rr ON r.R_Req_ID = rr.R_Req_ID
                    JOIN [User] u ON rr.User_ID = u.User_ID
                    JOIN Hall h ON r.Hall_ID = h.Hall_ID";

                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Reservation reservation = new Reservation
                    {
                        StartDate = reader.GetDateTime(0),
                        CustomerName = reader.GetString(1),
                        HallName = reader.GetString(2),
                        Function = reader.GetString(3),
                        Status = reader.GetString(4)
                    };
                    reservations.Add(reservation);
                }
            }

            return reservations;
        }
    }
}
