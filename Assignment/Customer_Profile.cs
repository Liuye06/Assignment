using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    public partial class Customer_Profile : Form
    {
        private SidebarManager _sidebarManager;
        private int currentUserID; // Store the userID

        public Customer_Profile(int userID)
        {
            InitializeComponent();
            _sidebarManager = new SidebarManager(this);
            currentUserID = userID; // Store the userID
            UserSessionManager.Login(userID);
        }


        private void btnUpdateProfile_Click(object sender, EventArgs e)
        {

        }

        private void Customer_Profile_Load(object sender, EventArgs e)
        {
            LoadCustomerProfile(currentUserID);
        }

        public void ReloadCustomerProfile()
        {
            LoadCustomerProfile(currentUserID); // Reload the chef profile with the updated data
        }

        private void LoadCustomerProfile(int loggedInUserID)
        {
            Dictionary<string, object> cusData = CustomerProfileDB.GetCusProfile(loggedInUserID);

            if (cusData.Count > 0)
            {
                txtEmail.Text = cusData["Email"].ToString();
                txtName.Text = cusData["Real_Name"].ToString();
                dtpDOB.Value = (DateTime)cusData["DOB"];
                cmbGender.SelectedItem = cusData["Gender"].ToString();
                txtUsername.Text = cusData["Username"].ToString();
                txtPassword.Text = cusData["Password"].ToString(); // Load password

                // Make all fields read-only
                txtEmail.ReadOnly = true;
                txtName.ReadOnly = true;
                txtUsername.ReadOnly = true;
                txtPassword.ReadOnly = true;

                // Disable DateTimePicker and ComboBox
                dtpDOB.Enabled = false;
                cmbGender.Enabled = false;

                if (cusData.ContainsKey("Profile_Pic"))
                {
                    picProfilePic.Image = (Image)cusData["Profile_Pic"];
                }
            }
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {

        }
    }
}
