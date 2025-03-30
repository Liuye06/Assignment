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
    public partial class DeleteReservation : Form
    {
        public DeleteReservation()
        {
            InitializeComponent();
            LoadReservationIDs();
            LoadReservationData();
        }

        private void LoadReservationIDs()
        {
            DataTable dt = RersevationCoordinator.GetReservationIDs();
            listBox1.DataSource = dt;
            listBox1.DisplayMember = "Reservation_ID";
            listBox1.ValueMember = "Reservation_ID";
        }

        private void LoadReservationData()
        {
            DataTable dt = RersevationCoordinator.GetReservationData();
            dataGridView1.DataSource = dt;
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
            {
                MessageBox.Show("Please select a reservation to delete.", "Warning",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Confirm deletion
            DialogResult result = MessageBox.Show("Are you sure you want to delete this reservation?",
                                               "Confirm Delete",
                                               MessageBoxButtons.YesNo,
                                               MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                DataRowView selectedRow = (DataRowView)listBox1.SelectedItem;
                int reservationID = Convert.ToInt32(selectedRow["Reservation_ID"]);

                bool success = RersevationCoordinator.DeleteReservation(reservationID);

                if (success)
                {
                    MessageBox.Show("Reservation deleted successfully!", "Success",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Refresh the data
                    LoadReservationIDs();
                    LoadReservationData();
                }
            }
        }
    }
}
