using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static Assignment.FoodMenuManager;

namespace Assignment
{
    public partial class CheckoutForm : Form
    {

        private List<OrderItem> cartList;
        private int userId;

        public CheckoutForm(List<OrderItem> cart, int userId=7)
        {
            InitializeComponent();
            this.cartList = cart;
            this.userId = userId;
            LoadCartItems();

        }

        private void LoadCartItems()
        {
            lstCartFood.View = View.Details; // Ensure items are displayed in detail mode
            lstCartFood.FullRowSelect = true; // Allow full row selection

            // Clear existing columns and set new ones
            lstCartFood.Columns.Clear();
            lstCartFood.Columns.Add("Item Name", 150, HorizontalAlignment.Left);
            lstCartFood.Columns.Add("Quantity", 70, HorizontalAlignment.Center);
            lstCartFood.Columns.Add("Price (RM/Each)", 90, HorizontalAlignment.Right);

            lstCartFood.Items.Clear(); // Clear existing items
            decimal totalAmount = 0;

            foreach (var item in cartList)
            {
                ListViewItem listItem = new ListViewItem(new string[]
                {
                    item.ItemName,
                    item.Quantity.ToString(),
                    item.Price.ToString("F2"), // Format price
                    item.TotalPrice.ToString("F2") // Format total price
                });

                lstCartFood.Items.Add(listItem);
                totalAmount += item.TotalPrice;
            }

            lblTotalFood.Text = $"Total: RM {totalAmount:F2}";
        }


        private void btnConfirm_Pay_Click(object sender, EventArgs e)
        {
            if (cartList.Count == 0)
            {
                MessageBox.Show("Your cart is empty. Please add items before proceeding to payment.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Save order into the database
            FoodMenuManager.PlaceOrder(userId, cartList);
            MessageBox.Show("Order confirmed and saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void lstCartFood_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstCartFood.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lstCartFood.SelectedItems[0];
                string selectedItemName = selectedItem.SubItems[0].Text;

                var orderItem = cartList.FirstOrDefault(item => item.ItemName == selectedItemName);
                if (orderItem != null)
                {
                    numQuantity.Value = orderItem.Quantity; // Set quantity in numeric box
                }
            }
        }

        private void btnUpdateOrder_Click(object sender, EventArgs e)
        {
            if (lstCartFood.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select an item to update.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ListViewItem selectedItem = lstCartFood.SelectedItems[0];
            string selectedItemName = selectedItem.SubItems[0].Text;
            int newQuantity = (int)numQuantity.Value;

            if (newQuantity <= 0)
            {
                MessageBox.Show("Quantity must be at least 1.", "Invalid Quantity", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var orderItem = cartList.FirstOrDefault(item => item.ItemName == selectedItemName);
            if (orderItem != null)
            {
                orderItem.Quantity = newQuantity;
                MessageBox.Show("Order updated successfully!", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadCartItems(); // Refresh UI
            }
        }

        private void btnRemoveButton_Click(object sender, EventArgs e)
        {
            if (lstCartFood.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select an item to remove.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ListViewItem selectedItem = lstCartFood.SelectedItems[0];
            string selectedItemName = selectedItem.SubItems[0].Text;

            var orderItem = cartList.FirstOrDefault(item => item.ItemName == selectedItemName);
            if (orderItem != null)
            {
                cartList.Remove(orderItem);
                MessageBox.Show("Order removed successfully!", "Removed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadCartItems(); // Refresh UI
            }
        }

        private void btn_Return_Click(object sender, EventArgs e)
        {
            // Find the already opened CustomerMenu form
            foreach (Form form in Application.OpenForms)
            {
                if (form is CustomerMenu)
                {
                    form.Show();  // Show the existing form
                    this.Close(); // Close the CheckoutForm
                    return;
                }
            }

            // If not found, open a new one (fallback case)
            CustomerMenu customerMenu = new CustomerMenu(userId);
            customerMenu.Show();
            this.Close();
        }

        private void CheckoutForm_Load(object sender, EventArgs e)
        {

        }
    }
}
