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

        public static DataTable GetCustomerData()// get the new data of Customers
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

        public static bool AddUser(string realName, DateTime dob, string gender, string email,
                                 string role, string username, string password, DataGridView dataGridView)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"INSERT INTO [User] (Real_Name, DOB, Gender, Email, Role, Username, Password) 
                                VALUES (@Real_Name, @DOB, @Gender, @Email, @Role, @Username, @Password)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Add("@Real_Name", SqlDbType.NVarChar).Value = realName;
                        cmd.Parameters.Add("@DOB", SqlDbType.DateTime).Value = dob;
                        cmd.Parameters.Add("@Gender", SqlDbType.NVarChar).Value = gender;
                        cmd.Parameters.Add("@Email", SqlDbType.NVarChar).Value = email;
                        cmd.Parameters.Add("@Role", SqlDbType.NVarChar).Value = role;
                        cmd.Parameters.Add("@Username", SqlDbType.NVarChar).Value = username;
                        cmd.Parameters.Add("@Password", SqlDbType.NVarChar).Value = password;

                        bool success = cmd.ExecuteNonQuery() > 0;
                        if (success && dataGridView != null)
                        {
                            RefreshDataGridView(dataGridView);
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
        public static List<string> GetStaffRoles()
        {
            return new List<string> { "Admin", "Chef", "Manager", "Reservation Coordinator" };
        }

        public static bool AddStaff(string realName, DateTime dob, string gender, string email,
                                  string role, string username, string password, DataGridView dataGridView)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"INSERT INTO [User] (Real_Name, DOB, Gender, Email, Role, Username, Password) 
                                VALUES (@Real_Name, @DOB, @Gender, @Email, @Role, @Username, @Password)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Add("@Real_Name", SqlDbType.NVarChar).Value = realName;
                        cmd.Parameters.Add("@DOB", SqlDbType.DateTime).Value = dob;
                        cmd.Parameters.Add("@Gender", SqlDbType.NVarChar).Value = gender;
                        cmd.Parameters.Add("@Email", SqlDbType.NVarChar).Value = email;
                        cmd.Parameters.Add("@Role", SqlDbType.NVarChar).Value = role;
                        cmd.Parameters.Add("@Username", SqlDbType.NVarChar).Value = username;
                        cmd.Parameters.Add("@Password", SqlDbType.NVarChar).Value = password;

                        bool success = cmd.ExecuteNonQuery() > 0;
                        if (success && dataGridView != null)
                        {
                            RefreshDataGridView(dataGridView);
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
        public static bool IsUsernameAvailable(string username) // Validate if username already exists
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM [User] WHERE Username = @Username";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", username);
                        return (int)cmd.ExecuteScalar() == 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error checking username: " + ex.Message, "Database Error",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }
        //  after edit refresh the DataGridView
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
                        RefreshDataGridView(dataGridView);
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
        public static bool DeleteUser(string user_Id, DataGridView dataGridView)//refresh DataGridView after delete user
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

                    string deleteQuery = "DELETE FROM [User] WHERE User_ID = @UserID";
                    using (SqlCommand deleteCmd = new SqlCommand(deleteQuery, conn))
                    {
                        deleteCmd.Parameters.AddWithValue("@UserID", user_Id);
                        bool success = deleteCmd.ExecuteNonQuery() > 0;
                        if (success)
                        {
                            RefreshDataGridView(dataGridView);
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
        public static void RefreshDataGridView(DataGridView dataGridView)
        {
            if (dataGridView == null || dataGridView.IsDisposed) return;

            try
            {
                dataGridView.DataSource = GetCustomerData();
                dataGridView.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error refreshing grid: " + ex.Message, "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static void LoadCustomers(ListBox listBox)
        {
            if (listBox == null || listBox.IsDisposed) return;

            try
            {
                listBox.Invoke((MethodInvoker)delegate
                {
                    listBox.Items.Clear();
                    DataTable dt = GetCustomerData();
                    if (dt == null) return;

                    foreach (DataRow row in dt.Rows)
                    {
                        string displayText = $"{row["User_ID"]} - {row["Real_Name"]}";
                        listBox.Items.Add(new ListItem(displayText, row["User_ID"].ToString()));
                    }
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading customers: " + ex.Message,
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static DataTable GetCustomerFeedbacks()//admin see cus feedback
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT Feedback_ID, Order_ID, Feedback FROM [Table]";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading feedback data: " + ex.Message,
                                  "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return dt;
        }

        public static void ConfigureFeedbackGridView(DataGridView dataGridView)
        {
            if (dataGridView == null) return;

            try
            {
                dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView.ReadOnly = true;
                dataGridView.AllowUserToAddRows = false;
                dataGridView.AllowUserToDeleteRows = false;
                dataGridView.RowHeadersVisible = false;
                dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                if (dataGridView.Columns.Contains("Feedback_ID"))
                    dataGridView.Columns["Feedback_ID"].HeaderText = "Feedback ID";
                if (dataGridView.Columns.Contains("Order_ID"))
                    dataGridView.Columns["Order_ID"].HeaderText = "Order ID";
                if (dataGridView.Columns.Contains("Feedback"))
                    dataGridView.Columns["Feedback"].HeaderText = "Customer Feedback";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error configuring grid view: " + ex.Message,
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static DataTable GetStaffDataByRole(string role)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query;
                    if (string.IsNullOrEmpty(role))
                    {
                        query = "SELECT User_ID, Email, Real_Name, DOB, Gender FROM [User] WHERE Role IN ('Admin', 'Manager', 'Chef', 'Reservation Coordinator')";
                    }
                    else
                    {
                        query = "SELECT User_ID, Email, Real_Name, DOB, Gender FROM [User] WHERE Role = @Role";
                    }

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        if (!string.IsNullOrEmpty(role))
                        {
                            cmd.Parameters.AddWithValue("@Role", role);
                        }
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(dt);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading staff data: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return dt;
        }
        public static void RefreshStaffGridView(DataGridView dataGridView, string role)
        {
            if (dataGridView == null || dataGridView.IsDisposed) return;

            try
            {
                dataGridView.DataSource = GetStaffDataByRole(role);
                dataGridView.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error refreshing grid: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void LoadStaff(ListBox listBox) // for load the staff role
        {
            if (listBox == null || listBox.IsDisposed) return;
            try
            {
                listBox.Invoke((MethodInvoker)delegate
                {
                    listBox.Items.Clear();
                    DataTable dt = GetStaffDataByRole(""); // Pass empty string or specific role if needed
                    if (dt == null) return;

                    foreach (DataRow row in dt.Rows)
                    {
                        string displayText = $"{row["User_ID"]} - {row["Real_Name"]}";
                        listBox.Items.Add(new ListItem(displayText, row["User_ID"].ToString()));
                    }
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading staff: " + ex.Message,
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
        
