namespace Assignment
{
    partial class DeleteStaff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteStaff));
            this.btn_delete = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.listBoxStaff = new System.Windows.Forms.ListBox();
            this.btn_ResetseacrhStaff = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_delete
            // 
            this.btn_delete.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.Color.LightSalmon;
            this.btn_delete.Location = new System.Drawing.Point(236, 353);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(255, 38);
            this.btn_delete.TabIndex = 3;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(244, 66);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(247, 33);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // listBoxStaff
            // 
            this.listBoxStaff.FormattingEnabled = true;
            this.listBoxStaff.ItemHeight = 25;
            this.listBoxStaff.Location = new System.Drawing.Point(235, 158);
            this.listBoxStaff.Name = "listBoxStaff";
            this.listBoxStaff.Size = new System.Drawing.Size(594, 129);
            this.listBoxStaff.TabIndex = 4;
            // 
            // btn_ResetseacrhStaff
            // 
            this.btn_ResetseacrhStaff.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ResetseacrhStaff.ForeColor = System.Drawing.Color.LightSalmon;
            this.btn_ResetseacrhStaff.Location = new System.Drawing.Point(658, 66);
            this.btn_ResetseacrhStaff.Name = "btn_ResetseacrhStaff";
            this.btn_ResetseacrhStaff.Size = new System.Drawing.Size(207, 35);
            this.btn_ResetseacrhStaff.TabIndex = 5;
            this.btn_ResetseacrhStaff.Text = "Reset";
            this.btn_ResetseacrhStaff.UseVisualStyleBackColor = true;
            this.btn_ResetseacrhStaff.Click += new System.EventHandler(this.btn_ResetseacrhStaff_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel.ForeColor = System.Drawing.Color.LightSalmon;
            this.btn_Cancel.Location = new System.Drawing.Point(572, 353);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(257, 38);
            this.btn_Cancel.TabIndex = 6;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click_1);
            // 
            // DeleteStaff
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1082, 453);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_ResetseacrhStaff);
            this.Controls.Add(this.listBoxStaff);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.comboBox1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "DeleteStaff";
            this.Text = "DeleteStaff";
            this.Load += new System.EventHandler(this.DeleteStaff_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ListBox listBoxStaff;
        private System.Windows.Forms.Button btn_ResetseacrhStaff;
        private System.Windows.Forms.Button btn_Cancel;
    }
}