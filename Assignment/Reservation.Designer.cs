namespace Assignment
{
    partial class Reservation
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
            this.gbManageReservation = new System.Windows.Forms.GroupBox();
            this.btnResetReservationSearch = new System.Windows.Forms.Button();
            this.dgvReservation = new System.Windows.Forms.DataGridView();
            this.btnSearchReservation = new System.Windows.Forms.Button();
            this.txtReservation = new System.Windows.Forms.TextBox();
            this.lblReservation = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tableSidebar_Reservation.SuspendLayout();
            this.gbManageReservation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservation)).BeginInit();
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
            this.tableSidebar_Reservation.TabIndex = 7;
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
            // 
            // gbManageReservation
            // 
            this.gbManageReservation.Controls.Add(this.button1);
            this.gbManageReservation.Controls.Add(this.btnResetReservationSearch);
            this.gbManageReservation.Controls.Add(this.dgvReservation);
            this.gbManageReservation.Controls.Add(this.btnSearchReservation);
            this.gbManageReservation.Controls.Add(this.txtReservation);
            this.gbManageReservation.Controls.Add(this.lblReservation);
            this.gbManageReservation.Location = new System.Drawing.Point(218, 72);
            this.gbManageReservation.Name = "gbManageReservation";
            this.gbManageReservation.Size = new System.Drawing.Size(852, 369);
            this.gbManageReservation.TabIndex = 8;
            this.gbManageReservation.TabStop = false;
            this.gbManageReservation.Text = "Manage Reservation";
            // 
            // btnResetReservationSearch
            // 
            this.btnResetReservationSearch.Location = new System.Drawing.Point(526, 41);
            this.btnResetReservationSearch.Name = "btnResetReservationSearch";
            this.btnResetReservationSearch.Size = new System.Drawing.Size(289, 35);
            this.btnResetReservationSearch.TabIndex = 11;
            this.btnResetReservationSearch.Text = "Reset Search Reservation";
            // 
            // dgvReservation
            // 
            this.dgvReservation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservation.Location = new System.Drawing.Point(30, 93);
            this.dgvReservation.Name = "dgvReservation";
            this.dgvReservation.RowHeadersWidth = 51;
            this.dgvReservation.RowTemplate.Height = 24;
            this.dgvReservation.Size = new System.Drawing.Size(785, 216);
            this.dgvReservation.TabIndex = 9;
            // 
            // btnSearchReservation
            // 
            this.btnSearchReservation.Location = new System.Drawing.Point(414, 41);
            this.btnSearchReservation.Name = "btnSearchReservation";
            this.btnSearchReservation.Size = new System.Drawing.Size(106, 35);
            this.btnSearchReservation.TabIndex = 8;
            this.btnSearchReservation.Text = "Search";
            this.btnSearchReservation.UseVisualStyleBackColor = true;
            this.btnSearchReservation.Click += new System.EventHandler(this.btnSearchReservation_Click);
            // 
            // txtReservation
            // 
            this.txtReservation.Location = new System.Drawing.Point(146, 43);
            this.txtReservation.Name = "txtReservation";
            this.txtReservation.Size = new System.Drawing.Size(262, 30);
            this.txtReservation.TabIndex = 7;
            // 
            // lblReservation
            // 
            this.lblReservation.AutoSize = true;
            this.lblReservation.Location = new System.Drawing.Point(25, 46);
            this.lblReservation.Name = "lblReservation";
            this.lblReservation.Size = new System.Drawing.Size(115, 25);
            this.lblReservation.TabIndex = 6;
            this.lblReservation.Text = "Reservation";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(601, 315);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(214, 33);
            this.button1.TabIndex = 12;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Reservation
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1082, 453);
            this.Controls.Add(this.gbManageReservation);
            this.Controls.Add(this.tableSidebar_Reservation);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Reservation";
            this.Text = "Reservation";
            this.Load += new System.EventHandler(this.Reservation_Load);
            this.tableSidebar_Reservation.ResumeLayout(false);
            this.gbManageReservation.ResumeLayout(false);
            this.gbManageReservation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservation)).EndInit();
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
        private System.Windows.Forms.Button btnResetReservationSearch;
        private System.Windows.Forms.DataGridView dgvReservation;
        private System.Windows.Forms.Button btnSearchReservation;
        private System.Windows.Forms.TextBox txtReservation;
        private System.Windows.Forms.Label lblReservation;
        private System.Windows.Forms.Button button1;
    }
}