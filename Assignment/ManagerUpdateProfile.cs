using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Configuration;

namespace Assignment
{
    public partial class ManagerProfile : Form
    {
        private SidebarManager _sidebarManager;

        public ManagerProfile()
        {
            InitializeComponent();
            _sidebarManager = new SidebarManager(this);
        }


        private void LoadUserProfile(int userID)
        {
            string query = "SELECT Email, Real_Name, DOB, Gender, Username, Profile_Pic FROM User WHERE User_ID = @UserID AND Role = 'Manager'";
            
            string connectionString = ConfigurationManager.ConnectionStrings["MyDBConnection"].ConnectionString;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@UserID", userID);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    txtManagerUsername.Text = reader["Username"].ToString();
                    txtManagerPassword.Text = reader["Password"].ToString();
                    txtManagerName.Text = reader["Name"].ToString();
                    txtMangerEmail.Text = reader["Email"].ToString();
                    dtpDOB.Value = Convert.ToDateTime(reader["DateOfBirth"]);
                    cmbManagerGender.Text = reader["Gender"].ToString();

                    // Load Profile Picture
                    if (reader["ProfilePicture"] != DBNull.Value)
                    {
                        byte[] imageBytes = (byte[])reader["ProfilePicture"];
                        using (MemoryStream ms = new MemoryStream(imageBytes))
                        {
                            picManagerProfilePic.Image = Image.FromStream(ms);
                        }
                    }
                }
                reader.Close();
            }
        }
        private void btnMMenu_UProfile_Click(object sender, EventArgs e)
        {
            _sidebarManager.NavigateTo(new MainManageMenu());
        }

        private void btnMHall_UProfile_Click(object sender, EventArgs e)
        {
            _sidebarManager.NavigateTo(new MainManageHall());
        }

        private void btnHRReport_UProfile_Click(object sender, EventArgs e)
        {
            _sidebarManager.NavigateTo(new MainHallResvReport());
        }

        private void btnUProfile_UProfile_Click(object sender, EventArgs e)
        {
            _sidebarManager.NavigateTo(new ManagerProfile());
        }

        private void btnUpdateManagerProfile_Click(object sender, EventArgs e)
        {

        }

        private void ManagerProfile_Load(object sender, EventArgs e)
        {
            LoadUserProfile(UserID);
        }
    }
}
