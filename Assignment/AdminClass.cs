using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Assignment
{
    public class MenuManager
    {
        private static readonly string connectionString = ConfigurationManager.ConnectionStrings["myCS"].ConnectionString;

        public static DataTable addCustomerData()
        {
            DataTable dt = new DataTable();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT Email, Real_Name, DOB, Gender, Username,Password,Role FROM User";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading user data: " + ex.Message);
                }
            }

            return dt; // Return the loaded data
        }


        public static bool EditUser(string selectedUser, string selectedField, string newValue)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = $"UPDATE User SET {selectedField} = @NewValue WHERE Real_Name = @UserName AND Role = 'Customer'";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@NewValue", newValue);
                        cmd.Parameters.AddWithValue("@UserName", selectedUser);

                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating user info: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }


        public static bool DeleteUser(string username)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Check if the item exists
                    string checkQuery = "SELECT COUNT(*) FROM User WHERE Username = @Username";
                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@Username", username);
                        int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                        if (count == 0)
                        {
                            return false; // Item does not exist
                        }
                    }

                    // Perform delete operation
                    string deleteQuery = "DELETE FROM User WHERE Username = @Username";
                    using (SqlCommand deleteCmd = new SqlCommand(deleteQuery, conn))
                    {
                        deleteCmd.Parameters.AddWithValue("@Username", username);
                        deleteCmd.ExecuteNonQuery();
                    }

                    return true; // Successfully deleted
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting User: " + ex.Message);
                    return false;
                }
            }
        }


        public static bool addUser(string Real_Name, double DOB, string Gender,string Role, string Email, string Username,string Password)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["myCS"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO User (Real_Name, DOB, Gender, Role, Email, Username, Password) VALUES (@Real_Name, @DOB, @Gender, @Role, @Email, @Username, @Password)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Add("@Real_Name", SqlDbType.NVarChar).Value = Real_Name;
                        cmd.Parameters.Add("@DOB", SqlDbType.NVarChar).Value = DOB;
                        cmd.Parameters.Add("@Gender", SqlDbType.NVarChar).Value =Gender;
                        cmd.Parameters.Add("@Role", SqlDbType.NVarChar).Value =Role;
                        cmd.Parameters.Add("@Email", SqlDbType.NVarChar).Value = Email;
                        cmd.Parameters.Add("@Username", SqlDbType.NVarChar).Value =Username;
                        cmd.Parameters.Add("@Password", SqlDbType.NVarChar).Value =Password;

                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error adding New User: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }


        