namespace Assignment
{
    partial class UpdateManagerProfile
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
            this.txt_CE = new System.Windows.Forms.TextBox();
            this.txt_CN = new System.Windows.Forms.TextBox();
            this.txt_CU = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btn_UPI = new System.Windows.Forms.Button();
            this.btn_SP = new System.Windows.Forms.Button();
            this.grp_c_information.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            // lbl_cDOB
            // 
            this.lbl_cDOB.AutoSize = true;
            this.lbl_cDOB.Location = new System.Drawing.Point(27, 236);
            this.lbl_cDOB.Name = "lbl_cDOB";
            this.lbl_cDOB.Size = new System.Drawing.Size(115, 22);
            this.lbl_cDOB.TabIndex = 5;
            this.lbl_cDOB.Text = "Date of Birth:";
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
            this.grp_c_information.Controls.Add(this.dateTimePicker1);
            this.grp_c_information.Controls.Add(this.txt_CE);
            this.grp_c_information.Controls.Add(this.txt_CN);
            this.grp_c_information.Controls.Add(this.txt_CU);
            this.grp_c_information.Controls.Add(this.lbl_cusername);
            this.grp_c_information.Controls.Add(this.lbl_cname);
            this.grp_c_information.Controls.Add(this.lbl_cemail);
            this.grp_c_information.Controls.Add(this.lbl_cDOB);
            this.grp_c_information.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_c_information.Location = new System.Drawing.Point(33, 69);
            this.grp_c_information.Name = "grp_c_information";
            this.grp_c_information.Size = new System.Drawing.Size(495, 292);
            this.grp_c_information.TabIndex = 11;
            this.grp_c_information.TabStop = false;
            this.grp_c_information.Text = "Information";
            // 
            // txt_CE
            // 
            this.txt_CE.Location = new System.Drawing.Point(170, 174);
            this.txt_CE.Name = "txt_CE";
            this.txt_CE.Size = new System.Drawing.Size(301, 28);
            this.txt_CE.TabIndex = 8;
            // 
            // txt_CN
            // 
            this.txt_CN.Location = new System.Drawing.Point(170, 102);
            this.txt_CN.Name = "txt_CN";
            this.txt_CN.Size = new System.Drawing.Size(301, 28);
            this.txt_CN.TabIndex = 7;
            // 
            // txt_CU
            // 
            this.txt_CU.Location = new System.Drawing.Point(170, 35);
            this.txt_CU.Name = "txt_CU";
            this.txt_CU.Size = new System.Drawing.Size(301, 28);
            this.txt_CU.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(590, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(174, 175);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(170, 236);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(301, 28);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // btn_UPI
            // 
            this.btn_UPI.Location = new System.Drawing.Point(603, 239);
            this.btn_UPI.Name = "btn_UPI";
            this.btn_UPI.Size = new System.Drawing.Size(146, 38);
            this.btn_UPI.TabIndex = 12;
            this.btn_UPI.Text = "Upload Image";
            this.btn_UPI.UseVisualStyleBackColor = true;
            // 
            // btn_SP
            // 
            this.btn_SP.Location = new System.Drawing.Point(603, 363);
            this.btn_SP.Name = "btn_SP";
            this.btn_SP.Size = new System.Drawing.Size(127, 36);
            this.btn_SP.TabIndex = 13;
            this.btn_SP.Text = "Save Change";
            this.btn_SP.UseVisualStyleBackColor = true;
            // 
            // Chef_Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_SP);
            this.Controls.Add(this.btn_UPI);
            this.Controls.Add(this.grp_c_information);
            this.Controls.Add(this.btn_p_back);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Chef_Profile";
            this.Text = "Chef_Profile";
            this.grp_c_information.ResumeLayout(false);
            this.grp_c_information.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
    }
}