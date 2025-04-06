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
    public partial class Customer_Homepage : Form
    {
        private SidebarManager _sidebarManager;
        private int currentUserID; // Store the userID

        public Customer_Homepage(int userID)
        {
            InitializeComponent();
            _sidebarManager = new SidebarManager(this);
            currentUserID = userID; // Store the userID
            UserSessionManager.Login(userID);
        }


        private void btnProfile_Click(object sender, EventArgs e)
        {
            _sidebarManager.NavigateTo(new Customer_Profile(currentUserID));
        }

        private void btnViewOrders_Click(object sender, EventArgs e)
        {
            _sidebarManager.NavigateTo(new Customer_ViewCustomerOrder(currentUserID));
        }

        private void btnViewReplyRequest_Click(object sender, EventArgs e)
        {
            _sidebarManager.NavigateTo(new Customer_ViewCustomerReplyRequest(currentUserID));
        }

        private void btnMakeOrder_Click(object sender, EventArgs e)
        {
            _sidebarManager.NavigateTo(new CustomerMenu(currentUserID));
        }

        private void btnMakeReservation_Click(object sender, EventArgs e)
        {
            _sidebarManager.NavigateTo(new Customer_MakeReservation(currentUserID));
        }

        private void btnViewReservation_Click(object sender, EventArgs e)
        {
            _sidebarManager.NavigateTo(new Customer_ViewReservation(currentUserID));
        }

        private void btnFeedback_Click(object sender, EventArgs e)
        {
            _sidebarManager.NavigateTo(new Customer_Feedback(currentUserID));
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            UserSessionManager.Logout(this);
        }
    }
}
