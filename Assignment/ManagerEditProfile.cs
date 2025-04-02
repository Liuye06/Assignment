using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Assignment
{
    public partial class ManagerEditProfile : Form
    {
        private int currentUserID; // Store the userID for the manager
        private ManagerProfile _managerProfile;
        private byte[] profilePicData = null; // Store the image data

        public ManagerEditProfile(int userID, ManagerProfile managerProfile)
        {
            InitializeComponent();
            currentUserID = userID; // Store the userID
            _managerProfile = managerProfile; // Store reference to the parent form
        }

        // Load manager profile data into the update form

        private void ManagerEditProfile_Load(object sender, EventArgs e)
        {
            Dictionary<string, object> managerData = ManagerProfileDB.GetManagerProfile(currentUserID);

            if (managerData.Count > 0)
            {
                txtMangerEmail.Text = managerData["Email"].ToString();
                txtManagerName.Text = managerData["Real_Name"].ToString();
                dtpDOB.Value = (DateTime)managerData["DOB"];
                cmbManagerGender.SelectedItem = managerData["Gender"].ToString();
                txtManagerUsername.Text = managerData["Username"].ToString();
                txtManagerPassword.Text = managerData["Password"].ToString(); // Load password

                // Make username field read-only
                txtManagerUsername.ReadOnly = true;

                if (managerData.ContainsKey("Profile_Pic"))
                {
                    picManagerProfilePic.Image = (Image)managerData["Profile_Pic"];
                }
            }
        }

        private void btnSaveManagerProfile_Click(object sender, EventArgs e)
        {
            // Convert image to byte array using the service method
            byte[] imageBytes = ImageManager.ImageToByteArray(picManagerProfilePic.Image);

            bool isUpdated = ManagerProfileDB.UpdateManagerProfile(
                currentUserID,
                txtMangerEmail.Text,
                txtManagerName.Text,
                dtpDOB.Value,
                cmbManagerGender.SelectedItem.ToString(),
                txtManagerPassword.Text,
                imageBytes
            );

            if (isUpdated)
            {
                MessageBox.Show("Profile updated successfully.");

                // Call ReloadManagerProfile from the parent form to refresh the data
                if (_managerProfile != null)
                {
                    _managerProfile.ReloadManagerProfile();
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
                picManagerProfilePic.Image = new Bitmap(imagePath);

                // Convert image to byte array using MemoryStream (directly in the method)
                using (MemoryStream ms = new MemoryStream())
                {
                    picManagerProfilePic.Image.Save(ms, picManagerProfilePic.Image.RawFormat);
                    profilePicData = ms.ToArray();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

