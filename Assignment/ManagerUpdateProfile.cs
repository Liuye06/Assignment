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
        private int currentUserID; // Store the userID

        public ManagerProfile(int userID)
        {
            InitializeComponent();
            _sidebarManager = new SidebarManager(this);
            currentUserID = userID; // Store the userID
            UserSessionManager.Login(userID);
        }

        private void ManagerProfile_Load(object sender, EventArgs e)
        {
            LoadManagerProfile(currentUserID);
        }


        public void ReloadManagerProfile()
        {
            LoadManagerProfile(currentUserID); // Reload the manager profile with the updated data
        }

        private void LoadManagerProfile(int loggedInUserID)
        {
            Dictionary<string, object> managerData = ManagerProfileDB.GetManagerProfile(loggedInUserID);

            if (managerData.Count > 0)
            {
                txtMangerEmail.Text = managerData["Email"].ToString();
                txtManagerName.Text = managerData["Real_Name"].ToString();
                dtpDOB.Value = (DateTime)managerData["DOB"];
                cmbManagerGender.SelectedItem = managerData["Gender"].ToString();
                txtManagerUsername.Text = managerData["Username"].ToString();
                txtManagerPassword.Text = managerData["Password"].ToString(); // Load password

                // Make all fields read-only
                txtMangerEmail.ReadOnly = true;
                txtManagerName.ReadOnly = true;
                txtManagerUsername.ReadOnly = true;
                txtManagerPassword.ReadOnly = true;

                // Disable DateTimePicker and ComboBox
                dtpDOB.Enabled = false;
                cmbManagerGender.Enabled = false;

                if (managerData.ContainsKey("Profile_Pic"))
                {
                    picManagerProfilePic.Image = (Image)managerData["Profile_Pic"];
                }
            }
        }

        private void btnUpdateManagerProfile_Click(object sender, EventArgs e)
        {
            // Open the UpdateManagerProfileForm when the update button is clicked
            ManagerEditProfile updateForm = new ManagerEditProfile(currentUserID, this);
            updateForm.Show();
        }

        private void btnMMenu_UProfile_Click(object sender, EventArgs e)
        {
            _sidebarManager.NavigateTo(new MainManageMenu(currentUserID));
        }

        private void btnMHall_UProfile_Click(object sender, EventArgs e)
        {
            _sidebarManager.NavigateTo(new MainManageHall(currentUserID));
        }

        private void btnHRReport_UProfile_Click(object sender, EventArgs e)
        {
            _sidebarManager.NavigateTo(new MainHallResvReport(currentUserID));
        }

        private void btnUProfile_UProfile_Click(object sender, EventArgs e)
        {
            _sidebarManager.NavigateTo(new ManagerProfile(currentUserID));
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            UserSessionManager.Logout(this);
        }
    }
}
