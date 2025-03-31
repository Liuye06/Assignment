using System;
using System.Windows.Forms;

namespace Assignment
{
    public partial class DeleteStaff : Form
    {
        public DeleteStaff()
        {
            InitializeComponent();

            // Set up event handler for listBox selection change
            listBoxStaff.SelectedIndexChanged += listBoxStaff_SelectedIndexChanged;
        }

        private void DeleteStaff_Load(object sender, EventArgs e)
        {
            // Load staff roles from AdminClass
            listBoxStaff.Items.Clear();
            listBoxStaff.Items.AddRange(AdminClass.GetStaffRoles().ToArray());

            // Select first item by default if available
            if (listBoxStaff.Items.Count > 0)
            {
                listBoxStaff.SelectedIndex = 0;
            }
        }

        private void listBoxStaff_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Automatically load staff when role selection changes
            LoadStaffForSelectedRole();
        }

        private void btn_searchStaff_Click(object sender, EventArgs e)
        {
            // Reuse the same loading logic
            LoadStaffForSelectedRole();
        }

        private void LoadStaffForSelectedRole()
        {
            if (listBoxStaff.SelectedItem == null)
            {
                MessageBox.Show("Please select a role to search.", "Warning",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedRole = listBoxStaff.SelectedItem.ToString();

            // Get staff names from AdminClass
            try
            {
                comboBox1.DataSource = AdminClass.GetStaffNamesByRole(selectedRole);
                comboBox1.SelectedIndex = -1; // Clear any previous selection

                if (comboBox1.Items.Count == 0)
                {
                    MessageBox.Show("No staff found for the selected role.", "Information",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading staff: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Please select a staff member to delete.", "Warning",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedStaffName = comboBox1.SelectedItem.ToString();

            // Confirm deletion
            DialogResult result = MessageBox.Show($"Are you sure you want to delete {selectedStaffName}?",
                                                "Confirm Delete",
                                                MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    // Delete through AdminClass
                    bool isDeleted = AdminClass.DeleteStaffByName(selectedStaffName);

                    if (isDeleted)
                    {
                        MessageBox.Show("Staff deleted successfully.", "Success",
                                      MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Refresh the staff list
                        LoadStaffForSelectedRole();
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete staff.", "Error",
                                      MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting staff: {ex.Message}", "Error",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}