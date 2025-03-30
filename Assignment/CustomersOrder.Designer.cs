namespace Assignment
{
    partial class CustomersOrder
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
            this.tableSidebar_ChefCustomerOrder = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_chef = new System.Windows.Forms.Label();
            this.btninventory_ChefCustomerOrder = new System.Windows.Forms.Button();
            this.btnCusOrder_ChefCustomerOrder = new System.Windows.Forms.Button();
            this.btnChefProfile_ChefCustomerOrder = new System.Windows.Forms.Button();
            this.gbShowCusOrder = new System.Windows.Forms.GroupBox();
            this.lblOrderID = new System.Windows.Forms.Label();
            this.cmbNewCusOrderStatus = new System.Windows.Forms.ComboBox();
            this.btnRefreshStatusCusOrder = new System.Windows.Forms.Button();
            this.btnUpdateCusOrderStatus = new System.Windows.Forms.Button();
            this.lblCusStatusOrder = new System.Windows.Forms.Label();
            this.cmbCusOrderStatus = new System.Windows.Forms.ComboBox();
            this.dgvChefCusOrder = new System.Windows.Forms.DataGridView();
            this.CusOrderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColFoodName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCusOrderStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UpdateCusOrder = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColChefInCharge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblFoodName = new System.Windows.Forms.Label();
            this.tableSidebar_ChefCustomerOrder.SuspendLayout();
            this.gbShowCusOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChefCusOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // tableSidebar_ChefCustomerOrder
            // 
            this.tableSidebar_ChefCustomerOrder.ColumnCount = 1;
            this.tableSidebar_ChefCustomerOrder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableSidebar_ChefCustomerOrder.Controls.Add(this.lbl_chef, 0, 0);
            this.tableSidebar_ChefCustomerOrder.Controls.Add(this.btninventory_ChefCustomerOrder, 0, 1);
            this.tableSidebar_ChefCustomerOrder.Controls.Add(this.btnCusOrder_ChefCustomerOrder, 0, 2);
            this.tableSidebar_ChefCustomerOrder.Controls.Add(this.btnChefProfile_ChefCustomerOrder, 0, 3);
            this.tableSidebar_ChefCustomerOrder.Location = new System.Drawing.Point(12, 11);
            this.tableSidebar_ChefCustomerOrder.Name = "tableSidebar_ChefCustomerOrder";
            this.tableSidebar_ChefCustomerOrder.RowCount = 5;
            this.tableSidebar_ChefCustomerOrder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableSidebar_ChefCustomerOrder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableSidebar_ChefCustomerOrder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableSidebar_ChefCustomerOrder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableSidebar_ChefCustomerOrder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableSidebar_ChefCustomerOrder.Size = new System.Drawing.Size(200, 430);
            this.tableSidebar_ChefCustomerOrder.TabIndex = 6;
            // 
            // lbl_chef
            // 
            this.lbl_chef.AutoSize = true;
            this.lbl_chef.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_chef.Location = new System.Drawing.Point(3, 0);
            this.lbl_chef.Name = "lbl_chef";
            this.lbl_chef.Size = new System.Drawing.Size(93, 39);
            this.lbl_chef.TabIndex = 14;
            this.lbl_chef.Text = "Chef";
            // 
            // btninventory_ChefCustomerOrder
            // 
            this.btninventory_ChefCustomerOrder.BackColor = System.Drawing.Color.Silver;
            this.btninventory_ChefCustomerOrder.FlatAppearance.BorderSize = 0;
            this.btninventory_ChefCustomerOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btninventory_ChefCustomerOrder.Location = new System.Drawing.Point(3, 62);
            this.btninventory_ChefCustomerOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btninventory_ChefCustomerOrder.Name = "btninventory_ChefCustomerOrder";
            this.btninventory_ChefCustomerOrder.Size = new System.Drawing.Size(194, 36);
            this.btninventory_ChefCustomerOrder.TabIndex = 0;
            this.btninventory_ChefCustomerOrder.Text = "Manage Inventory";
            this.btninventory_ChefCustomerOrder.UseVisualStyleBackColor = false;
            this.btninventory_ChefCustomerOrder.Click += new System.EventHandler(this.btninventory_ChefCustomerOrder_Click);
            // 
            // btnCusOrder_ChefCustomerOrder
            // 
            this.btnCusOrder_ChefCustomerOrder.BackColor = System.Drawing.Color.Silver;
            this.btnCusOrder_ChefCustomerOrder.FlatAppearance.BorderSize = 0;
            this.btnCusOrder_ChefCustomerOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCusOrder_ChefCustomerOrder.Location = new System.Drawing.Point(3, 102);
            this.btnCusOrder_ChefCustomerOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCusOrder_ChefCustomerOrder.Name = "btnCusOrder_ChefCustomerOrder";
            this.btnCusOrder_ChefCustomerOrder.Size = new System.Drawing.Size(194, 36);
            this.btnCusOrder_ChefCustomerOrder.TabIndex = 1;
            this.btnCusOrder_ChefCustomerOrder.Text = "Customer\'s Orders";
            this.btnCusOrder_ChefCustomerOrder.UseVisualStyleBackColor = false;
            this.btnCusOrder_ChefCustomerOrder.Click += new System.EventHandler(this.btnCusOrder_ChefCustomerOrder_Click);
            // 
            // btnChefProfile_ChefCustomerOrder
            // 
            this.btnChefProfile_ChefCustomerOrder.BackColor = System.Drawing.Color.Silver;
            this.btnChefProfile_ChefCustomerOrder.FlatAppearance.BorderSize = 0;
            this.btnChefProfile_ChefCustomerOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChefProfile_ChefCustomerOrder.Location = new System.Drawing.Point(3, 142);
            this.btnChefProfile_ChefCustomerOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnChefProfile_ChefCustomerOrder.Name = "btnChefProfile_ChefCustomerOrder";
            this.btnChefProfile_ChefCustomerOrder.Size = new System.Drawing.Size(194, 36);
            this.btnChefProfile_ChefCustomerOrder.TabIndex = 2;
            this.btnChefProfile_ChefCustomerOrder.Text = "Chef Profile";
            this.btnChefProfile_ChefCustomerOrder.UseVisualStyleBackColor = false;
            this.btnChefProfile_ChefCustomerOrder.Click += new System.EventHandler(this.btnChefProfile_ChefCustomerOrder_Click);
            // 
            // gbShowCusOrder
            // 
            this.gbShowCusOrder.Controls.Add(this.lblFoodName);
            this.gbShowCusOrder.Controls.Add(this.lblOrderID);
            this.gbShowCusOrder.Controls.Add(this.cmbNewCusOrderStatus);
            this.gbShowCusOrder.Controls.Add(this.btnRefreshStatusCusOrder);
            this.gbShowCusOrder.Controls.Add(this.btnUpdateCusOrderStatus);
            this.gbShowCusOrder.Controls.Add(this.lblCusStatusOrder);
            this.gbShowCusOrder.Controls.Add(this.cmbCusOrderStatus);
            this.gbShowCusOrder.Controls.Add(this.dgvChefCusOrder);
            this.gbShowCusOrder.Location = new System.Drawing.Point(218, 73);
            this.gbShowCusOrder.Name = "gbShowCusOrder";
            this.gbShowCusOrder.Size = new System.Drawing.Size(852, 369);
            this.gbShowCusOrder.TabIndex = 7;
            this.gbShowCusOrder.TabStop = false;
            this.gbShowCusOrder.Text = "Customer Order";
            // 
            // lblOrderID
            // 
            this.lblOrderID.AutoSize = true;
            this.lblOrderID.Location = new System.Drawing.Point(40, 328);
            this.lblOrderID.Name = "lblOrderID";
            this.lblOrderID.Size = new System.Drawing.Size(0, 25);
            this.lblOrderID.TabIndex = 16;
            // 
            // cmbNewCusOrderStatus
            // 
            this.cmbNewCusOrderStatus.FormattingEnabled = true;
            this.cmbNewCusOrderStatus.Items.AddRange(new object[] {
            "In Progress",
            "Completed"});
            this.cmbNewCusOrderStatus.Location = new System.Drawing.Point(485, 325);
            this.cmbNewCusOrderStatus.Name = "cmbNewCusOrderStatus";
            this.cmbNewCusOrderStatus.Size = new System.Drawing.Size(176, 33);
            this.cmbNewCusOrderStatus.TabIndex = 15;
            // 
            // btnRefreshStatusCusOrder
            // 
            this.btnRefreshStatusCusOrder.Location = new System.Drawing.Point(440, 40);
            this.btnRefreshStatusCusOrder.Name = "btnRefreshStatusCusOrder";
            this.btnRefreshStatusCusOrder.Size = new System.Drawing.Size(390, 28);
            this.btnRefreshStatusCusOrder.TabIndex = 14;
            this.btnRefreshStatusCusOrder.Text = "Refresh Status";
            this.btnRefreshStatusCusOrder.UseVisualStyleBackColor = true;
            this.btnRefreshStatusCusOrder.Click += new System.EventHandler(this.btnRefreshStatusCusOrder_Click);
            // 
            // btnUpdateCusOrderStatus
            // 
            this.btnUpdateCusOrderStatus.Location = new System.Drawing.Point(667, 325);
            this.btnUpdateCusOrderStatus.Name = "btnUpdateCusOrderStatus";
            this.btnUpdateCusOrderStatus.Size = new System.Drawing.Size(163, 28);
            this.btnUpdateCusOrderStatus.TabIndex = 13;
            this.btnUpdateCusOrderStatus.Text = "Update Status";
            this.btnUpdateCusOrderStatus.UseVisualStyleBackColor = true;
            this.btnUpdateCusOrderStatus.Click += new System.EventHandler(this.btnUpdateCusOrderStatus_Click);
            // 
            // lblCusStatusOrder
            // 
            this.lblCusStatusOrder.AutoSize = true;
            this.lblCusStatusOrder.Location = new System.Drawing.Point(40, 43);
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
            this.cmbCusOrderStatus.Location = new System.Drawing.Point(169, 40);
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
            this.ColCusOrderStatus,
            this.UpdateCusOrder,
            this.ColChefInCharge});
            this.dgvChefCusOrder.Location = new System.Drawing.Point(45, 91);
            this.dgvChefCusOrder.Name = "dgvChefCusOrder";
            this.dgvChefCusOrder.RowHeadersWidth = 51;
            this.dgvChefCusOrder.RowTemplate.Height = 30;
            this.dgvChefCusOrder.Size = new System.Drawing.Size(785, 224);
            this.dgvChefCusOrder.TabIndex = 3;
            this.dgvChefCusOrder.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChefCusOrder_CellContentClick);
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
            // ColCusOrderStatus
            // 
            this.ColCusOrderStatus.DataPropertyName = "OrderStatus";
            this.ColCusOrderStatus.HeaderText = "Status";
            this.ColCusOrderStatus.MinimumWidth = 6;
            this.ColCusOrderStatus.Name = "ColCusOrderStatus";
            this.ColCusOrderStatus.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColCusOrderStatus.Width = 125;
            // 
            // UpdateCusOrder
            // 
            this.UpdateCusOrder.DataPropertyName = "Update";
            this.UpdateCusOrder.HeaderText = "Action";
            this.UpdateCusOrder.MinimumWidth = 6;
            this.UpdateCusOrder.Name = "UpdateCusOrder";
            this.UpdateCusOrder.Text = "Update";
            this.UpdateCusOrder.UseColumnTextForButtonValue = true;
            this.UpdateCusOrder.Width = 125;
            // 
            // ColChefInCharge
            // 
            this.ColChefInCharge.DataPropertyName = "ChefInCharge";
            this.ColChefInCharge.HeaderText = "Chef In Charge";
            this.ColChefInCharge.MinimumWidth = 6;
            this.ColChefInCharge.Name = "ColChefInCharge";
            this.ColChefInCharge.Width = 187;
            // 
            // lblFoodName
            // 
            this.lblFoodName.AutoSize = true;
            this.lblFoodName.Location = new System.Drawing.Point(211, 327);
            this.lblFoodName.Name = "lblFoodName";
            this.lblFoodName.Size = new System.Drawing.Size(0, 25);
            this.lblFoodName.TabIndex = 17;
            // 
            // CustomersOrder
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1082, 453);
            this.Controls.Add(this.gbShowCusOrder);
            this.Controls.Add(this.tableSidebar_ChefCustomerOrder);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CustomersOrder";
            this.Text = "CustomersOrder";
            this.tableSidebar_ChefCustomerOrder.ResumeLayout(false);
            this.tableSidebar_ChefCustomerOrder.PerformLayout();
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
        private System.Windows.Forms.Label lbl_chef;
        private System.Windows.Forms.Button btnRefreshStatusCusOrder;
        private System.Windows.Forms.ComboBox cmbNewCusOrderStatus;
        private System.Windows.Forms.Label lblOrderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CusOrderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColFoodName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCusOrderStatus;
        private System.Windows.Forms.DataGridViewButtonColumn UpdateCusOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColChefInCharge;
        private System.Windows.Forms.Label lblFoodName;
    }
}