namespace Assignment
{
    partial class ReservationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReservationForm));
            this.tableSidebar_Reservation = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_RC = new System.Windows.Forms.Label();
            this.pic_logo = new System.Windows.Forms.PictureBox();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnManageReservation = new System.Windows.Forms.Button();
            this.btnReplyCustomer = new System.Windows.Forms.Button();
            this.btnRCProfile = new System.Windows.Forms.Button();
            this.gbManageReservation = new System.Windows.Forms.GroupBox();
            this.cmbAssignHall = new System.Windows.Forms.ComboBox();
            this.cmbChangeStatus = new System.Windows.Forms.ComboBox();
            this.btnUpdateStatus = new System.Windows.Forms.Button();
            this.lblChangeStatus = new System.Windows.Forms.Label();
            this.btnAssignHall = new System.Windows.Forms.Button();
            this.dgvReservation = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableSidebar_Reservation.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).BeginInit();
            this.gbManageReservation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservation)).BeginInit();
            this.panel2.SuspendLayout();
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
            this.tableSidebar_Reservation.Location = new System.Drawing.Point(12, 1);
            this.tableSidebar_Reservation.Name = "tableSidebar_Reservation";
            this.tableSidebar_Reservation.RowCount = 6;
            this.tableSidebar_Reservation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableSidebar_Reservation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableSidebar_Reservation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableSidebar_Reservation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableSidebar_Reservation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableSidebar_Reservation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableSidebar_Reservation.Size = new System.Drawing.Size(216, 464);
            this.tableSidebar_Reservation.TabIndex = 7;
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
            this.btnRCProfile.Text = "Reservation Coordinate Profile";
            this.btnRCProfile.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnRCProfile.UseVisualStyleBackColor = false;
            this.btnRCProfile.Click += new System.EventHandler(this.btnRCProfile_Click);
            // 
            // gbManageReservation
            // 
            this.gbManageReservation.BackColor = System.Drawing.Color.Transparent;
            this.gbManageReservation.Controls.Add(this.cmbAssignHall);
            this.gbManageReservation.Controls.Add(this.cmbChangeStatus);
            this.gbManageReservation.Controls.Add(this.btnUpdateStatus);
            this.gbManageReservation.Controls.Add(this.lblChangeStatus);
            this.gbManageReservation.Controls.Add(this.btnAssignHall);
            this.gbManageReservation.Controls.Add(this.dgvReservation);
            this.gbManageReservation.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbManageReservation.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.gbManageReservation.Location = new System.Drawing.Point(30, 28);
            this.gbManageReservation.Name = "gbManageReservation";
            this.gbManageReservation.Size = new System.Drawing.Size(821, 412);
            this.gbManageReservation.TabIndex = 8;
            this.gbManageReservation.TabStop = false;
            this.gbManageReservation.Text = "Manage Reservation";
            // 
            // cmbAssignHall
            // 
            this.cmbAssignHall.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cmbAssignHall.FormattingEnabled = true;
            this.cmbAssignHall.Location = new System.Drawing.Point(357, 357);
            this.cmbAssignHall.Name = "cmbAssignHall";
            this.cmbAssignHall.Size = new System.Drawing.Size(229, 33);
            this.cmbAssignHall.TabIndex = 16;
            // 
            // cmbChangeStatus
            // 
            this.cmbChangeStatus.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cmbChangeStatus.FormattingEnabled = true;
            this.cmbChangeStatus.Items.AddRange(new object[] {
            "Completed ",
            "Confirmed"});
            this.cmbChangeStatus.Location = new System.Drawing.Point(174, 84);
            this.cmbChangeStatus.Name = "cmbChangeStatus";
            this.cmbChangeStatus.Size = new System.Drawing.Size(285, 33);
            this.cmbChangeStatus.TabIndex = 15;
            // 
            // btnUpdateStatus
            // 
            this.btnUpdateStatus.ForeColor = System.Drawing.Color.IndianRed;
            this.btnUpdateStatus.Location = new System.Drawing.Point(485, 82);
            this.btnUpdateStatus.Name = "btnUpdateStatus";
            this.btnUpdateStatus.Size = new System.Drawing.Size(330, 37);
            this.btnUpdateStatus.TabIndex = 14;
            this.btnUpdateStatus.Text = "Update Status";
            this.btnUpdateStatus.UseVisualStyleBackColor = true;
            this.btnUpdateStatus.Click += new System.EventHandler(this.btnUpdateStatus_Click);
            // 
            // lblChangeStatus
            // 
            this.lblChangeStatus.AutoSize = true;
            this.lblChangeStatus.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblChangeStatus.Location = new System.Drawing.Point(12, 88);
            this.lblChangeStatus.Name = "lblChangeStatus";
            this.lblChangeStatus.Size = new System.Drawing.Size(156, 25);
            this.lblChangeStatus.TabIndex = 13;
            this.lblChangeStatus.Text = "Change Status";
            // 
            // btnAssignHall
            // 
            this.btnAssignHall.ForeColor = System.Drawing.Color.IndianRed;
            this.btnAssignHall.Location = new System.Drawing.Point(601, 356);
            this.btnAssignHall.Name = "btnAssignHall";
            this.btnAssignHall.Size = new System.Drawing.Size(214, 34);
            this.btnAssignHall.TabIndex = 12;
            this.btnAssignHall.Text = "Assign Hall";
            this.btnAssignHall.UseVisualStyleBackColor = true;
            this.btnAssignHall.Click += new System.EventHandler(this.btnAssignHall_Click);
            // 
            // dgvReservation
            // 
            this.dgvReservation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservation.Location = new System.Drawing.Point(30, 134);
            this.dgvReservation.Name = "dgvReservation";
            this.dgvReservation.RowHeadersWidth = 51;
            this.dgvReservation.RowTemplate.Height = 24;
            this.dgvReservation.Size = new System.Drawing.Size(785, 207);
            this.dgvReservation.TabIndex = 9;
            this.dgvReservation.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReservation_CellClick);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Controls.Add(this.gbManageReservation);
            this.panel2.Location = new System.Drawing.Point(219, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(868, 464);
            this.panel2.TabIndex = 9;
            // 
            // ReservationForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(237)))), ((int)(((byte)(225)))));
            this.ClientSize = new System.Drawing.Size(1082, 453);
            this.Controls.Add(this.tableSidebar_Reservation);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ReservationForm";
            this.Text = "Reservation";
            this.Load += new System.EventHandler(this.Reservation_Load);
            this.tableSidebar_Reservation.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).EndInit();
            this.gbManageReservation.ResumeLayout(false);
            this.gbManageReservation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservation)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn reservationIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hallIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rReqIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.TableLayoutPanel tableSidebar_Reservation;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnManageReservation;
        private System.Windows.Forms.Button btnRCProfile;
        private System.Windows.Forms.Button btnReplyCustomer;
        private System.Windows.Forms.GroupBox gbManageReservation;
        private System.Windows.Forms.DataGridView dgvReservation;
        private System.Windows.Forms.Button btnAssignHall;
        private System.Windows.Forms.ComboBox cmbChangeStatus;
        private System.Windows.Forms.Button btnUpdateStatus;
        private System.Windows.Forms.Label lblChangeStatus;
        private System.Windows.Forms.ComboBox cmbAssignHall;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_RC;
        private System.Windows.Forms.PictureBox pic_logo;
        private System.Windows.Forms.Panel panel2;
    }
}