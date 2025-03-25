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
            this.btninventory_ChefCustomerOrder = new System.Windows.Forms.Button();
            this.btnCusOrder_ChefCustomerOrder = new System.Windows.Forms.Button();
            this.btnChefProfile_ChefCustomerOrder = new System.Windows.Forms.Button();
            this.gbShowCusOrder = new System.Windows.Forms.GroupBox();
            this.btnResetChefCusOrderSearch = new System.Windows.Forms.Button();
            this.dgvChefCusOrder = new System.Windows.Forms.DataGridView();
            this.btnSearchCusOrderStatus = new System.Windows.Forms.Button();
            this.lblCusOrderStatus = new System.Windows.Forms.Label();
            this.cmbCusOrderStatus = new System.Windows.Forms.ComboBox();
            this.ColFoodName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCusOrderStatus = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ChefInCharge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColIngredientEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColIngredientDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tableSidebar_ChefCustomerOrder.SuspendLayout();
            this.gbShowCusOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChefCusOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // tableSidebar_ChefCustomerOrder
            // 
            this.tableSidebar_ChefCustomerOrder.ColumnCount = 1;
            this.tableSidebar_ChefCustomerOrder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
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
            // 
            // gbShowCusOrder
            // 
            this.gbShowCusOrder.Controls.Add(this.cmbCusOrderStatus);
            this.gbShowCusOrder.Controls.Add(this.btnResetChefCusOrderSearch);
            this.gbShowCusOrder.Controls.Add(this.dgvChefCusOrder);
            this.gbShowCusOrder.Controls.Add(this.btnSearchCusOrderStatus);
            this.gbShowCusOrder.Controls.Add(this.lblCusOrderStatus);
            this.gbShowCusOrder.Location = new System.Drawing.Point(218, 73);
            this.gbShowCusOrder.Name = "gbShowCusOrder";
            this.gbShowCusOrder.Size = new System.Drawing.Size(852, 369);
            this.gbShowCusOrder.TabIndex = 7;
            this.gbShowCusOrder.TabStop = false;
            this.gbShowCusOrder.Text = "Customer Order";
            // 
            // btnResetChefCusOrderSearch
            // 
            this.btnResetChefCusOrderSearch.Location = new System.Drawing.Point(567, 39);
            this.btnResetChefCusOrderSearch.Name = "btnResetChefCusOrderSearch";
            this.btnResetChefCusOrderSearch.Size = new System.Drawing.Size(263, 35);
            this.btnResetChefCusOrderSearch.TabIndex = 5;
            this.btnResetChefCusOrderSearch.Text = "Reset Search Ingredient";
            // 
            // dgvChefCusOrder
            // 
            this.dgvChefCusOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChefCusOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColFoodName,
            this.ColCusOrderStatus,
            this.ChefInCharge,
            this.ColIngredientEdit,
            this.ColIngredientDelete});
            this.dgvChefCusOrder.Location = new System.Drawing.Point(45, 91);
            this.dgvChefCusOrder.Name = "dgvChefCusOrder";
            this.dgvChefCusOrder.RowHeadersWidth = 51;
            this.dgvChefCusOrder.RowTemplate.Height = 24;
            this.dgvChefCusOrder.Size = new System.Drawing.Size(785, 263);
            this.dgvChefCusOrder.TabIndex = 3;
            // 
            // btnSearchCusOrderStatus
            // 
            this.btnSearchCusOrderStatus.Location = new System.Drawing.Point(416, 39);
            this.btnSearchCusOrderStatus.Name = "btnSearchCusOrderStatus";
            this.btnSearchCusOrderStatus.Size = new System.Drawing.Size(145, 35);
            this.btnSearchCusOrderStatus.TabIndex = 2;
            this.btnSearchCusOrderStatus.Text = "Search";
            this.btnSearchCusOrderStatus.UseVisualStyleBackColor = true;
            // 
            // lblCusOrderStatus
            // 
            this.lblCusOrderStatus.AutoSize = true;
            this.lblCusOrderStatus.Location = new System.Drawing.Point(40, 44);
            this.lblCusOrderStatus.Name = "lblCusOrderStatus";
            this.lblCusOrderStatus.Size = new System.Drawing.Size(68, 25);
            this.lblCusOrderStatus.TabIndex = 0;
            this.lblCusOrderStatus.Text = "Status";
            // 
            // cmbCusOrderStatus
            // 
            this.cmbCusOrderStatus.FormattingEnabled = true;
            this.cmbCusOrderStatus.Items.AddRange(new object[] {
            "Haven\'t accepted",
            "In Progress",
            "Completed"});
            this.cmbCusOrderStatus.Location = new System.Drawing.Point(136, 41);
            this.cmbCusOrderStatus.Name = "cmbCusOrderStatus";
            this.cmbCusOrderStatus.Size = new System.Drawing.Size(274, 33);
            this.cmbCusOrderStatus.TabIndex = 6;
            // 
            // ColFoodName
            // 
            this.ColFoodName.DataPropertyName = "Food";
            this.ColFoodName.HeaderText = "Food";
            this.ColFoodName.MinimumWidth = 6;
            this.ColFoodName.Name = "ColFoodName";
            this.ColFoodName.Width = 160;
            // 
            // ColCusOrderStatus
            // 
            this.ColCusOrderStatus.DataPropertyName = "Status";
            this.ColCusOrderStatus.HeaderText = "Status";
            this.ColCusOrderStatus.MinimumWidth = 6;
            this.ColCusOrderStatus.Name = "ColCusOrderStatus";
            this.ColCusOrderStatus.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColCusOrderStatus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColCusOrderStatus.Width = 150;
            // 
            // ChefInCharge
            // 
            this.ChefInCharge.HeaderText = "Chef In Charge";
            this.ChefInCharge.MinimumWidth = 6;
            this.ChefInCharge.Name = "ChefInCharge";
            this.ChefInCharge.Width = 180;
            // 
            // ColIngredientEdit
            // 
            this.ColIngredientEdit.DataPropertyName = "Edit";
            this.ColIngredientEdit.HeaderText = "Action";
            this.ColIngredientEdit.MinimumWidth = 6;
            this.ColIngredientEdit.Name = "ColIngredientEdit";
            this.ColIngredientEdit.Text = "Edit";
            this.ColIngredientEdit.UseColumnTextForButtonValue = true;
            this.ColIngredientEdit.Width = 120;
            // 
            // ColIngredientDelete
            // 
            this.ColIngredientDelete.DataPropertyName = "Delete";
            this.ColIngredientDelete.HeaderText = "Action";
            this.ColIngredientDelete.MinimumWidth = 6;
            this.ColIngredientDelete.Name = "ColIngredientDelete";
            this.ColIngredientDelete.Text = "Delete";
            this.ColIngredientDelete.UseColumnTextForButtonValue = true;
            this.ColIngredientDelete.Width = 120;
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
            this.Load += new System.EventHandler(this.View_Order_Load);
            this.tableSidebar_ChefCustomerOrder.ResumeLayout(false);
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
        private System.Windows.Forms.Button btnResetChefCusOrderSearch;
        private System.Windows.Forms.DataGridView dgvChefCusOrder;
        private System.Windows.Forms.Button btnSearchCusOrderStatus;
        private System.Windows.Forms.Label lblCusOrderStatus;
        private System.Windows.Forms.ComboBox cmbCusOrderStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColFoodName;
        private System.Windows.Forms.DataGridViewComboBoxColumn ColCusOrderStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChefInCharge;
        private System.Windows.Forms.DataGridViewButtonColumn ColIngredientEdit;
        private System.Windows.Forms.DataGridViewButtonColumn ColIngredientDelete;
    }
}