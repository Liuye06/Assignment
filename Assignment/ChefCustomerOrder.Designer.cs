namespace Assignment
{
    partial class ChefCustomerOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChefCustomerOrder));
            this.tableSidebar_ChefCustomerOrder = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pic_logo = new System.Windows.Forms.PictureBox();
            this.lbl_chef = new System.Windows.Forms.Label();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btninventory_ChefCustomerOrder = new System.Windows.Forms.Button();
            this.btnCusOrder_ChefCustomerOrder = new System.Windows.Forms.Button();
            this.btnChefProfile_ChefCustomerOrder = new System.Windows.Forms.Button();
            this.gbShowCusOrder = new System.Windows.Forms.GroupBox();
            this.btnUpdateChef = new System.Windows.Forms.Button();
            this.cmbChef = new System.Windows.Forms.ComboBox();
            this.btnRefreshStatusCusOrder = new System.Windows.Forms.Button();
            this.btnUpdateCusOrderStatus = new System.Windows.Forms.Button();
            this.lblCusStatusOrder = new System.Windows.Forms.Label();
            this.cmbCusOrderStatus = new System.Windows.Forms.ComboBox();
            this.dgvChefCusOrder = new System.Windows.Forms.DataGridView();
            this.CusOrderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColFoodName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChefInCharge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CanUpdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableSidebar_ChefCustomerOrder.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).BeginInit();
            this.gbShowCusOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChefCusOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // tableSidebar_ChefCustomerOrder
            // 
            this.tableSidebar_ChefCustomerOrder.BackColor = System.Drawing.Color.SandyBrown;
            this.tableSidebar_ChefCustomerOrder.ColumnCount = 1;
            this.tableSidebar_ChefCustomerOrder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableSidebar_ChefCustomerOrder.Controls.Add(this.panel2, 0, 0);
            this.tableSidebar_ChefCustomerOrder.Controls.Add(this.btnLogOut, 0, 4);
            this.tableSidebar_ChefCustomerOrder.Controls.Add(this.btninventory_ChefCustomerOrder, 0, 1);
            this.tableSidebar_ChefCustomerOrder.Controls.Add(this.btnCusOrder_ChefCustomerOrder, 0, 2);
            this.tableSidebar_ChefCustomerOrder.Controls.Add(this.btnChefProfile_ChefCustomerOrder, 0, 3);
            this.tableSidebar_ChefCustomerOrder.Location = new System.Drawing.Point(12, 0);
            this.tableSidebar_ChefCustomerOrder.Name = "tableSidebar_ChefCustomerOrder";
            this.tableSidebar_ChefCustomerOrder.RowCount = 6;
            this.tableSidebar_ChefCustomerOrder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableSidebar_ChefCustomerOrder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableSidebar_ChefCustomerOrder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableSidebar_ChefCustomerOrder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableSidebar_ChefCustomerOrder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableSidebar_ChefCustomerOrder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableSidebar_ChefCustomerOrder.Size = new System.Drawing.Size(236, 452);
            this.tableSidebar_ChefCustomerOrder.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SandyBrown;
            this.panel2.Controls.Add(this.pic_logo);
            this.panel2.Controls.Add(this.lbl_chef);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(230, 144);
            this.panel2.TabIndex = 18;
            // 
            // pic_logo
            // 
            this.pic_logo.Image = ((System.Drawing.Image)(resources.GetObject("pic_logo.Image")));
            this.pic_logo.Location = new System.Drawing.Point(0, 42);
            this.pic_logo.Name = "pic_logo";
            this.pic_logo.Size = new System.Drawing.Size(138, 102);
            this.pic_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pic_logo.TabIndex = 9;
            this.pic_logo.TabStop = false;
            // 
            // lbl_chef
            // 
            this.lbl_chef.AutoSize = true;
            this.lbl_chef.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_chef.Location = new System.Drawing.Point(0, 0);
            this.lbl_chef.Name = "lbl_chef";
            this.lbl_chef.Size = new System.Drawing.Size(90, 54);
            this.lbl_chef.TabIndex = 3;
            this.lbl_chef.Text = "Chef";
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.Gainsboro;
            this.btnLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.Image = ((System.Drawing.Image)(resources.GetObject("btnLogOut.Image")));
            this.btnLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogOut.Location = new System.Drawing.Point(3, 288);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(230, 39);
            this.btnLogOut.TabIndex = 15;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btninventory_ChefCustomerOrder
            // 
            this.btninventory_ChefCustomerOrder.BackColor = System.Drawing.Color.Gainsboro;
            this.btninventory_ChefCustomerOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btninventory_ChefCustomerOrder.FlatAppearance.BorderSize = 0;
            this.btninventory_ChefCustomerOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btninventory_ChefCustomerOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninventory_ChefCustomerOrder.Image = ((System.Drawing.Image)(resources.GetObject("btninventory_ChefCustomerOrder.Image")));
            this.btninventory_ChefCustomerOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btninventory_ChefCustomerOrder.Location = new System.Drawing.Point(3, 152);
            this.btninventory_ChefCustomerOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btninventory_ChefCustomerOrder.Name = "btninventory_ChefCustomerOrder";
            this.btninventory_ChefCustomerOrder.Size = new System.Drawing.Size(230, 41);
            this.btninventory_ChefCustomerOrder.TabIndex = 0;
            this.btninventory_ChefCustomerOrder.Text = "Manage Inventory";
            this.btninventory_ChefCustomerOrder.UseVisualStyleBackColor = false;
            this.btninventory_ChefCustomerOrder.Click += new System.EventHandler(this.btninventory_ChefCustomerOrder_Click);
            // 
            // btnCusOrder_ChefCustomerOrder
            // 
            this.btnCusOrder_ChefCustomerOrder.BackColor = System.Drawing.Color.Gainsboro;
            this.btnCusOrder_ChefCustomerOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCusOrder_ChefCustomerOrder.FlatAppearance.BorderSize = 0;
            this.btnCusOrder_ChefCustomerOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCusOrder_ChefCustomerOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCusOrder_ChefCustomerOrder.Image = ((System.Drawing.Image)(resources.GetObject("btnCusOrder_ChefCustomerOrder.Image")));
            this.btnCusOrder_ChefCustomerOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCusOrder_ChefCustomerOrder.Location = new System.Drawing.Point(3, 197);
            this.btnCusOrder_ChefCustomerOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCusOrder_ChefCustomerOrder.Name = "btnCusOrder_ChefCustomerOrder";
            this.btnCusOrder_ChefCustomerOrder.Size = new System.Drawing.Size(230, 41);
            this.btnCusOrder_ChefCustomerOrder.TabIndex = 1;
            this.btnCusOrder_ChefCustomerOrder.Text = "Customer\'s Orders";
            this.btnCusOrder_ChefCustomerOrder.UseVisualStyleBackColor = false;
            this.btnCusOrder_ChefCustomerOrder.Click += new System.EventHandler(this.btnCusOrder_ChefCustomerOrder_Click);
            // 
            // btnChefProfile_ChefCustomerOrder
            // 
            this.btnChefProfile_ChefCustomerOrder.BackColor = System.Drawing.Color.Gainsboro;
            this.btnChefProfile_ChefCustomerOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChefProfile_ChefCustomerOrder.FlatAppearance.BorderSize = 0;
            this.btnChefProfile_ChefCustomerOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChefProfile_ChefCustomerOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChefProfile_ChefCustomerOrder.Image = ((System.Drawing.Image)(resources.GetObject("btnChefProfile_ChefCustomerOrder.Image")));
            this.btnChefProfile_ChefCustomerOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnChefProfile_ChefCustomerOrder.Location = new System.Drawing.Point(3, 242);
            this.btnChefProfile_ChefCustomerOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnChefProfile_ChefCustomerOrder.Name = "btnChefProfile_ChefCustomerOrder";
            this.btnChefProfile_ChefCustomerOrder.Size = new System.Drawing.Size(230, 41);
            this.btnChefProfile_ChefCustomerOrder.TabIndex = 2;
            this.btnChefProfile_ChefCustomerOrder.Text = "Chef Profile";
            this.btnChefProfile_ChefCustomerOrder.UseVisualStyleBackColor = false;
            this.btnChefProfile_ChefCustomerOrder.Click += new System.EventHandler(this.btnChefProfile_ChefCustomerOrder_Click);
            // 
            // gbShowCusOrder
            // 
            this.gbShowCusOrder.Controls.Add(this.btnUpdateChef);
            this.gbShowCusOrder.Controls.Add(this.cmbChef);
            this.gbShowCusOrder.Controls.Add(this.btnRefreshStatusCusOrder);
            this.gbShowCusOrder.Controls.Add(this.btnUpdateCusOrderStatus);
            this.gbShowCusOrder.Controls.Add(this.lblCusStatusOrder);
            this.gbShowCusOrder.Controls.Add(this.cmbCusOrderStatus);
            this.gbShowCusOrder.Controls.Add(this.dgvChefCusOrder);
            this.gbShowCusOrder.Location = new System.Drawing.Point(254, 73);
            this.gbShowCusOrder.Name = "gbShowCusOrder";
            this.gbShowCusOrder.Size = new System.Drawing.Size(816, 369);
            this.gbShowCusOrder.TabIndex = 7;
            this.gbShowCusOrder.TabStop = false;
            this.gbShowCusOrder.Text = "Customer Order";
            // 
            // btnUpdateChef
            // 
            this.btnUpdateChef.Location = new System.Drawing.Point(429, 326);
            this.btnUpdateChef.Name = "btnUpdateChef";
            this.btnUpdateChef.Size = new System.Drawing.Size(184, 33);
            this.btnUpdateChef.TabIndex = 19;
            this.btnUpdateChef.Text = "Update Chef";
            this.btnUpdateChef.UseVisualStyleBackColor = true;
            this.btnUpdateChef.Click += new System.EventHandler(this.btnUpdateChef_Click);
            // 
            // cmbChef
            // 
            this.cmbChef.FormattingEnabled = true;
            this.cmbChef.Items.AddRange(new object[] {
            "In Progress",
            "Completed"});
            this.cmbChef.Location = new System.Drawing.Point(19, 327);
            this.cmbChef.Name = "cmbChef";
            this.cmbChef.Size = new System.Drawing.Size(404, 33);
            this.cmbChef.TabIndex = 18;
            // 
            // btnRefreshStatusCusOrder
            // 
            this.btnRefreshStatusCusOrder.Location = new System.Drawing.Point(414, 41);
            this.btnRefreshStatusCusOrder.Name = "btnRefreshStatusCusOrder";
            this.btnRefreshStatusCusOrder.Size = new System.Drawing.Size(390, 36);
            this.btnRefreshStatusCusOrder.TabIndex = 14;
            this.btnRefreshStatusCusOrder.Text = "Refresh Status";
            this.btnRefreshStatusCusOrder.UseVisualStyleBackColor = true;
            this.btnRefreshStatusCusOrder.Click += new System.EventHandler(this.btnRefreshStatusCusOrder_Click);
            // 
            // btnUpdateCusOrderStatus
            // 
            this.btnUpdateCusOrderStatus.Location = new System.Drawing.Point(619, 326);
            this.btnUpdateCusOrderStatus.Name = "btnUpdateCusOrderStatus";
            this.btnUpdateCusOrderStatus.Size = new System.Drawing.Size(185, 33);
            this.btnUpdateCusOrderStatus.TabIndex = 13;
            this.btnUpdateCusOrderStatus.Text = "Update Status";
            this.btnUpdateCusOrderStatus.UseVisualStyleBackColor = true;
            this.btnUpdateCusOrderStatus.Click += new System.EventHandler(this.btnUpdateCusOrderStatus_Click);
            // 
            // lblCusStatusOrder
            // 
            this.lblCusStatusOrder.AutoSize = true;
            this.lblCusStatusOrder.Location = new System.Drawing.Point(14, 44);
            this.lblCusStatusOrder.Name = "lblCusStatusOrder";
            this.lblCusStatusOrder.Size = new System.Drawing.Size(123, 25);
            this.lblCusStatusOrder.TabIndex = 12;
            this.lblCusStatusOrder.Text = "Order Status";
            // 
            // cmbCusOrderStatus
            // 
            this.cmbCusOrderStatus.FormattingEnabled = true;
            this.cmbCusOrderStatus.Items.AddRange(new object[] {
            "All",
            "Pending",
            "In Progress",
            "Completed"});
            this.cmbCusOrderStatus.Location = new System.Drawing.Point(143, 41);
            this.cmbCusOrderStatus.Name = "cmbCusOrderStatus";
            this.cmbCusOrderStatus.Size = new System.Drawing.Size(265, 33);
            this.cmbCusOrderStatus.TabIndex = 11;
            this.cmbCusOrderStatus.SelectedIndexChanged += new System.EventHandler(this.cmbCusOrderStatus_SelectedIndexChanged);
            // 
            // dgvChefCusOrder
            // 
            this.dgvChefCusOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChefCusOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CusOrderID,
            this.ColFoodName,
            this.OrderStatus,
            this.ChefInCharge,
            this.CanUpdate});
            this.dgvChefCusOrder.Location = new System.Drawing.Point(19, 92);
            this.dgvChefCusOrder.Name = "dgvChefCusOrder";
            this.dgvChefCusOrder.RowHeadersWidth = 51;
            this.dgvChefCusOrder.RowTemplate.Height = 30;
            this.dgvChefCusOrder.Size = new System.Drawing.Size(785, 224);
            this.dgvChefCusOrder.TabIndex = 3;
            this.dgvChefCusOrder.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChefCusOrder_CellContentClick_1);
            this.dgvChefCusOrder.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChefCusOrder_CellValueChanged);
            // 
            // CusOrderID
            // 
            this.CusOrderID.DataPropertyName = "OrderID";
            this.CusOrderID.HeaderText = "Order ID";
            this.CusOrderID.MinimumWidth = 6;
            this.CusOrderID.Name = "CusOrderID";
            this.CusOrderID.Width = 125;
            // 
            // ColFoodName
            // 
            this.ColFoodName.DataPropertyName = "FoodName";
            this.ColFoodName.HeaderText = "Food Name";
            this.ColFoodName.MinimumWidth = 6;
            this.ColFoodName.Name = "ColFoodName";
            this.ColFoodName.Width = 170;
            // 
            // OrderStatus
            // 
            this.OrderStatus.DataPropertyName = "OrderStatus";
            this.OrderStatus.HeaderText = "Status";
            this.OrderStatus.MinimumWidth = 6;
            this.OrderStatus.Name = "OrderStatus";
            this.OrderStatus.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.OrderStatus.Width = 125;
            // 
            // ChefInCharge
            // 
            this.ChefInCharge.DataPropertyName = "ChefInCharge";
            this.ChefInCharge.HeaderText = "Chef In Charge";
            this.ChefInCharge.MinimumWidth = 6;
            this.ChefInCharge.Name = "ChefInCharge";
            this.ChefInCharge.Width = 187;
            // 
            // CanUpdate
            // 
            this.CanUpdate.DataPropertyName = "CanUpdate";
            this.CanUpdate.HeaderText = "CanUpdate";
            this.CanUpdate.MinimumWidth = 6;
            this.CanUpdate.Name = "CanUpdate";
            this.CanUpdate.Visible = false;
            this.CanUpdate.Width = 125;
            // 
            // ChefCustomerOrder
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(237)))), ((int)(((byte)(225)))));
            this.ClientSize = new System.Drawing.Size(1082, 453);
            this.Controls.Add(this.gbShowCusOrder);
            this.Controls.Add(this.tableSidebar_ChefCustomerOrder);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ChefCustomerOrder";
            this.Text = "CustomersOrder";
            this.tableSidebar_ChefCustomerOrder.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).EndInit();
            this.gbShowCusOrder.ResumeLayout(false);
            this.gbShowCusOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChefCusOrder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableSidebar_ChefCustomerOrder;
        private System.Windows.Forms.Button btninventory_ChefCustomerOrder;
        private System.Windows.Forms.Button btnCusOrder_ChefCustomerOrder;
        private System.Windows.Forms.Button btnChefProfile_ChefCustomerOrder;
        private System.Windows.Forms.GroupBox gbShowCusOrder;
        private System.Windows.Forms.DataGridView dgvChefCusOrder;
        private System.Windows.Forms.Label lblCusStatusOrder;
        private System.Windows.Forms.ComboBox cmbCusOrderStatus;
        private System.Windows.Forms.Button btnUpdateCusOrderStatus;
        private System.Windows.Forms.Button btnRefreshStatusCusOrder;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.ComboBox cmbChef;
        private System.Windows.Forms.Button btnUpdateChef;
        private System.Windows.Forms.DataGridViewTextBoxColumn CusOrderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColFoodName;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChefInCharge;
        private System.Windows.Forms.DataGridViewTextBoxColumn CanUpdate;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pic_logo;
        private System.Windows.Forms.Label lbl_chef;
    }
}