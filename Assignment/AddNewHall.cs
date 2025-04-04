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
    public partial class AddNewHall : Form
    {
        private SidebarManager _sidebarManager;
        private int currentUserID; // Store the userID

        public AddNewHall(int userID)
        {
            InitializeComponent();
            _sidebarManager = new SidebarManager(this);
            currentUserID = userID; // Store the userID
        }

        private void btnAddNewHall_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHallName.Text) ||
            string.IsNullOrWhiteSpace(txtCapacity.Text) ||
            string.IsNullOrWhiteSpace(txtPriceHall.Text))
                {
                    MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

            if (!int.TryParse(txtCapacity.Text, out int capacity))
            {
                MessageBox.Show("Invalid capacity format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtPriceHall.Text, out decimal price))
            {
                MessageBox.Show("Invalid price format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool success = HallManager.AddHallData(txtHallName.Text, capacity, price);

            if (success)
            {
                MessageBox.Show("Hall data added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Error adding hall data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancelHall_Click(object sender, EventArgs e)
        {
            this.Close(); // Closes the current form
        }

        private void btnMMenu_AddNewHall_Click(object sender, EventArgs e)
        {
            _sidebarManager.NavigateTo(new MainManageMenu(currentUserID));
        }

        private void btnMHall_AddNewHall_Click(object sender, EventArgs e)
        {
            _sidebarManager.NavigateTo(new MainManageHall(currentUserID));
        }

        private void btnHRReport_AddNewHall_Click(object sender, EventArgs e)
        {
            _sidebarManager.NavigateTo(new MainHallResvReport(currentUserID));
        }

        private void btnUProfile_AddNewHall_Click(object sender, EventArgs e)
        {
            _sidebarManager.NavigateTo(new ManagerProfile(currentUserID));
        }

        private void txtPriceHall_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
