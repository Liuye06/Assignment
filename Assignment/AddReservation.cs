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
    public partial class AddReservation : Form
    {
        public AddReservation()
        {
            InitializeComponent();
            LoadAvailableHalls();
            LoadPendingRequests();
        }

        private void AddReservation_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet8.Hall' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'database1DataSet6.R_Request' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'database1DataSet4.Reservation' table. You can move, or remove it, as needed.
        }
        private void LoadAvailableHalls()
        {
            DataTable dt = RersevationCoordinator.GetAvailableHalls();
            dataGridView1.DataSource = dt;
        }

        private void LoadPendingRequests()
        {
            DataTable dt = RersevationCoordinator.GetPendingRequests();
            listBox1.DataSource = dt;
            listBox1.DisplayMember = "User_ID";
            listBox1.ValueMember = "User_ID";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_HallID.Text))
            {
                MessageBox.Show("Please enter a Hall ID.", "Warning",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (listBox1.SelectedItem == null)
            {
                MessageBox.Show("Please select a customer.", "Warning",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txt_HallID.Text, out int hallID))
            {
                MessageBox.Show("Please enter a valid Hall ID (numeric value).", "Warning",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataRowView selectedRow = (DataRowView)listBox1.SelectedItem;
            int userID = Convert.ToInt32(selectedRow["User_ID"]);
            DateTime startDate = Convert.ToDateTime(selectedRow["Start_Date"]);

            bool success = RersevationCoordinator.CreateReservation(hallID, userID, startDate);

            if (success)
            {
                MessageBox.Show("Reservation created successfully!", "Success",
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Refresh the data
                LoadAvailableHalls();
                txt_HallID.Clear();
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        { 
            txt_HallID.Clear();
        }
    }
}
