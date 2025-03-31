using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Assignment.FoodMenuManager;

namespace Assignment
{
    public partial class CheckoutForm : Form
    {

        private List<OrderItem> cartList;
        private int userId;

        public CheckoutForm(List<OrderItem> cart, int userId)
        {
            InitializeComponent();
            this.cartList = cart;
            this.userId = userId;
            LoadCartItems();
        }

        private void LoadCartItems()
        {
            listView1.Items.Clear();
            decimal totalAmount = 0;

            foreach (var item in cartList)
            {
                ListViewItem listItem = new ListViewItem(new string[]
                {
                item.ItemName,
                item.Quantity.ToString(),
                $"RM {item.Price:F2}",
                $"RM {item.Quantity * item.Price:F2}"
                });

                listView1.Items.Add(listItem);
                totalAmount += item.Quantity * item.Price;
            }

            label1.Text = $"Total: RM {totalAmount:F2}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Save order into the database
            FoodMenuManager.PlaceOrder(userId, cartList);
            MessageBox.Show("Order confirmed and saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
