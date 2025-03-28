namespace Assignment
{
    partial class EditCus
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
            this.SuspendLayout();

            // label1
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(319, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please enter new data:";

            // comboBox1
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
                "Real Name",
                "Date of Birth",
                "Gender",
                "Email",
                "Username"});
            this.comboBox1.Location = new System.Drawing.Point(319, 111);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 24);
            this.comboBox1.TabIndex = 1;

            // listBox1
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(108, 111);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(200, 180);
            this.listBox1.TabIndex = 2;

            // lbl_EditCus
            this.lbl_EditCus.AutoSize = true;
            this.lbl_EditCus.Location = new System.Drawing.Point(105, 62);
            this.lbl_EditCus.Name = "lbl_EditCus";
            this.lbl_EditCus.Size = new System.Drawing.Size(76, 16);
            this.lbl_EditCus.TabIndex = 3;
            this.lbl_EditCus.Text = "List of User:";

            // txt_EditCus
            this.txt_EditCus.Location = new System.Drawing.Point(319, 180);
            this.txt_EditCus.Name = "txt_EditCus";
            this.txt_EditCus.Size = new System.Drawing.Size(200, 22);
            this.txt_EditCus.TabIndex = 4;

            // btn_Cancel
            this.btn_Cancel.Location = new System.Drawing.Point(444, 250);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 30);
            this.btn_Cancel.TabIndex = 5;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);

            // btn_EditCus
            this.btn_EditCus.Location = new System.Drawing.Point(319, 250);
            this.btn_EditCus.Name = "btn_EditCus";
            this.btn_EditCus.Size = new System.Drawing.Size(75, 30);
            this.btn_EditCus.TabIndex = 6;
            this.btn_EditCus.Text = "Save";
            this.btn_EditCus.UseVisualStyleBackColor = true;
            this.btn_EditCus.Click += new System.EventHandler(this.btn_EditCus_Click);

            // label2
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(319, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Type of Information:";

            // Form
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 350);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_EditCus);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.txt_EditCus);
            this.Controls.Add(this.lbl_EditCus);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Name = "EditCus";
            this.Text = "Edit Customer";
            this.Load += new System.EventHandler(this.EditCus_Load);
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
    }
}