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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel_ViewOrders = new System.Windows.Forms.Panel();
            this.listB_Items = new System.Windows.Forms.ListBox();
            this.btn_SearchOrder = new System.Windows.Forms.Button();
            this.lbl_SearchOrder = new System.Windows.Forms.Label();
            this.txt_SearchOrder = new System.Windows.Forms.TextBox();
            this.lbl_Total_O = new System.Windows.Forms.Label();
            this.lbl_OrderID_O = new System.Windows.Forms.Label();
            this.lbl_Items = new System.Windows.Forms.Label();
            this.dataGV_ViewOrder = new System.Windows.Forms.DataGridView();
            this.tableSidebar_CustomerProfile = new System.Windows.Forms.TableLayoutPanel();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnFeedback = new System.Windows.Forms.Button();
            this.btnMakePayment = new System.Windows.Forms.Button();
            this.btnMakeReservation = new System.Windows.Forms.Button();
            this.btnMakeOrder = new System.Windows.Forms.Button();
            this.btnViewReservations = new System.Windows.Forms.Button();
            this.btnViewOrders = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.ColOrderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPaymentStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColShowMenu = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel_ViewOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_ViewOrder)).BeginInit();
            this.tableSidebar_CustomerProfile.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_ViewOrders
            // 
            this.panel_ViewOrders.AutoScroll = true;
            this.panel_ViewOrders.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel_ViewOrders.Controls.Add(this.listB_Items);
            this.panel_ViewOrders.Controls.Add(this.btn_SearchOrder);
            this.panel_ViewOrders.Controls.Add(this.dataGV_ViewOrder);
            this.panel_ViewOrders.Controls.Add(this.lbl_SearchOrder);
            this.panel_ViewOrders.Controls.Add(this.txt_SearchOrder);
            this.panel_ViewOrders.Controls.Add(this.lbl_Total_O);
            this.panel_ViewOrders.Controls.Add(this.lbl_OrderID_O);
            this.panel_ViewOrders.Controls.Add(this.lbl_Items);
            this.panel_ViewOrders.Location = new System.Drawing.Point(219, 76);
            this.panel_ViewOrders.Margin = new System.Windows.Forms.Padding(4);
            this.panel_ViewOrders.Name = "panel_ViewOrders";
            this.panel_ViewOrders.Size = new System.Drawing.Size(850, 360);
            this.panel_ViewOrders.TabIndex = 45;
            // 
            // listB_Items
            // 
            this.listB_Items.FormattingEnabled = true;
            this.listB_Items.ItemHeight = 25;
            this.listB_Items.Location = new System.Drawing.Point(619, 128);
            this.listB_Items.Margin = new System.Windows.Forms.Padding(4);
            this.listB_Items.Name = "listB_Items";
            this.listB_Items.Size = new System.Drawing.Size(203, 179);
            this.listB_Items.TabIndex = 20;
            // 
            // btn_SearchOrder
            // 
            this.btn_SearchOrder.Location = new System.Drawing.Point(546, 22);
            this.btn_SearchOrder.Margin = new System.Windows.Forms.Padding(4);
            this.btn_SearchOrder.Name = "btn_SearchOrder";
            this.btn_SearchOrder.Size = new System.Drawing.Size(276, 35);
            this.btn_SearchOrder.TabIndex = 26;
            this.btn_SearchOrder.Text = "Search";
            this.btn_SearchOrder.UseVisualStyleBackColor = true;
            // 
            // lbl_SearchOrder
            // 
            this.lbl_SearchOrder.AutoSize = true;
            this.lbl_SearchOrder.Location = new System.Drawing.Point(27, 25);
            this.lbl_SearchOrder.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_SearchOrder.Name = "lbl_SearchOrder";
            this.lbl_SearchOrder.Size = new System.Drawing.Size(130, 25);
            this.lbl_SearchOrder.TabIndex = 25;
            this.lbl_SearchOrder.Text = "Search Order";
            // 
            // txt_SearchOrder
            // 
            this.txt_SearchOrder.Location = new System.Drawing.Point(263, 24);
            this.txt_SearchOrder.Margin = new System.Windows.Forms.Padding(4);
            this.txt_SearchOrder.Name = "txt_SearchOrder";
            this.txt_SearchOrder.Size = new System.Drawing.Size(256, 30);
            this.txt_SearchOrder.TabIndex = 24;
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
            // lbl_Items
            // 
            this.lbl_Items.AutoSize = true;
            this.lbl_Items.Location = new System.Drawing.Point(614, 80);
            this.lbl_Items.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Items.Name = "lbl_Items";
            this.lbl_Items.Size = new System.Drawing.Size(65, 25);
            this.lbl_Items.TabIndex = 19;
            this.lbl_Items.Text = "Items:";
            // 
            // dataGV_ViewOrder
            // 
            this.dataGV_ViewOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGV_ViewOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColOrderID,
            this.ColTotal,
            this.ColPaymentStatus,
            this.ColShowMenu});
            this.dataGV_ViewOrder.Location = new System.Drawing.Point(32, 128);
            this.dataGV_ViewOrder.Margin = new System.Windows.Forms.Padding(4);
            this.dataGV_ViewOrder.Name = "dataGV_ViewOrder";
            this.dataGV_ViewOrder.RowHeadersWidth = 51;
            this.dataGV_ViewOrder.Size = new System.Drawing.Size(579, 179);
            this.dataGV_ViewOrder.TabIndex = 15;
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
            this.tableSidebar_CustomerProfile.TabIndex = 29;
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
            // 
            // ColOrderID
            // 
            this.ColOrderID.DataPropertyName = "OrderID";
            this.ColOrderID.HeaderText = "Order ID";
            this.ColOrderID.MinimumWidth = 6;
            this.ColOrderID.Name = "ColOrderID";
            this.ColOrderID.Width = 120;
            // 
            // ColTotal
            // 
            this.ColTotal.HeaderText = "Total";
            this.ColTotal.MinimumWidth = 6;
            this.ColTotal.Name = "ColTotal";
            // 
            // ColPaymentStatus
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.ColPaymentStatus.DefaultCellStyle = dataGridViewCellStyle2;
            this.ColPaymentStatus.HeaderText = "Payment Status";
            this.ColPaymentStatus.MinimumWidth = 6;
            this.ColPaymentStatus.Name = "ColPaymentStatus";
            this.ColPaymentStatus.Width = 180;
            // 
            // ColShowMenu
            // 
            this.ColShowMenu.DataPropertyName = "Show";
            this.ColShowMenu.HeaderText = "Action";
            this.ColShowMenu.MinimumWidth = 6;
            this.ColShowMenu.Name = "ColShowMenu";
            this.ColShowMenu.Text = "Show";
            this.ColShowMenu.UseColumnTextForButtonValue = true;
            this.ColShowMenu.Width = 125;
            // 
            // ViewCustomerOrder
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1082, 453);
            this.Controls.Add(this.tableSidebar_CustomerProfile);
            this.Controls.Add(this.panel_ViewOrders);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ViewCustomerOrder";
            this.Text = "ViewCustomerOrder";
            this.panel_ViewOrders.ResumeLayout(false);
            this.panel_ViewOrders.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_ViewOrder)).EndInit();
            this.tableSidebar_CustomerProfile.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_ViewOrders;
        private System.Windows.Forms.Button btn_SearchOrder;
        private System.Windows.Forms.Label lbl_SearchOrder;
        private System.Windows.Forms.TextBox txt_SearchOrder;
        private System.Windows.Forms.Label lbl_Total_O;
        private System.Windows.Forms.Label lbl_OrderID_O;
        private System.Windows.Forms.ListBox listB_Items;
        private System.Windows.Forms.Label lbl_Items;
        private System.Windows.Forms.DataGridView dataGV_ViewOrder;
        private System.Windows.Forms.TableLayoutPanel tableSidebar_CustomerProfile;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnFeedback;
        private System.Windows.Forms.Button btnMakePayment;
        private System.Windows.Forms.Button btnMakeReservation;
        private System.Windows.Forms.Button btnMakeOrder;
        private System.Windows.Forms.Button btnViewReservations;
        private System.Windows.Forms.Button btnViewOrders;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColOrderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPaymentStatus;
        private System.Windows.Forms.DataGridViewButtonColumn ColShowMenu;
    }
}