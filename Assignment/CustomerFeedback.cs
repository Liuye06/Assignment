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
            _sidebarManager.NavigateTo(new ViewCustomerReplyRequest(currentUserId));
        }

        private void btnMakeReservation_Click(object sender, EventArgs e)
        {
            _sidebarManager.NavigateTo(new CustomerMakeAnReservation(currentUserId));
        }

        private void btnMakePayment_Click(object sender, EventArgs e)
        {
            _sidebarManager.NavigateTo(new CustomerViewReservation());
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
            int orderId;
            if (int.TryParse(txtSearchOrder.Text, out orderId))
            {
                OrderFeedback feedbackHandler = new OrderFeedback();
                feedbackHandler.SearchOrderFeedback(orderId, listViewOrder); // Call function to filter ListView
            }
            else
            {
                MessageBox.Show("Please enter a valid Order ID.");
            }
        }

        private void btn_SubmitFeedback_Click(object sender, EventArgs e)
        {
            if (listViewOrder.SelectedItems.Count > 0 && !string.IsNullOrWhiteSpace(txt_Feedback.Text))
            {
                int orderId = int.Parse(listViewOrder.SelectedItems[0].SubItems[0].Text); 

                OrderFeedback feedbackHandler = new OrderFeedback();
                if (feedbackHandler.SubmitFeedback(orderId, txt_Feedback.Text))
                {
                    MessageBox.Show("Feedback submitted successfully.");

                    // ✅ Refresh the ListView to show the updated feedback
                    feedbackHandler.LoadOrders(listViewOrder);
                }
                else
                {
                    MessageBox.Show("Error submitting feedback.");
                }
            }
            else
            {
                MessageBox.Show("Please select an order and enter feedback.");
            }
        }

        private void CustomerFeedback_Load(object sender, EventArgs e)
        {
            listViewOrder.View = View.Details;
            listViewOrder.FullRowSelect = true;
            listViewOrder.GridLines = true;

            listViewOrder.Columns.Clear();
            listViewOrder.Columns.Add("Order ID", 100);
            listViewOrder.Columns.Add("Item Name", 150); 
            listViewOrder.Columns.Add("Feedback", 300);

            OrderFeedback feedbackHandler = new OrderFeedback();
            feedbackHandler.LoadOrders(listViewOrder);
        }

        private void btnResetSearch_Click(object sender, EventArgs e)
        {
            txtSearchOrder.Text = ""; // Clear search box
            listViewOrder.Items.Clear(); // Clear list
            OrderFeedback feedbackHandler = new OrderFeedback();
            feedbackHandler.LoadOrders(listViewOrder); // Reload all orders
        }
    }
}
