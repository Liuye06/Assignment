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
    public partial class MainManageHall : Form
    {
        private SidebarManager _sidebarManager;
        private BindingSource bindingSource = new BindingSource();
        private int currentUserID; // Store the userID


        public MainManageHall(int userID)
        {
            InitializeComponent();
            _sidebarManager = new SidebarManager(this);
            currentUserID = userID; // Store the userID
            UserSessionManager.Login(userID);
        }


        private void MainManageHall_Load(object sender, EventArgs e)
        {
            LoadHallData();
        }

        private void LoadHallData()
        {
            DataTable dt = HallManager.LoadHallData();
            if (dt != null)
            {
                bindingSource.DataSource = dt;
                dgvHall.AutoGenerateColumns = false;
                dgvHall.DataSource = bindingSource;
            }
        }


        private void dgvHall_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0) // Ensure valid cell
            {
                string columnName = dgvHall.Columns[e.ColumnIndex].Name; // Get clicked column name

                if (columnName == "ColHallEdit")
                {
                    // 📝 Edit Button Clicked
                    string hallName = dgvHall.Rows[e.RowIndex].Cells["ColHallName"].Value.ToString();
                    EditHallName(hallName);
                }
                else if (columnName == "ColHallDelete")
                {
                    // ❌ Delete Button Clicked
                    string hallName = dgvHall.Rows[e.RowIndex].Cells["ColHallName"].Value.ToString();
                    DeleteHallName(hallName);
                }
            }
        }


        private void EditHallName(string hallName)
        {
            // Ensure the SidebarManager is passed
            SidebarManager sidebarManager = new SidebarManager(this);
            Manager_EditHallData editForm = new Manager_EditHallData(hallName, sidebarManager, currentUserID);

            if (editForm.ShowDialog() == DialogResult.OK)
            {
                LoadHallData(); // Refresh menu items after editing
            }
        }


        private void DeleteHallName(string hallName)
        {
            DialogResult result = MessageBox.Show($"Are you sure you want to delete {hallName}?",
                                                  "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                if (HallManager.DeleteHallData(hallName)) // Call new method from MenuManager
                {
                    MessageBox.Show("Hall data deleted successfully!");
                    LoadHallData(); // Refresh DataGridView
                }
                else
                {
                    MessageBox.Show("Error: Hall data not found or could not be deleted.", "Deletion Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnAddNewHall_Click(object sender, EventArgs e)
        {
            Manager_AddNewHall form = new Manager_AddNewHall(currentUserID);

            if (form.ShowDialog() == DialogResult.OK) // Wait until form is closed
            {
                LoadHallData();
            }
        }


        private void btnSearchHall_Click(object sender, EventArgs e)
        {
            string searchText = txtHall.Text.Trim().Replace("'", "''"); // Prevent SQL errors

            if (!string.IsNullOrEmpty(searchText))
            {
                bindingSource.Filter = $"Hall_Name LIKE '%{searchText}%'"; // 🔹 Apply filter
            }
            else
            {
                bindingSource.RemoveFilter(); // 🔹 Show all rows
            }
        }


        private void btnResetHallSearch_Click(object sender, EventArgs e)
        {
            txtHall.Text = "";
            bindingSource.RemoveFilter(); // Reset all filters 
        }


        private void btnMMenu_MHall_Click(object sender, EventArgs e)
        {
            _sidebarManager.NavigateTo(new MainManageMenu(currentUserID));
        }

        private void btnMHall_MHall_Click(object sender, EventArgs e)
        {
            _sidebarManager.NavigateTo(new MainManageHall(currentUserID));
        }

        private void btnHRReport_MHall_Click(object sender, EventArgs e)
        {
            _sidebarManager.NavigateTo(new Manager_MainHallResvReport(currentUserID));
        }

        private void btnUProfile_MHall_Click(object sender, EventArgs e)
        {
            _sidebarManager.NavigateTo(new ManagerProfile(currentUserID));
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            UserSessionManager.Logout(this);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
