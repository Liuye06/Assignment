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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RCMainPage));
            this.tableSidebar_Reservation = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_RC = new System.Windows.Forms.Label();
            this.pic_logo = new System.Windows.Forms.PictureBox();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnManageReservation = new System.Windows.Forms.Button();
            this.btnReplyCustomer = new System.Windows.Forms.Button();
            this.btnRCProfile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableSidebar_Reservation.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableSidebar_Reservation
            // 
            this.tableSidebar_Reservation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(119)))), ((int)(((byte)(81)))));
            this.tableSidebar_Reservation.ColumnCount = 1;
            this.tableSidebar_Reservation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableSidebar_Reservation.Controls.Add(this.panel1, 0, 0);
            this.tableSidebar_Reservation.Controls.Add(this.btnLogOut, 0, 4);
            this.tableSidebar_Reservation.Controls.Add(this.btnManageReservation, 0, 1);
            this.tableSidebar_Reservation.Controls.Add(this.btnReplyCustomer, 0, 2);
            this.tableSidebar_Reservation.Controls.Add(this.btnRCProfile, 0, 3);
            this.tableSidebar_Reservation.Location = new System.Drawing.Point(12, -3);
            this.tableSidebar_Reservation.Name = "tableSidebar_Reservation";
            this.tableSidebar_Reservation.RowCount = 6;
            this.tableSidebar_Reservation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableSidebar_Reservation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableSidebar_Reservation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableSidebar_Reservation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableSidebar_Reservation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableSidebar_Reservation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableSidebar_Reservation.Size = new System.Drawing.Size(216, 464);
            this.tableSidebar_Reservation.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_RC);
            this.panel1.Controls.Add(this.pic_logo);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(210, 144);
            this.panel1.TabIndex = 17;
            // 
            // lbl_RC
            // 
            this.lbl_RC.AutoSize = true;
            this.lbl_RC.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RC.Location = new System.Drawing.Point(-2, 0);
            this.lbl_RC.Name = "lbl_RC";
            this.lbl_RC.Size = new System.Drawing.Size(159, 58);
            this.lbl_RC.TabIndex = 19;
            this.lbl_RC.Text = "Reservation \r\nCoordinator";
            // 
            // pic_logo
            // 
            this.pic_logo.Image = ((System.Drawing.Image)(resources.GetObject("pic_logo.Image")));
            this.pic_logo.Location = new System.Drawing.Point(3, 45);
            this.pic_logo.Name = "pic_logo";
            this.pic_logo.Size = new System.Drawing.Size(130, 99);
            this.pic_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pic_logo.TabIndex = 18;
            this.pic_logo.TabStop = false;
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.Gainsboro;
            this.btnLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.Image = ((System.Drawing.Image)(resources.GetObject("btnLogOut.Image")));
            this.btnLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogOut.Location = new System.Drawing.Point(3, 318);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(210, 39);
            this.btnLogOut.TabIndex = 15;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnManageReservation
            // 
            this.btnManageReservation.BackColor = System.Drawing.Color.Gainsboro;
            this.btnManageReservation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManageReservation.FlatAppearance.BorderSize = 0;
            this.btnManageReservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageReservation.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageReservation.Image = ((System.Drawing.Image)(resources.GetObject("btnManageReservation.Image")));
            this.btnManageReservation.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnManageReservation.Location = new System.Drawing.Point(3, 152);
            this.btnManageReservation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnManageReservation.Name = "btnManageReservation";
            this.btnManageReservation.Size = new System.Drawing.Size(210, 41);
            this.btnManageReservation.TabIndex = 0;
            this.btnManageReservation.Text = "Manage Reservation";
            this.btnManageReservation.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnManageReservation.UseVisualStyleBackColor = false;
            this.btnManageReservation.Click += new System.EventHandler(this.btnManageReservation_Click);
            // 
            // btnReplyCustomer
            // 
            this.btnReplyCustomer.BackColor = System.Drawing.Color.Gainsboro;
            this.btnReplyCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReplyCustomer.FlatAppearance.BorderSize = 0;
            this.btnReplyCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReplyCustomer.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReplyCustomer.Image = ((System.Drawing.Image)(resources.GetObject("btnReplyCustomer.Image")));
            this.btnReplyCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReplyCustomer.Location = new System.Drawing.Point(3, 197);
            this.btnReplyCustomer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReplyCustomer.Name = "btnReplyCustomer";
            this.btnReplyCustomer.Size = new System.Drawing.Size(210, 41);
            this.btnReplyCustomer.TabIndex = 1;
            this.btnReplyCustomer.Text = "Reply Customer";
            this.btnReplyCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnReplyCustomer.UseVisualStyleBackColor = false;
            this.btnReplyCustomer.Click += new System.EventHandler(this.btnReplyCustomer_Click);
            // 
            // btnRCProfile
            // 
            this.btnRCProfile.BackColor = System.Drawing.Color.Gainsboro;
            this.btnRCProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRCProfile.FlatAppearance.BorderSize = 0;
            this.btnRCProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRCProfile.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRCProfile.Image = ((System.Drawing.Image)(resources.GetObject("btnRCProfile.Image")));
            this.btnRCProfile.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRCProfile.Location = new System.Drawing.Point(3, 242);
            this.btnRCProfile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRCProfile.Name = "btnRCProfile";
            this.btnRCProfile.Size = new System.Drawing.Size(210, 71);
            this.btnRCProfile.TabIndex = 2;
            this.btnRCProfile.Text = "Reservation Coordinator Profile";
            this.btnRCProfile.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnRCProfile.UseVisualStyleBackColor = false;
            this.btnRCProfile.Click += new System.EventHandler(this.btnRCProfile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.WindowText;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 26F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(453, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(420, 53);
            this.label1.TabIndex = 18;
            this.label1.Text = "Welcome Back To Work";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(250, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(811, 419);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // RCMainPage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(237)))), ((int)(((byte)(225)))));
            this.ClientSize = new System.Drawing.Size(1082, 453);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableSidebar_Reservation);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "RCMainPage";
            this.Text = "RCMainPage";
            this.Load += new System.EventHandler(this.RCMainPage_Load);
            this.tableSidebar_Reservation.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableSidebar_Reservation;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnManageReservation;
        private System.Windows.Forms.Button btnReplyCustomer;
        private System.Windows.Forms.Button btnRCProfile;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_RC;
        private System.Windows.Forms.PictureBox pic_logo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}