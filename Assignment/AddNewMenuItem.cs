using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Assignment
{
    public partial class AddNewMenuItem : Form
    {
        public MenuItem NewMenuItem { get; private set; } // Store the new item
        private SidebarManager _sidebarManager;

        public AddNewMenuItem()
        {
            InitializeComponent();
            _sidebarManager = new SidebarManager(this);
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

            NewMenuItem = new MenuItem(txtAddMenu.Text, picAddMenu.Image, price, cmbCategoryMenu.SelectedItem.ToString());
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnMMenu_AddMenu_Click(object sender, EventArgs e)
        {
            _sidebarManager.NavigateTo(new MainManageMenu());
        }

        private void btnMHall_AddMenu_Click(object sender, EventArgs e)
        {
            _sidebarManager.NavigateTo(new MainManageHall());
        }

        private void btnMRReport_AddMenu_Click(object sender, EventArgs e)
        {
            _sidebarManager.NavigateTo(new MainHallResvReport());
        }

        private void btnUProfile_AddMenu_Click(object sender, EventArgs e)
        {
            _sidebarManager.NavigateTo(new ManagerUpdateProfile());
        }

        private void btnCancelMenu_Click(object sender, EventArgs e)
        {
            this.Close(); // Closes the current form
        }
    }
}
