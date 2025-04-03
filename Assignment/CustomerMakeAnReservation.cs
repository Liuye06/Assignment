using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    public partial class CustomerMakeAnReservation : Form
    {
        private SidebarManager _sidebarManager;
        private int currentUserId;

        public CustomerMakeAnReservation(int userId)
        {
            InitializeComponent();
            this.currentUserId = userId;
            _sidebarManager = new SidebarManager(this);
            UserSessionManager.Login(userId);
        }

        private void btn_SendReq_Click(object sender, EventArgs e)
        {
            // Get input values
            DateTime startDate = monthCalendarStart.SelectionStart;
            DateTime endDate = monthCalendarEnd.SelectionStart; // Capture end date
            string selectedFunction = cmbFunction.SelectedItem?.ToString();
            string requestDetails = txtRequest.Text.Trim();
            int headCount = (int)numHeadCount.Value;
            DateTime requestDate = DateTime.Now;

            // Validation
            if (string.IsNullOrEmpty(selectedFunction))
            {
                MessageBox.Show("Please select a function!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (headCount <= 0)
            {
                MessageBox.Show("Head count must be greater than 0!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int totalDays = (endDate - startDate).Days;

            // Show Confirmation Dialog with Details
            string confirmationMessage = $"Confirm Reservation Details:\n\n" +
                                         $"📅 Start Date: {startDate:yyyy-MM-dd}\n" +
                                         $"📅 End Date: {endDate:yyyy-MM-dd}\n" +
                                         $"📌 Total Days: {totalDays}\n" +
                                         $"👥 Head Count: {headCount}\n" +
                                         $"🎉 Function: {selectedFunction}\n" +
                                         $"🕒 Request Date: {requestDate:yyyy-MM-dd HH:mm:ss}\n\n" +
                                         $"Do you want to proceed?";

            DialogResult result = MessageBox.Show(confirmationMessage, "Confirm Reservation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Call ReservationManager to insert into the database
                bool success = CustomerReservationManager.SubmitReservation(currentUserId, requestDetails, selectedFunction, headCount, startDate, endDate);

                if (success)
                {
                    MessageBox.Show("Reservation request submitted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFields();
                }
            }
        }

        private void ClearFields()
        {
            txtRequest.Text = "";
            numHeadCount.Value = 0;
            cmbFunction.SelectedIndex = -1; // Reset selection
        }

        private void CustomerMakeAnReservation_Load(object sender, EventArgs e)
        {
            // Set the minimum selectable start date (today + 3 days)
            monthCalendarStart.MinDate = DateTime.Today.AddDays(3);

            // Ensure the end date is at least the start date by default
            monthCalendarEnd.MinDate = monthCalendarStart.MinDate.AddDays(1);
        }

        private void monthCalendarStart_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime selectedStartDate = e.Start;

            // Ensure user selects at least 3 days ahead
            if (selectedStartDate < DateTime.Today.AddDays(3))
            {
                MessageBox.Show("Start date must be at least 3 days from today!", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                monthCalendarStart.SetDate(DateTime.Today.AddDays(3));  // Reset selection
            }

            // Update the minimum selectable end date
            monthCalendarEnd.MinDate = monthCalendarStart.SelectionStart.AddDays(1);
        }

        private void monthCalendarEnd_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime selectedEndDate = e.Start;

            // Ensure end date is after start date
            if (selectedEndDate <= monthCalendarStart.SelectionStart)
            {
                MessageBox.Show("End date must be after the start date!", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                monthCalendarEnd.SetDate(monthCalendarStart.SelectionStart.AddDays(1));  // Reset selection
            }
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

        private void btnMakeOrder_Click(object sender, EventArgs e)
        {
            _sidebarManager.NavigateTo(new CustomerMenu(currentUserId));
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
    }
}
