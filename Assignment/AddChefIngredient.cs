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
    public partial class AddChefIngredient : Form
    {
        private SidebarManager _sidebarManager;
        private int currentUserID; // Store the userID

        public AddChefIngredient(int userID)
        {
            InitializeComponent();
            _sidebarManager = new SidebarManager(this);
            currentUserID = userID; // Store the userID
        }

        private void btnAddNewIngredient_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAddIngredient.Text) ||
            string.IsNullOrWhiteSpace(txtAddStock.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtAddStock.Text, out int stock))
            {
                MessageBox.Show("Invalid stock format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool success = ChefManager.AddChefData(txtAddIngredient.Text, stock);

            if (success)
            {
                MessageBox.Show("Ingredient data added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Error adding ingredient data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancelIngredient_Click(object sender, EventArgs e)
        {
            this.Close(); // Closes the current form
        }
    }
}
