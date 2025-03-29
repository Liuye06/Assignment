using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Assignment;

namespace Assignment
{
    public partial class EditCus : Form
    {
        private DataGridView dataGridView;
        private string selectedUserId = "";
        public EditCus(DataGridView dgv)
        {
            InitializeComponent(); // This must be first!
            this.dataGridView = dgv ?? throw new ArgumentNullException(nameof(dgv));

            // Proper event handler assignment
            this.listBox1.SelectedIndexChanged += ListBox1_SelectedIndexChanged;
            this.btn_EditCus.Click += btn_EditCus_Click_1;

            // Initialize comboBox items
            comboBox1.Items.AddRange(new string[] {
            "Real Name",
            "Date of Birth",
            "Gender",
            "Email",
            "Username"
        });
     }
        private void EditCus_Load(object sender, EventArgs e)
        {
            try
            {
                if (listBox1 != null && !listBox1.IsDisposed)
                {
                    AdminClass.LoadCustomers(listBox1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading customers: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem is ListItem selectedItem)
            {
                selectedUserId = selectedItem.Value;
            }
            else
            {
                selectedUserId = "";
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_EditCus.Clear();
            if (comboBox1.SelectedItem?.ToString() == "Date of Birth")
            {
                txt_EditCus.Text = "DD/MM/YYYY";
            }
        }
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            listBox1.ClearSelected();
            comboBox1.SelectedIndex = -1;
            txt_EditCus.Clear();
            selectedUserId = "";
        }

        private void btn_EditCus_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedUserId) || comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Please select a user and a field to edit.", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedField = comboBox1.SelectedItem.ToString();
            string newValue = txt_EditCus.Text.Trim();

            if (string.IsNullOrWhiteSpace(newValue))
            {
                MessageBox.Show("Please enter a valid value.", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Single combined confirmation dialog with user ID
            DialogResult result = MessageBox.Show(
                $"User ID: {selectedUserId}\n\nChange {selectedField} to: {newValue}\n\nConfirm update?",
                "Update Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
            {
                return; // User canceled
            }

            // Rest of your update logic...
            var fieldMapping = new Dictionary<string, string>
    {
        { "Real Name", "Real_Name" },
        { "Date of Birth", "DOB" },
        { "Gender", "Gender" },
        { "Email", "Email" },
        { "Username", "Username" }
    };

            bool success = AdminClass.EditUser(
                selectedUserId,
                fieldMapping[selectedField],
                newValue,
                dataGridView
            );

            if (success)
            {
                MessageBox.Show("Update successful!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                AdminClass.LoadCustomers(listBox1);
            }
        }
    }
}