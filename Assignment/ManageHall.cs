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


        public MainManageHall()
        {
            InitializeComponent();
            _sidebarManager = new SidebarManager(this);
        }


        private void MainManageHall_Load(object sender, EventArgs e)
        {
            LoadHallData();
        }

        private void LoadHallData()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MyDBConnection"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT HallName, Capacity, Price_P_D FROM Hall";

                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    bindingSource.DataSource = dt;
                    dgvHall.AutoGenerateColumns = false;
                    dgvHall.DataSource = bindingSource;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading data: " + ex.Message);
                }
            }
        }


        private void btnAddNewHall_Click(object sender, EventArgs e)
        {
            AddNewHall form = new AddNewHall();

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
                bindingSource.Filter = $"HallName LIKE '%{searchText}%'"; // 🔹 Apply filter
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
            _sidebarManager.NavigateTo(new MainManageMenu());
        }

        private void btnMHall_MHall_Click(object sender, EventArgs e)
        {
            _sidebarManager.NavigateTo(new MainManageHall());
        }

        private void btnHRReport_MHall_Click(object sender, EventArgs e)
        {
            _sidebarManager.NavigateTo(new MainHallResvReport());
        }

        private void btnUProfile_MHall_Click(object sender, EventArgs e)
        {
            _sidebarManager.NavigateTo(new ManagerUpdateProfile());
        }

    }
}
