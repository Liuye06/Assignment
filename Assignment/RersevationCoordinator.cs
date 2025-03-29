using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class RersevationCoordinator
    {
        private static readonly string connectionString = ConfigurationManager.ConnectionStrings["myCS"].ConnectionString;
        public static bool UpdateRCProfile(string username, string realName, string dob, string gender, string email, string password)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE [User] SET Real_Name = @Real_Name, DOB = @DOB, Gender = @Gender, Email = @Email, Password = @Password WHERE Username = @Username";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Real_Name", realName);
                    cmd.Parameters.AddWithValue("@DOB", Convert.ToDateTime(dob));
                    cmd.Parameters.AddWithValue("@Gender", gender);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Password", password);
                    cmd.Parameters.AddWithValue("@Username", username);

                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        // update profile
        public static bool UpdateRCProfilePic(string username, string imagePath)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE [User] SET Profile_Pic = @Profile_Pic WHERE Username = @Username";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Username", username);

                    byte[] imageBytes = File.ReadAllBytes(imagePath);
                    cmd.Parameters.AddWithValue("@Profile_Pic", imageBytes);

                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
    }
}
