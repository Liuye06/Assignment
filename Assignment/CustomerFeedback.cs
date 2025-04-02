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
    public partial class CustomerFeedback : Form
    {
        private SidebarManager _sidebarManager;
        private int currentUserId;

        public CustomerFeedback(int userId)
        {
            InitializeComponent();
            this.currentUserId = userId;
            _sidebarManager = new SidebarManager(this);
            UserSessionManager.Login(userId);
        }

        private void btn_SubmitFeedback_Click(object sender, EventArgs e)
        {

        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            _sidebarManager.NavigateTo(new Customer_Profile(currentUserId));
        }

        private void btnViewOrders_Click(object sender, EventArgs e)
        {
            _sidebarManager.NavigateTo(new ViewCustomerOrder(currentUserId));
        }

        private void btnViewReservations_Click(object sender, EventArgs e)
        {
            _sidebarManager.NavigateTo(new ViewCustomerReservation(currentUserId));
        }

        private void btnMakeReservation_Click(object sender, EventArgs e)
        {
            _sidebarManager.NavigateTo(new CustomerMakeAnReservation(currentUserId));
        }

        private void btnMakePayment_Click(object sender, EventArgs e)
        {
            _sidebarManager.NavigateTo(new CustomerPaymentHistory());
        }

        private void btnFeedback_Click(object sender, EventArgs e)
        {
            _sidebarManager.NavigateTo(new CustomerFeedback(currentUserId));
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            UserSessionManager.Logout(this);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }
    }
}
