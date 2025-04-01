using System;
using System.Windows.Forms;

namespace Assignment
{
    public partial class addStaff : Form // Changed from cb_StaffGender
    {
        private DataGridView _dataGridView; // Reference to main form's grid

        public addStaff(DataGridView dataGridView)
        {
            InitializeComponent();
            _dataGridView = dataGridView;
            LoadStaffRoles();
            InitializeGenderComboBox();
        }

        private void InitializeGenderComboBox()
        {
            // Make sure the ComboBox is named cb_StaffGender in designer
            cb_StaffGender.Items.AddRange(new object[] { "Male", "Female" });
            cb_StaffGender.SelectedIndex = 0; // Select first item by default
        }

        private void LoadStaffRoles()
        {
            cB_StaffRole.DataSource = AdminClass.GetStaffRoles();
            cB_StaffRole.SelectedIndex = 0;
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txt_StaffName.Text))
            {
                ShowError("Please enter staff name");
                return false;
            }

            if (dtp_dob_for_staff.Value > DateTime.Today)
            {
                ShowError("Date of birth cannot be in the future.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txt_StaffEmail.Text) || !txt_StaffEmail.Text.Contains("@"))
            {
                ShowError("Please enter a valid email address");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txt_StaffUsername.Text))
            {
                ShowError("Please enter a username");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txt_StaffPassword.Text) || txt_StaffPassword.Text.Length < 6)
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

        private void ClearForm()
        {
            txt_StaffName.Text = "";
            dtp_dob_for_staff.Value = DateTime.Today;
            cb_StaffGender.SelectedIndex = -1;
            txt_StaffEmail.Text = "";
            txt_StaffUsername.Text = "";
            txt_StaffPassword.Text = "";
            cB_StaffRole.SelectedIndex = -1;
        }


        private void btn_addStaff_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
                return;

            DateTime dob = dtp_dob_for_staff.Value; // Get date directly

            if (!AdminClass.IsUsernameAvailable(txt_StaffUsername.Text))
            {
                MessageBox.Show("Username already exists", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool success = AdminClass.AddStaff(
                txt_StaffName.Text,
                dob,
                cb_StaffGender.SelectedItem.ToString(),
                txt_StaffEmail.Text,
                cB_StaffRole.SelectedItem.ToString(),
                txt_StaffUsername.Text,
                txt_StaffPassword.Text,
                _dataGridView);

            if (success)
            {
                MessageBox.Show("Staff registration successful!", "Success",
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
                // Refresh the DataGridView
                AdminClass.RefreshDataGridView(_dataGridView);
            }
        }
        private void addStaff_Load(object sender, EventArgs e)
        {
            dtp_dob_for_staff.Value = DateTime.Today; // Set default to today
            cb_StaffGender.SelectedIndex = 0;
            cB_StaffRole.SelectedIndex = 0;
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}