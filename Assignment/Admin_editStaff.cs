using System;
using System.Windows.Forms;

namespace Assignment
{
    public partial class Admin_editStaff : Form
    {
        private DataGridView _dataGridView; // Reference to main form's DataGridView
        public Admin_editStaff(DataGridView dataGridView)
        {
            InitializeComponent();
            _dataGridView = dataGridView;

            // Set up event handlers
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
        }
        private void editStaff_Load(object sender, EventArgs e)
        {
            // Load roles
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(AdminClass.GetStaffRoles().ToArray());

            // Load editable fields
            comboBox2.Items.Clear();
            comboBox2.Items.AddRange(AdminClass.GetEditableFields().ToArray());

            // Clear other controls
            listBox1.Items.Clear();
            txt_EditCus.Clear();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null) return;

            string selectedRole = comboBox1.SelectedItem.ToString();

            // Load staff names for selected role
            listBox1.Items.Clear();
            listBox1.Items.AddRange(AdminClass.GetStaffNamesByRole(selectedRole).ToArray());

            // Clear other controls
            comboBox2.SelectedIndex = -1;
            txt_EditCus.Clear();
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null) return;

            string selectedStaff = listBox1.SelectedItem.ToString();
            var details = AdminClass.GetStaffDetails(selectedStaff);

            // Display current value when field is selected
            if (comboBox2.SelectedItem != null)
            {
                string selectedField = comboBox2.SelectedItem.ToString();
                txt_EditCus.Text = details.ContainsKey(selectedField) ? details[selectedField] : "";
            }
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null || comboBox2.SelectedItem == null) return;

            string selectedStaff = listBox1.SelectedItem.ToString();
            string selectedField = comboBox2.SelectedItem.ToString();

            var details = AdminClass.GetStaffDetails(selectedStaff);
            txt_EditCus.Text = details.ContainsKey(selectedField) ? details[selectedField] : "";
        }
        private void btn_EditCus_Click_1(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null ||
                comboBox2.SelectedItem == null ||
                string.IsNullOrWhiteSpace(txt_EditCus.Text))
            {
                MessageBox.Show("Please select a staff member, field, and enter new value",
                              "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string staffName = listBox1.SelectedItem.ToString();
            string field = comboBox2.SelectedItem.ToString();
            string newValue = txt_EditCus.Text.Trim();

            DialogResult confirm = MessageBox.Show(
                $"Are you sure you want to update {staffName}'s {field} to {newValue}?",
                "Confirm Update",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                bool success = AdminClass.UpdateStaffInfo(staffName, field, newValue, _dataGridView);
                if (success)
                {
                    MessageBox.Show("Staff information updated successfully!",
                                  "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Refresh the current field value
                    comboBox2_SelectedIndexChanged(sender, e);
                    this.Close(); // Close the form after successful update
                }
                else
                {
                    MessageBox.Show("Failed to update staff information",
                                  "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void btn_Cancel_Click_1(object sender, EventArgs e)
        {
            // Clear all selections
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            listBox1.Items.Clear();
            txt_EditCus.Clear();
            this.Close(); // Close the form
        }
    }
}