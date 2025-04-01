using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Assignment
{
    public partial class AddNewMenuItem : Form
    {
        private SidebarManager _sidebarManager;
        private int currentUserID; // Store the userID

        public AddNewMenuItem(int userID)
        {
            InitializeComponent();
            _sidebarManager = new SidebarManager(this);
            currentUserID = userID; // Store the userID
        }

        private void btnBrowseImageMenu_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                picAddMenu.Image = Image.FromFile(openFileDialog.FileName);
            }

        }

        private void btnAddMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAddMenu.Text) ||
            string.IsNullOrWhiteSpace(txtPriceMenu.Text) ||
            cmbCategoryMenu.SelectedItem == null ||
            picAddMenu.Image == null)
                {
                    MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

            if (!decimal.TryParse(txtPriceMenu.Text, out decimal price))
            {
                MessageBox.Show("Invalid price format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            byte[] imageData = ImageManager.ImageToByteArray(picAddMenu.Image); // Convert image

            bool success = MenuManager.AddMenuItem(txtAddMenu.Text, imageData, price, cmbCategoryMenu.SelectedItem.ToString());

            if (success)
            {
                MessageBox.Show("Menu item added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Error adding menu item.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnMMenu_AddMenu_Click(object sender, EventArgs e)
        {
            _sidebarManager.NavigateTo(new MainManageMenu(currentUserID));
        }

        private void btnMHall_AddMenu_Click(object sender, EventArgs e)
        {
            _sidebarManager.NavigateTo(new MainManageHall(currentUserID));
        }

        private void btnMRReport_AddMenu_Click(object sender, EventArgs e)
        {
            _sidebarManager.NavigateTo(new MainHallResvReport(currentUserID));
        }

        private void btnUProfile_AddMenu_Click(object sender, EventArgs e)
        {
            _sidebarManager.NavigateTo(new ManagerProfile(currentUserID));
        }

        private void btnCancelMenu_Click(object sender, EventArgs e)
        {
            this.Close(); // Closes the current form
        }
    }
}
