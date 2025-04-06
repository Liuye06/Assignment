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

namespace Assignment
{
    public partial class Manager_EditMenuItemForm : Form
    {
        private string originalMenuItem;
        private SidebarManager _sidebarManager;
        private int currentUserID; // Store the userID

        public Manager_EditMenuItemForm(string menuItem, SidebarManager sidebarManager, int userID)
        {
            InitializeComponent();
            originalMenuItem = menuItem;
            LoadMenuItemDetails(menuItem);
            _sidebarManager =  sidebarManager;
            currentUserID = userID; // Store the userID
        }

        private void LoadMenuItemDetails(string menuItem)
        {
            DataRow menuItemData = MenuManager.GetMenuItem(menuItem); // Fetch data from MenuManager

            if (menuItemData != null)
            {
                txtEditMenu.Text = menuItemData["Item"].ToString();
                txtEditPriceMenu.Text = menuItemData["Price"].ToString();
                cmbEditCategoryMenu.Text = menuItemData["Category"].ToString();

                // Load Image if it exists
                if (menuItemData["Image"] != DBNull.Value)
                {
                    byte[] imageBytes = (byte[])menuItemData["Image"];
                    picEditMenu.Image = ImageManager.ByteArrayToImage(imageBytes);
                }
                else
                {
                    picEditMenu.Image = null; // Set default if no image
                }
            }
            else
            {
                MessageBox.Show("Menu item not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSaveMenuItem_Click(object sender, EventArgs e)
        {
            string newMenuItem = txtEditMenu.Text.Trim();
            string price = txtEditPriceMenu.Text.Trim();
            string category = cmbEditCategoryMenu.Text.Trim();

            if (string.IsNullOrEmpty(newMenuItem) || string.IsNullOrEmpty(price) || string.IsNullOrEmpty(category))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            if (!decimal.TryParse(price, out decimal priceValue))
            {
                MessageBox.Show("Invalid price format.");
                return;
            }

            byte[] imageData = picEditMenu.Image != null ? ImageManager.ImageToByteArray(picEditMenu.Image) : null;

            if (MenuManager.UpdateMenuItem(originalMenuItem, newMenuItem, price, category))
            {
                MessageBox.Show("Menu item updated successfully!");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnEditBrowseImageMenu_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                picEditMenu.Image = Image.FromFile(openFileDialog.FileName);
            }
        }

        
        private void btnCancelEditMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
