namespace Assignment
{
    partial class CustomerMakeAnReservation
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
            this.tableSidebar_CustomerProfile = new System.Windows.Forms.TableLayoutPanel();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnFeedback = new System.Windows.Forms.Button();
            this.btnMakePayment = new System.Windows.Forms.Button();
            this.btnMakeReservationRequest = new System.Windows.Forms.Button();
            this.btnMakeOrder = new System.Windows.Forms.Button();
            this.btnViewReservations = new System.Windows.Forms.Button();
            this.btnViewOrders = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.panel_ReservationRequest = new System.Windows.Forms.Panel();
            this.monthCalendarEnd = new System.Windows.Forms.MonthCalendar();
            this.lblEndReservationDate = new System.Windows.Forms.Label();
            this.numHeadCount = new System.Windows.Forms.NumericUpDown();
            this.lbl_HeadCount = new System.Windows.Forms.Label();
            this.lblStartReservationDate = new System.Windows.Forms.Label();
            this.lbl_Function = new System.Windows.Forms.Label();
            this.cmbFunction = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtRequest = new System.Windows.Forms.TextBox();
            this.monthCalendarStart = new System.Windows.Forms.MonthCalendar();
            this.btn_SendReq = new System.Windows.Forms.Button();
            this.tableSidebar_CustomerProfile.SuspendLayout();
            this.panel_ReservationRequest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numHeadCount)).BeginInit();
            this.SuspendLayout();
            // 
            // tableSidebar_CustomerProfile
            // 
            this.tableSidebar_CustomerProfile.ColumnCount = 1;
            this.tableSidebar_CustomerProfile.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableSidebar_CustomerProfile.Controls.Add(this.btnLogOut, 0, 8);
            this.tableSidebar_CustomerProfile.Controls.Add(this.btnFeedback, 0, 7);
            this.tableSidebar_CustomerProfile.Controls.Add(this.btnMakePayment, 0, 6);
            this.tableSidebar_CustomerProfile.Controls.Add(this.btnMakeReservationRequest, 0, 5);
            this.tableSidebar_CustomerProfile.Controls.Add(this.btnMakeOrder, 0, 4);
            this.tableSidebar_CustomerProfile.Controls.Add(this.btnViewReservations, 0, 3);
            this.tableSidebar_CustomerProfile.Controls.Add(this.btnViewOrders, 0, 2);
            this.tableSidebar_CustomerProfile.Controls.Add(this.btnProfile, 0, 1);
            this.tableSidebar_CustomerProfile.Location = new System.Drawing.Point(12, 12);
            this.tableSidebar_CustomerProfile.Name = "tableSidebar_CustomerProfile";
            this.tableSidebar_CustomerProfile.RowCount = 10;
            this.tableSidebar_CustomerProfile.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableSidebar_CustomerProfile.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableSidebar_CustomerProfile.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableSidebar_CustomerProfile.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableSidebar_CustomerProfile.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableSidebar_CustomerProfile.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableSidebar_CustomerProfile.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableSidebar_CustomerProfile.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableSidebar_CustomerProfile.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableSidebar_CustomerProfile.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableSidebar_CustomerProfile.Size = new System.Drawing.Size(200, 424);
            this.tableSidebar_CustomerProfile.TabIndex = 31;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(4, 374);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(192, 32);
            this.btnLogOut.TabIndex = 3;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnFeedback
            // 
            this.btnFeedback.Location = new System.Drawing.Point(4, 334);
            this.btnFeedback.Margin = new System.Windows.Forms.Padding(4);
            this.btnFeedback.Name = "btnFeedback";
            this.btnFeedback.Size = new System.Drawing.Size(192, 32);
            this.btnFeedback.TabIndex = 2;
            this.btnFeedback.Text = "Feedback";
            this.btnFeedback.UseVisualStyleBackColor = true;
            this.btnFeedback.Click += new System.EventHandler(this.btnFeedback_Click);
            // 
            // btnMakePayment
            // 
            this.btnMakePayment.Location = new System.Drawing.Point(4, 294);
            this.btnMakePayment.Margin = new System.Windows.Forms.Padding(4);
            this.btnMakePayment.Name = "btnMakePayment";
            this.btnMakePayment.Size = new System.Drawing.Size(192, 32);
            this.btnMakePayment.TabIndex = 5;
            this.btnMakePayment.Text = "Make Payment";
            this.btnMakePayment.UseVisualStyleBackColor = true;
            this.btnMakePayment.Click += new System.EventHandler(this.btnMakePayment_Click);
            // 
            // btnMakeReservationRequest
            // 
            this.btnMakeReservationRequest.Location = new System.Drawing.Point(4, 224);
            this.btnMakeReservationRequest.Margin = new System.Windows.Forms.Padding(4);
            this.btnMakeReservationRequest.Name = "btnMakeReservationRequest";
            this.btnMakeReservationRequest.Size = new System.Drawing.Size(192, 62);
            this.btnMakeReservationRequest.TabIndex = 1;
            this.btnMakeReservationRequest.Text = "Make a Reservation";
            this.btnMakeReservationRequest.UseVisualStyleBackColor = true;
            this.btnMakeReservationRequest.Click += new System.EventHandler(this.btnMakeReservation_Click);
            // 
            // btnMakeOrder
            // 
            this.btnMakeOrder.Location = new System.Drawing.Point(4, 184);
            this.btnMakeOrder.Margin = new System.Windows.Forms.Padding(4);
            this.btnMakeOrder.Name = "btnMakeOrder";
            this.btnMakeOrder.Size = new System.Drawing.Size(192, 32);
            this.btnMakeOrder.TabIndex = 0;
            this.btnMakeOrder.Text = "Make an Order";
            this.btnMakeOrder.UseVisualStyleBackColor = true;
            this.btnMakeOrder.Click += new System.EventHandler(this.btnMakeOrder_Click);
            // 
            // btnViewReservations
            // 
            this.btnViewReservations.Location = new System.Drawing.Point(4, 144);
            this.btnViewReservations.Margin = new System.Windows.Forms.Padding(4);
            this.btnViewReservations.Name = "btnViewReservations";
            this.btnViewReservations.Size = new System.Drawing.Size(192, 32);
            this.btnViewReservations.TabIndex = 6;
            this.btnViewReservations.Text = "View Reservations";
            this.btnViewReservations.UseVisualStyleBackColor = true;
            this.btnViewReservations.Click += new System.EventHandler(this.btnViewReservations_Click);
            // 
            // btnViewOrders
            // 
            this.btnViewOrders.FlatAppearance.BorderSize = 0;
            this.btnViewOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewOrders.Location = new System.Drawing.Point(4, 104);
            this.btnViewOrders.Margin = new System.Windows.Forms.Padding(4);
            this.btnViewOrders.Name = "btnViewOrders";
            this.btnViewOrders.Size = new System.Drawing.Size(192, 32);
            this.btnViewOrders.TabIndex = 4;
            this.btnViewOrders.Text = "View Orders";
            this.btnViewOrders.UseVisualStyleBackColor = true;
            this.btnViewOrders.Click += new System.EventHandler(this.btnViewOrders_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.FlatAppearance.BorderSize = 0;
            this.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfile.Location = new System.Drawing.Point(4, 64);
            this.btnProfile.Margin = new System.Windows.Forms.Padding(4);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(192, 32);
            this.btnProfile.TabIndex = 9;
            this.btnProfile.Text = "Profile";
            this.btnProfile.UseVisualStyleBackColor = true;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // panel_ReservationRequest
            // 
            this.panel_ReservationRequest.AutoScroll = true;
            this.panel_ReservationRequest.BackColor = System.Drawing.Color.MistyRose;
            this.panel_ReservationRequest.Controls.Add(this.monthCalendarEnd);
            this.panel_ReservationRequest.Controls.Add(this.lblEndReservationDate);
            this.panel_ReservationRequest.Controls.Add(this.numHeadCount);
            this.panel_ReservationRequest.Controls.Add(this.lbl_HeadCount);
            this.panel_ReservationRequest.Controls.Add(this.lblStartReservationDate);
            this.panel_ReservationRequest.Controls.Add(this.lbl_Function);
            this.panel_ReservationRequest.Controls.Add(this.cmbFunction);
            this.panel_ReservationRequest.Controls.Add(this.label11);
            this.panel_ReservationRequest.Controls.Add(this.txtRequest);
            this.panel_ReservationRequest.Controls.Add(this.monthCalendarStart);
            this.panel_ReservationRequest.Controls.Add(this.btn_SendReq);
            this.panel_ReservationRequest.Location = new System.Drawing.Point(219, 76);
            this.panel_ReservationRequest.Margin = new System.Windows.Forms.Padding(4);
            this.panel_ReservationRequest.Name = "panel_ReservationRequest";
            this.panel_ReservationRequest.Size = new System.Drawing.Size(850, 360);
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
            this.lblEndReservationDate.Location = new System.Drawing.Point(317, 17);
            this.lblEndReservationDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEndReservationDate.Name = "lblEndReservationDate";
            this.lblEndReservationDate.Size = new System.Drawing.Size(201, 25);
            this.lblEndReservationDate.TabIndex = 48;
            this.lblEndReservationDate.Text = "End Reservation Date";
            // 
            // numHeadCount
            // 
            this.numHeadCount.Location = new System.Drawing.Point(621, 160);
            this.numHeadCount.Margin = new System.Windows.Forms.Padding(4);
            this.numHeadCount.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numHeadCount.Name = "numHeadCount";
            this.numHeadCount.Size = new System.Drawing.Size(160, 30);
            this.numHeadCount.TabIndex = 45;
            // 
            // lbl_HeadCount
            // 
            this.lbl_HeadCount.AutoSize = true;
            this.lbl_HeadCount.Location = new System.Drawing.Point(616, 126);
            this.lbl_HeadCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_HeadCount.Name = "lbl_HeadCount";
            this.lbl_HeadCount.Size = new System.Drawing.Size(117, 25);
            this.lbl_HeadCount.TabIndex = 44;
            this.lbl_HeadCount.Text = "Head Count";
            // 
            // lblStartReservationDate
            // 
            this.lblStartReservationDate.AutoSize = true;
            this.lblStartReservationDate.Location = new System.Drawing.Point(26, 17);
            this.lblStartReservationDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStartReservationDate.Name = "lblStartReservationDate";
            this.lblStartReservationDate.Size = new System.Drawing.Size(207, 25);
            this.lblStartReservationDate.TabIndex = 43;
            this.lblStartReservationDate.Text = "Start Reservation Date";
            // 
            // lbl_Function
            // 
            this.lbl_Function.AutoSize = true;
            this.lbl_Function.Location = new System.Drawing.Point(616, 28);
            this.lbl_Function.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Function.Name = "lbl_Function";
            this.lbl_Function.Size = new System.Drawing.Size(87, 25);
            this.lbl_Function.TabIndex = 42;
            this.lbl_Function.Text = "Function";
            // 
            // cmbFunction
            // 
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
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(26, 277);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 25);
            this.label11.TabIndex = 40;
            this.label11.Text = "Request";
            // 
            // txtRequest
            // 
            this.txtRequest.Location = new System.Drawing.Point(31, 311);
            this.txtRequest.Margin = new System.Windows.Forms.Padding(4);
            this.txtRequest.Name = "txtRequest";
            this.txtRequest.Size = new System.Drawing.Size(588, 30);
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
            this.btn_SendReq.Location = new System.Drawing.Point(663, 279);
            this.btn_SendReq.Margin = new System.Windows.Forms.Padding(4);
            this.btn_SendReq.Name = "btn_SendReq";
            this.btn_SendReq.Size = new System.Drawing.Size(132, 63);
            this.btn_SendReq.TabIndex = 38;
            this.btn_SendReq.Text = "Send Request";
            this.btn_SendReq.UseVisualStyleBackColor = true;
            this.btn_SendReq.Click += new System.EventHandler(this.btn_SendReq_Click);
            // 
            // CustomerMakeAnReservation
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1082, 453);
            this.Controls.Add(this.panel_ReservationRequest);
            this.Controls.Add(this.tableSidebar_CustomerProfile);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "CustomerMakeAnReservation";
            this.Text = "CustomerMakeAnReservation";
            this.Load += new System.EventHandler(this.CustomerMakeAnReservation_Load);
            this.tableSidebar_CustomerProfile.ResumeLayout(false);
            this.panel_ReservationRequest.ResumeLayout(false);
            this.panel_ReservationRequest.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numHeadCount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableSidebar_CustomerProfile;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnFeedback;
        private System.Windows.Forms.Button btnMakePayment;
        private System.Windows.Forms.Button btnMakeReservationRequest;
        private System.Windows.Forms.Button btnMakeOrder;
        private System.Windows.Forms.Button btnViewReservations;
        private System.Windows.Forms.Button btnViewOrders;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Panel panel_ReservationRequest;
        private System.Windows.Forms.NumericUpDown numHeadCount;
        private System.Windows.Forms.Label lbl_HeadCount;
        private System.Windows.Forms.Label lblStartReservationDate;
        private System.Windows.Forms.Label lbl_Function;
        private System.Windows.Forms.ComboBox cmbFunction;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtRequest;
        private System.Windows.Forms.MonthCalendar monthCalendarStart;
        private System.Windows.Forms.Button btn_SendReq;
        private System.Windows.Forms.MonthCalendar monthCalendarEnd;
        private System.Windows.Forms.Label lblEndReservationDate;
    }
}