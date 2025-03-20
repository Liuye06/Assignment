using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;


namespace Assignment
{
    public partial class MainManageMenu : Form
    {
        private SidebarManager _sidebarManager;
        private BindingSource bindingSource = new BindingSource();


        public MainManageMenu()
        {
            InitializeComponent();
            _sidebarManager = new SidebarManager(this);
        }

        private void MainManageMenu_Load(object sender, EventArgs e)
        {
            LoadMenuData();
            dgvMenu.CellContentClick -= dgvMenu_CellContentClick; // Ensure no duplicates
            dgvMenu.CellContentClick += dgvMenu_CellContentClick;
            dgvMenu.CellFormatting += dgvMenu_CellFormatting;
        }

        private void LoadMenuData()
        {
            DataTable dt = MenuManager.LoadMenuData();
            if (dt != null)
            {
                bindingSource.DataSource = dt;
                dgvMenu.AutoGenerateColumns = false;
                dgvMenu.DataSource = bindingSource;
            }
        }


        private void dgvMenu_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvMenu.Columns[e.ColumnIndex].Name == "colMenuImage")  // Ensure this matches your Image column name
            {
                if (e.Value != null && e.Value is byte[] byteArray)
                {
                    e.Value = ImageManager.ByteArrayToImage(byteArray);
                }
            }
        }


        private void btnAddMenu_Click(object sender, EventArgs e)
        {
            AddNewMenuItem form = new AddNewMenuItem();

            if (form.ShowDialog() == DialogResult.OK) // Wait until form is closed
            {
                LoadMenuData();
            }
        }


        private void btnSearchMenu_Click(object sender, EventArgs e)
        {
            string searchText = txtMenu.Text.Trim().Replace("'", "''"); // Prevent SQL errors

            if (!string.IsNullOrEmpty(searchText))
            {
                bindingSource.Filter = $"Item LIKE '%{searchText}%'"; //  Apply filter
            }
            else
            {
                bindingSource.RemoveFilter(); //  Show all rows
            }
        }


        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCategory = cmbCategory.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(selectedCategory) && selectedCategory != "All")
            {
                bindingSource.Filter = $"Category = '{selectedCategory}'"; // 🔹 Filter by category
            }
            else
            {
                bindingSource.RemoveFilter(); // 🔹 Show all rows
            }
        }


        private void btnResetMMenu_Click(object sender, EventArgs e)
        {
            txtMenu.Text = "";
            cmbCategory.SelectedIndex = 0; // Select "All"
            bindingSource.RemoveFilter(); // Reset all filters 
        }


        private void dgvMenu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0) // Ensure valid cell
            {
                string columnName = dgvMenu.Columns[e.ColumnIndex].Name; // Get clicked column name

                if (columnName == "ColMenuEdit")
                {
                    // 📝 Edit Button Clicked
                    string menuItem = dgvMenu.Rows[e.RowIndex].Cells["ColMenuItem"].Value.ToString();
                    EditMenuItem(menuItem);
                }
                else if (columnName == "ColMenuDelete")
                {
                    // ❌ Delete Button Clicked
                    string menuItem = dgvMenu.Rows[e.RowIndex].Cells["ColMenuItem"].Value.ToString();
                    DeleteMenuItem(menuItem);
                }
            }
        }


        private void EditMenuItem(string menuItem)
        {
            // Ensure the SidebarManager is passed
            SidebarManager sidebarManager = new SidebarManager(this);
            EditMenuItemForm editForm = new EditMenuItemForm(menuItem, sidebarManager);

            if (editForm.ShowDialog() == DialogResult.OK)
            {
                LoadMenuData(); // Refresh menu items after editing
            }
        }


        private void DeleteMenuItem(string menuItem)
        {
            DialogResult result = MessageBox.Show($"Are you sure you want to delete {menuItem}?",
                                                  "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                if (MenuManager.DeleteMenuItem(menuItem)) // Call new method from MenuManager
                {
                    MessageBox.Show("Menu item deleted successfully!");
                    LoadMenuData(); // Refresh DataGridView
                }
                else
                {
                    MessageBox.Show("Error: Menu item not found or could not be deleted.", "Deletion Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void btnMMenu_MMenu_Click(object sender, EventArgs e)
        {
            _sidebarManager.NavigateTo(new MainManageMenu());
        }

        private void btnMHall_MMenu_Click(object sender, EventArgs e)
        {
            _sidebarManager.NavigateTo(new MainManageHall());
        }

        private void btn_HRReport_MMenu_Click(object sender, EventArgs e)
        {
            _sidebarManager.NavigateTo(new MainHallResvReport());
        }

        private void btnUProfile_MMenu_Click(object sender, EventArgs e)
        {
            _sidebarManager.NavigateTo(new ManagerProfile());
        }
    }
}
