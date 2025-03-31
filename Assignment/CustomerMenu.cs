using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Assignment
{
    public partial class CustomerMenu : Form
    {
        public CustomerMenu()
        {
            InitializeComponent();
            LoadFoodMenu();
        }


        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void LoadFoodMenu()
        {
            DataTable foodTable = FoodMenuManager.GetFoodMenuFromDB();

            foreach (DataRow row in foodTable.Rows)
            {
                Panel itemPanel = CreateMenuItem(row);
                flowPanelMenu.Controls.Add(itemPanel);
            }
        }

        private Panel CreateMenuItem(DataRow row)
        {
            // Create a new panel
            Panel panel = new Panel
            {
                Size = new Size(200, 300),
                BackColor = Color.MistyRose,
                Margin = new Padding(10)
            };

            // PictureBox for food image
            PictureBox pictureBox = new PictureBox
            {
                Size = new Size(180, 120),
                Location = new Point(10, 10),
                SizeMode = PictureBoxSizeMode.StretchImage
            };

            // Load image from file
            string imagePath = Path.Combine(Application.StartupPath, "images", row["ImagePath"].ToString());
            pictureBox.Image = File.Exists(imagePath) ? Image.FromFile(imagePath) : Image.FromFile("default.png");

            // Food Name Label
            Label nameLabel = new Label
            {
                Text = row["Name"].ToString(),
                Location = new Point(10, 140),
                Font = new Font("Arial", 10, FontStyle.Bold),
                AutoSize = true
            };

            // Quantity Selector
            NumericUpDown quantityBox = new NumericUpDown
            {
                Location = new Point(10, 170),
                Minimum = 0,
                Maximum = 10,
                Width = 50
            };

            // Price Label
            Label priceLabel = new Label
            {
                Text = $"Price: RM{row["Price"]}",
                Location = new Point(10, 200),
                AutoSize = true
            };

            // Special Request TextBox
            TextBox requestBox = new TextBox
            {
                Location = new Point(10, 230),
                Width = 150,
                PlaceholderText = "Special Request"
            };

            // Add controls to panel
            panel.Controls.Add(pictureBox);
            panel.Controls.Add(nameLabel);
            panel.Controls.Add(quantityBox);
            panel.Controls.Add(priceLabel);
            panel.Controls.Add(requestBox);

            return panel;
        }
    }
}
