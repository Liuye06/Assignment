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

            byte[] imageData = ImageToByteArray(picAddMenu.Image); // Convert image

            string connectionString = ConfigurationManager.ConnectionStrings["MyDBConnection"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO Menu (Item, Image, Price, Category) VALUES (@Item, @Image, @Price, @Category)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Item", txtAddMenu.Text);
                        cmd.Parameters.AddWithValue("@Image", imageData);
                        cmd.Parameters.AddWithValue("@Price", price);
                        cmd.Parameters.AddWithValue("@Category", cmbCategoryMenu.SelectedItem.ToString());

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


        private byte[] ImageToByteArray(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Png); // Save as PNG (or use JPEG)
                return ms.ToArray();
            }
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
