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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Chef));
            this.btn_inventory = new System.Windows.Forms.Button();
            this.btn_ChefProfile = new System.Windows.Forms.Button();
            this.btn_CusOrder = new System.Windows.Forms.Button();
            this.lbl_chef = new System.Windows.Forms.Label();
            this.tableSidebar_CInventory = new System.Windows.Forms.TableLayoutPanel();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.gbCInventory = new System.Windows.Forms.GroupBox();
            this.btnResetIngredientSearch = new System.Windows.Forms.Button();
            this.btnAddNewIngredient = new System.Windows.Forms.Button();
            this.dgvIngredient = new System.Windows.Forms.DataGridView();
            this.ColIngredientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColIngredientEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColIngredientDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnSearchIngredient = new System.Windows.Forms.Button();
            this.txtIngredient = new System.Windows.Forms.TextBox();
            this.lblIngredient = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pic_logo = new System.Windows.Forms.PictureBox();
            this.tableSidebar_CInventory.SuspendLayout();
            this.gbCInventory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngredient)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_inventory
            // 
            this.btn_inventory.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_inventory.FlatAppearance.BorderSize = 0;
            this.btn_inventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_inventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_inventory.Image = ((System.Drawing.Image)(resources.GetObject("btn_inventory.Image")));
            this.btn_inventory.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_inventory.Location = new System.Drawing.Point(3, 152);
            this.btn_inventory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_inventory.Name = "btn_inventory";
            this.btn_inventory.Size = new System.Drawing.Size(230, 41);
            this.btn_inventory.TabIndex = 0;
            this.btn_inventory.Text = "Manage Inventory";
            this.btn_inventory.UseVisualStyleBackColor = false;
            this.btn_inventory.Click += new System.EventHandler(this.btn_inventory_Click);
            // 
            // btn_ChefProfile
            // 
            this.btn_ChefProfile.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_ChefProfile.FlatAppearance.BorderSize = 0;
            this.btn_ChefProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ChefProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ChefProfile.Image = ((System.Drawing.Image)(resources.GetObject("btn_ChefProfile.Image")));
            this.btn_ChefProfile.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_ChefProfile.Location = new System.Drawing.Point(3, 242);
            this.btn_ChefProfile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_ChefProfile.Name = "btn_ChefProfile";
            this.btn_ChefProfile.Size = new System.Drawing.Size(230, 41);
            this.btn_ChefProfile.TabIndex = 2;
            this.btn_ChefProfile.Text = "Chef Profile";
            this.btn_ChefProfile.UseVisualStyleBackColor = false;
            this.btn_ChefProfile.Click += new System.EventHandler(this.btn_ChefProfile_Click);
            // 
            // btn_CusOrder
            // 
            this.btn_CusOrder.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_CusOrder.FlatAppearance.BorderSize = 0;
            this.btn_CusOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CusOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CusOrder.Image = ((System.Drawing.Image)(resources.GetObject("btn_CusOrder.Image")));
            this.btn_CusOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_CusOrder.Location = new System.Drawing.Point(3, 197);
            this.btn_CusOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_CusOrder.Name = "btn_CusOrder";
            this.btn_CusOrder.Size = new System.Drawing.Size(230, 41);
            this.btn_CusOrder.TabIndex = 1;
            this.btn_CusOrder.Text = "Customer\'s Orders";
            this.btn_CusOrder.UseVisualStyleBackColor = false;
            this.btn_CusOrder.Click += new System.EventHandler(this.btn_CusOrder_Click);
            // 
            // lbl_chef
            // 
            this.lbl_chef.AutoSize = true;
            this.lbl_chef.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_chef.Location = new System.Drawing.Point(0, 0);
            this.lbl_chef.Name = "lbl_chef";
            this.lbl_chef.Size = new System.Drawing.Size(93, 39);
            this.lbl_chef.TabIndex = 3;
            this.lbl_chef.Text = "Chef";
            // 
            // tableSidebar_CInventory
            // 
            this.tableSidebar_CInventory.BackColor = System.Drawing.Color.SandyBrown;
            this.tableSidebar_CInventory.ColumnCount = 1;
            this.tableSidebar_CInventory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableSidebar_CInventory.Controls.Add(this.btnLogOut, 0, 4);
            this.tableSidebar_CInventory.Controls.Add(this.btn_inventory, 0, 1);
            this.tableSidebar_CInventory.Controls.Add(this.btn_CusOrder, 0, 2);
            this.tableSidebar_CInventory.Controls.Add(this.btn_ChefProfile, 0, 3);
            this.tableSidebar_CInventory.Controls.Add(this.panel2, 0, 0);
            this.tableSidebar_CInventory.Location = new System.Drawing.Point(12, -1);
            this.tableSidebar_CInventory.Name = "tableSidebar_CInventory";
            this.tableSidebar_CInventory.RowCount = 6;
            this.tableSidebar_CInventory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableSidebar_CInventory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableSidebar_CInventory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableSidebar_CInventory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableSidebar_CInventory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableSidebar_CInventory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableSidebar_CInventory.Size = new System.Drawing.Size(236, 452);
            this.tableSidebar_CInventory.TabIndex = 5;
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.Gainsboro;
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.Image = ((System.Drawing.Image)(resources.GetObject("btnLogOut.Image")));
            this.btnLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogOut.Location = new System.Drawing.Point(3, 288);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(230, 39);
            this.btnLogOut.TabIndex = 16;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // gbCInventory
            // 
            this.gbCInventory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.gbCInventory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gbCInventory.Controls.Add(this.btnResetIngredientSearch);
            this.gbCInventory.Controls.Add(this.btnAddNewIngredient);
            this.gbCInventory.Controls.Add(this.dgvIngredient);
            this.gbCInventory.Controls.Add(this.btnSearchIngredient);
            this.gbCInventory.Controls.Add(this.txtIngredient);
            this.gbCInventory.Controls.Add(this.lblIngredient);
            this.gbCInventory.Location = new System.Drawing.Point(232, 62);
            this.gbCInventory.Name = "gbCInventory";
            this.gbCInventory.Size = new System.Drawing.Size(810, 362);
            this.gbCInventory.TabIndex = 6;
            this.gbCInventory.TabStop = false;
            this.gbCInventory.Text = "Manage Inventory";
            // 
            // btnResetIngredientSearch
            // 
            this.btnResetIngredientSearch.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnResetIngredientSearch.Location = new System.Drawing.Point(414, 320);
            this.btnResetIngredientSearch.Name = "btnResetIngredientSearch";
            this.btnResetIngredientSearch.Size = new System.Drawing.Size(372, 35);
            this.btnResetIngredientSearch.TabIndex = 5;
            this.btnResetIngredientSearch.Text = "Reset Search Ingredient";
            this.btnResetIngredientSearch.Click += new System.EventHandler(this.btnResetIngredientSearch_Click);
            // 
            // btnAddNewIngredient
            // 
            this.btnAddNewIngredient.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAddNewIngredient.Location = new System.Drawing.Point(19, 320);
            this.btnAddNewIngredient.Name = "btnAddNewIngredient";
            this.btnAddNewIngredient.Size = new System.Drawing.Size(370, 35);
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
            this.dgvIngredient.Location = new System.Drawing.Point(19, 98);
            this.dgvIngredient.Name = "dgvIngredient";
            this.dgvIngredient.RowHeadersWidth = 51;
            this.dgvIngredient.RowTemplate.Height = 24;
            this.dgvIngredient.Size = new System.Drawing.Size(767, 216);
            this.dgvIngredient.TabIndex = 3;
            this.dgvIngredient.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvIngredient_CellContentClick);
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
            // btnSearchIngredient
            // 
            this.btnSearchIngredient.Location = new System.Drawing.Point(461, 41);
            this.btnSearchIngredient.Name = "btnSearchIngredient";
            this.btnSearchIngredient.Size = new System.Drawing.Size(106, 35);
            this.btnSearchIngredient.TabIndex = 2;
            this.btnSearchIngredient.Text = "Search";
            this.btnSearchIngredient.UseVisualStyleBackColor = true;
            this.btnSearchIngredient.Click += new System.EventHandler(this.btnSearchIngredient_Click);
            // 
            // txtIngredient
            // 
            this.txtIngredient.Location = new System.Drawing.Point(193, 43);
            this.txtIngredient.Name = "txtIngredient";
            this.txtIngredient.Size = new System.Drawing.Size(262, 30);
            this.txtIngredient.TabIndex = 1;
            // 
            // lblIngredient
            // 
            this.lblIngredient.AutoSize = true;
            this.lblIngredient.Location = new System.Drawing.Point(85, 46);
            this.lblIngredient.Name = "lblIngredient";
            this.lblIngredient.Size = new System.Drawing.Size(98, 25);
            this.lblIngredient.TabIndex = 0;
            this.lblIngredient.Text = "Ingredient";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.gbCInventory);
            this.panel1.Location = new System.Drawing.Point(22, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1054, 452);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pic_logo);
            this.panel2.Controls.Add(this.lbl_chef);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(230, 144);
            this.panel2.TabIndex = 17;
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
            // Chef
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(237)))), ((int)(((byte)(225)))));
            this.ClientSize = new System.Drawing.Size(1082, 453);
            this.Controls.Add(this.tableSidebar_CInventory);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Chef";
            this.Text = "ChefInventory";
            this.Load += new System.EventHandler(this.Chef_Load);
            this.tableSidebar_CInventory.ResumeLayout(false);
            this.gbCInventory.ResumeLayout(false);
            this.gbCInventory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngredient)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).EndInit();
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
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pic_logo;
    }
}