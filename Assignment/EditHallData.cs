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
    public partial class EditHallData : Form
    {
        private string originalHallData;
        private SidebarManager _sidebarManager;

        public EditHallData(string hallData, SidebarManager sidebarManager)
        {
            InitializeComponent();
            originalHallData = hallData;
            LoadHallDataDetails(hallData);
            _sidebarManager = sidebarManager;
        }


        private void LoadHallDataDetails(string hallData)
        {
            DataRow hallNameData = HallManager.GetHallData(hallData); // Fetch data from MenuManager

            if (hallNameData != null)
            {
                txtEditHall.Text = hallNameData["Hall_Name"].ToString();
                txtEditCapacityHall.Text = hallNameData["Capacity"].ToString();
                txtEditPriceHall.Text = hallNameData["Price_P_Day"].ToString();
            }
            else
            {
                MessageBox.Show("Hall data not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSaveHallName_Click(object sender, EventArgs e)
        {
            string newHallName = txtEditHall.Text.Trim();
            string capacity = txtEditCapacityHall.Text.Trim();
            string price = txtEditPriceHall.Text.Trim();

            if (string.IsNullOrEmpty(newHallName) || string.IsNullOrEmpty(capacity) || string.IsNullOrEmpty(price))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            if (!int.TryParse(capacity, out int capacityValue))
            {
                MessageBox.Show("Invalid capacity format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(price, out decimal priceValue))
            {
                MessageBox.Show("Invalid price format.");
                return;
            }

            if (HallManager.UpdateHallData(originalHallData, newHallName, capacity, price))
            {
                MessageBox.Show("Hall data updated successfully!");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnCancelEditHall_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMMenu_EditHall_Click(object sender, EventArgs e)
        {
            _sidebarManager.NavigateTo(new MainManageMenu());
        }

        private void btnMHall_EditHall_Click(object sender, EventArgs e)
        {
            _sidebarManager.NavigateTo(new MainManageHall());
        }

        private void btnHRReport_EditHall_Click(object sender, EventArgs e)
        {
            _sidebarManager.NavigateTo(new MainHallResvReport());
        }

        private void btnUProfile_EditHall_Click(object sender, EventArgs e)
        {
            _sidebarManager.NavigateTo(new ManagerUpdateProfile());
        }
    }
}
