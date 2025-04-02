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
            this.tableSidebar_Reservation = new System.Windows.Forms.TableLayoutPanel();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnManageReservation = new System.Windows.Forms.Button();
            this.btnReplyCustomer = new System.Windows.Forms.Button();
            this.btnRCProfile = new System.Windows.Forms.Button();
            this.tableSidebar_Reservation.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableSidebar_Reservation
            // 
            this.tableSidebar_Reservation.ColumnCount = 1;
            this.tableSidebar_Reservation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableSidebar_Reservation.Controls.Add(this.btnLogOut, 0, 4);
            this.tableSidebar_Reservation.Controls.Add(this.btnManageReservation, 0, 1);
            this.tableSidebar_Reservation.Controls.Add(this.btnReplyCustomer, 0, 2);
            this.tableSidebar_Reservation.Controls.Add(this.btnRCProfile, 0, 3);
            this.tableSidebar_Reservation.Location = new System.Drawing.Point(12, 11);
            this.tableSidebar_Reservation.Name = "tableSidebar_Reservation";
            this.tableSidebar_Reservation.RowCount = 6;
            this.tableSidebar_Reservation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableSidebar_Reservation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableSidebar_Reservation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableSidebar_Reservation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableSidebar_Reservation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableSidebar_Reservation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableSidebar_Reservation.Size = new System.Drawing.Size(200, 430);
            this.tableSidebar_Reservation.TabIndex = 10;
            // 
            // btnLogOut
            // 
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.Location = new System.Drawing.Point(3, 183);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(194, 34);
            this.btnLogOut.TabIndex = 15;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnManageReservation
            // 
            this.btnManageReservation.BackColor = System.Drawing.Color.Silver;
            this.btnManageReservation.FlatAppearance.BorderSize = 0;
            this.btnManageReservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageReservation.Location = new System.Drawing.Point(3, 62);
            this.btnManageReservation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnManageReservation.Name = "btnManageReservation";
            this.btnManageReservation.Size = new System.Drawing.Size(194, 36);
            this.btnManageReservation.TabIndex = 0;
            this.btnManageReservation.Text = "Manage Reservation";
            this.btnManageReservation.UseVisualStyleBackColor = false;
            this.btnManageReservation.Click += new System.EventHandler(this.btnManageReservation_Click);
            // 
            // btnReplyCustomer
            // 
            this.btnReplyCustomer.BackColor = System.Drawing.Color.Silver;
            this.btnReplyCustomer.FlatAppearance.BorderSize = 0;
            this.btnReplyCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReplyCustomer.Location = new System.Drawing.Point(3, 102);
            this.btnReplyCustomer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReplyCustomer.Name = "btnReplyCustomer";
            this.btnReplyCustomer.Size = new System.Drawing.Size(194, 36);
            this.btnReplyCustomer.TabIndex = 1;
            this.btnReplyCustomer.Text = "Reply Customer";
            this.btnReplyCustomer.UseVisualStyleBackColor = false;
            this.btnReplyCustomer.Click += new System.EventHandler(this.btnReplyCustomer_Click);
            // 
            // btnRCProfile
            // 
            this.btnRCProfile.BackColor = System.Drawing.Color.Silver;
            this.btnRCProfile.FlatAppearance.BorderSize = 0;
            this.btnRCProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRCProfile.Location = new System.Drawing.Point(3, 142);
            this.btnRCProfile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRCProfile.Name = "btnRCProfile";
            this.btnRCProfile.Size = new System.Drawing.Size(194, 36);
            this.btnRCProfile.TabIndex = 2;
            this.btnRCProfile.Text = "Reservation Coordinate Profile";
            this.btnRCProfile.UseVisualStyleBackColor = false;
            this.btnRCProfile.Click += new System.EventHandler(this.btnRCProfile_Click);
            // 
            // RCMainPage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1082, 453);
            this.Controls.Add(this.tableSidebar_Reservation);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "RCMainPage";
            this.Text = "RCMainPage";
            this.Load += new System.EventHandler(this.RCMainPage_Load);
            this.tableSidebar_Reservation.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableSidebar_Reservation;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnManageReservation;
        private System.Windows.Forms.Button btnReplyCustomer;
        private System.Windows.Forms.Button btnRCProfile;
    }
}