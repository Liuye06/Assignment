namespace Assignment
{
    partial class ViewCustomerOrder
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
            this.panel_ViewOrders = new System.Windows.Forms.Panel();
            this.listView_OrderHistory = new System.Windows.Forms.ListView();
            this.OrderID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ItemName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TotalPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbl_Total_O = new System.Windows.Forms.Label();
            this.lbl_OrderID_O = new System.Windows.Forms.Label();
            this.lblViewCusOrder = new System.Windows.Forms.Label();
            this.tableSidebar_Customer = new System.Windows.Forms.TableLayoutPanel();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnMakeReservation = new System.Windows.Forms.Button();
            this.btnViewReservation = new System.Windows.Forms.Button();
            this.btnFeedback = new System.Windows.Forms.Button();
            this.btnViewReplyRequest = new System.Windows.Forms.Button();
            this.btnViewOrders = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnMakeOrder = new System.Windows.Forms.Button();
            this.panel_ViewOrders.SuspendLayout();
            this.tableSidebar_Customer.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_ViewOrders
            // 
            this.panel_ViewOrders.AutoScroll = true;
            this.panel_ViewOrders.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel_ViewOrders.Controls.Add(this.listView_OrderHistory);
            this.panel_ViewOrders.Controls.Add(this.lbl_Total_O);
            this.panel_ViewOrders.Controls.Add(this.lbl_OrderID_O);
            this.panel_ViewOrders.Controls.Add(this.lblViewCusOrder);
            this.panel_ViewOrders.Location = new System.Drawing.Point(219, 76);
            this.panel_ViewOrders.Margin = new System.Windows.Forms.Padding(4);
            this.panel_ViewOrders.Name = "panel_ViewOrders";
            this.panel_ViewOrders.Size = new System.Drawing.Size(850, 360);
            this.panel_ViewOrders.TabIndex = 45;
            // 
            // listView_OrderHistory
            // 
            this.listView_OrderHistory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.OrderID,
            this.ItemName,
            this.Status,
            this.TotalPrice});
            this.listView_OrderHistory.FullRowSelect = true;
            this.listView_OrderHistory.GridLines = true;
            this.listView_OrderHistory.HideSelection = false;
            this.listView_OrderHistory.Location = new System.Drawing.Point(38, 58);
            this.listView_OrderHistory.Name = "listView_OrderHistory";
            this.listView_OrderHistory.Size = new System.Drawing.Size(765, 270);
            this.listView_OrderHistory.TabIndex = 23;
            this.listView_OrderHistory.UseCompatibleStateImageBehavior = false;
            this.listView_OrderHistory.View = System.Windows.Forms.View.Details;
            // 
            // OrderID
            // 
            this.OrderID.Text = "Order ID";
            this.OrderID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.OrderID.Width = 80;
            // 
            // ItemName
            // 
            this.ItemName.Text = "Food Name";
            this.ItemName.Width = 150;
            // 
            // Status
            // 
            this.Status.Text = "Status";
            this.Status.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Status.Width = 100;
            // 
            // TotalPrice
            // 
            this.TotalPrice.Text = "Total Price (RM)";
            this.TotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TotalPrice.Width = 150;
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
            // lblViewCusOrder
            // 
            this.lblViewCusOrder.AutoSize = true;
            this.lblViewCusOrder.Location = new System.Drawing.Point(33, 18);
            this.lblViewCusOrder.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblViewCusOrder.Name = "lblViewCusOrder";
            this.lblViewCusOrder.Size = new System.Drawing.Size(272, 25);
            this.lblViewCusOrder.TabIndex = 19;
            this.lblViewCusOrder.Text = "Your Order History and Status";
            // 
            // tableSidebar_Customer
            // 
            this.tableSidebar_Customer.ColumnCount = 1;
            this.tableSidebar_Customer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableSidebar_Customer.Controls.Add(this.btnLogOut, 0, 8);
            this.tableSidebar_Customer.Controls.Add(this.btnMakeReservation, 0, 5);
            this.tableSidebar_Customer.Controls.Add(this.btnViewReservation, 0, 4);
            this.tableSidebar_Customer.Controls.Add(this.btnFeedback, 0, 7);
            this.tableSidebar_Customer.Controls.Add(this.btnViewReplyRequest, 0, 3);
            this.tableSidebar_Customer.Controls.Add(this.btnViewOrders, 0, 2);
            this.tableSidebar_Customer.Controls.Add(this.btnProfile, 0, 1);
            this.tableSidebar_Customer.Controls.Add(this.btnMakeOrder, 0, 6);
            this.tableSidebar_Customer.Location = new System.Drawing.Point(12, 12);
            this.tableSidebar_Customer.Name = "tableSidebar_Customer";
            this.tableSidebar_Customer.RowCount = 10;
            this.tableSidebar_Customer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableSidebar_Customer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableSidebar_Customer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableSidebar_Customer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableSidebar_Customer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableSidebar_Customer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableSidebar_Customer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableSidebar_Customer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableSidebar_Customer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableSidebar_Customer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableSidebar_Customer.Size = new System.Drawing.Size(200, 424);
            this.tableSidebar_Customer.TabIndex = 24;
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
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click_1);
            // 
            // btnMakeReservation
            // 
            this.btnMakeReservation.Location = new System.Drawing.Point(4, 224);
            this.btnMakeReservation.Margin = new System.Windows.Forms.Padding(4);
            this.btnMakeReservation.Name = "btnMakeReservation";
            this.btnMakeReservation.Size = new System.Drawing.Size(192, 62);
            this.btnMakeReservation.TabIndex = 1;
            this.btnMakeReservation.Text = "Make a Reservation Request";
            this.btnMakeReservation.UseVisualStyleBackColor = true;
            this.btnMakeReservation.Click += new System.EventHandler(this.btnMakeReservation_Click_1);
            // 
            // btnViewReservation
            // 
            this.btnViewReservation.Location = new System.Drawing.Point(4, 184);
            this.btnViewReservation.Margin = new System.Windows.Forms.Padding(4);
            this.btnViewReservation.Name = "btnViewReservation";
            this.btnViewReservation.Size = new System.Drawing.Size(192, 32);
            this.btnViewReservation.TabIndex = 5;
            this.btnViewReservation.Text = "View Reservation";
            this.btnViewReservation.UseVisualStyleBackColor = true;
            this.btnViewReservation.Click += new System.EventHandler(this.btnViewReservation_Click);
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
            this.btnFeedback.Click += new System.EventHandler(this.btnFeedback_Click_1);
            // 
            // btnViewReplyRequest
            // 
            this.btnViewReplyRequest.Location = new System.Drawing.Point(4, 144);
            this.btnViewReplyRequest.Margin = new System.Windows.Forms.Padding(4);
            this.btnViewReplyRequest.Name = "btnViewReplyRequest";
            this.btnViewReplyRequest.Size = new System.Drawing.Size(192, 32);
            this.btnViewReplyRequest.TabIndex = 6;
            this.btnViewReplyRequest.Text = "View Reply Request";
            this.btnViewReplyRequest.UseVisualStyleBackColor = true;
            this.btnViewReplyRequest.Click += new System.EventHandler(this.btnViewReplyRequest_Click);
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
            this.btnViewOrders.Click += new System.EventHandler(this.btnViewOrders_Click_1);
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
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click_1);
            // 
            // btnMakeOrder
            // 
            this.btnMakeOrder.Location = new System.Drawing.Point(4, 294);
            this.btnMakeOrder.Margin = new System.Windows.Forms.Padding(4);
            this.btnMakeOrder.Name = "btnMakeOrder";
            this.btnMakeOrder.Size = new System.Drawing.Size(192, 32);
            this.btnMakeOrder.TabIndex = 0;
            this.btnMakeOrder.Text = "Make an Order";
            this.btnMakeOrder.UseVisualStyleBackColor = true;
            this.btnMakeOrder.Click += new System.EventHandler(this.btnMakeOrder_Click_1);
            // 
            // ViewCustomerOrder
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1082, 453);
            this.Controls.Add(this.tableSidebar_Customer);
            this.Controls.Add(this.panel_ViewOrders);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ViewCustomerOrder";
            this.Text = "ViewCustomerOrder";
            this.panel_ViewOrders.ResumeLayout(false);
            this.panel_ViewOrders.PerformLayout();
            this.tableSidebar_Customer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_ViewOrders;
        private System.Windows.Forms.Label lbl_Total_O;
        private System.Windows.Forms.Label lbl_OrderID_O;
        private System.Windows.Forms.Label lblViewCusOrder;
        private System.Windows.Forms.ListView listView_OrderHistory;
        private System.Windows.Forms.ColumnHeader OrderID;
        private System.Windows.Forms.ColumnHeader ItemName;
        private System.Windows.Forms.ColumnHeader Status;
        private System.Windows.Forms.ColumnHeader TotalPrice;
        private System.Windows.Forms.TableLayoutPanel tableSidebar_Customer;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnMakeReservation;
        private System.Windows.Forms.Button btnViewReservation;
        private System.Windows.Forms.Button btnFeedback;
        private System.Windows.Forms.Button btnViewReplyRequest;
        private System.Windows.Forms.Button btnViewOrders;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnMakeOrder;
    }
}