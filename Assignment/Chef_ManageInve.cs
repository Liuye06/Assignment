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
    public partial class Chef_ManageInve: Form
    {
        private SidebarManager _sidebarManager;
        private BindingSource bindingSource = new BindingSource();
        private int currentUserID; // Store the userID

        public Chef_ManageInve(int userID)
        {
            InitializeComponent();
            _sidebarManager = new SidebarManager(this);
            currentUserID = userID; // Store the userID
            UserSessionManager.Login(userID);
        }


        private void Chef_Load(object sender, EventArgs e)
        {
            LoadChefData();
        }


        private void LoadChefData()
        {
            DataTable dt = ChefManager.LoadChefData();
            if (dt != null)
            {
                bindingSource.DataSource = dt;
                dgvIngredient.AutoGenerateColumns = false;
                dgvIngredient.DataSource = bindingSource;
            }
        }


        private void dgvIngredient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0) // Ensure valid cell
            {
                string columnName = dgvIngredient.Columns[e.ColumnIndex].Name; // Get clicked column name

                if (columnName == "ColIngredientEdit")
                {
                    // 📝 Edit Button Clicked
                    string ingredient = dgvIngredient.Rows[e.RowIndex].Cells["ColIngredientName"].Value.ToString();
                    EditChefName(ingredient);
                }
                else if (columnName == "ColIngredientDelete")
                {
                    // ❌ Delete Button Clicked
                    string ingredient = dgvIngredient.Rows[e.RowIndex].Cells["ColIngredientName"].Value.ToString();
                    DeleteChefName(ingredient);
                }
            }
        }

        private void EditChefName(string ingredient)
        {
            // Ensure the SidebarManager is passed
            SidebarManager sidebarManager = new SidebarManager(this);
            Chef_EditChefIngredient editForm = new Chef_EditChefIngredient(ingredient, sidebarManager, currentUserID);

            if (editForm.ShowDialog() == DialogResult.OK)
            {
                LoadChefData(); // Refresh menu items after editing
            }
        }


        private void DeleteChefName(string ingredient)
        {
            DialogResult result = MessageBox.Show($"Are you sure you want to delete {ingredient}?",
                                                  "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                if (ChefManager.DeleteChefData(ingredient)) // Call new method from MenuManager
                {
                    MessageBox.Show("Inventory data deleted successfully!");
                    LoadChefData(); // Refresh DataGridView
                }
                else
                {
                    MessageBox.Show("Error: Inventory data not found or could not be deleted.", "Deletion Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnAddNewIngredient_Click(object sender, EventArgs e)
        {
            Chef_AddChefIngredient form = new Chef_AddChefIngredient(currentUserID);

            if (form.ShowDialog() == DialogResult.OK) // Wait until form is closed
            {
                LoadChefData();
            }
        }

        private void btnSearchIngredient_Click(object sender, EventArgs e)
        {
            string searchText = txtIngredient.Text.Trim().Replace("'", "''"); // Prevent SQL errors

            if (!string.IsNullOrEmpty(searchText))
            {
                bindingSource.Filter = $"Ingredient LIKE '%{searchText}%'"; // 🔹 Apply filter
            }
            else
            {
                bindingSource.RemoveFilter(); // 🔹 Show all rows
            }
        }

        private void btnResetIngredientSearch_Click(object sender, EventArgs e)
        {
            txtIngredient.Text = "";
            bindingSource.RemoveFilter(); // Reset all filters 
        }


        private void btn_inventory_Click(object sender, EventArgs e)
        {
            _sidebarManager.NavigateTo(new Chef_ManageInve(currentUserID));
        }

        private void btn_CusOrder_Click(object sender, EventArgs e)
        {
            _sidebarManager.NavigateTo(new Chef_CustomerOrder(currentUserID));
        }

        private void btn_ChefProfile_Click(object sender, EventArgs e)
        {
            _sidebarManager.NavigateTo(new Chef_Profile(currentUserID));
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            UserSessionManager.Logout(this);
        }
    }
}
