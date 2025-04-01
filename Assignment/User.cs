using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

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

        public string Login()
        {
            string status = "Incorrect username/password"; // Default message
            string connectionString = ConfigurationManager.ConnectionStrings["MyDBConnection"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT Role FROM [User] WHERE Username = @a AND Password = @b";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@a", username);
                        cmd.Parameters.AddWithValue("@b", password);

                        object result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            string userRole = result.ToString().ToLower(); // Normalize case
                            status = "Success";

                            // Open the correct form based on role
                            if (userRole == "admin")
                            {
                                Admin adminForm = new Admin(username);
                                adminForm.Show();
                            }
                            else if (userRole == "customer")
                            {
                                CustomerHomepage customerForm = new CustomerHomepage(username);
                                customerForm.Show();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Database error: " + ex.Message); // Log the error
                    status = "Database connection error. Please try again.";
                }
            }

            return status;
        }
    }
}

