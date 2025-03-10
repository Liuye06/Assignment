namespace Assignment
{
    partial class Admin
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.btn_Home = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_SalesReport = new System.Windows.Forms.Button();
            this.btn_Feedback = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(560, 50);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(297, 29);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = "Welcome to Admin page";
            // 
            // btn_Home
            // 
            this.btn_Home.FlatAppearance.BorderColor = System.Drawing.Color.AntiqueWhite;
            this.btn_Home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Home.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Home.ForeColor = System.Drawing.Color.Black;
            this.btn_Home.Location = new System.Drawing.Point(-2, 122);
            this.btn_Home.Name = "btn_Home";
            this.btn_Home.Size = new System.Drawing.Size(258, 78);
            this.btn_Home.TabIndex = 2;
            this.btn_Home.Text = "Home";
            this.btn_Home.UseVisualStyleBackColor = true;
            this.btn_Home.UseWaitCursor = true;
            this.btn_Home.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_Update);
            this.panel1.Controls.Add(this.btn_Feedback);
            this.panel1.Controls.Add(this.btn_SalesReport);
            this.panel1.Controls.Add(this.btn_Home);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(257, 559);
            this.panel1.TabIndex = 3;
            this.panel1.UseWaitCursor = true;
            // 
            // btn_SalesReport
            // 
            this.btn_SalesReport.FlatAppearance.BorderColor = System.Drawing.Color.AntiqueWhite;
            this.btn_SalesReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SalesReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SalesReport.ForeColor = System.Drawing.Color.Black;
            this.btn_SalesReport.Location = new System.Drawing.Point(3, 206);
            this.btn_SalesReport.Name = "btn_SalesReport";
            this.btn_SalesReport.Size = new System.Drawing.Size(258, 78);
            this.btn_SalesReport.TabIndex = 6;
            this.btn_SalesReport.Text = "Sales Report";
            this.btn_SalesReport.UseVisualStyleBackColor = true;
            this.btn_SalesReport.UseWaitCursor = true;
            // 
            // btn_Feedback
            // 
            this.btn_Feedback.FlatAppearance.BorderColor = System.Drawing.Color.AntiqueWhite;
            this.btn_Feedback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Feedback.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Feedback.ForeColor = System.Drawing.Color.Black;
            this.btn_Feedback.Location = new System.Drawing.Point(-2, 299);
            this.btn_Feedback.Name = "btn_Feedback";
            this.btn_Feedback.Size = new System.Drawing.Size(258, 78);
            this.btn_Feedback.TabIndex = 7;
            this.btn_Feedback.Text = "Feedback";
            this.btn_Feedback.UseVisualStyleBackColor = true;
            this.btn_Feedback.UseWaitCursor = true;
            // 
            // btn_Update
            // 
            this.btn_Update.FlatAppearance.BorderColor = System.Drawing.Color.AntiqueWhite;
            this.btn_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.ForeColor = System.Drawing.Color.Black;
            this.btn_Update.Location = new System.Drawing.Point(-2, 393);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(258, 78);
            this.btn_Update.TabIndex = 8;
            this.btn_Update.Text = "Update User";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.UseWaitCursor = true;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(1154, 559);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Button btn_Home;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Feedback;
        private System.Windows.Forms.Button btn_SalesReport;
    }
}