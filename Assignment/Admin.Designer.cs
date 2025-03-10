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
            this.btn_salesReport = new System.Windows.Forms.Button();
            this.btn_feedback = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
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
            this.btn_Home.Location = new System.Drawing.Point(-1, 122);
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
            this.panel1.Controls.Add(this.btn_update);
            this.panel1.Controls.Add(this.btn_feedback);
            this.panel1.Controls.Add(this.btn_salesReport);
            this.panel1.Controls.Add(this.btn_Home);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(257, 576);
            this.panel1.TabIndex = 3;
            this.panel1.UseWaitCursor = true;
            // 
            // btn_salesReport
            // 
            this.btn_salesReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salesReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salesReport.Location = new System.Drawing.Point(-1, 196);
            this.btn_salesReport.Name = "btn_salesReport";
            this.btn_salesReport.Size = new System.Drawing.Size(257, 78);
            this.btn_salesReport.TabIndex = 3;
            this.btn_salesReport.Text = "Sales Report";
            this.btn_salesReport.UseVisualStyleBackColor = true;
            this.btn_salesReport.UseWaitCursor = true;
            // 
            // btn_feedback
            // 
            this.btn_feedback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_feedback.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_feedback.Location = new System.Drawing.Point(-1, 362);
            this.btn_feedback.Name = "btn_feedback";
            this.btn_feedback.Size = new System.Drawing.Size(258, 78);
            this.btn_feedback.TabIndex = 4;
            this.btn_feedback.Text = "Feedback";
            this.btn_feedback.UseVisualStyleBackColor = true;
            this.btn_feedback.UseWaitCursor = true;
            this.btn_feedback.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_update
            // 
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.Location = new System.Drawing.Point(-1, 460);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(258, 78);
            this.btn_update.TabIndex = 5;
            this.btn_update.Text = "Update User";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.UseWaitCursor = true;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 576);
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
        private System.Windows.Forms.Button btn_feedback;
        private System.Windows.Forms.Button btn_salesReport;
        private System.Windows.Forms.Button btn_update;
    }
}