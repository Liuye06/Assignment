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
    public partial class Chef_Profile : Form
    {
        private SidebarManager _sidebarManager;
        private int currentUserID; // Store the userID

        public Chef_Profile(int userID)
        {
            InitializeComponent();
            _sidebarManager = new SidebarManager(this);
            currentUserID = userID; // Store the userID
            UserSessionManager.Login(userID);

        }

        private void Chef_Profile_Load(object sender, EventArgs e)
        {
            LoadChefProfile(currentUserID);
        }

        public void ReloadChefProfile()
        {
            LoadChefProfile(currentUserID); // Reload the chef profile with the updated data
        }

        private void LoadChefProfile(int loggedInUserID)
        {
            Dictionary<string, object> chefData = ChefProfileDB.GetChefProfile(loggedInUserID);

            if (chefData.Count > 0)
            {
                txtEmail.Text = chefData["Email"].ToString();
                txtName.Text = chefData["Real_Name"].ToString();
                dtpDOB.Value = (DateTime)chefData["DOB"];
                cmbGender.SelectedItem = chefData["Gender"].ToString();
                txtUsername.Text = chefData["Username"].ToString();
                txtPassword.Text = chefData["Password"].ToString(); // Load password

                // Make all fields read-only
                txtEmail.ReadOnly = true;
                txtName.ReadOnly = true;
                txtUsername.ReadOnly = true;
                txtPassword.ReadOnly = true;

                // Disable DateTimePicker and ComboBox
                dtpDOB.Enabled = false;
                cmbGender.Enabled = false;

                if (chefData.ContainsKey("Profile_Pic"))
                {
                    picProfilePic.Image = (Image)chefData["Profile_Pic"];
                }
            }
        }


        private void btnUpdateProfile_Click(object sender, EventArgs e)
        {
            ChefEditProfile updateForm = new ChefEditProfile(currentUserID, this);
            updateForm.Show();
        }

        private void btn_inventory_CProfile_Click(object sender, EventArgs e)
        {
            _sidebarManager.NavigateTo(new Chef(currentUserID));
        }

        private void btn_CusOrder_CProfile_Click(object sender, EventArgs e)
        {
            _sidebarManager.NavigateTo(new ChefCustomerOrder(currentUserID));
        }

        private void btn_ChefProfile_CProfile_Click(object sender, EventArgs e)
        {
            _sidebarManager.NavigateTo(new Chef_Profile(currentUserID));
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            UserSessionManager.Logout(this);
        }
    }
}
