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

namespace Assignment
{
    public partial class ChefEditProfile : Form
    {
        private int currentUserID; // Store the userID for the chef
        private Chef_Profile _chefProfile;
        private byte[] profilePicData = null; // Store the image data

        public ChefEditProfile(int userID, Chef_Profile chefProfile)
        {
            InitializeComponent();
            currentUserID = userID; // Store the userID
            _chefProfile = chefProfile; // Store reference to the parent form
        }
       

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ChefEditProfile_Load_1(object sender, EventArgs e)
        {
            Dictionary<string, object> chefData = ChefProfileDB.GetChefProfile(currentUserID);

            if (chefData.Count > 0)
            {
                txtEmail.Text = chefData["Email"].ToString();
                txtName.Text = chefData["Real_Name"].ToString();
                dtpDOB.Value = (DateTime)chefData["DOB"];
                cmbGender.SelectedItem = chefData["Gender"].ToString();
                txtUsername.Text = chefData["Username"].ToString();
                txtPassword.Text = chefData["Password"].ToString(); // Load password

                // Make username field read-only
                txtUsername.ReadOnly = true;

                if (chefData.ContainsKey("Profile_Pic"))
                {
                    picProfilePic.Image = (Image)chefData["Profile_Pic"];
                }
            }
        }

        private void btnSaveProfile_Click(object sender, EventArgs e)
        {
            // Convert image to byte array using the service method
            byte[] imageBytes = ImageManager.ImageToByteArray(picProfilePic.Image);

            bool isUpdated = ChefProfileDB.UpdateChefProfile(
                currentUserID,
                txtEmail.Text,
                txtName.Text,
                dtpDOB.Value,
                cmbGender.SelectedItem.ToString(),
                txtPassword.Text,
                imageBytes
            );

            if (isUpdated)
            {
                MessageBox.Show("Profile updated successfully.");

                // Call ReloadManagerProfile from the parent form to refresh the data
                if (_chefProfile != null)
                {
                    _chefProfile.ReloadManagerProfile();
                }

                this.Close();
            }
            else
            {
                MessageBox.Show("Failed to update profile.");
            }
        }

        private void btnEditBrowseImageMenu_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Title = "Select Profile Picture",
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string imagePath = openFileDialog.FileName;
                picProfilePic.Image = new Bitmap(imagePath);

                // Convert image to byte array using MemoryStream (directly in the method)
                using (MemoryStream ms = new MemoryStream())
                {
                    picProfilePic.Image.Save(ms, picProfilePic.Image.RawFormat);
                    profilePicData = ms.ToArray();
                }
            }
        }
    }
}
