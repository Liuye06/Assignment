namespace Assignment
{
    partial class RCMainPage
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Profile = new System.Windows.Forms.Button();
            this.btn_Reply = new System.Windows.Forms.Button();
            this.btn_Reservation = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Profile);
            this.panel1.Controls.Add(this.btn_Reservation);
            this.panel1.Controls.Add(this.btn_Reply);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(228, 452);
            this.panel1.TabIndex = 0;
            // 
            // btn_Profile
            // 
            this.btn_Profile.Location = new System.Drawing.Point(0, 269);
            this.btn_Profile.Name = "btn_Profile";
            this.btn_Profile.Size = new System.Drawing.Size(228, 77);
            this.btn_Profile.TabIndex = 2;
            this.btn_Profile.Text = "Profile";
            this.btn_Profile.UseVisualStyleBackColor = true;
            this.btn_Profile.Click += new System.EventHandler(this.btn_Profile_Click);
            // 
            // btn_Reply
            // 
            this.btn_Reply.Location = new System.Drawing.Point(0, 103);
            this.btn_Reply.Name = "btn_Reply";
            this.btn_Reply.Size = new System.Drawing.Size(228, 77);
            this.btn_Reply.TabIndex = 1;
            this.btn_Reply.Text = "Reply Request";
            this.btn_Reply.UseVisualStyleBackColor = true;
            this.btn_Reply.Click += new System.EventHandler(this.btn_Reply_Click);
            // 
            // btn_Reservation
            // 
            this.btn_Reservation.Location = new System.Drawing.Point(0, 186);
            this.btn_Reservation.Name = "btn_Reservation";
            this.btn_Reservation.Size = new System.Drawing.Size(228, 77);
            this.btn_Reservation.TabIndex = 0;
            this.btn_Reservation.Text = "Manage Reservation";
            this.btn_Reservation.UseVisualStyleBackColor = true;
            this.btn_Reservation.Click += new System.EventHandler(this.btn_Reservation_Click);
            // 
            // RCMainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 450);
            this.Controls.Add(this.panel1);
            this.Name = "RCMainPage";
            this.Text = "RCMainPage";
            this.Load += new System.EventHandler(this.RCMainPage_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Reservation;
        private System.Windows.Forms.Button btn_Profile;
        private System.Windows.Forms.Button btn_Reply;
    }
}