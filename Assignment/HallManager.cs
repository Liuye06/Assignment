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
    public class HallManager
    {
        private static readonly string connectionString = ConfigurationManager.ConnectionStrings["MyDBConnection"].ConnectionString;

        public static DataTable LoadHallData()
        {
            DataTable dt = new DataTable();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT Hall_Name, Capacity, Price_P_Day FROM Hall";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading hall data: " + ex.Message);
                }
            }

            return dt; // Return the loaded data
        }

        public static bool UpdateHallData(string originalHall, string newHall, string capacity, string price)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE Hall SET Hall_Name = @NewHallName, Capacity = @Capacity, Price_P_Day = @Price WHERE Hall_Name = @OriginalHallName";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@NewHallName", newHall);
                        cmd.Parameters.AddWithValue("@Capacity", capacity);
                        cmd.Parameters.AddWithValue("@Price", price);
                        cmd.Parameters.AddWithValue("@OriginalHallName", originalHall);
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating hall name: " + ex.Message);
                    return false;
                }
            }
        }

        public static bool DeleteHallData(string hallName)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Check if the item exists
                    string checkQuery = "SELECT COUNT(*) FROM Hall WHERE Hall_Name = @HallName";
                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@HallName", hallName);
                        int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                        if (count == 0)
                        {
                            return false; // Item does not exist
                        }
                    }

                    // Perform delete operation
                    string deleteQuery = "DELETE FROM Hall WHERE Hall_Name = @HallName";
                    using (SqlCommand deleteCmd = new SqlCommand(deleteQuery, conn))
                    {
                        deleteCmd.Parameters.AddWithValue("@HallName", hallName);
                        deleteCmd.ExecuteNonQuery();
                    }

                    return true; // Successfully deleted
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting item: " + ex.Message);
                    return false;
                }
            }
        }


        public static bool AddHallData(string hallName, int capacity, decimal price)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MyDBConnection"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO Hall (Hall_Name, Capacity, Price_P_Day) VALUES (@Hall_Name, @Capacity, @Price_P_Day)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Hall_Name", hallName);
                        cmd.Parameters.AddWithValue("@Capacity", capacity);
                        cmd.Parameters.AddWithValue("@Price_P_Day", price);

                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error adding hall data: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }


        public static DataRow GetHallData(string hallName)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MyDBConnection"].ConnectionString;
            DataTable dt = new DataTable();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT Hall_Name, Capacity, Price_P_Day FROM Hall WHERE Hall_Name = @HallName";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@HallName", hallName);

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(dt);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error retrieving hall data: " + ex.Message);
                    return null;
                }
            }

            return dt.Rows.Count > 0 ? dt.Rows[0] : null; // Return first row or null if not found
        }
    }
}
