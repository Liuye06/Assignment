namespace Assignment
{
    partial class Customer_Profile
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
            this.gbCustomerProfile = new System.Windows.Forms.GroupBox();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.picProfilePic = new System.Windows.Forms.PictureBox();
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
            this.tableSidebar_Customer = new System.Windows.Forms.TableLayoutPanel();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnMakeReservation = new System.Windows.Forms.Button();
            this.btnViewReservation = new System.Windows.Forms.Button();
            this.btnFeedback = new System.Windows.Forms.Button();
            this.btnViewReplyRequest = new System.Windows.Forms.Button();
            this.btnViewOrders = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnMakeOrder = new System.Windows.Forms.Button();
            this.gbCustomerProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProfilePic)).BeginInit();
            this.tableSidebar_Customer.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbCustomerProfile
            // 
            this.gbCustomerProfile.Controls.Add(this.dtpDOB);
            this.gbCustomerProfile.Controls.Add(this.cmbGender);
            this.gbCustomerProfile.Controls.Add(this.picProfilePic);
            this.gbCustomerProfile.Controls.Add(this.txtPassword);
            this.gbCustomerProfile.Controls.Add(this.txtUsername);
            this.gbCustomerProfile.Controls.Add(this.lblPassword);
            this.gbCustomerProfile.Controls.Add(this.lblUsername);
            this.gbCustomerProfile.Controls.Add(this.lblGender);
            this.gbCustomerProfile.Controls.Add(this.lblDOB);
            this.gbCustomerProfile.Controls.Add(this.btnUpdateProfile);
            this.gbCustomerProfile.Controls.Add(this.txtEmail);
            this.gbCustomerProfile.Controls.Add(this.txtName);
            this.gbCustomerProfile.Controls.Add(this.lblProfilePic);
            this.gbCustomerProfile.Controls.Add(this.lblEmail);
            this.gbCustomerProfile.Controls.Add(this.lblName);
            this.gbCustomerProfile.Location = new System.Drawing.Point(218, 72);
            this.gbCustomerProfile.Name = "gbCustomerProfile";
            this.gbCustomerProfile.Size = new System.Drawing.Size(852, 369);
            this.gbCustomerProfile.TabIndex = 16;
            this.gbCustomerProfile.TabStop = false;
            this.gbCustomerProfile.Text = "Customer Profile";
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
            // picProfilePic
            // 
            this.picProfilePic.Location = new System.Drawing.Point(544, 76);
            this.picProfilePic.Name = "picProfilePic";
            this.picProfilePic.Size = new System.Drawing.Size(219, 210);
            this.picProfilePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picProfilePic.TabIndex = 18;
            this.picProfilePic.TabStop = false;
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
            // tableSidebar_Customer
            // 
            this.tableSidebar_Customer.ColumnCount = 1;
            this.tableSidebar_Customer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableSidebar_Customer.Controls.Add(this.btnLogOut, 0, 8);
            this.tableSidebar_Customer.Controls.Add(this.btnMakeReservation, 0, 5);
            this.tableSidebar_Customer.Controls.Add(this.btnViewReservation, 0, 4);
            this.tableSidebar_Customer.Controls.Add(this.btnFeedback, 0, 7);
            this.tableSidebar_Customer.Controls.Add(this.btnViewReplyRequest, 0, 3);
            this.tableSidebar_Customer.Controls.Add(this.btnViewOrders, 0, 2);
            this.tableSidebar_Customer.Controls.Add(this.btnProfile, 0, 1);
            this.tableSidebar_Customer.Controls.Add(this.btnMakeOrder, 0, 6);
            this.tableSidebar_Customer.Location = new System.Drawing.Point(12, 17);
            this.tableSidebar_Customer.Name = "tableSidebar_Customer";
            this.tableSidebar_Customer.RowCount = 10;
            this.tableSidebar_Customer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableSidebar_Customer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableSidebar_Customer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableSidebar_Customer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableSidebar_Customer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableSidebar_Customer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableSidebar_Customer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableSidebar_Customer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableSidebar_Customer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableSidebar_Customer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableSidebar_Customer.Size = new System.Drawing.Size(200, 424);
            this.tableSidebar_Customer.TabIndex = 20;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(4, 374);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(192, 32);
            this.btnLogOut.TabIndex = 3;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click_1);
            // 
            // btnMakeReservation
            // 
            this.btnMakeReservation.Location = new System.Drawing.Point(4, 224);
            this.btnMakeReservation.Margin = new System.Windows.Forms.Padding(4);
            this.btnMakeReservation.Name = "btnMakeReservation";
            this.btnMakeReservation.Size = new System.Drawing.Size(192, 62);
            this.btnMakeReservation.TabIndex = 1;
            this.btnMakeReservation.Text = "Make a Reservation Request";
            this.btnMakeReservation.UseVisualStyleBackColor = true;
            this.btnMakeReservation.Click += new System.EventHandler(this.btnMakeReservation_Click_1);
            // 
            // btnViewReservation
            // 
            this.btnViewReservation.Location = new System.Drawing.Point(4, 184);
            this.btnViewReservation.Margin = new System.Windows.Forms.Padding(4);
            this.btnViewReservation.Name = "btnViewReservation";
            this.btnViewReservation.Size = new System.Drawing.Size(192, 32);
            this.btnViewReservation.TabIndex = 5;
            this.btnViewReservation.Text = "View Reservation";
            this.btnViewReservation.UseVisualStyleBackColor = true;
            this.btnViewReservation.Click += new System.EventHandler(this.btnViewReservation_Click);
            // 
            // btnFeedback
            // 
            this.btnFeedback.Location = new System.Drawing.Point(4, 334);
            this.btnFeedback.Margin = new System.Windows.Forms.Padding(4);
            this.btnFeedback.Name = "btnFeedback";
            this.btnFeedback.Size = new System.Drawing.Size(192, 32);
            this.btnFeedback.TabIndex = 2;
            this.btnFeedback.Text = "Feedback";
            this.btnFeedback.UseVisualStyleBackColor = true;
            this.btnFeedback.Click += new System.EventHandler(this.btnFeedback_Click_1);
            // 
            // btnViewReplyRequest
            // 
            this.btnViewReplyRequest.Location = new System.Drawing.Point(4, 144);
            this.btnViewReplyRequest.Margin = new System.Windows.Forms.Padding(4);
            this.btnViewReplyRequest.Name = "btnViewReplyRequest";
            this.btnViewReplyRequest.Size = new System.Drawing.Size(192, 32);
            this.btnViewReplyRequest.TabIndex = 6;
            this.btnViewReplyRequest.Text = "View Reply Request";
            this.btnViewReplyRequest.UseVisualStyleBackColor = true;
            this.btnViewReplyRequest.Click += new System.EventHandler(this.btnViewReplyRequest_Click);
            // 
            // btnViewOrders
            // 
            this.btnViewOrders.FlatAppearance.BorderSize = 0;
            this.btnViewOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewOrders.Location = new System.Drawing.Point(4, 104);
            this.btnViewOrders.Margin = new System.Windows.Forms.Padding(4);
            this.btnViewOrders.Name = "btnViewOrders";
            this.btnViewOrders.Size = new System.Drawing.Size(192, 32);
            this.btnViewOrders.TabIndex = 4;
            this.btnViewOrders.Text = "View Orders";
            this.btnViewOrders.UseVisualStyleBackColor = true;
            this.btnViewOrders.Click += new System.EventHandler(this.btnViewOrders_Click_1);
            // 
            // btnProfile
            // 
            this.btnProfile.FlatAppearance.BorderSize = 0;
            this.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfile.Location = new System.Drawing.Point(4, 64);
            this.btnProfile.Margin = new System.Windows.Forms.Padding(4);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(192, 32);
            this.btnProfile.TabIndex = 9;
            this.btnProfile.Text = "Profile";
            this.btnProfile.UseVisualStyleBackColor = true;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click_1);
            // 
            // btnMakeOrder
            // 
            this.btnMakeOrder.Location = new System.Drawing.Point(4, 294);
            this.btnMakeOrder.Margin = new System.Windows.Forms.Padding(4);
            this.btnMakeOrder.Name = "btnMakeOrder";
            this.btnMakeOrder.Size = new System.Drawing.Size(192, 32);
            this.btnMakeOrder.TabIndex = 0;
            this.btnMakeOrder.Text = "Make an Order";
            this.btnMakeOrder.UseVisualStyleBackColor = true;
            this.btnMakeOrder.Click += new System.EventHandler(this.btnMakeOrder_Click_1);
            // 
            // Customer_Profile
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1082, 453);
            this.Controls.Add(this.tableSidebar_Customer);
            this.Controls.Add(this.gbCustomerProfile);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Customer_Profile";
            this.Text = "Customer_Profile";
            this.Load += new System.EventHandler(this.Customer_Profile_Load);
            this.gbCustomerProfile.ResumeLayout(false);
            this.gbCustomerProfile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProfilePic)).EndInit();
            this.tableSidebar_Customer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbCustomerProfile;
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
        private System.Windows.Forms.TableLayoutPanel tableSidebar_Customer;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnMakeReservation;
        private System.Windows.Forms.Button btnViewReservation;
        private System.Windows.Forms.Button btnFeedback;
        private System.Windows.Forms.Button btnViewReplyRequest;
        private System.Windows.Forms.Button btnViewOrders;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnMakeOrder;
    }
}