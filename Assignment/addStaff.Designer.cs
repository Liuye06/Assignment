namespace Assignment
{
    partial class addStaff
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
            this.btn_addStaff = new System.Windows.Forms.Button();
            this.txt_StaffPassword = new System.Windows.Forms.TextBox();
            this.txt_StaffUsername = new System.Windows.Forms.TextBox();
            this.txt_StaffEmail = new System.Windows.Forms.TextBox();
            this.txt_StaffDOB = new System.Windows.Forms.TextBox();
            this.txt_StaffName = new System.Windows.Forms.TextBox();
            this.lbl_CusUsername = new System.Windows.Forms.Label();
            this.lbl_CusPassword = new System.Windows.Forms.Label();
            this.lbl_GenderCus = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_DOB = new System.Windows.Forms.Label();
            this.lbl_CusName = new System.Windows.Forms.Label();
            this.cB_StaffRole = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_StaffGender = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btn_addStaff
            // 
            this.btn_addStaff.Location = new System.Drawing.Point(416, 383);
            this.btn_addStaff.Name = "btn_addStaff";
            this.btn_addStaff.Size = new System.Drawing.Size(95, 31);
            this.btn_addStaff.TabIndex = 28;
            this.btn_addStaff.Text = "Register";
            this.btn_addStaff.UseVisualStyleBackColor = true;
            this.btn_addStaff.Click += new System.EventHandler(this.btn_addStaff_Click);
            // 
            // txt_StaffPassword
            // 
            this.txt_StaffPassword.Location = new System.Drawing.Point(505, 328);
            this.txt_StaffPassword.Name = "txt_StaffPassword";
            this.txt_StaffPassword.Size = new System.Drawing.Size(100, 22);
            this.txt_StaffPassword.TabIndex = 27;
            // 
            // txt_StaffUsername
            // 
            this.txt_StaffUsername.Location = new System.Drawing.Point(505, 285);
            this.txt_StaffUsername.Name = "txt_StaffUsername";
            this.txt_StaffUsername.Size = new System.Drawing.Size(100, 22);
            this.txt_StaffUsername.TabIndex = 26;
            // 
            // txt_StaffEmail
            // 
            this.txt_StaffEmail.Location = new System.Drawing.Point(505, 241);
            this.txt_StaffEmail.Name = "txt_StaffEmail";
            this.txt_StaffEmail.Size = new System.Drawing.Size(100, 22);
            this.txt_StaffEmail.TabIndex = 25;
            // 
            // txt_StaffDOB
            // 
            this.txt_StaffDOB.Location = new System.Drawing.Point(505, 157);
            this.txt_StaffDOB.Name = "txt_StaffDOB";
            this.txt_StaffDOB.Size = new System.Drawing.Size(100, 22);
            this.txt_StaffDOB.TabIndex = 23;
            // 
            // txt_StaffName
            // 
            this.txt_StaffName.Location = new System.Drawing.Point(505, 113);
            this.txt_StaffName.Name = "txt_StaffName";
            this.txt_StaffName.Size = new System.Drawing.Size(100, 22);
            this.txt_StaffName.TabIndex = 22;
            // 
            // lbl_CusUsername
            // 
            this.lbl_CusUsername.AutoSize = true;
            this.lbl_CusUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CusUsername.Location = new System.Drawing.Point(299, 279);
            this.lbl_CusUsername.Name = "lbl_CusUsername";
            this.lbl_CusUsername.Size = new System.Drawing.Size(123, 25);
            this.lbl_CusUsername.TabIndex = 21;
            this.lbl_CusUsername.Text = "Username :";
            // 
            // lbl_CusPassword
            // 
            this.lbl_CusPassword.AutoSize = true;
            this.lbl_CusPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CusPassword.Location = new System.Drawing.Point(302, 325);
            this.lbl_CusPassword.Name = "lbl_CusPassword";
            this.lbl_CusPassword.Size = new System.Drawing.Size(119, 25);
            this.lbl_CusPassword.TabIndex = 20;
            this.lbl_CusPassword.Text = "Password :";
            // 
            // lbl_GenderCus
            // 
            this.lbl_GenderCus.AutoSize = true;
            this.lbl_GenderCus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GenderCus.Location = new System.Drawing.Point(299, 192);
            this.lbl_GenderCus.Name = "lbl_GenderCus";
            this.lbl_GenderCus.Size = new System.Drawing.Size(96, 25);
            this.lbl_GenderCus.TabIndex = 19;
            this.lbl_GenderCus.Text = "Gender :";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email.Location = new System.Drawing.Point(299, 238);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(78, 25);
            this.lbl_email.TabIndex = 18;
            this.lbl_email.Text = "Email :";
            // 
            // lbl_DOB
            // 
            this.lbl_DOB.AutoSize = true;
            this.lbl_DOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DOB.Location = new System.Drawing.Point(299, 151);
            this.lbl_DOB.Name = "lbl_DOB";
            this.lbl_DOB.Size = new System.Drawing.Size(145, 25);
            this.lbl_DOB.TabIndex = 17;
            this.lbl_DOB.Text = "Date of Born :";
            // 
            // lbl_CusName
            // 
            this.lbl_CusName.AutoSize = true;
            this.lbl_CusName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CusName.Location = new System.Drawing.Point(299, 107);
            this.lbl_CusName.Name = "lbl_CusName";
            this.lbl_CusName.Size = new System.Drawing.Size(81, 25);
            this.lbl_CusName.TabIndex = 16;
            this.lbl_CusName.Text = "Name :";
            // 
            // cB_StaffRole
            // 
            this.cB_StaffRole.FormattingEnabled = true;
            this.cB_StaffRole.Items.AddRange(new object[] {
            "Admin",
            "Chef",
            "Manager",
            "Reservation Coordinator"});
            this.cB_StaffRole.Location = new System.Drawing.Point(472, 47);
            this.cB_StaffRole.Name = "cB_StaffRole";
            this.cB_StaffRole.Size = new System.Drawing.Size(121, 24);
            this.cB_StaffRole.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(261, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 16);
            this.label1.TabIndex = 30;
            this.label1.Text = "Please select the role for register:";
            // 
            // cb_StaffGender
            // 
            this.cb_StaffGender.FormattingEnabled = true;
            this.cb_StaffGender.Location = new System.Drawing.Point(505, 196);
            this.cb_StaffGender.Name = "cb_StaffGender";
            this.cb_StaffGender.Size = new System.Drawing.Size(100, 24);
            this.cb_StaffGender.TabIndex = 31;
            // 
            // addStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 501);
            this.Controls.Add(this.cb_StaffGender);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cB_StaffRole);
            this.Controls.Add(this.btn_addStaff);
            this.Controls.Add(this.txt_StaffPassword);
            this.Controls.Add(this.txt_StaffUsername);
            this.Controls.Add(this.txt_StaffEmail);
            this.Controls.Add(this.txt_StaffDOB);
            this.Controls.Add(this.txt_StaffName);
            this.Controls.Add(this.lbl_CusUsername);
            this.Controls.Add(this.lbl_CusPassword);
            this.Controls.Add(this.lbl_GenderCus);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.lbl_DOB);
            this.Controls.Add(this.lbl_CusName);
            this.Name = "addStaff";
            this.Text = "addStaff";
            this.Load += new System.EventHandler(this.addStaff_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_addStaff;
        private System.Windows.Forms.TextBox txt_StaffPassword;
        private System.Windows.Forms.TextBox txt_StaffUsername;
        private System.Windows.Forms.TextBox txt_StaffEmail;
        private System.Windows.Forms.TextBox txt_StaffDOB;
        private System.Windows.Forms.TextBox txt_StaffName;
        private System.Windows.Forms.Label lbl_CusUsername;
        private System.Windows.Forms.Label lbl_CusPassword;
        private System.Windows.Forms.Label lbl_GenderCus;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_DOB;
        private System.Windows.Forms.Label lbl_CusName;
        private System.Windows.Forms.ComboBox cB_StaffRole;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_StaffGender;
    }
}