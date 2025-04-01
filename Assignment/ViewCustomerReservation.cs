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
    public partial class ViewCustomerReservation : Form
    {
        private SidebarManager _sidebarManager;
        private int userId; // Assuming this is passed or set somewhere in the form


        public ViewCustomerReservation(int userId=1)
        {
            InitializeComponent();
            _sidebarManager = new SidebarManager(this); 
            this.userId = userId;
            LoadReservations(); // Automatically load reservations when form opens
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
                MessageBox.Show("No reservations found!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            foreach (var res in reservations)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    res.StartDate.ToString("yyyy-MM-dd"),
                    res.EndDate.ToString("yyyy-MM-dd"),
                    res.TotalDays.ToString(),
                    res.Function,
                    res.Request,
                    res.HeadCount.ToString(),
                    res.RequestDate.ToString("yyyy-MM-dd"),
                    res.Status
                });
                item.Tag = res; // Store reservation details in the tag
                listView_ReservationRequest.Items.Add(item); // Corrected listView reference
            }
        }

        private void listView_ReservationRequest_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView_ReservationRequest.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView_ReservationRequest.SelectedItems[0];
                ReservationDetails reservation = (ReservationDetails)selectedItem.Tag;

                // Enable payment button only if status is "Approved"
                btnMakeResvPayment.Enabled = reservation.Status == "Approved";
                btnMakeResvPayment.Tag = reservation; // Store reservation details in button tag
            }
            else
            {
                btnMakeResvPayment.Enabled = false;
            }
        }

        private void btnMakeResvPayment_Click(object sender, EventArgs e)
        {
            if (btnMakeResvPayment.Tag is ReservationDetails reservation)
            {
                OpenPaymentForm(reservation);
            }
        }

        private void OpenPaymentForm(ReservationDetails reservation)
        {
            ReservationPayment paymentForm = new ReservationPayment();
            paymentForm.ShowDialog();
        }
    }
}
