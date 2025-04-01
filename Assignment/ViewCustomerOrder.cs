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


        public ViewCustomerOrder(int userId=7)
        {
            InitializeComponent();
            _sidebarManager = new SidebarManager(this);
            this.userId = userId;
            LoadOrders();
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
            _sidebarManager.NavigateTo(new Customer_Profile());
        }

        private void btnViewOrders_Click(object sender, EventArgs e)
        {
            _sidebarManager.NavigateTo(new ViewCustomerOrder());
        }

        private void btnViewReservations_Click(object sender, EventArgs e)
        {
            _sidebarManager.NavigateTo(new ViewCustomerReservation());
        }

        private void btnMakeOrder_Click(object sender, EventArgs e)
        {
            _sidebarManager.NavigateTo(new CustomerMenu());
        }

        private void btnMakeReservation_Click(object sender, EventArgs e)
        {
            _sidebarManager.NavigateTo(new CustomerMakeAnReservation());
        }

        private void btnMakePayment_Click(object sender, EventArgs e)
        {
            _sidebarManager.NavigateTo(new CustomerPaymentHistory());
        }

        private void btnFeedback_Click(object sender, EventArgs e)
        {
            _sidebarManager.NavigateTo(new CustomerFeedback());
        }
    }
}
