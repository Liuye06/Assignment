namespace Assignment
{
    partial class Admin_admin
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
            this.btnEditAdmin = new System.Windows.Forms.Button();
            this.btnRadmin = new System.Windows.Forms.Button();
            this.btnDeleteAdmin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEditAdmin
            // 
            this.btnEditAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditAdmin.Location = new System.Drawing.Point(298, 233);
            this.btnEditAdmin.Name = "btnEditAdmin";
            this.btnEditAdmin.Size = new System.Drawing.Size(146, 35);
            this.btnEditAdmin.TabIndex = 3;
            this.btnEditAdmin.Text = "Edit Profile";
            this.btnEditAdmin.UseVisualStyleBackColor = true;
            // 
            // btnRadmin
            // 
            this.btnRadmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRadmin.Location = new System.Drawing.Point(298, 158);
            this.btnRadmin.Name = "btnRadmin";
            this.btnRadmin.Size = new System.Drawing.Size(146, 35);
            this.btnRadmin.TabIndex = 4;
            this.btnRadmin.Text = "Register";
            this.btnRadmin.UseVisualStyleBackColor = true;
            // 
            // btnDeleteAdmin
            // 
            this.btnDeleteAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAdmin.Location = new System.Drawing.Point(298, 315);
            this.btnDeleteAdmin.Name = "btnDeleteAdmin";
            this.btnDeleteAdmin.Size = new System.Drawing.Size(146, 35);
            this.btnDeleteAdmin.TabIndex = 5;
            this.btnDeleteAdmin.Text = "Delete";
            this.btnDeleteAdmin.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(337, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "welcome";
            // 
            // Admin_admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDeleteAdmin);
            this.Controls.Add(this.btnRadmin);
            this.Controls.Add(this.btnEditAdmin);
            this.Name = "Admin_admin";
            this.Text = "Admin_admin";
            this.Load += new System.EventHandler(this.Admin_admin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEditAdmin;
        private System.Windows.Forms.Button btnRadmin;
        private System.Windows.Forms.Button btnDeleteAdmin;
        private System.Windows.Forms.Label label1;
    }
}