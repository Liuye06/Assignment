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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Assignment
{
    public partial class EditCus : Form
    {
        private string connectionString;

        public EditCus()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear(); // clear the listBox1

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT Real_Name FROM User WHERE Role = 'Customer'";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                listBox1.Items.Add(reader["Real_Name"].ToString());
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error edditing User Info:" + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnEditCus(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null || comboBox1.SelectedItem == null || string.IsNullOrWhiteSpace(txt_EditCus.Text))
            {
                MessageBox.Show("Please ensure you have selected a user, an editable field, and entered a new value!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedUser = listBox1.SelectedItem.ToString();  // Selected user's Real_Name
            string selectedField = comboBox1.SelectedItem.ToString(); // Selected field to edit
            string newValue = txt_EditCus.Text.Trim(); // New value to update

            // Call EditUser method
            if (EditUser(selectedUser, selectedField, newValue))
            {
                MessageBox.Show("User information updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Update failed. Please check the user information!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool EditUser(string selectedUser, string selectedField, string newValue)
        {
            throw new NotImplementedException();
        }

        private void EditCus_Load(object sender, EventArgs e)
        {
          
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Define possible user fields
            string[] information = { "Real_Name", "DOB", "Gender", "Email", "Username" };

            // Get selected field from ComboBox
            string selectedInfo = comboBox1.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(selectedInfo) && information.Contains(selectedInfo))
            {
                txt_EditCus.Text = ""; // Clear the text field when a new selection is made

                if (selectedInfo == "DOB")
                {
                    txt_EditCus.Text = "DD/MM/YYYY"; // Placeholder for date format
                }
            }
        }
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            listBox1.ClearSelected();    // Deselect any selected user in listBox1
            comboBox1.SelectedIndex = -1; // Reset comboBox1 selection
            txt_EditCus.Clear();         // Clear the text in txt_EditCus
        }
    }
}
