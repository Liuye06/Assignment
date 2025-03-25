namespace Assignment
{
    partial class Chef
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
            this.btn_inventory = new System.Windows.Forms.Button();
            this.btn_ChefProfile = new System.Windows.Forms.Button();
            this.btn_CusOrder = new System.Windows.Forms.Button();
            this.lbl_chef = new System.Windows.Forms.Label();
            this.tableSidebar_CInventory = new System.Windows.Forms.TableLayoutPanel();
            this.gbCInventory = new System.Windows.Forms.GroupBox();
            this.btnResetIngredientSearch = new System.Windows.Forms.Button();
            this.btnAddNewIngredient = new System.Windows.Forms.Button();
            this.dgvIngredient = new System.Windows.Forms.DataGridView();
            this.btnSearchIngredient = new System.Windows.Forms.Button();
            this.txtIngredient = new System.Windows.Forms.TextBox();
            this.lblIngredient = new System.Windows.Forms.Label();
            this.ColIngredientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColIngredientEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColIngredientDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tableSidebar_CInventory.SuspendLayout();
            this.gbCInventory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngredient)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_inventory
            // 
            this.btn_inventory.BackColor = System.Drawing.Color.Silver;
            this.btn_inventory.FlatAppearance.BorderSize = 0;
            this.btn_inventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_inventory.Location = new System.Drawing.Point(3, 62);
            this.btn_inventory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_inventory.Name = "btn_inventory";
            this.btn_inventory.Size = new System.Drawing.Size(194, 36);
            this.btn_inventory.TabIndex = 0;
            this.btn_inventory.Text = "Manage Inventory";
            this.btn_inventory.UseVisualStyleBackColor = false;
            this.btn_inventory.Click += new System.EventHandler(this.btn_inventory_Click);
            // 
            // btn_ChefProfile
            // 
            this.btn_ChefProfile.BackColor = System.Drawing.Color.Silver;
            this.btn_ChefProfile.FlatAppearance.BorderSize = 0;
            this.btn_ChefProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ChefProfile.Location = new System.Drawing.Point(3, 142);
            this.btn_ChefProfile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_ChefProfile.Name = "btn_ChefProfile";
            this.btn_ChefProfile.Size = new System.Drawing.Size(194, 36);
            this.btn_ChefProfile.TabIndex = 2;
            this.btn_ChefProfile.Text = "Chef Profile";
            this.btn_ChefProfile.UseVisualStyleBackColor = false;
            this.btn_ChefProfile.Click += new System.EventHandler(this.btn_ChefProfile_Click);
            // 
            // btn_CusOrder
            // 
            this.btn_CusOrder.BackColor = System.Drawing.Color.Silver;
            this.btn_CusOrder.FlatAppearance.BorderSize = 0;
            this.btn_CusOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CusOrder.Location = new System.Drawing.Point(3, 102);
            this.btn_CusOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_CusOrder.Name = "btn_CusOrder";
            this.btn_CusOrder.Size = new System.Drawing.Size(194, 36);
            this.btn_CusOrder.TabIndex = 1;
            this.btn_CusOrder.Text = "Customer\'s Orders";
            this.btn_CusOrder.UseVisualStyleBackColor = false;
            this.btn_CusOrder.Click += new System.EventHandler(this.btn_CusOrder_Click);
            // 
            // lbl_chef
            // 
            this.lbl_chef.AutoSize = true;
            this.lbl_chef.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_chef.Location = new System.Drawing.Point(3, 0);
            this.lbl_chef.Name = "lbl_chef";
            this.lbl_chef.Size = new System.Drawing.Size(93, 39);
            this.lbl_chef.TabIndex = 3;
            this.lbl_chef.Text = "Chef";
            // 
            // tableSidebar_CInventory
            // 
            this.tableSidebar_CInventory.ColumnCount = 1;
            this.tableSidebar_CInventory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableSidebar_CInventory.Controls.Add(this.btn_inventory, 0, 1);
            this.tableSidebar_CInventory.Controls.Add(this.btn_CusOrder, 0, 2);
            this.tableSidebar_CInventory.Controls.Add(this.lbl_chef, 0, 0);
            this.tableSidebar_CInventory.Controls.Add(this.btn_ChefProfile, 0, 3);
            this.tableSidebar_CInventory.Location = new System.Drawing.Point(12, 12);
            this.tableSidebar_CInventory.Name = "tableSidebar_CInventory";
            this.tableSidebar_CInventory.RowCount = 5;
            this.tableSidebar_CInventory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableSidebar_CInventory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableSidebar_CInventory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableSidebar_CInventory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableSidebar_CInventory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableSidebar_CInventory.Size = new System.Drawing.Size(200, 430);
            this.tableSidebar_CInventory.TabIndex = 5;
            // 
            // gbCInventory
            // 
            this.gbCInventory.Controls.Add(this.btnResetIngredientSearch);
            this.gbCInventory.Controls.Add(this.btnAddNewIngredient);
            this.gbCInventory.Controls.Add(this.dgvIngredient);
            this.gbCInventory.Controls.Add(this.btnSearchIngredient);
            this.gbCInventory.Controls.Add(this.txtIngredient);
            this.gbCInventory.Controls.Add(this.lblIngredient);
            this.gbCInventory.Location = new System.Drawing.Point(218, 72);
            this.gbCInventory.Name = "gbCInventory";
            this.gbCInventory.Size = new System.Drawing.Size(852, 369);
            this.gbCInventory.TabIndex = 6;
            this.gbCInventory.TabStop = false;
            this.gbCInventory.Text = "Manage Inventory";
            // 
            // btnResetIngredientSearch
            // 
            this.btnResetIngredientSearch.Location = new System.Drawing.Point(440, 320);
            this.btnResetIngredientSearch.Name = "btnResetIngredientSearch";
            this.btnResetIngredientSearch.Size = new System.Drawing.Size(390, 35);
            this.btnResetIngredientSearch.TabIndex = 5;
            this.btnResetIngredientSearch.Text = "Reset Search Ingredient";
            this.btnResetIngredientSearch.Click += new System.EventHandler(this.btnResetIngredientSearch_Click);
            // 
            // btnAddNewIngredient
            // 
            this.btnAddNewIngredient.Location = new System.Drawing.Point(45, 320);
            this.btnAddNewIngredient.Name = "btnAddNewIngredient";
            this.btnAddNewIngredient.Size = new System.Drawing.Size(390, 35);
            this.btnAddNewIngredient.TabIndex = 4;
            this.btnAddNewIngredient.Text = "Add New Ingredient";
            this.btnAddNewIngredient.Click += new System.EventHandler(this.btnAddNewIngredient_Click);
            // 
            // dgvIngredient
            // 
            this.dgvIngredient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIngredient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColIngredientName,
            this.ColStock,
            this.ColIngredientEdit,
            this.ColIngredientDelete});
            this.dgvIngredient.Location = new System.Drawing.Point(45, 91);
            this.dgvIngredient.Name = "dgvIngredient";
            this.dgvIngredient.RowHeadersWidth = 51;
            this.dgvIngredient.RowTemplate.Height = 24;
            this.dgvIngredient.Size = new System.Drawing.Size(785, 216);
            this.dgvIngredient.TabIndex = 3;
            this.dgvIngredient.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvIngredient_CellContentClick);
            // 
            // btnSearchIngredient
            // 
            this.btnSearchIngredient.Location = new System.Drawing.Point(416, 39);
            this.btnSearchIngredient.Name = "btnSearchIngredient";
            this.btnSearchIngredient.Size = new System.Drawing.Size(106, 35);
            this.btnSearchIngredient.TabIndex = 2;
            this.btnSearchIngredient.Text = "Search";
            this.btnSearchIngredient.UseVisualStyleBackColor = true;
            this.btnSearchIngredient.Click += new System.EventHandler(this.btnSearchIngredient_Click);
            // 
            // txtIngredient
            // 
            this.txtIngredient.Location = new System.Drawing.Point(148, 41);
            this.txtIngredient.Name = "txtIngredient";
            this.txtIngredient.Size = new System.Drawing.Size(262, 30);
            this.txtIngredient.TabIndex = 1;
            // 
            // lblIngredient
            // 
            this.lblIngredient.AutoSize = true;
            this.lblIngredient.Location = new System.Drawing.Point(40, 44);
            this.lblIngredient.Name = "lblIngredient";
            this.lblIngredient.Size = new System.Drawing.Size(98, 25);
            this.lblIngredient.TabIndex = 0;
            this.lblIngredient.Text = "Ingredient";
            // 
            // ColIngredientName
            // 
            this.ColIngredientName.DataPropertyName = "Ingredient";
            this.ColIngredientName.HeaderText = "Ingredient";
            this.ColIngredientName.MinimumWidth = 6;
            this.ColIngredientName.Name = "ColIngredientName";
            this.ColIngredientName.Width = 200;
            // 
            // ColStock
            // 
            this.ColStock.DataPropertyName = "Stock";
            this.ColStock.HeaderText = "Stock";
            this.ColStock.MinimumWidth = 6;
            this.ColStock.Name = "ColStock";
            this.ColStock.Width = 150;
            // 
            // ColIngredientEdit
            // 
            this.ColIngredientEdit.DataPropertyName = "Edit";
            this.ColIngredientEdit.HeaderText = "Action";
            this.ColIngredientEdit.MinimumWidth = 6;
            this.ColIngredientEdit.Name = "ColIngredientEdit";
            this.ColIngredientEdit.Text = "Edit";
            this.ColIngredientEdit.UseColumnTextForButtonValue = true;
            this.ColIngredientEdit.Width = 190;
            // 
            // ColIngredientDelete
            // 
            this.ColIngredientDelete.DataPropertyName = "Delete";
            this.ColIngredientDelete.HeaderText = "Action";
            this.ColIngredientDelete.MinimumWidth = 6;
            this.ColIngredientDelete.Name = "ColIngredientDelete";
            this.ColIngredientDelete.Text = "Delete";
            this.ColIngredientDelete.UseColumnTextForButtonValue = true;
            this.ColIngredientDelete.Width = 190;
            // 
            // Chef
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1082, 453);
            this.Controls.Add(this.gbCInventory);
            this.Controls.Add(this.tableSidebar_CInventory);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Chef";
            this.Text = "Chef";
            this.Load += new System.EventHandler(this.Chef_Load);
            this.tableSidebar_CInventory.ResumeLayout(false);
            this.tableSidebar_CInventory.PerformLayout();
            this.gbCInventory.ResumeLayout(false);
            this.gbCInventory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngredient)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_inventory;
        private System.Windows.Forms.Button btn_ChefProfile;
        private System.Windows.Forms.Button btn_CusOrder;
        private System.Windows.Forms.Label lbl_chef;
        private System.Windows.Forms.TableLayoutPanel tableSidebar_CInventory;
        private System.Windows.Forms.GroupBox gbCInventory;
        private System.Windows.Forms.Button btnResetIngredientSearch;
        private System.Windows.Forms.Button btnAddNewIngredient;
        private System.Windows.Forms.DataGridView dgvIngredient;
        private System.Windows.Forms.Button btnSearchIngredient;
        private System.Windows.Forms.TextBox txtIngredient;
        private System.Windows.Forms.Label lblIngredient;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColIngredientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColStock;
        private System.Windows.Forms.DataGridViewButtonColumn ColIngredientEdit;
        private System.Windows.Forms.DataGridViewButtonColumn ColIngredientDelete;
    }
}