using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;
using Assignment;

namespace Assignment
{
    public class AdminClass
    {
        private static readonly string connectionString = ConfigurationManager.ConnectionStrings["MyDBConnection"].ConnectionString;

        public static bool DeleteUser(string userId, DataGridView dataGridView = null)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string checkQuery = "SELECT COUNT(*) FROM [User] WHERE User_ID = @User_ID";
                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@User_ID", userId);
                        int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                        if (count == 0)
                        {
                            MessageBox.Show("User not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return false;
                        }
                    }
                    string deleteQuery = "DELETE FROM [User] WHERE User_ID = @User_ID";
                    using (SqlCommand deleteCmd = new SqlCommand(deleteQuery, conn))
                    {
                        deleteCmd.Parameters.AddWithValue("@User_ID", userId);
                        bool success = deleteCmd.ExecuteNonQuery() > 0;

                        if (success)
                        {
                            MessageBox.Show("Customer deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if (dataGridView != null)
                            {
                                RefreshDataGridView(dataGridView);
                            }
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

        public static DataTable GetCustomerData()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT User_ID, Real_Name, Email,DOB, Gender,Role, Username, Password FROM [User] WHERE Role = 'Customer'";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading customer data: " + ex.Message,
                                  "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return dt;
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
                MessageBox.Show("Error refreshing grid: " + ex.Message,
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static void LoadCustomers(ListBox listBox)
        {
            listBox.Items.Clear();
            var dt = GetCustomerData();

            foreach (DataRow row in dt.Rows)
            {
                // Verify this creates proper ListItem objects
                listBox.Items.Add(new ListItem(
                    $"{row["User_ID"]} - {row["Real_Name"]}",
                    row["User_ID"].ToString()
                ));
            }
        }
        public static DataTable GetCustomerFeedbacks()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT Feedback_ID, Order_ID, Feedback FROM [Feedback]";
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
                    string query = "SELECT User_ID, Real_Name, Email, DOB, Gender, Role, Username, Password FROM [User]";

                    if (!string.IsNullOrEmpty(role))
                    {
                        query += " WHERE Role = @Role";
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

        public static void RefreshStaffGridView(DataGridView dataGridView, string role = "")
        {
            if (dataGridView == null || !dataGridView.IsHandleCreated) return; // Ensure it's ready

            string query = "SELECT User_ID, Real_Name, Email, DOB, Gender, Role, Username, Password FROM [User]";

            if (!string.IsNullOrEmpty(role) && role != "All")
            {
                query += " WHERE Role = @Role";
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);

                    if (!string.IsNullOrEmpty(role) && role != "All")
                    {
                        cmd.Parameters.AddWithValue("@Role", role);
                    }

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    if (dataGridView.InvokeRequired)
                    {
                        dataGridView.Invoke((MethodInvoker)delegate {
                            dataGridView.DataSource = dt;
                            dataGridView.Refresh();
                        });
                    }
                    else
                    {
                        dataGridView.DataSource = dt;
                        dataGridView.Refresh();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading staff: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public static void LoadStaff(ListBox listBox)
        {
            if (listBox == null || listBox.IsDisposed) return;

            try
            {
                listBox.Invoke((MethodInvoker)delegate
                {
                    listBox.Items.Clear();
                    DataTable dt = GetStaffDataByRole(""); 

                    if (dt == null || dt.Rows.Count == 0) return;

                    foreach (DataRow row in dt.Rows)
                    {
                        string displayText = $"{row["User_ID"]} - {row["Real_Name"]} | {row["Email"]} | {row["DOB"]} | {row["Gender"]} | {row["Role"]} | {row["Username"]} | {row["Password"]}";
                        listBox.Items.Add(displayText);
                    }
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading staff: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public static List<string> GetStaffNamesByRole(string role)
        {
            List<string> staffNames = new List<string>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT Real_Name FROM [User] WHERE Role = @Role";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Role", role);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                staffNames.Add(reader["Real_Name"].ToString());
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading staff names: " + ex.Message,
                                  "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return staffNames;
        }


        public static bool DeleteStaffById(string selectedItem)
        {
            // Extract User_ID from the format "User_ID - Real_Name"
            string[] parts = selectedItem.Split(new[] { " - " }, 2, StringSplitOptions.None);
            if (parts.Length < 2) return false; // Prevents error if format is wrong

            int userId;
            if (!int.TryParse(parts[0], out userId))
            {
                MessageBox.Show("Invalid User ID format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand("DELETE FROM [User] WHERE User_ID = @UserId", conn))
            {
                cmd.Parameters.AddWithValue("@UserId", userId);

                try
                {
                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting staff: " + ex.Message,
                                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }

        public static List<string> GetAllStaffNames()
        {
            List<string> staffEntries = new List<string>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand("SELECT User_ID, Real_Name FROM [User]", conn))
            {
                try
                {
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Format: "User_ID - Real_Name"
                            string displayText = $"{reader["User_ID"]} - {reader["Real_Name"]}";
                            staffEntries.Add(displayText);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error retrieving staff names: " + ex.Message,
                                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return staffEntries;
        }


        public static List<string> GetEditableFields()
        {
            return new List<string> { "Real_Name", "DOB", "Gender", "Email", "Username" };
        }
        public static bool UpdateStaffInfo(string realName, string field, string newValue, DataGridView dataGridView)
        {
            HashSet<string> allowedFields = new HashSet<string> { "Real_Name", "DOB", "Gender", "Email", "Username" };

            if (!allowedFields.Contains(field))
            {
                MessageBox.Show("Invalid field update attempt!", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(
                $"UPDATE [User] SET {field} = @NewValue WHERE Real_Name = @RealName", conn))
            {
                cmd.Parameters.AddWithValue("@NewValue", newValue);
                cmd.Parameters.AddWithValue("@RealName", realName);

                try
                {
                    conn.Open();
                    bool success = cmd.ExecuteNonQuery() > 0;
                    if (success && dataGridView != null)
                    {
                        RefreshDataGridView(dataGridView);
                    }
                    return success;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error updating {field}: {ex.Message}",
                                   "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }
        public static Dictionary<string, string> GetStaffDetails(string realName)
        {
            var details = new Dictionary<string, string>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(
                "SELECT Real_Name, DOB, Gender, Email, Username FROM [User] WHERE Real_Name = @RealName", conn))
            {
                cmd.Parameters.AddWithValue("@RealName", realName);

                try
                {
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            details["Real_Name"] = reader["Real_Name"].ToString();
                            details["DOB"] = reader["DOB"].ToString();
                            details["Gender"] = reader["Gender"].ToString();
                            details["Email"] = reader["Email"].ToString();
                            details["Username"] = reader["Username"].ToString();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading staff details: {ex.Message}",
                                   "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return details;
        }

        // load admin data
        public static DataTable GetAdminData(int userID)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT Real_Name, DOB, Gender, Email, Username, Password, Profile_Pic FROM [User] WHERE User_ID = @UserID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@UserID", userID);
                    try
                    {
                        conn.Open();
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(dt);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            return dt;
        }


        // update admin info excluding profile
        public static bool UpdateAdminProfile(int userID, string username, string realName, string dob, string gender, string email, string password)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE [User] SET Real_Name = @Real_Name, DOB = @DOB, Gender = @Gender, Email = @Email, Password = @Password, Username = @Username WHERE User_ID = @User_ID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Real_Name", realName);
                    cmd.Parameters.AddWithValue("@DOB", Convert.ToDateTime(dob));
                    cmd.Parameters.AddWithValue("@Gender", gender);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Password", password);
                    cmd.Parameters.AddWithValue("@Username", username); // Include username update
                    cmd.Parameters.AddWithValue("@User_ID", userID); // Use User_ID to identify the record

                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        // update admin profile
        public static bool UpdateAdminProfilePic(int userID, string imagePath)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE [User] SET Profile_Pic = @Profile_Pic WHERE User_ID = @UserID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@UserID", userID);

                    byte[] imageBytes = File.ReadAllBytes(imagePath);
                    cmd.Parameters.AddWithValue("@Profile_Pic", imageBytes);

                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public static List<string> GetMenuItems()
        {
            List<string> menuItems = new List<string>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT Item FROM Menu";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        menuItems.Add(reader["Item"].ToString());
                    }
                }
            }
            return menuItems;
        }

        public static List<string> GetPaymentMonths()
        {
            List<string> months = new List<string>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT DISTINCT MONTH(Payment_Date) AS Month FROM Payment";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        months.Add(reader["Month"].ToString());
                    }
                }
            }
            return months;
        }

        public static List<string> GetMenuCategories()
        {
            List<string> categories = new List<string>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT DISTINCT Category FROM Menu";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        categories.Add(reader["Category"].ToString());
                    }
                }
            }
            return categories;
        }

        public static List<string> GetChefs()
        {
            List<string> chefs = new List<string>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT DISTINCT u.Real_Name " +
                       "FROM Chef_InCharge cic " +
                       "INNER JOIN [User] u ON cic.User_ID = u.User_ID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        chefs.Add(reader["Real_Name"].ToString());
                    }
                }
            }
            return chefs;
        }
    }
}
        
