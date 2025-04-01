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
        private int currentUserID; // Store the userID
        private BindingSource bindingSourceOrders;

        public CustomersOrder(int userID)
        {
            InitializeComponent();
            _sidebarManager = new SidebarManager(this);
            bindingSourceOrders = new BindingSource();
            LoadOrders();
            dgvChefCusOrder.CellClick += dgvChefCusOrder_CellContentClick;
            currentUserID = userID; // Store the userID
        }

        private void LoadOrders()
        {
            DataTable ordersTable = OrderManager.GetOrders();

            if (ordersTable == null || ordersTable.Rows.Count == 0)
            {
                MessageBox.Show("No data found! Check your database connection.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (ordersTable != null)
            {
                bindingSourceOrders.DataSource = ordersTable;
                dgvChefCusOrder.AutoGenerateColumns = false;
                dgvChefCusOrder.DataSource = bindingSourceOrders;
            }
        }


        private void FilterOrdersByStatus()
        {
            string selectedStatus = cmbCusOrderStatus.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(selectedStatus) && selectedStatus != "All")
            {
                try
                {
                    bindingSourceOrders.Filter = $"OrderStatus LIKE '{selectedStatus}'";  // Case-sensitive check
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error applying filter: " + ex.Message);
                }
            }
            else
            {
                bindingSourceOrders.RemoveFilter();  // Clear filter
            }
        }


        private void cmbCusOrderStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterOrdersByStatus();
        }



        private void btnRefreshStatusCusOrder_Click(object sender, EventArgs e)
        {
            if (bindingSourceOrders.SupportsFiltering)
            {
                bindingSourceOrders.RemoveFilter();  // Clear any applied filter
            }

            cmbCusOrderStatus.SelectedIndex = 0; // Reset dropdown to "All"
            LoadOrders();  // Reload all orders from the database
        }


        private void btnUpdateCusOrderStatus_Click(object sender, EventArgs e)
        {
            if (lblOrderID.Tag == null)
            {
                MessageBox.Show("Please select an order first.");
                return;
            }

            int orderID = (int)lblOrderID.Tag;
            string newStatus = cmbNewCusOrderStatus.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(newStatus))
            {
                MessageBox.Show("Please select a valid status.");
                return;
            }

            bool success = OrderManager.UpdateOrderStatus(orderID, newStatus, currentUserID);
            if (success)
            {
                MessageBox.Show("Order status updated successfully!");
                LoadOrders(); // Refresh DataGridView
            }
            else
            {
                MessageBox.Show("You are not authorized to update this order.");
            }
        }


        private void dgvChefCusOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ensure a valid row is clicked
            if (e.RowIndex < 0 || e.RowIndex >= dgvChefCusOrder.RowCount || e.ColumnIndex < 0)
                return;

            // Check if the clicked column is a button column
            if (!(dgvChefCusOrder.Columns[e.ColumnIndex] is DataGridViewButtonColumn))
                return;

            // Get the selected row
            DataGridViewRow selectedRow = dgvChefCusOrder.Rows[e.RowIndex];

            if (selectedRow.Cells["CusOrderID"].Value == null)
            {
                MessageBox.Show("Invalid selection. Order ID is missing.");
                return;
            }

            // Retrieve the selected Order ID
            int orderID;
            if (!int.TryParse(selectedRow.Cells["CusOrderID"].Value.ToString(), out orderID))
            {
                MessageBox.Show("Invalid Order ID format.");
                return;
            }

            string foodName = selectedRow.Cells["ColFoodName"].Value?.ToString() ?? "Unknown";

            // Find all rows that have the same CusOrderID
            foreach (DataGridViewRow row in dgvChefCusOrder.Rows)
            {
                if (row.Cells["CusOrderID"].Value != null && Convert.ToInt32(row.Cells["CusOrderID"].Value) == orderID)
                {
                    row.DefaultCellStyle.BackColor = Color.LightBlue; // Highlight matching rows
                }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.White; // Reset other rows
                }
            }

            // Display confirmation info at the bottom
            lblOrderID.Text = $"Order: {orderID}";
            lblFoodName.Text = $"Food: {foodName}";

            // Save selected order ID for updating later
            lblOrderID.Tag = orderID;
        }


        private void btnResetMMenu_Click(object sender, EventArgs e)
        {
            cmbNewCusOrderStatus.SelectedIndex = -1; // Reset dropdown
        }


        private void btninventory_ChefCustomerOrder_Click(object sender, EventArgs e)
        {
            _sidebarManager.NavigateTo(new Chef(currentUserID));
        }

        private void btnCusOrder_ChefCustomerOrder_Click(object sender, EventArgs e)
        {
            _sidebarManager.NavigateTo(new CustomersOrder(currentUserID));
        }

        private void btnChefProfile_ChefCustomerOrder_Click(object sender, EventArgs e)
        {
            _sidebarManager.NavigateTo(new Chef_Profile());
        }
    }
}
