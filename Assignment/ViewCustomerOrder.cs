using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    public partial class ViewCustomerOrder : Form
    {
        private SidebarManager _sidebarManager;

        public ViewCustomerOrder()
        {
            InitializeComponent();
            _sidebarManager = new SidebarManager(this);
        }

        private void LoadCartItems()
        {
            listB_Items.View = View.Details; // Ensure items are displayed in detail mode
            listB_Items.FullRowSelect = true; // Allow full row selection

            // Clear existing columns and set new ones
            listB_Items.Columns.Clear();
            listB_Items.Columns.Add("Item Name", 150, HorizontalAlignment.Left);
            listB_Items.Columns.Add("Quantity", 70, HorizontalAlignment.Center);
            listB_Items.Columns.Add("Price (RM/Each)", 90, HorizontalAlignment.Right);

            listB_Items.Items.Clear(); // Clear existing items
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

        private void listB_Items_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
