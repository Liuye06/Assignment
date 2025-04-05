using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Assignment
{
    public class RCProfileDB
    {
        private static readonly string connectionString = ConfigurationManager.ConnectionStrings["MyDBConnection"].ConnectionString;

        // Method to get manager profile data
        public static Dictionary<string, object> GetRCProfile(int userID)
        {
            Dictionary<string, object> rcData = new Dictionary<string, object>();

            string query = "SELECT Email, Real_Name, DOB, Gender, Username, Password, Profile_Pic FROM [User] WHERE User_ID = @UserID AND Role = 'Reservation Coordinator'";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@UserID", userID);

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    rcData["Email"] = reader["Email"].ToString();
                    rcData["Real_Name"] = reader["Real_Name"].ToString();
                    rcData["DOB"] = Convert.ToDateTime(reader["DOB"]);
                    rcData["Gender"] = reader["Gender"].ToString();
                    rcData["Username"] = reader["Username"].ToString(); // Username is loaded but not editable
                    rcData["Password"] = reader["Password"].ToString(); // Load password

                    if (!reader.IsDBNull(reader.GetOrdinal("Profile_Pic")))
                    {
                        byte[] imgData = (byte[])reader["Profile_Pic"];
                        using (MemoryStream ms = new MemoryStream(imgData))
                        {
                            rcData["Profile_Pic"] = Image.FromStream(ms);
                        }
                    }
                }
                reader.Close();
            }

            return rcData;
        }

        // Method to update chef profile (excluding Username)
        public static bool UpdateRCProfile(int userID, string email, string realName, DateTime dob, string gender, string password, byte[] profilePic)
        {
            string query = "UPDATE [User] SET Email = @Email, Real_Name = @RealName, DOB = @DOB, Gender = @Gender, Password = @Password, Profile_Pic = @ProfilePic WHERE User_ID = @UserID";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@RealName", realName);
                cmd.Parameters.AddWithValue("@DOB", dob);
                cmd.Parameters.AddWithValue("@Gender", gender);
                cmd.Parameters.AddWithValue("@Password", password);
                cmd.Parameters.AddWithValue("@UserID", userID);
                cmd.Parameters.AddWithValue("@ProfilePic", (object)profilePic ?? DBNull.Value); // Handle null images

                con.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }
    }
}
