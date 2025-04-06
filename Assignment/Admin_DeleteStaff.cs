using System;
using System.Windows.Forms;

namespace Assignment
{
    public partial class Admin_DeleteStaff : Form
    {
        public Admin_DeleteStaff()
        {
            InitializeComponent();

            // Set up event handler for comboBox1 selection change (roles)
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
        }

        private void DeleteStaff_Load(object sender, EventArgs e)
        {
            // Load staff roles into comboBox1
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(AdminClass.GetStaffRoles().ToArray());
            comboBox1.Items.Insert(0, "All Roles"); // Add "All Roles" option

            // Select "All Roles" by default
            comboBox1.SelectedIndex = 0;

            // Load all staff members into listBoxStaff
            LoadAllStaff();
        }


        private void LoadAllStaff()
        {
            try
            {
                listBoxStaff.Items.Clear();
                listBoxStaff.Items.AddRange(AdminClass.GetAllStaffNames().ToArray());

                if (listBoxStaff.Items.Count == 0)
                {
                    MessageBox.Show("No staff found.", "Information",
                                      MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading all staff: {ex.Message}", "Error",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Automatically load staff names when role selection changes
            LoadStaffForSelectedRole();
        }


        private void LoadStaffForSelectedRole()
        {
            if (comboBox1.SelectedItem == null) return;

            string selectedRole = comboBox1.SelectedItem.ToString();

            try
            {
                listBoxStaff.Items.Clear();

                // Check if "All Roles" is selected
                if (selectedRole == "All Roles")
                {
                    listBoxStaff.Items.AddRange(AdminClass.GetAllStaffNames().ToArray());
                }
                else
                {
                    listBoxStaff.Items.AddRange(AdminClass.GetStaffNamesByRole(selectedRole).ToArray());
                }

                // Do not show message if list is empty after filtering
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading staff: {ex.Message}", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btn_ResetseacrhStaff_Click(object sender, EventArgs e)
        {
            // Reset comboBox1 to "All Roles"
            comboBox1.SelectedIndex = 0;

            // Load all staff members again
            LoadAllStaff();
        }


        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (listBoxStaff.SelectedItem == null)
            {
                MessageBox.Show("Please select a staff member to delete.", "Warning",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedStaff = listBoxStaff.SelectedItem.ToString();

            // Confirm deletion
            DialogResult result = MessageBox.Show($"Are you sure you want to delete {selectedStaff}?",
                                                  "Confirm Delete",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                bool isDeleted = AdminClass.DeleteStaffById(selectedStaff);

                if (isDeleted)
                {
                    MessageBox.Show("Staff deleted successfully.", "Success",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Reload staff list, but suppress "No staff found" message
                    LoadStaffForSelectedRole();
                }
                else
                {
                    MessageBox.Show("Failed to delete staff.", "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void btn_Cancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}