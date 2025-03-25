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
    public class ChefManager
    {
        private static readonly string connectionString = ConfigurationManager.ConnectionStrings["MyDBConnection"].ConnectionString;

        public static DataTable LoadChefData()
        {
            DataTable dt = new DataTable();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT Ingredient, Stock FROM Stock";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading inventory data: " + ex.Message);
                }
            }

            return dt; // Return the loaded data
        }

        public static bool UpdateChefData(string originalIngredient, string newIngredient, string stock)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE Stock SET Ingredient = @NewIngredient, Stock = @Stock WHERE Stock = @OriginalIngredient";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@NewIngredient", stock);
                        cmd.Parameters.AddWithValue("@Stock", newIngredient);
                        cmd.Parameters.AddWithValue("@OriginalIngredient", originalIngredient);
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

        public static bool DeleteChefData(string ingredient)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Check if the item exists
                    string checkQuery = "SELECT COUNT(*) FROM Stock WHERE Ingredient = @Ingredient";
                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@Ingredient", ingredient);
                        int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                        if (count == 0)
                        {
                            return false; // Item does not exist
                        }
                    }

                    // Perform delete operation
                    string deleteQuery = "DELETE FROM Stock WHERE Ingredient = @Ingredient";
                    using (SqlCommand deleteCmd = new SqlCommand(deleteQuery, conn))
                    {
                        deleteCmd.Parameters.AddWithValue("@Ingredient", ingredient);
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


        public static bool AddChefData(string ingredient, int stock)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MyDBConnection"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO Stock (Ingredient, Stock) VALUES (@Ingredient, @Stock)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Ingredient", ingredient);
                        cmd.Parameters.AddWithValue("@Stock", stock);
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error adding inventory data: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }


        public static DataRow GetChefData(string ingredient)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MyDBConnection"].ConnectionString;
            DataTable dt = new DataTable();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT Ingredient, Stock FROM Stock WHERE Ingredient = @Ingredient";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Ingredient", ingredient);

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(dt);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error retrieving inventory data: " + ex.Message);
                    return null;
                }
            }

            return dt.Rows.Count > 0 ? dt.Rows[0] : null; // Return first row or null if not found
        }
    }
}
