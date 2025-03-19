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
    public class MenuManager
    {
        private static readonly string connectionString = ConfigurationManager.ConnectionStrings["MyDBConnection"].ConnectionString;

        public static DataTable LoadMenuData()
        {
            DataTable dt = new DataTable();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT Item, Image, Price, Category FROM Menu";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading menu data: " + ex.Message);
                }
            }

            return dt; // Return the loaded data
        }


        public static bool UpdateMenuItem(string originalItem, string newItem, string price, string category)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE Menu SET Item = @NewMenuItem, Price = @Price, Category = @Category WHERE Item = @OriginalMenuItem";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@NewMenuItem", newItem);
                        cmd.Parameters.AddWithValue("@Price", price);
                        cmd.Parameters.AddWithValue("@Category", category);
                        cmd.Parameters.AddWithValue("@OriginalMenuItem", originalItem);
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating menu item: " + ex.Message);
                    return false;
                }
            }
        }

        public static bool DeleteMenuItem(string menuItem)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Check if the item exists
                    string checkQuery = "SELECT COUNT(*) FROM Menu WHERE Item = @MenuItem";
                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@MenuItem", menuItem);
                        int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                        if (count == 0)
                        {
                            return false; // Item does not exist
                        }
                    }

                    // Perform delete operation
                    string deleteQuery = "DELETE FROM Menu WHERE Item = @MenuItem";
                    using (SqlCommand deleteCmd = new SqlCommand(deleteQuery, conn))
                    {
                        deleteCmd.Parameters.AddWithValue("@MenuItem", menuItem);
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


        public static bool AddMenuItem(string itemName, byte[] image, decimal price, string category)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MyDBConnection"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO Menu (Item, Image, Price, Category) VALUES (@Item, @Image, @Price, @Category)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Add("@Item", SqlDbType.NVarChar).Value = itemName;
                        cmd.Parameters.Add("@Image", SqlDbType.VarBinary).Value = (object)image ?? DBNull.Value; // Handles null images
                        cmd.Parameters.Add("@Price", SqlDbType.Decimal).Value = price;
                        cmd.Parameters.Add("@Category", SqlDbType.NVarChar).Value = category;

                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error adding menu item: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }


        public static DataRow GetMenuItem(string menuItem)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MyDBConnection"].ConnectionString;
            DataTable dt = new DataTable();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT Item, Price, Category, Image FROM Menu WHERE Item = @MenuItem";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MenuItem", menuItem);

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(dt);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error retrieving menu item: " + ex.Message);
                    return null;
                }
            }

            return dt.Rows.Count > 0 ? dt.Rows[0] : null; // Return first row or null if not found
        }
    }
}
    
