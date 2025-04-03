using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Assignment
{
    public partial class ReplyRequest : Form
    {
        private SidebarManager _sidebarManager;
        private BindingSource bindingSource = new BindingSource();
        private int currentUserID; // Store the userID

        public ReplyRequest(int userID)
        {
            InitializeComponent();
            _sidebarManager = new SidebarManager(this);
            currentUserID = userID; // Store the userID
            UserSessionManager.Login(userID);
        }


        private void ReplyRequest_Load(object sender, EventArgs e)
        {
            RequestHandler handler = new RequestHandler();
            handler.LoadRequests(dgvReplyRequest);
        }



        private void btnManageReservation_Click(object sender, EventArgs e)
        {

        }

        private void AddStatusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAddNewReservation_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdateStatus_Click(object sender, EventArgs e)
        {
            if (cmbChangeStatus.SelectedItem != null && dgvReplyRequest.SelectedRows.Count > 0)
            {
                // Get the selected row's request ID (even though it's hidden)
                int requestID = Convert.ToInt32(dgvReplyRequest.SelectedRows[0].Cells["R_Req_ID"].Value);
                string newStatus = cmbChangeStatus.SelectedItem.ToString();

                RequestHandler handler = new RequestHandler();
                bool success = handler.UpdateRequestStatus(requestID, newStatus);

                if (success)
                {
                    MessageBox.Show("Status updated successfully!");
                    handler.LoadRequests(dgvReplyRequest); // Refresh DataGridView
                }
                else
                {
                    MessageBox.Show("Failed to update status.");
                }
            }
            else
            {
                MessageBox.Show("Please select a request and a status.");
            }
        }

        private void dgvReplyRequest_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Ensure it's not a header row
            {
                DataGridViewRow row = dgvReplyRequest.Rows[e.RowIndex];

                // Populate only the status combo box
                cmbChangeStatus.SelectedItem = row.Cells["Status"].Value.ToString();
            }
        }

        private void btnAddNewReservation_Click_1(object sender, EventArgs e)
        {
            if (dgvReplyRequest.SelectedRows.Count > 0)
            {
                // Get selected data
                int requestID = Convert.ToInt32(dgvReplyRequest.SelectedRows[0].Cells["R_Req_ID"].Value);
                int userID = Convert.ToInt32(dgvReplyRequest.SelectedRows[0].Cells["User_ID"].Value);

                // Set Hall_ID to NULL and Status to Approved
                int? hallID = null; // Nullable int for Hall_ID
                string status = "Approved"; // Default Status

                // Add to Reservation
                RequestHandler handler = new RequestHandler();
                bool success = handler.AddToReservation(hallID, userID, requestID, status);

                if (success)
                {
                    MessageBox.Show("Request successfully added to Reservations!");
                }
                else
                {
                    MessageBox.Show("Failed to add the request to Reservations.");
                }
            }
            else
            {
                MessageBox.Show("Please select a request from the table.");
            }
        }
    }
}


