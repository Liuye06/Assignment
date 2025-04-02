using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;
using System.Data;

namespace Assignment
{
    public partial class addCustomer : Form
    {
        private DataGridView _dataGridView; // Store reference to main form's DataGridView

        public addCustomer(DataGridView dataGridView)// Modify constructor to accept DataGridView
        {
            InitializeComponent();
            _dataGridView = dataGridView;
        }

        
        private void btn_addCus_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            DateTime dob = dtp_dob_for_cus.Value; // Get selected date

            if (!AdminClass.IsUsernameAvailable(txt_CusUsername.Text))
            {
                MessageBox.Show("Username already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool success = AdminClass.AddUser(
                txt_CusName.Text,
                dob,
                cb_gender.Text,
                txt_CusEmail.Text,
                "Customer",
                txt_CusUsername.Text,
                txt_CusPassword.Text,
                null
            );

            if (success)
            {
                MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                refresh();
                AdminClass.RefreshDataGridView(_dataGridView); // Refresh the DataGridView
            }
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txt_CusName.Text))
            {
                ShowError("Please enter customer name");
                return false;
            }

            if (dtp_dob_for_cus.Value > DateTime.Today)
            {
                ShowError("Please enter date of birth");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txt_CusEmail.Text) || !txt_CusEmail.Text.Contains("@"))
            {
                ShowError("Please enter a valid email address");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txt_CusUsername.Text))
            {
                ShowError("Please enter a username");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txt_CusPassword.Text) || txt_CusPassword.Text.Length < 6)
            {
                ShowError("Password must be at least 6 characters");
                return false;
            }

            return true;
        }

        private void ShowError(string message)
        {
            MessageBox.Show(message, "Validation Error",
                          MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void refresh()
        {
            txt_CusName.Text = "";
            dtp_dob_for_cus.Value = DateTime.Today;
            txt_CusEmail.Text = "";
            txt_CusUsername.Text = "";
            txt_CusPassword.Text = "";
            cb_gender.SelectedIndex = 0;
        }


        private void addCustomer_Load(object sender, EventArgs e)
        {
            // Initialize form with default values
            dtp_dob_for_cus.Value = DateTime.Today; // Set default to today
            cb_gender.SelectedIndex = 0; // Select first item (Male)
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}