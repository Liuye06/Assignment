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
    public partial class Chef_EditChefIngredient : Form
    {
        private string originalIngredient;
        private SidebarManager _sidebarManager;
        private int currentUserID; // Store the userID

        public Chef_EditChefIngredient(string ingredient, SidebarManager sidebarManager, int userID)
        {
            InitializeComponent();
            originalIngredient = ingredient;
            LoadChefDataDetails(ingredient);
            _sidebarManager = sidebarManager;
            currentUserID = userID; // Store the userID
        }


        private void LoadChefDataDetails(string ingredient)
        {
            DataRow IngredientData = ChefManager.GetChefData(ingredient); // Fetch data from ChefManager

            if (IngredientData != null)
            {
                txtEditIngredient.Text = IngredientData["Ingredient"].ToString();
                txtEditStock.Text = IngredientData["Stock"].ToString();
            }
            else
            {
                MessageBox.Show("Ingredient data not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnSaveIngredient_Click(object sender, EventArgs e)
        {
            string newIngredient = txtEditIngredient.Text.Trim();
            string stock = txtEditStock.Text.Trim();

            if (string.IsNullOrEmpty(newIngredient) || string.IsNullOrEmpty(stock))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            if (!int.TryParse(stock, out int stockValue))
            {
                MessageBox.Show("Invalid capacity format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (ChefManager.UpdateChefData(originalIngredient, newIngredient, stock))
            {
                MessageBox.Show("Ingredient data updated successfully!");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnCancelEditIngredient_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ECinventory_Click(object sender, EventArgs e)
        {
            _sidebarManager.NavigateTo(new Chef_ManageInve(currentUserID));
        }

        private void btn_ECCusOrder_Click(object sender, EventArgs e)
        {
            _sidebarManager.NavigateTo(new Chef_CustomerOrder(currentUserID));
        }

        private void btn_ECChefProfile_Click(object sender, EventArgs e)
        {
            _sidebarManager.NavigateTo(new Chef_Profile(currentUserID));
        }
    }
}
