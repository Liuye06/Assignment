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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Assignment
{
    public partial class CustomerViewReservation : Form
    {
        private SidebarManager _sidebarManager;
        private int currentUserID; // Store the userID
        private ViewCustomerReservationNPayment viewCustomerReservationNPayment ;

        public CustomerViewReservation(int userID)
        {
            InitializeComponent();
            _sidebarManager = new SidebarManager(this);
            currentUserID = userID; // Store the userID
            viewCustomerReservationNPayment = new ViewCustomerReservationNPayment();
            UserSessionManager.Login(userID);

            // Initialize ListView and load data
            InitializeListView();
            LoadData();
        }


        private void InitializeListView()
        {
            listView_ReservationRequest.Columns.Add("Reservation ID", -2, HorizontalAlignment.Left);
            listView_ReservationRequest.Columns.Add("Customer Name", -2, HorizontalAlignment.Left);
            listView_ReservationRequest.Columns.Add("Hall ID", -2, HorizontalAlignment.Left);
            listView_ReservationRequest.Columns.Add("Hall Name", -2, HorizontalAlignment.Left);
            listView_ReservationRequest.Columns.Add("Status", -2, HorizontalAlignment.Left);
            listView_ReservationRequest.Columns.Add("Head Count", -2, HorizontalAlignment.Left);
            listView_ReservationRequest.Columns.Add("Total Price", -2, HorizontalAlignment.Left);
            listView_ReservationRequest.Columns.Add("Payment Status", -2, HorizontalAlignment.Left);
            listView_ReservationRequest.Columns.Add("Start Date", -2, HorizontalAlignment.Left);
            listView_ReservationRequest.Columns.Add("End Date", -2, HorizontalAlignment.Left);
        }

        private void LoadData()
        {
            viewCustomerReservationNPayment.LoadDataWithPaymentStatus(listView_ReservationRequest, currentUserID);
        }


        private void btnProfile_Click(object sender, EventArgs e)
        {
            _sidebarManager.NavigateTo(new Customer_Profile(currentUserID));
        }

        private void btnViewOrders_Click(object sender, EventArgs e)
        {
            _sidebarManager.NavigateTo(new ViewCustomerOrder(currentUserID));
        }

        private void btnViewReplyRequest_Click(object sender, EventArgs e)
        {
            _sidebarManager.NavigateTo(new ViewCustomerReplyRequest(currentUserID));
        }

        private void btnViewReservation_Click(object sender, EventArgs e)
        {
            _sidebarManager.NavigateTo(new CustomerViewReservation(currentUserID));
        }

        private void btnMakeReservation_Click(object sender, EventArgs e)
        {
            _sidebarManager.NavigateTo(new CustomerMakeAnReservation(currentUserID));
        }

        private void btnMakeOrder_Click(object sender, EventArgs e)
        {
            _sidebarManager.NavigateTo(new CustomerMenu(currentUserID));
        }

        private void btnFeedback_Click(object sender, EventArgs e)
        {
            _sidebarManager.NavigateTo(new CustomerFeedback(currentUserID));
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            UserSessionManager.Logout(this);
        }

        private void btnMakePayment_Click(object sender, EventArgs e)
        {
            if (listView_ReservationRequest.SelectedItems.Count > 0)
            {
                // Get the Reservation ID and Payment Status from the selected row
                string reservationId = listView_ReservationRequest.SelectedItems[0].SubItems[0].Text;
                string paymentStatus = listView_ReservationRequest.SelectedItems[0].SubItems[7].Text;

                // Check if the payment is already made or not
                if (paymentStatus.ToLower() == "paid")
                {
                    MessageBox.Show("Payment has already been made for this reservation.");
                    return;
                }

                // Proceed with the payment if not already paid
                ConfirmAndPay(reservationId);
            }
            else
            {
                MessageBox.Show("Please select a reservation to make a payment.");
            }
        }

        private void ConfirmAndPay(string reservationId)
        {
            try
            {
                // Fetch the selected reservation details directly from the ListView
                ListViewItem selectedItem = listView_ReservationRequest.SelectedItems[0];

                string selectedReservationId = selectedItem.SubItems[0].Text;
                string hallName = selectedItem.SubItems[3].Text;
                string pricePerDayText = selectedItem.SubItems[5].Text; // Assuming this is the Price_P_Day column

                // Fetch Start and End Dates from the Tag property as DateTime
                DateTime startDate = (DateTime)selectedItem.SubItems[8].Tag;  // Start Date stored in Tag
                DateTime endDate = (DateTime)selectedItem.SubItems[9].Tag;    // End Date stored in Tag

                string paymentStatus = selectedItem.SubItems[7].Text; // Payment Status column

                if (selectedReservationId != reservationId)
                {
                    MessageBox.Show("The reservation ID doesn't match the selected reservation.");
                    return;
                }

                // Validate price per day
                decimal pricePerDay;
                if (!decimal.TryParse(pricePerDayText, out pricePerDay))
                {
                    MessageBox.Show("Invalid price per day.");
                    return;
                }

                // Calculate the total price based on price per day and the number of days between start and end dates
                TimeSpan duration = endDate - startDate;
                decimal totalPrice = pricePerDay * duration.Days;

                // Check if the reservation has already been paid
                if (paymentStatus.ToLower() == "paid")
                {
                    MessageBox.Show("Payment has already been made for this reservation.");
                    return;
                }

                // Proceed with payment
                ProcessPayment(selectedReservationId, totalPrice);

                // Update the payment status to 'Paid' in the ListView directly
                selectedItem.SubItems[7].Text = "Paid"; // Update Payment Status in the ListView

                // Refresh the data to reflect the updated payment status
                MessageBox.Show("Payment successful for Reservation ID: " + selectedReservationId);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error processing payment: " + ex.Message);
            }
        }

        private void ProcessPayment(string reservationId, decimal amount)
        {
            var paymentDate = DateTime.Now;
            string status = "Paid";

            try
            {
                // Call method to insert payment record
                viewCustomerReservationNPayment.InsertPayment(paymentDate, amount, Convert.ToInt32(reservationId), status);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while processing the payment: " + ex.Message);
            }
        }
    }
}
