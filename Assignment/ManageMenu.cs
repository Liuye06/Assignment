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
            dgvMenu.CellContentClick += dgvMenu_CellContentClick;
        }

        private void LoadMenuData()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MyDBConnection"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT Item, Price, Category FROM Menu"; 

                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    bindingSource.DataSource = dt;
                    dgvMenu.AutoGenerateColumns = false;
                    dgvMenu.DataSource = bindingSource; 
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading data: " + ex.Message);
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
            if (e.RowIndex >= 0)
            {
                // Get the clicked column name
                if (dgvMenu.Columns[e.ColumnIndex].Name == "ColMenuEdit")
                {
                    string menuItem = dgvMenu.Rows[e.RowIndex].Cells["ColMenuEdit"].Value.ToString();
                    EditMenuItem(menuItem);
                }
                
            }
            LoadMenuData();
        }


        private void EditMenuItem(string menuItem)
        {
            EditMenuItemForm editForm = new EditMenuItemForm(menuItem);
            if (editForm.ShowDialog() == DialogResult.OK)
            {
                LoadMenuData(); // Refresh menu items after editing
            }
        }


        private void DeleteMenuItem(string menuItem)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete " + menuItem + "?",
                                                  "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                string connectionString = ConfigurationManager.ConnectionStrings["MyDBConnection"].ConnectionString;
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        string query = "DELETE FROM Menu WHERE Item = @MenuItem";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@Item", menuItem);
                            cmd.ExecuteNonQuery();
                        }
                        LoadMenuData(); // Refresh table after deletion
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error deleting item: " + ex.Message);
                    }
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
            _sidebarManager.NavigateTo(new ManagerUpdateProfile());
        }
    }
}
