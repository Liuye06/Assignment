namespace Assignment
{
    partial class Manager_EditProfile
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manager_EditProfile));
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.cmbManagerGender = new System.Windows.Forms.ComboBox();
            this.picManagerProfilePic = new System.Windows.Forms.PictureBox();
            this.txtManagerPassword = new System.Windows.Forms.TextBox();
            this.txtManagerUsername = new System.Windows.Forms.TextBox();
            this.lblManagerPassword = new System.Windows.Forms.Label();
            this.lblManagerUsername = new System.Windows.Forms.Label();
            this.lblManagerGender = new System.Windows.Forms.Label();
            this.lblManagerDOB = new System.Windows.Forms.Label();
            this.btnSaveManagerProfile = new System.Windows.Forms.Button();
            this.txtMangerEmail = new System.Windows.Forms.TextBox();
            this.txtManagerName = new System.Windows.Forms.TextBox();
            this.lblManagerProfilePic = new System.Windows.Forms.Label();
            this.lblManagerEmail = new System.Windows.Forms.Label();
            this.lblManagerName = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnEditBrowseImageMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picManagerProfilePic)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpDOB
            // 
            this.dtpDOB.Location = new System.Drawing.Point(331, 269);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(271, 30);
            this.dtpDOB.TabIndex = 22;
            // 
            // cmbManagerGender
            // 
            this.cmbManagerGender.BackColor = System.Drawing.Color.LightGray;
            this.cmbManagerGender.FormattingEnabled = true;
            this.cmbManagerGender.Items.AddRange(new object[] {
            "Female",
            "Male"});
            this.cmbManagerGender.Location = new System.Drawing.Point(331, 322);
            this.cmbManagerGender.Name = "cmbManagerGender";
            this.cmbManagerGender.Size = new System.Drawing.Size(271, 33);
            this.cmbManagerGender.TabIndex = 34;
            // 
            // picManagerProfilePic
            // 
            this.picManagerProfilePic.BackColor = System.Drawing.Color.Gainsboro;
            this.picManagerProfilePic.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picManagerProfilePic.Location = new System.Drawing.Point(689, 86);
            this.picManagerProfilePic.Name = "picManagerProfilePic";
            this.picManagerProfilePic.Size = new System.Drawing.Size(219, 210);
            this.picManagerProfilePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picManagerProfilePic.TabIndex = 33;
            this.picManagerProfilePic.TabStop = false;
            // 
            // txtManagerPassword
            // 
            this.txtManagerPassword.BackColor = System.Drawing.Color.LightGray;
            this.txtManagerPassword.Location = new System.Drawing.Point(331, 105);
            this.txtManagerPassword.Name = "txtManagerPassword";
            this.txtManagerPassword.Size = new System.Drawing.Size(271, 30);
            this.txtManagerPassword.TabIndex = 32;
            // 
            // txtManagerUsername
            // 
            this.txtManagerUsername.BackColor = System.Drawing.Color.LightGray;
            this.txtManagerUsername.Location = new System.Drawing.Point(331, 51);
            this.txtManagerUsername.Name = "txtManagerUsername";
            this.txtManagerUsername.Size = new System.Drawing.Size(271, 30);
            this.txtManagerUsername.TabIndex = 31;
            // 
            // lblManagerPassword
            // 
            this.lblManagerPassword.AutoSize = true;
            this.lblManagerPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblManagerPassword.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManagerPassword.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblManagerPassword.Location = new System.Drawing.Point(155, 105);
            this.lblManagerPassword.Name = "lblManagerPassword";
            this.lblManagerPassword.Size = new System.Drawing.Size(107, 25);
            this.lblManagerPassword.TabIndex = 30;
            this.lblManagerPassword.Text = "Password";
            // 
            // lblManagerUsername
            // 
            this.lblManagerUsername.AutoSize = true;
            this.lblManagerUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblManagerUsername.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManagerUsername.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblManagerUsername.Location = new System.Drawing.Point(155, 51);
            this.lblManagerUsername.Name = "lblManagerUsername";
            this.lblManagerUsername.Size = new System.Drawing.Size(111, 25);
            this.lblManagerUsername.TabIndex = 29;
            this.lblManagerUsername.Text = "Username";
            // 
            // lblManagerGender
            // 
            this.lblManagerGender.AutoSize = true;
            this.lblManagerGender.BackColor = System.Drawing.Color.Transparent;
            this.lblManagerGender.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManagerGender.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblManagerGender.Location = new System.Drawing.Point(155, 320);
            this.lblManagerGender.Name = "lblManagerGender";
            this.lblManagerGender.Size = new System.Drawing.Size(83, 25);
            this.lblManagerGender.TabIndex = 28;
            this.lblManagerGender.Text = "Gender";
            // 
            // lblManagerDOB
            // 
            this.lblManagerDOB.AutoSize = true;
            this.lblManagerDOB.BackColor = System.Drawing.Color.Transparent;
            this.lblManagerDOB.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManagerDOB.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblManagerDOB.Location = new System.Drawing.Point(155, 271);
            this.lblManagerDOB.Name = "lblManagerDOB";
            this.lblManagerDOB.Size = new System.Drawing.Size(151, 25);
            this.lblManagerDOB.TabIndex = 27;
            this.lblManagerDOB.Text = "Date of Birth";
            // 
            // btnSaveManagerProfile
            // 
            this.btnSaveManagerProfile.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveManagerProfile.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnSaveManagerProfile.Location = new System.Drawing.Point(149, 393);
            this.btnSaveManagerProfile.Name = "btnSaveManagerProfile";
            this.btnSaveManagerProfile.Size = new System.Drawing.Size(390, 35);
            this.btnSaveManagerProfile.TabIndex = 26;
            this.btnSaveManagerProfile.Text = "Save Profile";
            this.btnSaveManagerProfile.UseVisualStyleBackColor = true;
            this.btnSaveManagerProfile.Click += new System.EventHandler(this.btnSaveManagerProfile_Click);
            // 
            // txtMangerEmail
            // 
            this.txtMangerEmail.BackColor = System.Drawing.Color.LightGray;
            this.txtMangerEmail.Location = new System.Drawing.Point(331, 214);
            this.txtMangerEmail.Name = "txtMangerEmail";
            this.txtMangerEmail.Size = new System.Drawing.Size(271, 30);
            this.txtMangerEmail.TabIndex = 25;
            // 
            // txtManagerName
            // 
            this.txtManagerName.BackColor = System.Drawing.Color.LightGray;
            this.txtManagerName.Location = new System.Drawing.Point(331, 160);
            this.txtManagerName.Name = "txtManagerName";
            this.txtManagerName.Size = new System.Drawing.Size(271, 30);
            this.txtManagerName.TabIndex = 24;
            // 
            // lblManagerProfilePic
            // 
            this.lblManagerProfilePic.AutoSize = true;
            this.lblManagerProfilePic.BackColor = System.Drawing.Color.Transparent;
            this.lblManagerProfilePic.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManagerProfilePic.Location = new System.Drawing.Point(684, 53);
            this.lblManagerProfilePic.Name = "lblManagerProfilePic";
            this.lblManagerProfilePic.Size = new System.Drawing.Size(146, 22);
            this.lblManagerProfilePic.TabIndex = 23;
            this.lblManagerProfilePic.Text = "Profile Picture";
            // 
            // lblManagerEmail
            // 
            this.lblManagerEmail.AutoSize = true;
            this.lblManagerEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblManagerEmail.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManagerEmail.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblManagerEmail.Location = new System.Drawing.Point(155, 214);
            this.lblManagerEmail.Name = "lblManagerEmail";
            this.lblManagerEmail.Size = new System.Drawing.Size(75, 25);
            this.lblManagerEmail.TabIndex = 21;
            this.lblManagerEmail.Text = "Email";
            // 
            // lblManagerName
            // 
            this.lblManagerName.AutoSize = true;
            this.lblManagerName.BackColor = System.Drawing.Color.Transparent;
            this.lblManagerName.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManagerName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblManagerName.Location = new System.Drawing.Point(155, 160);
            this.lblManagerName.Name = "lblManagerName";
            this.lblManagerName.Size = new System.Drawing.Size(69, 25);
            this.lblManagerName.TabIndex = 20;
            this.lblManagerName.Text = "Name";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnCancel.Location = new System.Drawing.Point(545, 394);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(393, 34);
            this.btnCancel.TabIndex = 35;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnEditBrowseImageMenu
            // 
            this.btnEditBrowseImageMenu.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditBrowseImageMenu.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnEditBrowseImageMenu.Location = new System.Drawing.Point(689, 320);
            this.btnEditBrowseImageMenu.Name = "btnEditBrowseImageMenu";
            this.btnEditBrowseImageMenu.Size = new System.Drawing.Size(219, 34);
            this.btnEditBrowseImageMenu.TabIndex = 36;
            this.btnEditBrowseImageMenu.Text = "Browse Image";
            this.btnEditBrowseImageMenu.UseVisualStyleBackColor = true;
            this.btnEditBrowseImageMenu.Click += new System.EventHandler(this.btnEditBrowseImageMenu_Click);
            // 
            // ManagerEditProfile
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(237)))), ((int)(((byte)(225)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1082, 453);
            this.Controls.Add(this.btnEditBrowseImageMenu);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.dtpDOB);
            this.Controls.Add(this.cmbManagerGender);
            this.Controls.Add(this.picManagerProfilePic);
            this.Controls.Add(this.txtManagerPassword);
            this.Controls.Add(this.txtManagerUsername);
            this.Controls.Add(this.lblManagerPassword);
            this.Controls.Add(this.lblManagerUsername);
            this.Controls.Add(this.lblManagerGender);
            this.Controls.Add(this.lblManagerDOB);
            this.Controls.Add(this.btnSaveManagerProfile);
            this.Controls.Add(this.txtMangerEmail);
            this.Controls.Add(this.txtManagerName);
            this.Controls.Add(this.lblManagerProfilePic);
            this.Controls.Add(this.lblManagerEmail);
            this.Controls.Add(this.lblManagerName);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ManagerEditProfile";
            this.Text = "ManagerEditProfile";
            this.Load += new System.EventHandler(this.ManagerEditProfile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picManagerProfilePic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.ComboBox cmbManagerGender;
        private System.Windows.Forms.PictureBox picManagerProfilePic;
        private System.Windows.Forms.TextBox txtManagerPassword;
        private System.Windows.Forms.TextBox txtManagerUsername;
        private System.Windows.Forms.Label lblManagerPassword;
        private System.Windows.Forms.Label lblManagerUsername;
        private System.Windows.Forms.Label lblManagerGender;
        private System.Windows.Forms.Label lblManagerDOB;
        private System.Windows.Forms.Button btnSaveManagerProfile;
        private System.Windows.Forms.TextBox txtMangerEmail;
        private System.Windows.Forms.TextBox txtManagerName;
        private System.Windows.Forms.Label lblManagerProfilePic;
        private System.Windows.Forms.Label lblManagerEmail;
        private System.Windows.Forms.Label lblManagerName;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnEditBrowseImageMenu;
    }
}