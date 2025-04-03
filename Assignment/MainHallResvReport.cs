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
    public partial class MainHallResvReport : Form
    {
        private SidebarManager _sidebarManager;
        private int currentUserID; // Store the userID

        public MainHallResvReport(int userID)
        {
            InitializeComponent();
            _sidebarManager = new SidebarManager(this);
            currentUserID = userID; // Store the userID
            UserSessionManager.Login(userID);
        }

        private void btnMMenu_HRReport_Click(object sender, EventArgs e)
        {
            _sidebarManager.NavigateTo(new MainManageMenu(currentUserID));
        }

        private void btnMHall_HRReport_Click(object sender, EventArgs e)
        {
            _sidebarManager.NavigateTo(new MainManageHall(currentUserID));
        }

        private void btnHRReport_HRReport_Click(object sender, EventArgs e)
        {
            _sidebarManager.NavigateTo(new MainHallResvReport(currentUserID));
        }

        private void btnUProfile_HRReport_Click(object sender, EventArgs e)
        {
            _sidebarManager.NavigateTo(new ManagerProfile(currentUserID));
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            UserSessionManager.Logout(this);
        }

        private void btnExport_Click(object sender, EventArgs e)
        {

        }
    }
}
