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

namespace Assignment
{
    public partial class ChefCustomerOrder: Form
    {
        private SidebarManager _sidebarManager;
        private int currentUserID; // Store the userID
        private BindingSource bindingSourceOrders;

        public ChefCustomerOrder(int userID)
        {
            InitializeComponent();
            _sidebarManager = new SidebarManager(this);
            bindingSourceOrders = new BindingSource();
            LoadOrders();
            LoadChefsIntoComboBox(); // Load chefs into ComboBox
            dgvChefCusOrder.CellClick += dgvChefCusOrder_CellContentClick_1;
            currentUserID = userID; // Store the userID
            UserSessionManager.Login(userID);
        }

        private void LoadOrders()
        {
            DataTable ordersTable = OrderManager.GetOrders(currentUserID);

            if (ordersTable == null || ordersTable.Rows.Count == 0)
            {
                MessageBox.Show("No data found! Check your database connection.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bindingSourceOrders.DataSource = ordersTable;
            dgvChefCusOrder.AutoGenerateColumns = false;
            dgvChefCusOrder.DataSource = bindingSourceOrders;
        }


        private void dgvChefCusOrder_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // Ensure the event is triggered by a valid row and column
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return; // Prevent errors from header row clicks

            // Ensure "Status" and "ChefInCharge" columns exist
            if (dgvChefCusOrder.Columns["Status"] == null || dgvChefCusOrder.Columns["ChefInCharge"] == null)
            {
                MessageBox.Show("Required columns are missing.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataGridViewRow row = dgvChefCusOrder.Rows[e.RowIndex];

            // Check if "ChefInCharge" column was changed
            if (e.ColumnIndex == dgvChefCusOrder.Columns["ChefInCharge"].Index)
            {
                if (row.Cells["FoodID"].Value == null)
                {
                    MessageBox.Show("Missing FoodID value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                try
                {
                    int foodItemID = Convert.ToInt32(row.Cells["FoodID"].Value);
                    int chefID = Convert.ToInt32(row.Cells["ChefInCharge"].Value);

                    // Update the Chef in Charge
                    bool chefUpdateSuccess = OrderManager.UpdateChefInCharge(foodItemID, chefID);

                    if (chefUpdateSuccess)
                    {
                        // Automatically update the order status once a chef is assigned
                        string newStatus = "In Progress"; // You can change this as per your requirements

                        bool statusUpdateSuccess = OrderManager.UpdateOrderStatus(foodItemID, newStatus, chefID);

                        if (!statusUpdateSuccess)
                        {
                            MessageBox.Show("Failed to update order status.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Failed to update Chef In Charge.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
            if (dgvChefCusOrder.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an order first.");
                return;
            }

            DataGridViewRow selectedRow = dgvChefCusOrder.SelectedRows[0];
            int orderID = Convert.ToInt32(selectedRow.Cells["CusOrderID"].Value);
            string currentStatus = selectedRow.Cells["OrderStatus"].Value?.ToString();

            if (string.IsNullOrEmpty(currentStatus))
            {
                MessageBox.Show("Order status is not available.");
                return;
            }

            // Define the new status to update based on current status
            string newStatus = string.Empty;

            if (currentStatus == "In Progress")
            {
                newStatus = "Completed"; // Update to "Completed" if current status is "In Progress"
            }
            else if (currentStatus == "Completed")
            {
                MessageBox.Show("This order is already completed.");
                return; // No update needed if the order is already completed
            }
            else
            {
                newStatus = "In Progress"; // Update to "In Progress" for other statuses
            }

            // Update the status to the new value
            bool statusUpdateSuccess = OrderManager.UpdateOrderStatus(orderID, newStatus, currentUserID);

            if (statusUpdateSuccess)
            {
                MessageBox.Show($"Order status updated to {newStatus}.");
                LoadOrders(); // Refresh DataGridView
            }
            else
            {
                MessageBox.Show("Failed to update order status.");
            }
        }


        private void dgvChefCusOrder_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            // Ensure a valid row is clicked
            if (e.RowIndex < 0 || e.RowIndex >= dgvChefCusOrder.RowCount || e.ColumnIndex < 0)
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

            // Find all rows that have the same CusOrderID and change their color
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
        }


        private void btnUpdateChef_Click(object sender, EventArgs e)
        {
            if (dgvChefCusOrder.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an order first.");
                return;
            }

            DataGridViewRow selectedRow = dgvChefCusOrder.SelectedRows[0];
            int orderID = Convert.ToInt32(selectedRow.Cells["CusOrderID"].Value);
            int? newChefID = cmbChef.SelectedValue as int?;

            if (!newChefID.HasValue)
            {
                MessageBox.Show("Please select a valid chef.");
                return;
            }

            bool chefUpdateSuccess = OrderManager.UpdateChefInCharge(orderID, newChefID.Value);

            if (chefUpdateSuccess)
            {
                MessageBox.Show("Chef updated successfully!");
                LoadOrders(); // Refresh DataGridView
            }
            else
            {
                MessageBox.Show("Failed to update chef.");
            }
        }

        private void LoadChefsIntoComboBox()
        {
            DataTable chefsTable = OrderManager.GetAvailableChefs();

            if (chefsTable == null || chefsTable.Rows.Count == 0)
            {
                MessageBox.Show("No chefs found! Check your database connection.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            cmbChef.DataSource = chefsTable;
            cmbChef.DisplayMember = "ChefName";
            cmbChef.ValueMember = "ChefID";
        }


        private void btninventory_ChefCustomerOrder_Click(object sender, EventArgs e)
        {
            _sidebarManager.NavigateTo(new Chef(currentUserID));
        }

        private void btnCusOrder_ChefCustomerOrder_Click(object sender, EventArgs e)
        {
            _sidebarManager.NavigateTo(new ChefCustomerOrder(currentUserID));
        }

        private void btnChefProfile_ChefCustomerOrder_Click(object sender, EventArgs e)
        {
            _sidebarManager.NavigateTo(new Chef_Profile(currentUserID));
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            UserSessionManager.Logout(this);
        }
    }
}
