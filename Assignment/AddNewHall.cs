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
    public partial class AddNewHall : Form
    {
        private SidebarManager _sidebarManager;

        public AddNewHall()
        {
            InitializeComponent();
            _sidebarManager = new SidebarManager(this);
        }

        private void btnBrowseImageHall_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                picAddNewHall.Image = Image.FromFile(openFileDialog.FileName);
            }
        }

        private void btnAddNewHall_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHallName.Text) ||
            string.IsNullOrWhiteSpace(txtCapacity.Text) ||
            string.IsNullOrWhiteSpace(txtPriceHall.Text) ||
            picAddNewHall.Image == null)
                {
                    MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

            if (!decimal.TryParse(txtCapacity.Text, out decimal capacity))
            {
                MessageBox.Show("Invalid capacity format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtPriceHall.Text, out decimal price))
            {
                MessageBox.Show("Invalid price format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string connectionString = ConfigurationManager.ConnectionStrings["MyDBConnection"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO Hall (HallName, Capacity, Price_P_D) VALUES (@HallName, @Capacity, @Price_P_D)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@HallName", txtHallName.Text);
                        cmd.Parameters.AddWithValue("@Capacity", capacity);
                        cmd.Parameters.AddWithValue("@Price_P_D", price);

                        cmd.ExecuteNonQuery(); // 🔹 Insert into database
                    }

                    MessageBox.Show("Menu item added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error adding menu item: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancelHall_Click(object sender, EventArgs e)
        {
            this.Close(); // Closes the current form
        }

        private void btnMMenu_AddNewHall_Click(object sender, EventArgs e)
        {
            _sidebarManager.NavigateTo(new MainManageMenu());
        }

        private void btnMHall_AddNewHall_Click(object sender, EventArgs e)
        {
            _sidebarManager.NavigateTo(new MainManageHall());
        }

        private void btnHRReport_AddNewHall_Click(object sender, EventArgs e)
        {
            _sidebarManager.NavigateTo(new MainHallResvReport());
        }

        private void btnUProfile_AddNewHall_Click(object sender, EventArgs e)
        {
            _sidebarManager.NavigateTo(new ManagerUpdateProfile());
        }
    }
}
