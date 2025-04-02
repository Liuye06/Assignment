using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace Assignment
{
    public partial class ViewCustomerOrder : Form
    {
        private SidebarManager _sidebarManager;
        private int userId;
        private string connectionString = ConfigurationManager.ConnectionStrings["MyDBConnection"].ConnectionString;


        public ViewCustomerOrder(int userID)
        {
            InitializeComponent();
            _sidebarManager = new SidebarManager(this);
            this.userId = userID;
            LoadOrders();
            UserSessionManager.Login(userID);
        }


        private void LoadOrders()
        {
            // Fetch order details
            List<OrderDetails> orders = OrderDetails.GetOrderDetails(userId, connectionString);

            if (orders.Count == 0)
            {
                MessageBox.Show("No orders found!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Populate ListView
            foreach (var order in orders)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    order.OrderID.ToString(),
                    order.FoodName,
                    order.Status,
                    order.TotalPrice.ToString("F2") // Format to 2 decimal places
                });

                listView_OrderHistory.Items.Add(item);
            }
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            _sidebarManager.NavigateTo(new Customer_Profile(userId));
        }

        private void btnViewOrders_Click(object sender, EventArgs e)
        {
            _sidebarManager.NavigateTo(new ViewCustomerOrder(userId));
        }

        private void btnViewReservations_Click(object sender, EventArgs e)
        {
            _sidebarManager.NavigateTo(new ViewCustomerReservation(userId));
        }

        private void btnMakeOrder_Click(object sender, EventArgs e)
        {
            _sidebarManager.NavigateTo(new CustomerMenu(userId));
        }

        private void btnMakeReservation_Click(object sender, EventArgs e)
        {
            _sidebarManager.NavigateTo(new CustomerMakeAnReservation(userId));
        }

        private void btnMakePayment_Click(object sender, EventArgs e)
        {
            _sidebarManager.NavigateTo(new CustomerPaymentHistory());
        }

        private void btnFeedback_Click(object sender, EventArgs e)
        {
            _sidebarManager.NavigateTo(new CustomerFeedback(userId));
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            UserSessionManager.Logout(this);
        }
    }
}
