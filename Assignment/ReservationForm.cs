using System;
using System.Data;
using System.Windows.Forms;

namespace Assignment
{
    public partial class ReservationForm : Form
    {
        private SidebarManager _sidebarManager;
        private BindingSource bindingSource = new BindingSource();
        private int currentUserID; // Store the userID
        private ReservationManager reservationManager = new ReservationManager();

        public ReservationForm(int userID)
        {
            InitializeComponent();
            _sidebarManager = new SidebarManager(this);
            currentUserID = userID; // Store the userID
            UserSessionManager.Login(userID);
        }

        private void Reservation_Load(object sender, EventArgs e)
        {
            reservationManager.LoadReservations(dgvReservation);
            reservationManager.LoadHalls(cmbAssignHall); // Populate the combo box with hall data
            reservationManager.AddDeleteButtonColumn(dgvReservation); // Add the delete button column

        }

        private void btnUpdateStatus_Click(object sender, EventArgs e)
        {
            if (dgvReservation.SelectedRows.Count > 0)
            {
                int reservationID = Convert.ToInt32(dgvReservation.SelectedRows[0].Cells["Reservation_ID"].Value);
                string newStatus = cmbChangeStatus.SelectedItem.ToString();

                bool success = reservationManager.UpdateReservationStatus(reservationID, newStatus);

                if (success)
                {
                    MessageBox.Show("Status updated successfully!");
                    reservationManager.LoadReservations(dgvReservation); // Refresh DataGridView
                }
                else
                {
                    MessageBox.Show("Failed to update status.");
                }
            }
            else
            {
                MessageBox.Show("Please select a reservation from the table.");
            }
        }

        private void btnAssignHall_Click(object sender, EventArgs e)
        {
            if (dgvReservation.SelectedRows.Count > 0)
            {
                // Check if a hall is selected
                if (cmbAssignHall.SelectedItem == null)
                {
                    MessageBox.Show("Please select a hall.");
                    return;
                }

                int reservationID = Convert.ToInt32(dgvReservation.SelectedRows[0].Cells["Reservation_ID"].Value);
                int hallID = Convert.ToInt32(cmbAssignHall.SelectedValue);

                bool success = reservationManager.AssignHall(reservationID, hallID);

                if (success)
                {
                    MessageBox.Show("Hall assigned successfully!");
                    reservationManager.LoadReservations(dgvReservation); // Refresh DataGridView
                }
                else
                {
                    MessageBox.Show("Failed to assign hall.");
                }
            }
            else
            {
                MessageBox.Show("Please select a reservation from the table.");
            }
        }

        private void dgvReservation_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvReservation.Columns["Delete"].Index && e.RowIndex >= 0)
            {
                int reservationID = Convert.ToInt32(dgvReservation.Rows[e.RowIndex].Cells["Reservation_ID"].Value);

                // Confirm deletion
                DialogResult result = MessageBox.Show("Are you sure you want to delete this reservation?", "Confirm Deletion", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    bool success = reservationManager.DeleteReservation(reservationID);

                    if (success)
                    {
                        MessageBox.Show("Reservation deleted successfully!");
                        reservationManager.LoadReservations(dgvReservation); // Refresh DataGridView
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete reservation.");
                    }
                }
            }
        }

        private void btnManageReservation_Click(object sender, EventArgs e)
        {
            _sidebarManager.NavigateTo(new ReservationForm(currentUserID));
        }

        private void btnReplyCustomer_Click(object sender, EventArgs e)
        {
            _sidebarManager.NavigateTo(new ReplyRequest(currentUserID));
        }

        private void btnRCProfile_Click(object sender, EventArgs e)
        {
            _sidebarManager.NavigateTo(new RCProfile(currentUserID));
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            UserSessionManager.Logout(this);
        }
    }
}



