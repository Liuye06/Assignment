using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows.Forms;

namespace Assignment
{
    internal class User
    {
        private string username;
        private string password;

        public User(string username, string password)
        {
            this.username = username;
            this.password = password;
        }

        public string Login(Form loginForm)
        {
            string status = null;
            string connectionString = ConfigurationManager.ConnectionStrings["MyDBConnection"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Check if the user exists
                    string query = "SELECT User_ID, Role FROM [User] WHERE Username = @a AND Password = @b";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@a", username);
                        cmd.Parameters.AddWithValue("@b", password);

                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            int userID = reader.GetInt32(reader.GetOrdinal("User_ID"));
                            string userRole = reader.GetString(reader.GetOrdinal("Role"));

                            Form newForm = null;

                            // Open different forms based on role
                            if (userRole.Equals("admin", StringComparison.OrdinalIgnoreCase))
                                newForm = new Admin(userID);
                            else if (userRole.Equals("chef", StringComparison.OrdinalIgnoreCase))
                                newForm = new ChefHomepage(userID);
                            else if (userRole.Equals("manager", StringComparison.OrdinalIgnoreCase))
                                newForm = new ManagerHomepage(userID);
                            else if (userRole.Equals("Reservation Coordinator", StringComparison.OrdinalIgnoreCase))
                                newForm = new RCMainPage(userID);
                            else if (userRole.Equals("customer", StringComparison.OrdinalIgnoreCase))
                                newForm = new CustomerHomepage(userID);

                            if (newForm != null)
                            {
                                newForm.Show();  // ✅ Use Show() instead of ShowDialog()
                                loginForm.Hide(); // ✅ Hide instead of closing the login form
                            }
                        }
                        else
                        {
                            status = "Incorrect username/password";
                        }
                    }
                }
                catch (Exception ex)
                {
                    status = "Database error: " + ex.Message;
                }
            }
            return status;
        }
    }
}

