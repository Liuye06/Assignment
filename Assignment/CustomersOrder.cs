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
    public partial class CustomersOrder: Form
    {
        private SidebarManager _sidebarManager;
        private OrderManager orderManager;
        private int chefID; // Current logged-in chef
        private BindingSource bindingSourceOrders;

        public CustomersOrder(int loggedInChefID=0)
        {
            InitializeComponent();
            orderManager = new OrderManager();
            chefID = loggedInChefID;
            bindingSourceOrders = new BindingSource();
            LoadOrders();
        }

        private void LoadOrders()
        {
            DataTable ordersTable = orderManager.GetOrders();
            bindingSourceOrders.DataSource = ordersTable;

            dgvChefCusOrder.AutoGenerateColumns = false; //Prevent duplicate column
            dgvChefCusOrder.DataSource = bindingSourceOrders;

            dgvChefCusOrder.Columns.Clear(); // Ensure no duplicate columns

            // Add only necessary columns
            dgvChefCusOrder.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "FoodName", HeaderText = "Food Name" });
            dgvChefCusOrder.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "OrderStatus", HeaderText = "Status" });
            dgvChefCusOrder.Columns.Add(new DataGridViewComboBoxColumn { DataPropertyName = "Action", HeaderText = "Action" });
            dgvChefCusOrder.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "ChefInCharge", HeaderText = "Chef In Charge" });
        }

        private void btnResetMMenu_Click(object sender, EventArgs e)
        {

        }

        private void btninventory_ChefCustomerOrder_Click(object sender, EventArgs e)
        {
            _sidebarManager.NavigateTo(new Chef());
        }

        private void btnCusOrder_ChefCustomerOrder_Click(object sender, EventArgs e)
        {
            _sidebarManager.NavigateTo(new CustomersOrder());
        }

        private void btnChefProfile_ChefCustomerOrder_Click(object sender, EventArgs e)
        {
            _sidebarManager.NavigateTo(new Chef_Profile());
        }

        private void btnUpdateCusOrderStatus_Click(object sender, EventArgs e)
        {
            if (bindingSourceOrders.Current != null) // Check if a row is selected
            {
                DataRowView selectedRow = (DataRowView)bindingSourceOrders.Current;
                int orderID = Convert.ToInt32(selectedRow["Order_ID"]);
                string newStatus = cmbNewCusOrderStatus.SelectedItem?.ToString();

                if (string.IsNullOrEmpty(newStatus))
                {
                    MessageBox.Show("Please select a valid status.");
                    return;
                }

                bool success = orderManager.UpdateOrderStatus(orderID, newStatus, chefID);
                if (success)
                {
                    MessageBox.Show("Order status updated successfully!");
                    LoadOrders(); // Refresh BindingSource
                }
                else
                {
                    MessageBox.Show("You are not authorized to update this order.");
                }
            }
            else
            {
                MessageBox.Show("Please select an order to update.");
            }
        }
    }
}
