using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Assignment
{
    public partial class RCProfile : Form
    {
        private string username; 

        public RCProfile(string loggedInUsername)
        {
            InitializeComponent();
            username = loggedInUsername;
        }
        private void RCProfile_Load(object sender, EventArgs e)
        {
            LoadUserProfile();
        }

        private void LoadUserProfile()
        {
            DataTable dt = RersevationCoordinator.GetRCData(username);
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                txt_RCName.Text = row["Real_Name"].ToString();
                txt_RCDOB.Text = Convert.ToDateTime(row["DOB"]).ToString("yyyy-MM-dd");
                txt_RCGender.Text = row["Gender"].ToString();
                txt_RCEmail.Text = row["Email"].ToString();
                txt_RCUsername.Text = row["Username"].ToString();
                txt_RCPassword.Text = row["Password"].ToString();

                // load profile
                if (row["Profile_Pic"] != DBNull.Value)
                {
                    byte[] imageBytes = (byte[])row["Profile_Pic"];
                    using (MemoryStream ms = new MemoryStream(imageBytes))
                    {
                        pictureBox1.Image = Image.FromStream(ms);
                    }
                }
            }
        }
        private void btn_SaveProfile_Click(object sender, EventArgs e)
        {
            bool updated = RersevationCoordinator.UpdateRCProfile(
                username,
                txt_RCName.Text,
                txt_RCDOB.Text,
                txt_RCGender.Text,
                txt_RCEmail.Text,
                txt_RCPassword.Text
            );

            if (updated)
            {
                MessageBox.Show("Profile updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Failed to update profile.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_EditProfile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(ofd.FileName);
                pictureBox1.Tag = ofd.FileName; 
            }
        }
        private void btn_SaveProfilePic_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Tag != null)
            {
                string imagePath = pictureBox1.Tag.ToString();
                bool updated = RersevationCoordinator.UpdateRCProfilePic(username, imagePath);

                if (updated)
                {
                    MessageBox.Show("Profile picture updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Failed to update profile picture.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select an image first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
