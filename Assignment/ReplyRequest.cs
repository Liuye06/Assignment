using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
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
            // Load reservation data into DataGridView
            ReplyRequestDetails.LoadReservationsRequest(dgvReplyRequest);
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
    }
}

