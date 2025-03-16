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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
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
            this.grp_c_information.Controls.Add(this.textBox4);
            this.grp_c_information.Controls.Add(this.textBox3);
            this.grp_c_information.Controls.Add(this.textBox2);
            this.grp_c_information.Controls.Add(this.textBox1);
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
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(590, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(174, 175);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(242, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 28);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(242, 102);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 28);
            this.textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(242, 166);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 28);
            this.textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(242, 230);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 28);
            this.textBox4.TabIndex = 9;
            // 
            // Chef_Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
    }
}