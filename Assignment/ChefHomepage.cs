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
    public partial class ChefHomepage : Form
    {
        private SidebarManager _sidebarManager;
        private int currentUserID; // Store the userID

        public ChefHomepage(int userID)
        {
            InitializeComponent();
            _sidebarManager = new SidebarManager(this);
            currentUserID = userID; // Store the userID
            UserSessionManager.Login(userID);
        }

        private void btninventory_ChefCustomerOrder_Click(object sender, EventArgs e)
        {
            _sidebarManager.NavigateTo(new Chef(currentUserID));
        }

        private void btnCusOrder_ChefCustomerOrder_Click(object sender, EventArgs e)
        {
            _sidebarManager.NavigateTo(new ChefCustomerOrder(currentUserID));
        }

        private void btnChefProfile_ChefCustomerOrder_Click(object sender, EventArgs e)
        {
            _sidebarManager.NavigateTo(new Chef_Profile(currentUserID));
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            UserSessionManager.Logout(this);
        }

        private void tableSidebar_ChefCustomerOrder_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ChefHomepage_Load(object sender, EventArgs e)
        {

        }
    }
}
