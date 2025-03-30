using System;
using System.Data;
using System.Windows.Forms;

namespace Assignment
{
    public partial class Reservation : Form
    {
        public Reservation()
        {
            InitializeComponent();
            SetupDataGridView();
            LoadReservationData();
        }

        private void SetupDataGridView()
        {
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void LoadReservationData()
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor; // Show loading cursor

                DataTable reservationData = RersevationCoordinator.GetReservationData();

                if (reservationData != null)
                {
                    dataGridView1.DataSource = reservationData;

                    if (reservationData.Rows.Count == 0)
                    {
                        MessageBox.Show("No reservation data found.", "Information",
                                      MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading reservation data: " + ex.Message,
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor.Current = Cursors.Default; // Restore default cursor
            }
        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            LoadReservationData();
        }
    }
}