using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Assignment
{
    public partial class RCProfile : Form
    {
        private SidebarManager _sidebarManager;
        private int currentUserID; // Store the userID

        public RCProfile(int userID)
        {
            InitializeComponent();
            _sidebarManager = new SidebarManager(this);
            currentUserID = userID; // Store the userID
            UserSessionManager.Login(userID);
        }


        private void RCProfile_Load(object sender, EventArgs e)
        {
            LoadRCProfile(currentUserID);
        }

        public void ReloadRCProfile()
        {
            LoadRCProfile(currentUserID); 
        }

        private void LoadRCProfile(int loggedInUserID)
        {
            Dictionary<string, object> rcData = RCProfileDB.GetRCProfile(loggedInUserID);

            if (rcData.Count > 0)
            {
                txtEmail.Text = rcData["Email"].ToString();
                txtName.Text = rcData["Real_Name"].ToString();
                dtpDOB.Value = (DateTime)rcData["DOB"];
                cmbGender.SelectedItem = rcData["Gender"].ToString();
                txtUsername.Text = rcData["Username"].ToString();
                txtPassword.Text = rcData["Password"].ToString(); // Load password

                // Make all fields read-only
                txtEmail.ReadOnly = true;
                txtName.ReadOnly = true;
                txtUsername.ReadOnly = true;
                txtPassword.ReadOnly = true;

                // Disable All
                txtEmail.Enabled = false;
                txtName.Enabled = false;
                txtUsername.Enabled = false;
                txtPassword.Enabled = false;
                dtpDOB.Enabled = false;
                cmbGender.Enabled = false;

                if (rcData.ContainsKey("Profile_Pic"))
                {
                    picProfilePic.Image = (Image)rcData["Profile_Pic"];
                }
            }
        }

        private void btnUpdateProfile_Click_1(object sender, EventArgs e)
        {
            RCEditProfile updateForm = new RCEditProfile(currentUserID, this);
            updateForm.Show();
        }

        private void btnManageReservation_Click(object sender, EventArgs e)
        {
            _sidebarManager.NavigateTo(new ReservationForm(currentUserID));
        }

        private void btnReplyCustomer_Click(object sender, EventArgs e)
        {
            _sidebarManager.NavigateTo(new ReplyRequest(currentUserID));
        }

        private void btnRCProfile_Click(object sender, EventArgs e)
        {
            _sidebarManager.NavigateTo(new RCProfile(currentUserID));
        }

        private void btnLogOut_Click_1(object sender, EventArgs e)
        {
            UserSessionManager.Logout(this);
        }
    }
}
    
