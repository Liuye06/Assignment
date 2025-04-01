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
using static Assignment.FoodMenuManager;
using System.Configuration;


namespace Assignment
{
    public partial class CustomerMenu : Form
    {
        private SidebarManager _sidebarManager;
        private int currentUserId; // Store logged-in user's ID

        public CustomerMenu(int userId=7)
        {
            InitializeComponent();
            this.currentUserId = userId; // Assign user ID
            LoadCategories();
            LoadFoodMenu();
            _sidebarManager = new SidebarManager(this);
        }


        private void LoadCategories()
        {
            List<string> categories = FoodMenuManager.GetCategories();
            cmbCategory.Items.Clear();
            cmbCategory.Items.Add("All"); // Default option
            cmbCategory.Items.AddRange(categories.ToArray());
            cmbCategory.SelectedIndex = 0; // Default to "All"
        }


        private void LoadFoodMenu(string category = "All")
        {
            flowPanelMenu.Controls.Clear(); // Clear previous menu items

            DataTable foodTable = FoodMenuManager.GetFoodMenuFromDB(category);

            foreach (DataRow row in foodTable.Rows)
            {
                Panel itemPanel = CreateMenuItem(row);
                flowPanelMenu.Controls.Add(itemPanel);
            }
        }


        private Panel CreateMenuItem(DataRow row)
        {
            string defaultImagePath = Path.Combine(Application.StartupPath, "Resources", "default_image.png");

            Panel panel = new Panel
            {
                Size = new Size(200, 230),
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

            // Convert Image from Database (VARBINARY to Image)
            byte[] imageData = row["Image"] as byte[];
            pictureBox.Image = (imageData != null && imageData.Length > 0)
                ? ImageManager.ByteArrayToImage(imageData)
                : (File.Exists(defaultImagePath) ? Image.FromFile(defaultImagePath) : null); // Ensure this exists in Resources

            // Food Name Label
            Label nameLabel = new Label
            {
                Text = row["Item"].ToString(),
                Location = new Point(10, 140),
                Font = new Font("Arial", 10, FontStyle.Bold),
                AutoSize = true
            };

            // FlowLayoutPanel to hold Price and Quantity side by side
            FlowLayoutPanel priceQuantityPanel = new FlowLayoutPanel
            {
                Location = new Point(10, 170),
                Width = 180,
                Height = 30,
                FlowDirection = FlowDirection.LeftToRight
            };

            // Price Label
            Label priceLabel = new Label
            {
                Text = $"RM {row["Price"]}",
                AutoSize = true,
                Font = new Font("Arial", 10, FontStyle.Bold)
            };

            // Quantity Selector (NumericUpDown)
            NumericUpDown quantityBox = new NumericUpDown
            {
                Minimum = 0,
                Maximum = 10,
                Width = 50
            };

            // Add Price and Quantity to the same row
            priceQuantityPanel.Controls.Add(priceLabel);
            priceQuantityPanel.Controls.Add(quantityBox);


            // Place Order Button
            Button btnPlaceOrder = new Button
            {
                Text = "Place Order",
                Location = new Point(10, 200),
                Size = new Size(180, 30),
                BackColor = Color.Pink,
            };


            btnPlaceOrder.Click += (sender, e) =>
            {
                int itemId = Convert.ToInt32(row["Item_Id"]);
                string itemName = row["Item"].ToString();
                decimal price = Convert.ToDecimal(row["Price"]);
                int quantity = (int)quantityBox.Value;

                if (quantity > 0)
                {
                    FoodMenuManager.AddOrderToList(cartList, itemId, itemName, price, quantity);
                    // Reset quantity to 0 after placing the order
                    quantityBox.Value = 0;
                }
                else
                {
                    MessageBox.Show("Please select a quantity greater than 0.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            };

            // Add controls to panel
            panel.Controls.Add(pictureBox);
            panel.Controls.Add(nameLabel);
            panel.Controls.Add(priceQuantityPanel);
            panel.Controls.Add(btnPlaceOrder);

            return panel;
        }

        private List<OrderItem> cartList = new List<OrderItem>();


        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCategory = cmbCategory.SelectedItem.ToString();
            LoadFoodMenu(selectedCategory); // Reload menu based on selection
        }

        private void btnResetCMenu_Click(object sender, EventArgs e)
        {
            cmbCategory.SelectedIndex = 0; // Set to "All"
            LoadFoodMenu("All"); // Reload full menu
        }


        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            if (cartList.Count == 0)
            {
                MessageBox.Show("Your cart is empty!", "Empty Cart", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            CheckoutForm checkout = new CheckoutForm(cartList, currentUserId);
            checkout.ShowDialog();
        }


        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            if (cartList.Count == 0)
            {
                MessageBox.Show("Your cart is empty!", "Empty Cart", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Pass the existing cartList reference instead of creating a new one
            CheckoutForm checkout = new CheckoutForm(cartList, currentUserId);
            checkout.ShowDialog();
        }


        private void btnProfile_Click_1(object sender, EventArgs e)
        {
            _sidebarManager.NavigateTo(new Customer_Profile());
        }

        private void btnViewOrders_Click_1(object sender, EventArgs e)
        {
            _sidebarManager.NavigateTo(new ViewCustomerOrder());
        }

        private void btnViewReservations_Click_1(object sender, EventArgs e)
        {
            _sidebarManager.NavigateTo(new ViewCustomerReservation());
        }

        private void btnMakeOrder_Click_1(object sender, EventArgs e)
        {
            _sidebarManager.NavigateTo(new CustomerMenu());
        }

        private void btnMakeReservation_Click_1(object sender, EventArgs e)
        {
            _sidebarManager.NavigateTo(new CustomerMakeAnReservation());
        }

        private void btnMakePayment_Click_1(object sender, EventArgs e)
        {
            _sidebarManager.NavigateTo(new CustomerPaymentHistory());
        }

        private void btnFeedback_Click_1(object sender, EventArgs e)
        {
            _sidebarManager.NavigateTo(new CustomerFeedback());
        }
    }
}
