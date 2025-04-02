namespace Assignment
{
    partial class Chef_Profile
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
            this.tableSidebar_CProfile = new System.Windows.Forms.TableLayoutPanel();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btn_inventory_CProfile = new System.Windows.Forms.Button();
            this.btn_CusOrder_CProfile = new System.Windows.Forms.Button();
            this.lbl_chef = new System.Windows.Forms.Label();
            this.btn_ChefProfile_CProfile = new System.Windows.Forms.Button();
            this.gbChefProfile = new System.Windows.Forms.GroupBox();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblDOB = new System.Windows.Forms.Label();
            this.btnUpdateProfile = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblProfilePic = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.picProfilePic = new System.Windows.Forms.PictureBox();
            this.tableSidebar_CProfile.SuspendLayout();
            this.gbChefProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProfilePic)).BeginInit();
            this.SuspendLayout();
            // 
            // tableSidebar_CProfile
            // 
            this.tableSidebar_CProfile.ColumnCount = 1;
            this.tableSidebar_CProfile.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableSidebar_CProfile.Controls.Add(this.btnLogOut, 0, 4);
            this.tableSidebar_CProfile.Controls.Add(this.btn_inventory_CProfile, 0, 1);
            this.tableSidebar_CProfile.Controls.Add(this.btn_CusOrder_CProfile, 0, 2);
            this.tableSidebar_CProfile.Controls.Add(this.lbl_chef, 0, 0);
            this.tableSidebar_CProfile.Controls.Add(this.btn_ChefProfile_CProfile, 0, 3);
            this.tableSidebar_CProfile.Location = new System.Drawing.Point(12, 11);
            this.tableSidebar_CProfile.Name = "tableSidebar_CProfile";
            this.tableSidebar_CProfile.RowCount = 6;
            this.tableSidebar_CProfile.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableSidebar_CProfile.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableSidebar_CProfile.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableSidebar_CProfile.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableSidebar_CProfile.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableSidebar_CProfile.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableSidebar_CProfile.Size = new System.Drawing.Size(200, 430);
            this.tableSidebar_CProfile.TabIndex = 14;
            // 
            // btnLogOut
            // 
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.Location = new System.Drawing.Point(3, 183);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(194, 34);
            this.btnLogOut.TabIndex = 16;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btn_inventory_CProfile
            // 
            this.btn_inventory_CProfile.BackColor = System.Drawing.Color.Silver;
            this.btn_inventory_CProfile.FlatAppearance.BorderSize = 0;
            this.btn_inventory_CProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_inventory_CProfile.Location = new System.Drawing.Point(3, 62);
            this.btn_inventory_CProfile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_inventory_CProfile.Name = "btn_inventory_CProfile";
            this.btn_inventory_CProfile.Size = new System.Drawing.Size(194, 36);
            this.btn_inventory_CProfile.TabIndex = 0;
            this.btn_inventory_CProfile.Text = "Manage Inventory";
            this.btn_inventory_CProfile.UseVisualStyleBackColor = false;
            this.btn_inventory_CProfile.Click += new System.EventHandler(this.btn_inventory_CProfile_Click);
            // 
            // btn_CusOrder_CProfile
            // 
            this.btn_CusOrder_CProfile.BackColor = System.Drawing.Color.Silver;
            this.btn_CusOrder_CProfile.FlatAppearance.BorderSize = 0;
            this.btn_CusOrder_CProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CusOrder_CProfile.Location = new System.Drawing.Point(3, 102);
            this.btn_CusOrder_CProfile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_CusOrder_CProfile.Name = "btn_CusOrder_CProfile";
            this.btn_CusOrder_CProfile.Size = new System.Drawing.Size(194, 36);
            this.btn_CusOrder_CProfile.TabIndex = 1;
            this.btn_CusOrder_CProfile.Text = "Customer\'s Orders";
            this.btn_CusOrder_CProfile.UseVisualStyleBackColor = false;
            this.btn_CusOrder_CProfile.Click += new System.EventHandler(this.btn_CusOrder_CProfile_Click);
            // 
            // lbl_chef
            // 
            this.lbl_chef.AutoSize = true;
            this.lbl_chef.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_chef.Location = new System.Drawing.Point(3, 0);
            this.lbl_chef.Name = "lbl_chef";
            this.lbl_chef.Size = new System.Drawing.Size(93, 39);
            this.lbl_chef.TabIndex = 3;
            this.lbl_chef.Text = "Chef";
            // 
            // btn_ChefProfile_CProfile
            // 
            this.btn_ChefProfile_CProfile.BackColor = System.Drawing.Color.Silver;
            this.btn_ChefProfile_CProfile.FlatAppearance.BorderSize = 0;
            this.btn_ChefProfile_CProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ChefProfile_CProfile.Location = new System.Drawing.Point(3, 142);
            this.btn_ChefProfile_CProfile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_ChefProfile_CProfile.Name = "btn_ChefProfile_CProfile";
            this.btn_ChefProfile_CProfile.Size = new System.Drawing.Size(194, 36);
            this.btn_ChefProfile_CProfile.TabIndex = 2;
            this.btn_ChefProfile_CProfile.Text = "Chef Profile";
            this.btn_ChefProfile_CProfile.UseVisualStyleBackColor = false;
            this.btn_ChefProfile_CProfile.Click += new System.EventHandler(this.btn_ChefProfile_CProfile_Click);
            // 
            // gbChefProfile
            // 
            this.gbChefProfile.Controls.Add(this.dtpDOB);
            this.gbChefProfile.Controls.Add(this.cmbGender);
            this.gbChefProfile.Controls.Add(this.picProfilePic);
            this.gbChefProfile.Controls.Add(this.txtPassword);
            this.gbChefProfile.Controls.Add(this.txtUsername);
            this.gbChefProfile.Controls.Add(this.lblPassword);
            this.gbChefProfile.Controls.Add(this.lblUsername);
            this.gbChefProfile.Controls.Add(this.lblGender);
            this.gbChefProfile.Controls.Add(this.lblDOB);
            this.gbChefProfile.Controls.Add(this.btnUpdateProfile);
            this.gbChefProfile.Controls.Add(this.txtEmail);
            this.gbChefProfile.Controls.Add(this.txtName);
            this.gbChefProfile.Controls.Add(this.lblProfilePic);
            this.gbChefProfile.Controls.Add(this.lblEmail);
            this.gbChefProfile.Controls.Add(this.lblName);
            this.gbChefProfile.Location = new System.Drawing.Point(215, 72);
            this.gbChefProfile.Name = "gbChefProfile";
            this.gbChefProfile.Size = new System.Drawing.Size(852, 369);
            this.gbChefProfile.TabIndex = 15;
            this.gbChefProfile.TabStop = false;
            this.gbChefProfile.Text = "Chef Profile";
            // 
            // dtpDOB
            // 
            this.dtpDOB.Location = new System.Drawing.Point(161, 256);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(271, 30);
            this.dtpDOB.TabIndex = 3;
            // 
            // cmbGender
            // 
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "Female",
            "Male"});
            this.cmbGender.Location = new System.Drawing.Point(161, 309);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(271, 33);
            this.cmbGender.TabIndex = 19;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(161, 92);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(271, 30);
            this.txtPassword.TabIndex = 17;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(161, 38);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(271, 30);
            this.txtUsername.TabIndex = 16;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(37, 95);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(98, 25);
            this.lblPassword.TabIndex = 15;
            this.lblPassword.Text = "Password";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(37, 41);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(102, 25);
            this.lblUsername.TabIndex = 14;
            this.lblUsername.Text = "Username";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(37, 310);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(77, 25);
            this.lblGender.TabIndex = 11;
            this.lblGender.Text = "Gender";
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Location = new System.Drawing.Point(37, 261);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(118, 25);
            this.lblDOB.TabIndex = 10;
            this.lblDOB.Text = "Date of Birth";
            // 
            // btnUpdateProfile
            // 
            this.btnUpdateProfile.Location = new System.Drawing.Point(461, 307);
            this.btnUpdateProfile.Name = "btnUpdateProfile";
            this.btnUpdateProfile.Size = new System.Drawing.Size(371, 35);
            this.btnUpdateProfile.TabIndex = 9;
            this.btnUpdateProfile.Text = "Update Profile";
            this.btnUpdateProfile.UseVisualStyleBackColor = true;
            this.btnUpdateProfile.Click += new System.EventHandler(this.btnUpdateProfile_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(161, 201);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(271, 30);
            this.txtEmail.TabIndex = 8;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(161, 147);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(271, 30);
            this.txtName.TabIndex = 7;
            // 
            // lblProfilePic
            // 
            this.lblProfilePic.AutoSize = true;
            this.lblProfilePic.Location = new System.Drawing.Point(539, 43);
            this.lblProfilePic.Name = "lblProfilePic";
            this.lblProfilePic.Size = new System.Drawing.Size(131, 25);
            this.lblProfilePic.TabIndex = 4;
            this.lblProfilePic.Text = "Profile Picture";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(37, 204);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(60, 25);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Email";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(37, 150);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(64, 25);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // picProfilePic
            // 
            this.picProfilePic.Location = new System.Drawing.Point(544, 76);
            this.picProfilePic.Name = "picProfilePic";
            this.picProfilePic.Size = new System.Drawing.Size(219, 210);
            this.picProfilePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picProfilePic.TabIndex = 18;
            this.picProfilePic.TabStop = false;
            // 
            // Chef_Profile
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1082, 453);
            this.Controls.Add(this.gbChefProfile);
            this.Controls.Add(this.tableSidebar_CProfile);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Chef_Profile";
            this.Text = "Chef_Profile";
            this.Load += new System.EventHandler(this.Chef_Profile_Load);
            this.tableSidebar_CProfile.ResumeLayout(false);
            this.tableSidebar_CProfile.PerformLayout();
            this.gbChefProfile.ResumeLayout(false);
            this.gbChefProfile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProfilePic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableSidebar_CProfile;
        private System.Windows.Forms.Button btn_inventory_CProfile;
        private System.Windows.Forms.Button btn_CusOrder_CProfile;
        private System.Windows.Forms.Label lbl_chef;
        private System.Windows.Forms.Button btn_ChefProfile_CProfile;
        private System.Windows.Forms.GroupBox gbChefProfile;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.PictureBox picProfilePic;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.Button btnUpdateProfile;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblProfilePic;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnLogOut;
    }
}