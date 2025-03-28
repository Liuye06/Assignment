namespace Assignment
{
    partial class editStaff
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lbl_EditCus = new System.Windows.Forms.Label();
            this.txt_EditCus = new System.Windows.Forms.TextBox();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_EditCus = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(331, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 16);
            this.label1.TabIndex = 40;
            this.label1.Text = "Please insect new data:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Admin",
            "Chef",
            "Manager",
            "Reservation Coordinator "});
            this.comboBox1.Location = new System.Drawing.Point(131, 54);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 39;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(89, 163);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(155, 84);
            this.listBox1.TabIndex = 38;
            // 
            // lbl_EditCus
            // 
            this.lbl_EditCus.AutoSize = true;
            this.lbl_EditCus.Location = new System.Drawing.Point(86, 144);
            this.lbl_EditCus.Name = "lbl_EditCus";
            this.lbl_EditCus.Size = new System.Drawing.Size(76, 16);
            this.lbl_EditCus.TabIndex = 37;
            this.lbl_EditCus.Text = "List of User:";
            // 
            // txt_EditCus
            // 
            this.txt_EditCus.Location = new System.Drawing.Point(485, 177);
            this.txt_EditCus.Name = "txt_EditCus";
            this.txt_EditCus.Size = new System.Drawing.Size(100, 22);
            this.txt_EditCus.TabIndex = 36;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(431, 331);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 35;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            // 
            // btn_EditCus
            // 
            this.btn_EditCus.Location = new System.Drawing.Point(238, 331);
            this.btn_EditCus.Name = "btn_EditCus";
            this.btn_EditCus.Size = new System.Drawing.Size(75, 23);
            this.btn_EditCus.TabIndex = 34;
            this.btn_EditCus.Text = "Save";
            this.btn_EditCus.UseVisualStyleBackColor = true;
            this.btn_EditCus.Click += new System.EventHandler(this.btn_EditCus_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 41;
            this.label2.Text = "Role:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(355, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 16);
            this.label3.TabIndex = 43;
            this.label3.Text = "Type of Information:";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Real_Name",
            "DOB",
            "Gender",
            "Email",
            "Username"});
            this.comboBox2.Location = new System.Drawing.Point(485, 54);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 24);
            this.comboBox2.TabIndex = 42;
            // 
            // editStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lbl_EditCus);
            this.Controls.Add(this.txt_EditCus);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_EditCus);
            this.Name = "editStaff";
            this.Text = "editStaff";
            this.Load += new System.EventHandler(this.editStaff_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lbl_EditCus;
        private System.Windows.Forms.TextBox txt_EditCus;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_EditCus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}