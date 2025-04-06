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
    public partial class Customer_ViewCustomerReplyRequest : Form
    {
        private SidebarManager _sidebarManager;
        private int userId; // Assuming this is passed or set somewhere in the form


        public Customer_ViewCustomerReplyRequest(int userID)
        {
            InitializeComponent();
            _sidebarManager = new SidebarManager(this); 
            this.userId = userID;
            LoadReservations(); // Automatically load reservations when form opens
            UserSessionManager.Login(userID);
        }


        private void LoadReservations()
        {
            listView_ReservationRequest.View = View.Details;
            listView_ReservationRequest.FullRowSelect = true;
            listView_ReservationRequest.GridLines = true;

            // Clear previous columns and items
            listView_ReservationRequest.Columns.Clear();
            listView_ReservationRequest.Items.Clear();

            // Add columns
            listView_ReservationRequest.Columns.Add("Request ID", 80, HorizontalAlignment.Center); // New column for R_Req_ID
            listView_ReservationRequest.Columns.Add("Start Date", 100, HorizontalAlignment.Center);
            listView_ReservationRequest.Columns.Add("End Date", 100, HorizontalAlignment.Center);
            listView_ReservationRequest.Columns.Add("Total Days", 80, HorizontalAlignment.Center);
            listView_ReservationRequest.Columns.Add("Function", 120, HorizontalAlignment.Left);
            listView_ReservationRequest.Columns.Add("Request", 150, HorizontalAlignment.Left);
            listView_ReservationRequest.Columns.Add("Head Count", 80, HorizontalAlignment.Center);
            listView_ReservationRequest.Columns.Add("Request Date", 100, HorizontalAlignment.Center);
            listView_ReservationRequest.Columns.Add("Status", 100, HorizontalAlignment.Center);

            // Get reservations from class
            List<ReservationDetails> reservations = ReservationDetails.GetReservations(userId);

            if (reservations.Count == 0)
            {
                return; // Just leave ListView empty instead of showing a message every time.
            }

            foreach (var res in reservations)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    res.R_Req_ID.ToString(),
                    res.StartDate.ToString("yyyy-MM-dd"),
                    res.EndDate.ToString("yyyy-MM-dd"),
                    res.TotalDays.ToString(),
                    res.Function,
                    res.Request,
                    res.HeadCount.ToString(),
                    res.RequestDate.ToString("yyyy-MM-dd"),
                    res.Status,
                });
                item.Tag = res; // Store reservation details in the tag
                listView_ReservationRequest.Items.Add(item); // Corrected listView reference
            }
        }


        private void btnProfile_Click_1(object sender, EventArgs e)
        {
            _sidebarManager.NavigateTo(new Customer_Profile(userId));
        }

        private void btnViewOrders_Click(object sender, EventArgs e)
        {
            _sidebarManager.NavigateTo(new Customer_ViewCustomerOrder(userId));
        }

        private void btnViewReplyRequest_Click(object sender, EventArgs e)
        {
            _sidebarManager.NavigateTo(new Customer_ViewCustomerReplyRequest(userId));
        }

        private void btnViewReservation_Click(object sender, EventArgs e)
        {
            _sidebarManager.NavigateTo(new Customer_ViewReservation(userId));
        }

        private void btnMakeReservation_Click(object sender, EventArgs e)
        {
            _sidebarManager.NavigateTo(new Customer_MakeReservation(userId));
        }

        private void btnMakeOrder_Click(object sender, EventArgs e)
        {
            _sidebarManager.NavigateTo(new Customer_Menu(userId));
        }

        private void btnFeedback_Click(object sender, EventArgs e)
        {
            _sidebarManager.NavigateTo(new Customer_Feedback(userId));
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            UserSessionManager.Logout(this);
        }
    }
}
