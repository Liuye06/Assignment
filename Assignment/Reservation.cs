using System;
using System.Data;
using System.Windows.Forms;

namespace Assignment
{
    public partial class Reservation : Form
    {
        private SidebarManager _sidebarManager;
        private BindingSource bindingSource = new BindingSource();
        private int currentUserID; // Store the userID
        private ReservationManager reservationManager = new ReservationManager();

        public Reservation(int userID)
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
    }
}


