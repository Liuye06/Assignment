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
    public partial class EditMenuItemForm : Form
    {
        private string originalMenuItem;
        private SidebarManager _sidebarManager;

        public EditMenuItemForm(string menuItem)
        {
            InitializeComponent();
            originalMenuItem = menuItem;
            LoadMenuItemDetails(menuItem);
            _sidebarManager = new SidebarManager(this);
        }

        private void LoadMenuItemDetails(string menuItem)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MyDBConnection"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT Item, Price, Category FROM Menu WHERE Item = @MenuItem";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MenuItem", menuItem);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtEditMenu.Text = reader["Item"].ToString();
                                txtEditPriceMenu.Text = reader["Price"].ToString();
                                cmbEditCategoryMenu.Text = reader["Category"].ToString();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading menu item: " + ex.Message);
                }
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

            string connectionString = ConfigurationManager.ConnectionStrings["MyDBConnection"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE Menu SET Item = @NewMenuItem, Price = @Price, Category = @Category WHERE Item = @OriginalMenuItem";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@NewMenuItem", newMenuItem);
                        cmd.Parameters.AddWithValue("@Price", price);
                        cmd.Parameters.AddWithValue("@Category", category);
                        cmd.Parameters.AddWithValue("@OriginalMenuItem", originalMenuItem);

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Menu item updated successfully!");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating menu item: " + ex.Message);
                }
            }
        }

        private void btnCancelEditMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMMenu_EditMenu_Click(object sender, EventArgs e)
        {
            _sidebarManager.NavigateTo(new MainManageMenu());
        }

        private void btnMHall_EditMenu_Click(object sender, EventArgs e)
        {
            _sidebarManager.NavigateTo(new MainManageHall());
        }

        private void btn_HRReport_EditMenu_Click(object sender, EventArgs e)
        {
            _sidebarManager.NavigateTo(new MainHallResvReport());
        }

        private void btnUProfile_EditMenu_Click(object sender, EventArgs e)
        {
            _sidebarManager.NavigateTo(new ManagerUpdateProfile());
        }
    }
}
