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
            this.btn_EditCus = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.txt_EditCus = new System.Windows.Forms.TextBox();
            this.lbl_EditCus = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_EditCus
            // 
            this.btn_EditCus.Location = new System.Drawing.Point(392, 324);
            this.btn_EditCus.Name = "btn_EditCus";
            this.btn_EditCus.Size = new System.Drawing.Size(75, 23);
            this.btn_EditCus.TabIndex = 3;
            this.btn_EditCus.Text = "Save";
            this.btn_EditCus.UseVisualStyleBackColor = true;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(621, 324);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 4;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            // 
            // txt_EditCus
            // 
            this.txt_EditCus.Location = new System.Drawing.Point(491, 210);
            this.txt_EditCus.Name = "txt_EditCus";
            this.txt_EditCus.Size = new System.Drawing.Size(100, 22);
            this.txt_EditCus.TabIndex = 29;
            // 
            // lbl_EditCus
            // 
            this.lbl_EditCus.AutoSize = true;
            this.lbl_EditCus.Location = new System.Drawing.Point(105, 62);
            this.lbl_EditCus.Name = "lbl_EditCus";
            this.lbl_EditCus.Size = new System.Drawing.Size(44, 16);
            this.lbl_EditCus.TabIndex = 30;
            this.lbl_EditCus.Text = "label1";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(108, 111);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(155, 84);
            this.listBox1.TabIndex = 31;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Real_Name",
            "DOB",
            "Gender",
            "Email",
            "Username"});
            this.comboBox1.Location = new System.Drawing.Point(482, 111);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 32;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(319, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 16);
            this.label1.TabIndex = 33;
            this.label1.Text = "Please insect new data:";
            // 
            // EditCus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 485);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lbl_EditCus);
            this.Controls.Add(this.txt_EditCus);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_EditCus);
            this.Name = "EditCus";
            this.Text = "EditCus";
            this.Load += new System.EventHandler(this.EditCus_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_EditCus;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.TextBox txt_EditCus;
        private System.Windows.Forms.Label lbl_EditCus;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
    }
}