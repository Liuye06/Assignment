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
    public partial class RCEditProfile : Form
    {
        private int currentUserID;
        private RCProfile _rcProfile;
        private byte[] profilePicData = null; // Store the image data


        public RCEditProfile(int userID, RCProfile rcProfile)
        {
            InitializeComponent();
            currentUserID = userID; // Store the userID
            _rcProfile = rcProfile; // Store reference to the parent form
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void RCEditProfile_Load(object sender, EventArgs e)
        {
            Dictionary<string, object> rcData = RCProfileDB.GetRCProfile(currentUserID);

            if (rcData.Count > 0)
            {
                txtEmail.Text = rcData["Email"].ToString();
                txtName.Text = rcData["Real_Name"].ToString();
                dtpDOB.Value = (DateTime)rcData["DOB"];
                cmbGender.SelectedItem = rcData["Gender"].ToString();
                txtUsername.Text = rcData["Username"].ToString();
                txtPassword.Text = rcData["Password"].ToString(); // Load password

                // Make username field read-only
                txtUsername.ReadOnly = true;

                if (rcData.ContainsKey("Profile_Pic"))
                {
                    picProfilePic.Image = (Image)rcData["Profile_Pic"];
                }
            }
        }

        private void btnSaveProfile_Click_1(object sender, EventArgs e)
        {
            // Convert image to byte array using the service method
            byte[] imageBytes = ImageManager.ImageToByteArray(picProfilePic.Image);

            bool isUpdated = RCProfileDB.UpdateRCProfile(
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
                if (_rcProfile != null)
                {
                    _rcProfile.ReloadRCProfile();
                }

                this.Close();
            }
            else
            {
                MessageBox.Show("Failed to update profile.");
            }
        }

        private void btnEditBrowseImageMenu_Click(object sender, EventArgs e)
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
