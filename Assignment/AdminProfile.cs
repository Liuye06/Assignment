using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    public partial class AdminProfile : Form
    {
        private int currentUserID;

        public AdminProfile(int userID)
        {
            InitializeComponent();
            currentUserID = userID;
        }

        private void AdminProfile_Load(object sender, EventArgs e)
        {
            LoadAdminData();
        }


        private void LoadAdminData()
        {
            // Get admin data using current username
            DataTable dt = AdminClass.GetAdminData(currentUserID);
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];

                // Populate textboxes with current admin data
                txt_AdminName.Text = row["Real_Name"].ToString();
                txt_AdminEmail.Text = row["Email"].ToString();
                txt_AdminUsername.Text = row["Username"].ToString();
                txt_AdminPassword.Text = row["Password"].ToString();

                // Set the DateTimePicker value
                dtp_dob_for_admin.Value = Convert.ToDateTime(row["DOB"]);

                // Set the ComboBox value for Gender
                cb_AdminGender.SelectedItem = row["Gender"].ToString();

                // Load the profile picture (if available)
                if (row["Profile_Pic"] != DBNull.Value)
                {
                    byte[] imageData = (byte[])row["Profile_Pic"];
                    using (MemoryStream ms = new MemoryStream(imageData))
                    {
                        pictureBox1.Image = Image.FromStream(ms);
                    }
                }
            }
        }


        private void btn_SaveProfile_Click(object sender, EventArgs e)
        {
            // Get the updated values from the controls
            string updatedName = txt_AdminName.Text;
            string updatedEmail = txt_AdminEmail.Text;
            string updatedUsername = txt_AdminUsername.Text;
            string updatedPassword = txt_AdminPassword.Text;
            string updatedDOB = dtp_dob_for_admin.Value.ToString("yyyy-MM-dd");
            string updatedGender = cb_AdminGender.SelectedItem.ToString();

            // Call the method to update the admin profile in the database
            bool updated = AdminClass.UpdateAdminProfile(
                currentUserID,
                updatedUsername,
                updatedName,
                updatedDOB,
                updatedGender,
                updatedEmail,
                updatedPassword
            );

            // Show a message to indicate success or failure
            if (updated)
                MessageBox.Show("Profile updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Update failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            Admin adminForm = new Admin(currentUserID);
            adminForm.Show();
            this.Close();
        }


        private void btn_editProfile_Click(object sender, EventArgs e)
        {
            // Allow user to select a new profile picture
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Title = "Select Profile Picture",
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
            };

            // If a file is selected, set the picture
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog.FileName);

                // Update the profile picture in the database
                bool updated = AdminClass.UpdateAdminProfilePic(currentUserID, openFileDialog.FileName);
                if (updated)
                    MessageBox.Show("Profile picture updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Failed to update profile picture.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Admin adminForm = new Admin(currentUserID);
            adminForm.Show();
            this.Close();
        }
    }
}
