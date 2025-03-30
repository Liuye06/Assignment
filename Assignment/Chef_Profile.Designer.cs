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
            this.lbl_cusername = new System.Windows.Forms.Label();
            this.lbl_cname = new System.Windows.Forms.Label();
            this.lbl_cemail = new System.Windows.Forms.Label();
            this.lbl_cDOB = new System.Windows.Forms.Label();
            this.btn_p_back = new System.Windows.Forms.Button();
            this.grp_c_information = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txt_CE = new System.Windows.Forms.TextBox();
            this.txt_CN = new System.Windows.Forms.TextBox();
            this.txt_CU = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_UPI = new System.Windows.Forms.Button();
            this.btn_SP = new System.Windows.Forms.Button();
            this.tableSidebar_CProfile = new System.Windows.Forms.TableLayoutPanel();
            this.btn_inventory_CProfile = new System.Windows.Forms.Button();
            this.btn_CusOrder_CProfile = new System.Windows.Forms.Button();
            this.lbl_chef = new System.Windows.Forms.Label();
            this.btn_ChefProfile_CProfile = new System.Windows.Forms.Button();
            this.grp_c_information.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableSidebar_CProfile.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_cusername
            // 
            this.lbl_cusername.AutoSize = true;
            this.lbl_cusername.Location = new System.Drawing.Point(24, 28);
            this.lbl_cusername.Name = "lbl_cusername";
            this.lbl_cusername.Size = new System.Drawing.Size(108, 25);
            this.lbl_cusername.TabIndex = 1;
            this.lbl_cusername.Text = "Username:";
            // 
            // lbl_cname
            // 
            this.lbl_cname.AutoSize = true;
            this.lbl_cname.Location = new System.Drawing.Point(24, 82);
            this.lbl_cname.Name = "lbl_cname";
            this.lbl_cname.Size = new System.Drawing.Size(70, 25);
            this.lbl_cname.TabIndex = 2;
            this.lbl_cname.Text = "Name:";
            // 
            // lbl_cemail
            // 
            this.lbl_cemail.AutoSize = true;
            this.lbl_cemail.Location = new System.Drawing.Point(24, 138);
            this.lbl_cemail.Name = "lbl_cemail";
            this.lbl_cemail.Size = new System.Drawing.Size(66, 25);
            this.lbl_cemail.TabIndex = 3;
            this.lbl_cemail.Text = "Email:";
            // 
            // lbl_cDOB
            // 
            this.lbl_cDOB.AutoSize = true;
            this.lbl_cDOB.Location = new System.Drawing.Point(24, 189);
            this.lbl_cDOB.Name = "lbl_cDOB";
            this.lbl_cDOB.Size = new System.Drawing.Size(124, 25);
            this.lbl_cDOB.TabIndex = 5;
            this.lbl_cDOB.Text = "Date of Birth:";
            // 
            // btn_p_back
            // 
            this.btn_p_back.Location = new System.Drawing.Point(401, 26);
            this.btn_p_back.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_p_back.Name = "btn_p_back";
            this.btn_p_back.Size = new System.Drawing.Size(93, 23);
            this.btn_p_back.TabIndex = 10;
            this.btn_p_back.Text = "Back";
            this.btn_p_back.UseVisualStyleBackColor = true;
            this.btn_p_back.Click += new System.EventHandler(this.button2_Click);
            // 
            // grp_c_information
            // 
            this.grp_c_information.Controls.Add(this.dateTimePicker1);
            this.grp_c_information.Controls.Add(this.txt_CE);
            this.grp_c_information.Controls.Add(this.txt_CN);
            this.grp_c_information.Controls.Add(this.txt_CU);
            this.grp_c_information.Controls.Add(this.lbl_cusername);
            this.grp_c_information.Controls.Add(this.lbl_cname);
            this.grp_c_information.Controls.Add(this.lbl_cemail);
            this.grp_c_information.Controls.Add(this.lbl_cDOB);
            this.grp_c_information.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_c_information.Location = new System.Drawing.Point(357, 101);
            this.grp_c_information.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grp_c_information.Name = "grp_c_information";
            this.grp_c_information.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grp_c_information.Size = new System.Drawing.Size(440, 234);
            this.grp_c_information.TabIndex = 11;
            this.grp_c_information.TabStop = false;
            this.grp_c_information.Text = "Information";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(151, 189);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(268, 30);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // txt_CE
            // 
            this.txt_CE.Location = new System.Drawing.Point(151, 139);
            this.txt_CE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_CE.Name = "txt_CE";
            this.txt_CE.Size = new System.Drawing.Size(268, 30);
            this.txt_CE.TabIndex = 8;
            // 
            // txt_CN
            // 
            this.txt_CN.Location = new System.Drawing.Point(151, 82);
            this.txt_CN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_CN.Name = "txt_CN";
            this.txt_CN.Size = new System.Drawing.Size(268, 30);
            this.txt_CN.TabIndex = 7;
            // 
            // txt_CU
            // 
            this.txt_CU.Location = new System.Drawing.Point(151, 28);
            this.txt_CU.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_CU.Name = "txt_CU";
            this.txt_CU.Size = new System.Drawing.Size(268, 30);
            this.txt_CU.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(852, 84);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(155, 140);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btn_UPI
            // 
            this.btn_UPI.Location = new System.Drawing.Point(864, 237);
            this.btn_UPI.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_UPI.Name = "btn_UPI";
            this.btn_UPI.Size = new System.Drawing.Size(130, 30);
            this.btn_UPI.TabIndex = 12;
            this.btn_UPI.Text = "Upload Image";
            this.btn_UPI.UseVisualStyleBackColor = true;
            // 
            // btn_SP
            // 
            this.btn_SP.Location = new System.Drawing.Point(864, 336);
            this.btn_SP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_SP.Name = "btn_SP";
            this.btn_SP.Size = new System.Drawing.Size(113, 29);
            this.btn_SP.TabIndex = 13;
            this.btn_SP.Text = "Save Change";
            this.btn_SP.UseVisualStyleBackColor = true;
            // 
            // tableSidebar_CProfile
            // 
            this.tableSidebar_CProfile.ColumnCount = 1;
            this.tableSidebar_CProfile.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableSidebar_CProfile.Controls.Add(this.btn_inventory_CProfile, 0, 1);
            this.tableSidebar_CProfile.Controls.Add(this.btn_CusOrder_CProfile, 0, 2);
            this.tableSidebar_CProfile.Controls.Add(this.lbl_chef, 0, 0);
            this.tableSidebar_CProfile.Controls.Add(this.btn_ChefProfile_CProfile, 0, 3);
            this.tableSidebar_CProfile.Location = new System.Drawing.Point(12, 11);
            this.tableSidebar_CProfile.Name = "tableSidebar_CProfile";
            this.tableSidebar_CProfile.RowCount = 5;
            this.tableSidebar_CProfile.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableSidebar_CProfile.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableSidebar_CProfile.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableSidebar_CProfile.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableSidebar_CProfile.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableSidebar_CProfile.Size = new System.Drawing.Size(200, 430);
            this.tableSidebar_CProfile.TabIndex = 14;
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
            // 
            // Chef_Profile
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1082, 453);
            this.Controls.Add(this.tableSidebar_CProfile);
            this.Controls.Add(this.btn_SP);
            this.Controls.Add(this.btn_UPI);
            this.Controls.Add(this.grp_c_information);
            this.Controls.Add(this.btn_p_back);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Chef_Profile";
            this.Text = "Chef_Profile";
            this.grp_c_information.ResumeLayout(false);
            this.grp_c_information.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableSidebar_CProfile.ResumeLayout(false);
            this.tableSidebar_CProfile.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_cusername;
        private System.Windows.Forms.Label lbl_cname;
        private System.Windows.Forms.Label lbl_cemail;
        private System.Windows.Forms.Label lbl_cDOB;
        private System.Windows.Forms.Button btn_p_back;
        private System.Windows.Forms.GroupBox grp_c_information;
        private System.Windows.Forms.TextBox txt_CE;
        private System.Windows.Forms.TextBox txt_CN;
        private System.Windows.Forms.TextBox txt_CU;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btn_UPI;
        private System.Windows.Forms.Button btn_SP;
        private System.Windows.Forms.TableLayoutPanel tableSidebar_CProfile;
        private System.Windows.Forms.Button btn_inventory_CProfile;
        private System.Windows.Forms.Button btn_CusOrder_CProfile;
        private System.Windows.Forms.Label lbl_chef;
        private System.Windows.Forms.Button btn_ChefProfile_CProfile;
    }
}