namespace Assignment
{
    partial class ViewCustomerReservation
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
            this.btnMakeReservation = new System.Windows.Forms.Button();
            this.btnMakeOrder = new System.Windows.Forms.Button();
            this.btnViewReservations = new System.Windows.Forms.Button();
            this.btnViewOrders = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.panel_ViewReservation = new System.Windows.Forms.Panel();
            this.btnMakeResvPayment = new System.Windows.Forms.Button();
            this.listView_ReservationRequest = new System.Windows.Forms.ListView();
            this.lbl_Total_O = new System.Windows.Forms.Label();
            this.lbl_OrderID_O = new System.Windows.Forms.Label();
            this.lblViewRevRequest = new System.Windows.Forms.Label();
            this.tableSidebar_CustomerProfile.SuspendLayout();
            this.panel_ViewReservation.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableSidebar_CustomerProfile
            // 
            this.tableSidebar_CustomerProfile.ColumnCount = 1;
            this.tableSidebar_CustomerProfile.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableSidebar_CustomerProfile.Controls.Add(this.btnLogOut, 0, 8);
            this.tableSidebar_CustomerProfile.Controls.Add(this.btnFeedback, 0, 7);
            this.tableSidebar_CustomerProfile.Controls.Add(this.btnMakePayment, 0, 6);
            this.tableSidebar_CustomerProfile.Controls.Add(this.btnMakeReservation, 0, 5);
            this.tableSidebar_CustomerProfile.Controls.Add(this.btnMakeOrder, 0, 4);
            this.tableSidebar_CustomerProfile.Controls.Add(this.btnViewReservations, 0, 3);
            this.tableSidebar_CustomerProfile.Controls.Add(this.btnViewOrders, 0, 2);
            this.tableSidebar_CustomerProfile.Controls.Add(this.btnProfile, 0, 1);
            this.tableSidebar_CustomerProfile.Location = new System.Drawing.Point(12, 17);
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
            this.tableSidebar_CustomerProfile.TabIndex = 30;
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
            // btnMakeReservation
            // 
            this.btnMakeReservation.Location = new System.Drawing.Point(4, 224);
            this.btnMakeReservation.Margin = new System.Windows.Forms.Padding(4);
            this.btnMakeReservation.Name = "btnMakeReservation";
            this.btnMakeReservation.Size = new System.Drawing.Size(192, 62);
            this.btnMakeReservation.TabIndex = 1;
            this.btnMakeReservation.Text = "Make a Reservation";
            this.btnMakeReservation.UseVisualStyleBackColor = true;
            this.btnMakeReservation.Click += new System.EventHandler(this.btnMakeReservation_Click);
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
            // panel_ViewReservation
            // 
            this.panel_ViewReservation.AutoScroll = true;
            this.panel_ViewReservation.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel_ViewReservation.Controls.Add(this.btnMakeResvPayment);
            this.panel_ViewReservation.Controls.Add(this.listView_ReservationRequest);
            this.panel_ViewReservation.Controls.Add(this.lbl_Total_O);
            this.panel_ViewReservation.Controls.Add(this.lbl_OrderID_O);
            this.panel_ViewReservation.Controls.Add(this.lblViewRevRequest);
            this.panel_ViewReservation.Location = new System.Drawing.Point(219, 80);
            this.panel_ViewReservation.Margin = new System.Windows.Forms.Padding(4);
            this.panel_ViewReservation.Name = "panel_ViewReservation";
            this.panel_ViewReservation.Size = new System.Drawing.Size(850, 360);
            this.panel_ViewReservation.TabIndex = 46;
            // 
            // btnMakeResvPayment
            // 
            this.btnMakeResvPayment.Location = new System.Drawing.Point(38, 311);
            this.btnMakeResvPayment.Name = "btnMakeResvPayment";
            this.btnMakeResvPayment.Size = new System.Drawing.Size(332, 32);
            this.btnMakeResvPayment.TabIndex = 24;
            this.btnMakeResvPayment.Text = "Make Payment";
            this.btnMakeResvPayment.UseVisualStyleBackColor = true;
            this.btnMakeResvPayment.Click += new System.EventHandler(this.btnMakeResvPayment_Click);
            // 
            // listView_ReservationRequest
            // 
            this.listView_ReservationRequest.FullRowSelect = true;
            this.listView_ReservationRequest.GridLines = true;
            this.listView_ReservationRequest.HideSelection = false;
            this.listView_ReservationRequest.Location = new System.Drawing.Point(38, 58);
            this.listView_ReservationRequest.Name = "listView_ReservationRequest";
            this.listView_ReservationRequest.Size = new System.Drawing.Size(765, 235);
            this.listView_ReservationRequest.TabIndex = 23;
            this.listView_ReservationRequest.UseCompatibleStateImageBehavior = false;
            this.listView_ReservationRequest.View = System.Windows.Forms.View.Details;
            this.listView_ReservationRequest.SelectedIndexChanged += new System.EventHandler(this.listView_ReservationRequest_SelectedIndexChanged);
            // 
            // lbl_Total_O
            // 
            this.lbl_Total_O.AutoSize = true;
            this.lbl_Total_O.Location = new System.Drawing.Point(299, 130);
            this.lbl_Total_O.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Total_O.Name = "lbl_Total_O";
            this.lbl_Total_O.Size = new System.Drawing.Size(0, 25);
            this.lbl_Total_O.TabIndex = 22;
            // 
            // lbl_OrderID_O
            // 
            this.lbl_OrderID_O.AutoSize = true;
            this.lbl_OrderID_O.Location = new System.Drawing.Point(299, 99);
            this.lbl_OrderID_O.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_OrderID_O.Name = "lbl_OrderID_O";
            this.lbl_OrderID_O.Size = new System.Drawing.Size(0, 25);
            this.lbl_OrderID_O.TabIndex = 21;
            // 
            // lblViewRevRequest
            // 
            this.lblViewRevRequest.AutoSize = true;
            this.lblViewRevRequest.Location = new System.Drawing.Point(33, 18);
            this.lblViewRevRequest.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblViewRevRequest.Name = "lblViewRevRequest";
            this.lblViewRevRequest.Size = new System.Drawing.Size(337, 25);
            this.lblViewRevRequest.TabIndex = 19;
            this.lblViewRevRequest.Text = "Your Reservation Request and Status";
            this.lblViewRevRequest.Click += new System.EventHandler(this.lblViewRevRequest_Click);
            // 
            // ViewCustomerReservation
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1082, 453);
            this.Controls.Add(this.panel_ViewReservation);
            this.Controls.Add(this.tableSidebar_CustomerProfile);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ViewCustomerReservation";
            this.Text = "ViewCustomerReservation";
            this.tableSidebar_CustomerProfile.ResumeLayout(false);
            this.panel_ViewReservation.ResumeLayout(false);
            this.panel_ViewReservation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableSidebar_CustomerProfile;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnFeedback;
        private System.Windows.Forms.Button btnMakePayment;
        private System.Windows.Forms.Button btnMakeReservation;
        private System.Windows.Forms.Button btnMakeOrder;
        private System.Windows.Forms.Button btnViewReservations;
        private System.Windows.Forms.Button btnViewOrders;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Panel panel_ViewReservation;
        private System.Windows.Forms.ListView listView_ReservationRequest;
        private System.Windows.Forms.Label lbl_Total_O;
        private System.Windows.Forms.Label lbl_OrderID_O;
        private System.Windows.Forms.Label lblViewRevRequest;
        private System.Windows.Forms.Button btnMakeResvPayment;
    }
}