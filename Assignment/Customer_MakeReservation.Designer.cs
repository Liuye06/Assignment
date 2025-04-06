namespace Assignment
{
    partial class Customer_MakeReservation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customer_MakeReservation));
            this.panel_ReservationRequest = new System.Windows.Forms.Panel();
            this.monthCalendarEnd = new System.Windows.Forms.MonthCalendar();
            this.lblEndReservationDate = new System.Windows.Forms.Label();
            this.numHeadCount = new System.Windows.Forms.NumericUpDown();
            this.lbl_HeadCount = new System.Windows.Forms.Label();
            this.lblStartReservationDate = new System.Windows.Forms.Label();
            this.lbl_Function = new System.Windows.Forms.Label();
            this.cmbFunction = new System.Windows.Forms.ComboBox();
            this.lbl_request = new System.Windows.Forms.Label();
            this.txtRequest = new System.Windows.Forms.TextBox();
            this.monthCalendarStart = new System.Windows.Forms.MonthCalendar();
            this.btn_SendReq = new System.Windows.Forms.Button();
            this.tableSidebar_Customer = new System.Windows.Forms.TableLayoutPanel();
            this.pic_logo = new System.Windows.Forms.PictureBox();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnMakeReservation = new System.Windows.Forms.Button();
            this.btnViewReservation = new System.Windows.Forms.Button();
            this.btnFeedback = new System.Windows.Forms.Button();
            this.btnViewReplyRequest = new System.Windows.Forms.Button();
            this.btnViewOrders = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnMakeOrder = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_ReservationRequest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numHeadCount)).BeginInit();
            this.tableSidebar_Customer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_ReservationRequest
            // 
            this.panel_ReservationRequest.AutoScroll = true;
            this.panel_ReservationRequest.BackColor = System.Drawing.Color.Transparent;
            this.panel_ReservationRequest.Controls.Add(this.monthCalendarEnd);
            this.panel_ReservationRequest.Controls.Add(this.lblEndReservationDate);
            this.panel_ReservationRequest.Controls.Add(this.numHeadCount);
            this.panel_ReservationRequest.Controls.Add(this.lbl_HeadCount);
            this.panel_ReservationRequest.Controls.Add(this.lblStartReservationDate);
            this.panel_ReservationRequest.Controls.Add(this.lbl_Function);
            this.panel_ReservationRequest.Controls.Add(this.cmbFunction);
            this.panel_ReservationRequest.Controls.Add(this.lbl_request);
            this.panel_ReservationRequest.Controls.Add(this.txtRequest);
            this.panel_ReservationRequest.Controls.Add(this.monthCalendarStart);
            this.panel_ReservationRequest.Controls.Add(this.btn_SendReq);
            this.panel_ReservationRequest.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_ReservationRequest.Location = new System.Drawing.Point(43, 61);
            this.panel_ReservationRequest.Margin = new System.Windows.Forms.Padding(4);
            this.panel_ReservationRequest.Name = "panel_ReservationRequest";
            this.panel_ReservationRequest.Size = new System.Drawing.Size(809, 360);
            this.panel_ReservationRequest.TabIndex = 56;
            // 
            // monthCalendarEnd
            // 
            this.monthCalendarEnd.Location = new System.Drawing.Point(300, 53);
            this.monthCalendarEnd.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.monthCalendarEnd.MinDate = new System.DateTime(2025, 3, 12, 0, 0, 0, 0);
            this.monthCalendarEnd.Name = "monthCalendarEnd";
            this.monthCalendarEnd.TabIndex = 49;
            this.monthCalendarEnd.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendarEnd_DateChanged);
            // 
            // lblEndReservationDate
            // 
            this.lblEndReservationDate.AutoSize = true;
            this.lblEndReservationDate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblEndReservationDate.Location = new System.Drawing.Point(317, 17);
            this.lblEndReservationDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEndReservationDate.Name = "lblEndReservationDate";
            this.lblEndReservationDate.Size = new System.Drawing.Size(235, 25);
            this.lblEndReservationDate.TabIndex = 48;
            this.lblEndReservationDate.Text = "End Reservation Date";
            // 
            // numHeadCount
            // 
            this.numHeadCount.BackColor = System.Drawing.Color.LightGray;
            this.numHeadCount.Location = new System.Drawing.Point(621, 160);
            this.numHeadCount.Margin = new System.Windows.Forms.Padding(4);
            this.numHeadCount.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numHeadCount.Name = "numHeadCount";
            this.numHeadCount.Size = new System.Drawing.Size(160, 32);
            this.numHeadCount.TabIndex = 45;
            // 
            // lbl_HeadCount
            // 
            this.lbl_HeadCount.AutoSize = true;
            this.lbl_HeadCount.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_HeadCount.Location = new System.Drawing.Point(616, 126);
            this.lbl_HeadCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_HeadCount.Name = "lbl_HeadCount";
            this.lbl_HeadCount.Size = new System.Drawing.Size(132, 25);
            this.lbl_HeadCount.TabIndex = 44;
            this.lbl_HeadCount.Text = "Head Count";
            // 
            // lblStartReservationDate
            // 
            this.lblStartReservationDate.AutoSize = true;
            this.lblStartReservationDate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblStartReservationDate.Location = new System.Drawing.Point(26, 17);
            this.lblStartReservationDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStartReservationDate.Name = "lblStartReservationDate";
            this.lblStartReservationDate.Size = new System.Drawing.Size(244, 25);
            this.lblStartReservationDate.TabIndex = 43;
            this.lblStartReservationDate.Text = "Start Reservation Date";
            // 
            // lbl_Function
            // 
            this.lbl_Function.AutoSize = true;
            this.lbl_Function.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Function.Location = new System.Drawing.Point(616, 28);
            this.lbl_Function.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Function.Name = "lbl_Function";
            this.lbl_Function.Size = new System.Drawing.Size(103, 25);
            this.lbl_Function.TabIndex = 42;
            this.lbl_Function.Text = "Function";
            // 
            // cmbFunction
            // 
            this.cmbFunction.BackColor = System.Drawing.Color.LightGray;
            this.cmbFunction.FormattingEnabled = true;
            this.cmbFunction.Items.AddRange(new object[] {
            "Birthday",
            "Wedding",
            "Conference",
            "Seminar",
            "Ceremony",
            "Anniversary",
            "Competition",
            "Performance"});
            this.cmbFunction.Location = new System.Drawing.Point(621, 62);
            this.cmbFunction.Margin = new System.Windows.Forms.Padding(4);
            this.cmbFunction.Name = "cmbFunction";
            this.cmbFunction.Size = new System.Drawing.Size(160, 33);
            this.cmbFunction.TabIndex = 41;
            // 
            // lbl_request
            // 
            this.lbl_request.AutoSize = true;
            this.lbl_request.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_request.Location = new System.Drawing.Point(26, 277);
            this.lbl_request.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_request.Name = "lbl_request";
            this.lbl_request.Size = new System.Drawing.Size(91, 25);
            this.lbl_request.TabIndex = 40;
            this.lbl_request.Text = "Request";
            // 
            // txtRequest
            // 
            this.txtRequest.BackColor = System.Drawing.Color.LightGray;
            this.txtRequest.Location = new System.Drawing.Point(31, 311);
            this.txtRequest.Margin = new System.Windows.Forms.Padding(4);
            this.txtRequest.Name = "txtRequest";
            this.txtRequest.Size = new System.Drawing.Size(588, 32);
            this.txtRequest.TabIndex = 39;
            // 
            // monthCalendarStart
            // 
            this.monthCalendarStart.Location = new System.Drawing.Point(31, 53);
            this.monthCalendarStart.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.monthCalendarStart.MinDate = new System.DateTime(2025, 3, 12, 0, 0, 0, 0);
            this.monthCalendarStart.Name = "monthCalendarStart";
            this.monthCalendarStart.TabIndex = 37;
            this.monthCalendarStart.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendarStart_DateChanged);
            // 
            // btn_SendReq
            // 
            this.btn_SendReq.ForeColor = System.Drawing.Color.Coral;
            this.btn_SendReq.Location = new System.Drawing.Point(649, 293);
            this.btn_SendReq.Margin = new System.Windows.Forms.Padding(4);
            this.btn_SendReq.Name = "btn_SendReq";
            this.btn_SendReq.Size = new System.Drawing.Size(132, 63);
            this.btn_SendReq.TabIndex = 38;
            this.btn_SendReq.Text = "Send Request";
            this.btn_SendReq.UseVisualStyleBackColor = true;
            this.btn_SendReq.Click += new System.EventHandler(this.btn_SendReq_Click);
            // 
            // tableSidebar_Customer
            // 
            this.tableSidebar_Customer.AutoScroll = true;
            this.tableSidebar_Customer.BackColor = System.Drawing.Color.Firebrick;
            this.tableSidebar_Customer.ColumnCount = 1;
            this.tableSidebar_Customer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableSidebar_Customer.Controls.Add(this.pic_logo, 0, 0);
            this.tableSidebar_Customer.Controls.Add(this.btnLogOut, 0, 8);
            this.tableSidebar_Customer.Controls.Add(this.btnMakeReservation, 0, 5);
            this.tableSidebar_Customer.Controls.Add(this.btnViewReservation, 0, 4);
            this.tableSidebar_Customer.Controls.Add(this.btnFeedback, 0, 7);
            this.tableSidebar_Customer.Controls.Add(this.btnViewReplyRequest, 0, 3);
            this.tableSidebar_Customer.Controls.Add(this.btnViewOrders, 0, 2);
            this.tableSidebar_Customer.Controls.Add(this.btnProfile, 0, 1);
            this.tableSidebar_Customer.Controls.Add(this.btnMakeOrder, 0, 6);
            this.tableSidebar_Customer.Location = new System.Drawing.Point(10, 2);
            this.tableSidebar_Customer.Name = "tableSidebar_Customer";
            this.tableSidebar_Customer.RowCount = 10;
            this.tableSidebar_Customer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableSidebar_Customer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableSidebar_Customer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableSidebar_Customer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableSidebar_Customer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableSidebar_Customer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableSidebar_Customer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableSidebar_Customer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableSidebar_Customer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableSidebar_Customer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableSidebar_Customer.Size = new System.Drawing.Size(228, 450);
            this.tableSidebar_Customer.TabIndex = 50;
            // 
            // pic_logo
            // 
            this.pic_logo.BackColor = System.Drawing.Color.Firebrick;
            this.pic_logo.Image = ((System.Drawing.Image)(resources.GetObject("pic_logo.Image")));
            this.pic_logo.Location = new System.Drawing.Point(3, 3);
            this.pic_logo.Name = "pic_logo";
            this.pic_logo.Size = new System.Drawing.Size(198, 144);
            this.pic_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pic_logo.TabIndex = 12;
            this.pic_logo.TabStop = false;
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.IndianRed;
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.Image = ((System.Drawing.Image)(resources.GetObject("btnLogOut.Image")));
            this.btnLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogOut.Location = new System.Drawing.Point(4, 519);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(199, 37);
            this.btnLogOut.TabIndex = 3;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click_1);
            // 
            // btnMakeReservation
            // 
            this.btnMakeReservation.BackColor = System.Drawing.Color.IndianRed;
            this.btnMakeReservation.FlatAppearance.BorderSize = 0;
            this.btnMakeReservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMakeReservation.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMakeReservation.Image = ((System.Drawing.Image)(resources.GetObject("btnMakeReservation.Image")));
            this.btnMakeReservation.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMakeReservation.Location = new System.Drawing.Point(4, 359);
            this.btnMakeReservation.Margin = new System.Windows.Forms.Padding(4);
            this.btnMakeReservation.Name = "btnMakeReservation";
            this.btnMakeReservation.Size = new System.Drawing.Size(199, 62);
            this.btnMakeReservation.TabIndex = 1;
            this.btnMakeReservation.Text = "Make a Reservation Request";
            this.btnMakeReservation.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnMakeReservation.UseVisualStyleBackColor = false;
            this.btnMakeReservation.Click += new System.EventHandler(this.btnMakeReservation_Click_1);
            // 
            // btnViewReservation
            // 
            this.btnViewReservation.BackColor = System.Drawing.Color.IndianRed;
            this.btnViewReservation.FlatAppearance.BorderSize = 0;
            this.btnViewReservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewReservation.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewReservation.Image = ((System.Drawing.Image)(resources.GetObject("btnViewReservation.Image")));
            this.btnViewReservation.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnViewReservation.Location = new System.Drawing.Point(4, 314);
            this.btnViewReservation.Margin = new System.Windows.Forms.Padding(4);
            this.btnViewReservation.Name = "btnViewReservation";
            this.btnViewReservation.Size = new System.Drawing.Size(199, 37);
            this.btnViewReservation.TabIndex = 5;
            this.btnViewReservation.Text = "View Reservation";
            this.btnViewReservation.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnViewReservation.UseVisualStyleBackColor = false;
            this.btnViewReservation.Click += new System.EventHandler(this.btnViewReservation_Click);
            // 
            // btnFeedback
            // 
            this.btnFeedback.BackColor = System.Drawing.Color.IndianRed;
            this.btnFeedback.FlatAppearance.BorderSize = 0;
            this.btnFeedback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFeedback.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFeedback.Image = ((System.Drawing.Image)(resources.GetObject("btnFeedback.Image")));
            this.btnFeedback.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFeedback.Location = new System.Drawing.Point(4, 474);
            this.btnFeedback.Margin = new System.Windows.Forms.Padding(4);
            this.btnFeedback.Name = "btnFeedback";
            this.btnFeedback.Size = new System.Drawing.Size(199, 37);
            this.btnFeedback.TabIndex = 2;
            this.btnFeedback.Text = "Feedback";
            this.btnFeedback.UseVisualStyleBackColor = false;
            this.btnFeedback.Click += new System.EventHandler(this.btnFeedback_Click_1);
            // 
            // btnViewReplyRequest
            // 
            this.btnViewReplyRequest.BackColor = System.Drawing.Color.IndianRed;
            this.btnViewReplyRequest.FlatAppearance.BorderSize = 0;
            this.btnViewReplyRequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewReplyRequest.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewReplyRequest.Image = ((System.Drawing.Image)(resources.GetObject("btnViewReplyRequest.Image")));
            this.btnViewReplyRequest.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnViewReplyRequest.Location = new System.Drawing.Point(4, 244);
            this.btnViewReplyRequest.Margin = new System.Windows.Forms.Padding(4);
            this.btnViewReplyRequest.Name = "btnViewReplyRequest";
            this.btnViewReplyRequest.Size = new System.Drawing.Size(199, 62);
            this.btnViewReplyRequest.TabIndex = 6;
            this.btnViewReplyRequest.Text = "View Reply Request";
            this.btnViewReplyRequest.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnViewReplyRequest.UseVisualStyleBackColor = false;
            this.btnViewReplyRequest.Click += new System.EventHandler(this.btnViewReplyRequest_Click);
            // 
            // btnViewOrders
            // 
            this.btnViewOrders.BackColor = System.Drawing.Color.IndianRed;
            this.btnViewOrders.FlatAppearance.BorderSize = 0;
            this.btnViewOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewOrders.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewOrders.Image = ((System.Drawing.Image)(resources.GetObject("btnViewOrders.Image")));
            this.btnViewOrders.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnViewOrders.Location = new System.Drawing.Point(4, 199);
            this.btnViewOrders.Margin = new System.Windows.Forms.Padding(4);
            this.btnViewOrders.Name = "btnViewOrders";
            this.btnViewOrders.Size = new System.Drawing.Size(199, 37);
            this.btnViewOrders.TabIndex = 4;
            this.btnViewOrders.Text = "View Orders";
            this.btnViewOrders.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnViewOrders.UseVisualStyleBackColor = false;
            this.btnViewOrders.Click += new System.EventHandler(this.btnViewOrders_Click_1);
            // 
            // btnProfile
            // 
            this.btnProfile.BackColor = System.Drawing.Color.IndianRed;
            this.btnProfile.FlatAppearance.BorderSize = 0;
            this.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfile.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfile.Image = ((System.Drawing.Image)(resources.GetObject("btnProfile.Image")));
            this.btnProfile.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProfile.Location = new System.Drawing.Point(4, 154);
            this.btnProfile.Margin = new System.Windows.Forms.Padding(4);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(199, 37);
            this.btnProfile.TabIndex = 9;
            this.btnProfile.Text = "Profile";
            this.btnProfile.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnProfile.UseVisualStyleBackColor = false;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click_1);
            // 
            // btnMakeOrder
            // 
            this.btnMakeOrder.BackColor = System.Drawing.Color.IndianRed;
            this.btnMakeOrder.FlatAppearance.BorderSize = 0;
            this.btnMakeOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMakeOrder.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMakeOrder.Image = ((System.Drawing.Image)(resources.GetObject("btnMakeOrder.Image")));
            this.btnMakeOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMakeOrder.Location = new System.Drawing.Point(4, 429);
            this.btnMakeOrder.Margin = new System.Windows.Forms.Padding(4);
            this.btnMakeOrder.Name = "btnMakeOrder";
            this.btnMakeOrder.Size = new System.Drawing.Size(199, 37);
            this.btnMakeOrder.TabIndex = 0;
            this.btnMakeOrder.Text = "Make an Order";
            this.btnMakeOrder.UseVisualStyleBackColor = false;
            this.btnMakeOrder.Click += new System.EventHandler(this.btnMakeOrder_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.panel_ReservationRequest);
            this.panel1.Location = new System.Drawing.Point(217, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(876, 450);
            this.panel1.TabIndex = 57;
            // 
            // CustomerMakeAnReservation
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(237)))), ((int)(((byte)(225)))));
            this.ClientSize = new System.Drawing.Size(1082, 453);
            this.Controls.Add(this.tableSidebar_Customer);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "CustomerMakeAnReservation";
            this.Text = "CustomerMakeAnReservation";
            this.Load += new System.EventHandler(this.CustomerMakeAnReservation_Load);
            this.panel_ReservationRequest.ResumeLayout(false);
            this.panel_ReservationRequest.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numHeadCount)).EndInit();
            this.tableSidebar_Customer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel_ReservationRequest;
        private System.Windows.Forms.NumericUpDown numHeadCount;
        private System.Windows.Forms.Label lbl_HeadCount;
        private System.Windows.Forms.Label lblStartReservationDate;
        private System.Windows.Forms.Label lbl_Function;
        private System.Windows.Forms.ComboBox cmbFunction;
        private System.Windows.Forms.Label lbl_request;
        private System.Windows.Forms.TextBox txtRequest;
        private System.Windows.Forms.MonthCalendar monthCalendarStart;
        private System.Windows.Forms.Button btn_SendReq;
        private System.Windows.Forms.MonthCalendar monthCalendarEnd;
        private System.Windows.Forms.Label lblEndReservationDate;
        private System.Windows.Forms.TableLayoutPanel tableSidebar_Customer;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnMakeReservation;
        private System.Windows.Forms.Button btnViewReservation;
        private System.Windows.Forms.Button btnFeedback;
        private System.Windows.Forms.Button btnViewReplyRequest;
        private System.Windows.Forms.Button btnViewOrders;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnMakeOrder;
        private System.Windows.Forms.PictureBox pic_logo;
        private System.Windows.Forms.Panel panel1;
    }
}