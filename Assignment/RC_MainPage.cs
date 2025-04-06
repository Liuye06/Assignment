using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    public partial class RC_MainPage : Form
    {
        private SidebarManager _sidebarManager;
        private int currentUserID; // Store the userID

        public RC_MainPage(int userID)
        {
            InitializeComponent();
            _sidebarManager = new SidebarManager(this);
            currentUserID = userID; // Store the userID
            UserSessionManager.Login(userID);
        }



        private void RCMainPage_Load(object sender, EventArgs e)
        {

        }

        private void btnManageReservation_Click(object sender, EventArgs e)
        {
            _sidebarManager.NavigateTo(new RC_ReservationForm(currentUserID));
        }
        

        private void btnReplyCustomer_Click(object sender, EventArgs e)
        {
            _sidebarManager.NavigateTo(new RC_ReplyRequest(currentUserID));
        }

        private void btnRCProfile_Click(object sender, EventArgs e)
        {
            _sidebarManager.NavigateTo(new RC_Profile(currentUserID));
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            UserSessionManager.Logout(this);
        }
    }
}