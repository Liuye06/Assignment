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

        public static DataTable LoadHallResvReport()
        {
            DataTable dt = new DataTable();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT" +
                                       "R.Reservation_ID, " +
                                       "H.Hall_Name, " +
                                       "U.User_Name AS Customer, " +
                                       "RR.Function AS Reservation_Type, " +
                                       "RR.Start_Date AS Reservation_Date, " +
                                       "R.Status" +
                                   "FROM Reservations R" +
                                   "JOIN Hall H ON R.Hall_ID = H.Hall_ID" +
                                   "JOIN User U ON R.User_ID = U.User_ID" +
                                   "JOIN Reservation_Requests RR ON R.R_Req_ID = RR.R_Req_ID;";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading hall reservation report: " + ex.Message);
                }
            }

            return dt; // Return the loaded data
        }
    }
}
