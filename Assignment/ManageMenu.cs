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


namespace Assignment
{
    public partial class MainManageMenu : Form
    {
        private MenuManager menuManager;
        private SidebarManager _sidebarManager;


        public MainManageMenu()
        {
            InitializeComponent();
            menuManager = new MenuManager();
            _sidebarManager = new SidebarManager(this);
        }

        private void btnAddMenu_Click(object sender, EventArgs e)
        {
            AddNewMenuItem form = new AddNewMenuItem();

            if (form.ShowDialog() == DialogResult.OK) // Wait until form is closed
            {
                menuManager.AddMenuItem(form.NewMenuItem); // Add new item from form
                LoadMenuData();
            }
        }

        private void dgvMenu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadMenuData();
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
            _sidebarManager.NavigateTo(new ManagerUpdateProfile());
        }

        private void btnSearchMenu_Click(object sender, EventArgs e)
        {
            string searchText = txtMenu.Text.Trim().ToLower();

            if (!string.IsNullOrEmpty(searchText))
            {
                foreach (DataGridViewRow row in dgvMenu.Rows)
                {
                    if (row.Cells["ColMenuItem"].Value != null &&
                        row.Cells["ColMenuItem"].Value.ToString().ToLower().Contains(searchText))
                    {
                        row.Visible = true; // Show matching row
                    }
                    else
                    {
                        row.Visible = false; // Hide non-matching rows
                    }
                }
            }
            else
            {
                // Show all rows if search box is empty
                foreach (DataGridViewRow row in dgvMenu.Rows)
                {
                    row.Visible = true;
                }
            }
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCategory = cmbCategory.SelectedItem?.ToString();

            foreach (DataGridViewRow row in dgvMenu.Rows)
            {
                if (row.Cells["ColMenuCategory"].Value != null &&
                    row.Cells["ColMenuCategory"].Value.ToString() == selectedCategory)
                {
                    row.Visible = true; // Show matching category
                }
                else
                {
                    row.Visible = false; // Hide non-matching category
                }
            }
        }

        private void btnResetMMenu_Click(object sender, EventArgs e)
        {
            txtMenu.Text = "";
            cmbCategory.SelectedIndex = 0; // Select "All"

            foreach (DataGridViewRow row in dgvMenu.Rows)
            {
                row.Visible = true;
            }
        }

        private void LoadMenuData()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MyDBConnection"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT Item, Price, Category FROM Menu"; // Adjust table name

                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvMenu.AutoGenerateColumns = false;
                    dgvMenu.DataSource = dt; // Assuming dgvMenu is your DataGridView name
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading data: " + ex.Message);
                }
            }
        }

        private void MainManageMenu_Load(object sender, EventArgs e)
        {
            LoadMenuData();
        }

    }
}
