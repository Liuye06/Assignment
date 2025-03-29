using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Assignment
{
    public partial class RCProfile : Form
    {
        public RCProfile()
        {
            InitializeComponent();
            currentUsername = username;
        }

        private void RCProfile_Load(object sender, EventArgs e)
        {
            LoadRCData();
        }
        private void LoadRCData()
        {
            DataTable dt = ReservationCoordinator.GetRCData(currentUsername);
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                txt_AdminName.Text = row["Real_Name"].ToString();
                txt_AdminDOB.Text = Convert.ToDateTime(row["DOB"]).ToString("yyyy-MM-dd");
                txt_AdminGender.Text = row["Gender"].ToString();
                txt_AdminEmail.Text = row["Email"].ToString();
                txt_AdminUsername.Text = row["Username"].ToString();
                txt_AdminPassword.Text = row["Password"].ToString();
                // load the profile
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
            bool updated = ReservationCoordinator.UpdateRCProfile(
                currentUsername,
                txt_RCName.Text,
                txt_RCDOB.Text,
                txt_RCGender.Text,
                txt_RCEmail.Text,
                txt_RCPassword.Text
            );

            if (updated)
                MessageBox.Show("Profile updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Update failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        private void btn_editProfile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Title = "Select Profile Picture",
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog.FileName);

                bool updated = ReservationCoordinator.UpdateRCProfilePic(currentUsername, openFileDialog.FileName);
                if (updated)
                    MessageBox.Show("Profile picture updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Failed to update profile picture.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
