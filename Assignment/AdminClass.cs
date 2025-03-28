using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Assignment
{
    public class AdminClass
    {
        private static readonly string connectionString = ConfigurationManager.ConnectionStrings["myCS"].ConnectionString;

        // get the new data of Customers 
        public static DataTable GetCustomerData()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT User_ID, Real_Name FROM [User] WHERE Role = 'Customer'";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading customer data: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return dt;
        }

        // 📌 after add user refresh DataGridView
        public static bool AddUser(string realName, DateTime dob, string gender, string email, string username, string password, DataGridView dataGridView)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"
                        INSERT INTO [User] (Real_Name, DOB, Gender, Email, Username, Password) 
                        VALUES (@Real_Name, @DOB, @Gender,@Email, @Username, @Password)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Add("@Real_Name", SqlDbType.NVarChar).Value = realName;
                        cmd.Parameters.Add("@DOB", SqlDbType.DateTime).Value = dob;
                        cmd.Parameters.Add("@Gender", SqlDbType.NVarChar).Value = gender;
                        cmd.Parameters.Add("@Email", SqlDbType.NVarChar).Value = email;
                        cmd.Parameters.Add("@Username", SqlDbType.NVarChar).Value = username;
                        cmd.Parameters.Add("@Password", SqlDbType.NVarChar).Value = password;

                        bool success = cmd.ExecuteNonQuery() > 0;
                        if (success)
                        {
                            RefreshCustomerGrid(dataGridView); 
                        }
                        return success;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error adding user: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }

        // 📌 after edit refresh the DataGridView
        public static bool EditUser(string user_Id, string field, string newValue, DataGridView dataGridView)
        {
            HashSet<string> allowedFields = new HashSet<string> { "Real_Name", "DOB", "Gender", "Email", "Username" };

            if (!allowedFields.Contains(field))
            {
                MessageBox.Show("Invalid field update attempt!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            string query = $"UPDATE [User] SET {field} = @value WHERE User_ID = @user_Id";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@value", newValue);
                cmd.Parameters.AddWithValue("@user_Id", user_Id);

                try
                {
                    conn.Open();
                    bool success = cmd.ExecuteNonQuery() > 0;
                    if (success)
                    {
                        RefreshCustomerGrid(dataGridView); 
                    }
                    return success;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating user: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }

        // 📌 refresh DataGridView after delete user
        public static bool DeleteUser(string user_Id, DataGridView dataGridView)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string checkQuery = "SELECT COUNT(*) FROM [User] WHERE User_ID = @User_ID";
                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@User_ID", user_Id);
                        int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                        if (count == 0)
                        {
                            MessageBox.Show("User not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return false;
                        }
                    }

                    string deleteQuery = "DELETE FROM [User] WHERE UserID = @UserID";
                    using (SqlCommand deleteCmd = new SqlCommand(deleteQuery, conn))
                    {
                        deleteCmd.Parameters.AddWithValue("@UserID", user_Id);
                        bool success = deleteCmd.ExecuteNonQuery() > 0;
                        if (success)
                        {
                            RefreshCustomerGrid(dataGridView); 
                        }
                        return success;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting user: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }

        // refresh the DataGridView
        public static void RefreshCustomerGrid(DataGridView dataGridView)
        {
            dataGridView.DataSource = GetCustomerData();
        }
        public static void LoadCustomers(ListBox listBox)
        {
            listBox.Items.Clear();
            DataTable dt = GetCustomerData();

            foreach (DataRow row in dt.Rows)
            {
                string displayText = $"{row["User_ID"]} - {row["Real_Name"]}";
                listBox.Items.Add(new ListItem(displayText, row["User_ID"].ToString()));
            }
        }

    }
}

