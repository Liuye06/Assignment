namespace Assignment
{
    partial class CustomerMenu
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
            this.flowPanelMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.btnResetCMenu = new System.Windows.Forms.Button();
            this.gbCMenu = new System.Windows.Forms.GroupBox();
            this.tableSidebar_Customer = new System.Windows.Forms.TableLayoutPanel();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnMakeReservation = new System.Windows.Forms.Button();
            this.btnViewReservation = new System.Windows.Forms.Button();
            this.btnFeedback = new System.Windows.Forms.Button();
            this.btnViewReplyRequest = new System.Windows.Forms.Button();
            this.btnViewOrders = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnMakeOrder = new System.Windows.Forms.Button();
            this.gbCMenu.SuspendLayout();
            this.tableSidebar_Customer.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowPanelMenu
            // 
            this.flowPanelMenu.AutoScroll = true;
            this.flowPanelMenu.Location = new System.Drawing.Point(45, 68);
            this.flowPanelMenu.Name = "flowPanelMenu";
            this.flowPanelMenu.Size = new System.Drawing.Size(791, 236);
            this.flowPanelMenu.TabIndex = 148;
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Location = new System.Drawing.Point(45, 310);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(390, 34);
            this.btnCheckOut.TabIndex = 0;
            this.btnCheckOut.Text = "Checkout";
            this.btnCheckOut.UseVisualStyleBackColor = true;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(299, 195);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Update";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Items.AddRange(new object[] {
            "All",
            "Appetizer",
            "Main Dish",
            "Side ",
            "Beverage",
            "Dessert"});
            this.cmbCategory.Location = new System.Drawing.Point(138, 37);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(313, 33);
            this.cmbCategory.TabIndex = 6;
            this.cmbCategory.SelectedIndexChanged += new System.EventHandler(this.cmbCategory_SelectedIndexChanged);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(40, 40);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(92, 25);
            this.lblCategory.TabIndex = 7;
            this.lblCategory.Text = "Category";
            // 
            // btnResetCMenu
            // 
            this.btnResetCMenu.Location = new System.Drawing.Point(467, 37);
            this.btnResetCMenu.Name = "btnResetCMenu";
            this.btnResetCMenu.Size = new System.Drawing.Size(369, 30);
            this.btnResetCMenu.TabIndex = 9;
            this.btnResetCMenu.Text = "Reset Category";
            this.btnResetCMenu.UseVisualStyleBackColor = true;
            this.btnResetCMenu.Click += new System.EventHandler(this.btnResetCMenu_Click);
            // 
            // gbCMenu
            // 
            this.gbCMenu.Controls.Add(this.flowPanelMenu);
            this.gbCMenu.Controls.Add(this.btnResetCMenu);
            this.gbCMenu.Controls.Add(this.lblCategory);
            this.gbCMenu.Controls.Add(this.cmbCategory);
            this.gbCMenu.Controls.Add(this.button3);
            this.gbCMenu.Controls.Add(this.btnCheckOut);
            this.gbCMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCMenu.Location = new System.Drawing.Point(218, 76);
            this.gbCMenu.Name = "gbCMenu";
            this.gbCMenu.Size = new System.Drawing.Size(852, 360);
            this.gbCMenu.TabIndex = 147;
            this.gbCMenu.TabStop = false;
            this.gbCMenu.Text = "Food Menu";
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
            this.tableSidebar_Customer.TabIndex = 149;
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
            this.btnMakeReservation.Click += new System.EventHandler(this.btnMakeReservation_Click);
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
            this.btnFeedback.Click += new System.EventHandler(this.btnFeedback_Click);
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
            // btnMakeOrder
            // 
            this.btnMakeOrder.Location = new System.Drawing.Point(4, 294);
            this.btnMakeOrder.Margin = new System.Windows.Forms.Padding(4);
            this.btnMakeOrder.Name = "btnMakeOrder";
            this.btnMakeOrder.Size = new System.Drawing.Size(192, 32);
            this.btnMakeOrder.TabIndex = 0;
            this.btnMakeOrder.Text = "Make an Order";
            this.btnMakeOrder.UseVisualStyleBackColor = true;
            this.btnMakeOrder.Click += new System.EventHandler(this.btnMakeOrder_Click);
            // 
            // CustomerMenu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1082, 453);
            this.Controls.Add(this.tableSidebar_Customer);
            this.Controls.Add(this.gbCMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "CustomerMenu";
            this.Text = "CustomerMenu";
            this.gbCMenu.ResumeLayout(false);
            this.gbCMenu.PerformLayout();
            this.tableSidebar_Customer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowPanelMenu;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Button btnResetCMenu;
        private System.Windows.Forms.GroupBox gbCMenu;
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