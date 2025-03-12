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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_cusername = new System.Windows.Forms.Label();
            this.lbl_cname = new System.Windows.Forms.Label();
            this.lbl_cemail = new System.Windows.Forms.Label();
            this.lbl_cgender = new System.Windows.Forms.Label();
            this.lbl_cDOB = new System.Windows.Forms.Label();
            this.lbl_role = new System.Windows.Forms.Label();
            this.btn_c_updateprofile = new System.Windows.Forms.Button();
            this.btn_p_back = new System.Windows.Forms.Button();
            this.grp_c_information = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grp_c_information.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(590, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(174, 175);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_cusername
            // 
            this.lbl_cusername.AutoSize = true;
            this.lbl_cusername.Location = new System.Drawing.Point(27, 35);
            this.lbl_cusername.Name = "lbl_cusername";
            this.lbl_cusername.Size = new System.Drawing.Size(97, 22);
            this.lbl_cusername.TabIndex = 1;
            this.lbl_cusername.Text = "Username:";
            // 
            // lbl_cname
            // 
            this.lbl_cname.AutoSize = true;
            this.lbl_cname.Location = new System.Drawing.Point(27, 102);
            this.lbl_cname.Name = "lbl_cname";
            this.lbl_cname.Size = new System.Drawing.Size(62, 22);
            this.lbl_cname.TabIndex = 2;
            this.lbl_cname.Text = "Name:";
            // 
            // lbl_cemail
            // 
            this.lbl_cemail.AutoSize = true;
            this.lbl_cemail.Location = new System.Drawing.Point(27, 172);
            this.lbl_cemail.Name = "lbl_cemail";
            this.lbl_cemail.Size = new System.Drawing.Size(59, 22);
            this.lbl_cemail.TabIndex = 3;
            this.lbl_cemail.Text = "Email:";
            // 
            // lbl_cgender
            // 
            this.lbl_cgender.AutoSize = true;
            this.lbl_cgender.Location = new System.Drawing.Point(27, 232);
            this.lbl_cgender.Name = "lbl_cgender";
            this.lbl_cgender.Size = new System.Drawing.Size(75, 22);
            this.lbl_cgender.TabIndex = 4;
            this.lbl_cgender.Text = "Gender:";
            // 
            // lbl_cDOB
            // 
            this.lbl_cDOB.AutoSize = true;
            this.lbl_cDOB.Location = new System.Drawing.Point(244, 35);
            this.lbl_cDOB.Name = "lbl_cDOB";
            this.lbl_cDOB.Size = new System.Drawing.Size(115, 22);
            this.lbl_cDOB.TabIndex = 5;
            this.lbl_cDOB.Text = "Date of Birth:";
            // 
            // lbl_role
            // 
            this.lbl_role.AutoSize = true;
            this.lbl_role.Location = new System.Drawing.Point(244, 102);
            this.lbl_role.Name = "lbl_role";
            this.lbl_role.Size = new System.Drawing.Size(52, 22);
            this.lbl_role.TabIndex = 6;
            this.lbl_role.Text = "Role:";
            // 
            // btn_c_updateprofile
            // 
            this.btn_c_updateprofile.Location = new System.Drawing.Point(580, 327);
            this.btn_c_updateprofile.Name = "btn_c_updateprofile";
            this.btn_c_updateprofile.Size = new System.Drawing.Size(166, 49);
            this.btn_c_updateprofile.TabIndex = 9;
            this.btn_c_updateprofile.Text = "Update proflie";
            this.btn_c_updateprofile.UseVisualStyleBackColor = true;
            // 
            // btn_p_back
            // 
            this.btn_p_back.Location = new System.Drawing.Point(13, 13);
            this.btn_p_back.Name = "btn_p_back";
            this.btn_p_back.Size = new System.Drawing.Size(105, 29);
            this.btn_p_back.TabIndex = 10;
            this.btn_p_back.Text = "Back";
            this.btn_p_back.UseVisualStyleBackColor = true;
            this.btn_p_back.Click += new System.EventHandler(this.button2_Click);
            // 
            // grp_c_information
            // 
            this.grp_c_information.Controls.Add(this.lbl_cgender);
            this.grp_c_information.Controls.Add(this.lbl_cusername);
            this.grp_c_information.Controls.Add(this.lbl_cname);
            this.grp_c_information.Controls.Add(this.lbl_cemail);
            this.grp_c_information.Controls.Add(this.lbl_cDOB);
            this.grp_c_information.Controls.Add(this.lbl_role);
            this.grp_c_information.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_c_information.Location = new System.Drawing.Point(33, 69);
            this.grp_c_information.Name = "grp_c_information";
            this.grp_c_information.Size = new System.Drawing.Size(495, 292);
            this.grp_c_information.TabIndex = 11;
            this.grp_c_information.TabStop = false;
            this.grp_c_information.Text = "Information";
            // 
            // Chef_Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grp_c_information);
            this.Controls.Add(this.btn_p_back);
            this.Controls.Add(this.btn_c_updateprofile);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Chef_Profile";
            this.Text = "Chef_Profile";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grp_c_information.ResumeLayout(false);
            this.grp_c_information.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_cusername;
        private System.Windows.Forms.Label lbl_cname;
        private System.Windows.Forms.Label lbl_cemail;
        private System.Windows.Forms.Label lbl_cgender;
        private System.Windows.Forms.Label lbl_cDOB;
        private System.Windows.Forms.Label lbl_role;
        private System.Windows.Forms.Button btn_c_updateprofile;
        private System.Windows.Forms.Button btn_p_back;
        private System.Windows.Forms.GroupBox grp_c_information;
    }
}