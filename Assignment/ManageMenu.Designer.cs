namespace Assignment
{
    partial class MainManageMenu
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
            this.btnAddMenu = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnSearchMenu = new System.Windows.Forms.Button();
            this.gbMMenu = new System.Windows.Forms.GroupBox();
            this.btnResetMMenu = new System.Windows.Forms.Button();
            this.dgvMenu = new System.Windows.Forms.DataGridView();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.lblMenu = new System.Windows.Forms.Label();
            this.txtMenu = new System.Windows.Forms.TextBox();
            this.tableSidebar_MMenu = new System.Windows.Forms.TableLayoutPanel();
            this.btnMMenu_MMenu = new System.Windows.Forms.Button();
            this.btnMHall_MMenu = new System.Windows.Forms.Button();
            this.btn_HRReport_MMenu = new System.Windows.Forms.Button();
            this.btnUProfile_MMenu = new System.Windows.Forms.Button();
            this.ColMenuItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMenuImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.ColMenuPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColMenuCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColMenuAction = new System.Windows.Forms.DataGridViewButtonColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.gbMMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).BeginInit();
            this.tableSidebar_MMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddMenu
            // 
            this.btnAddMenu.Location = new System.Drawing.Point(45, 325);
            this.btnAddMenu.Name = "btnAddMenu";
            this.btnAddMenu.Size = new System.Drawing.Size(343, 34);
            this.btnAddMenu.TabIndex = 0;
            this.btnAddMenu.Text = "Add New Menu Item";
            this.btnAddMenu.UseVisualStyleBackColor = true;
            this.btnAddMenu.Click += new System.EventHandler(this.btnAddMenu_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(172, 195);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Delete";
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
            // btnSearchMenu
            // 
            this.btnSearchMenu.Location = new System.Drawing.Point(299, 39);
            this.btnSearchMenu.Name = "btnSearchMenu";
            this.btnSearchMenu.Size = new System.Drawing.Size(106, 35);
            this.btnSearchMenu.TabIndex = 3;
            this.btnSearchMenu.Text = "Search";
            this.btnSearchMenu.UseVisualStyleBackColor = true;
            this.btnSearchMenu.Click += new System.EventHandler(this.btnSearchMenu_Click);
            // 
            // gbMMenu
            // 
            this.gbMMenu.Controls.Add(this.btnResetMMenu);
            this.gbMMenu.Controls.Add(this.dgvMenu);
            this.gbMMenu.Controls.Add(this.lblCategory);
            this.gbMMenu.Controls.Add(this.cmbCategory);
            this.gbMMenu.Controls.Add(this.lblMenu);
            this.gbMMenu.Controls.Add(this.txtMenu);
            this.gbMMenu.Controls.Add(this.button3);
            this.gbMMenu.Controls.Add(this.button2);
            this.gbMMenu.Controls.Add(this.btnSearchMenu);
            this.gbMMenu.Controls.Add(this.btnAddMenu);
            this.gbMMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbMMenu.Location = new System.Drawing.Point(218, 71);
            this.gbMMenu.Name = "gbMMenu";
            this.gbMMenu.Size = new System.Drawing.Size(752, 370);
            this.gbMMenu.TabIndex = 1;
            this.gbMMenu.TabStop = false;
            this.gbMMenu.Text = "Manage Menu";
            // 
            // btnResetMMenu
            // 
            this.btnResetMMenu.Location = new System.Drawing.Point(394, 325);
            this.btnResetMMenu.Name = "btnResetMMenu";
            this.btnResetMMenu.Size = new System.Drawing.Size(335, 34);
            this.btnResetMMenu.TabIndex = 9;
            this.btnResetMMenu.Text = "Reset Search Menu Item";
            this.btnResetMMenu.UseVisualStyleBackColor = true;
            this.btnResetMMenu.Click += new System.EventHandler(this.btnResetMMenu_Click);
            // 
            // dgvMenu
            // 
            this.dgvMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMenu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColMenuItem,
            this.colMenuImage,
            this.ColMenuPrice,
            this.ColMenuCategory,
            this.ColMenuAction});
            this.dgvMenu.Location = new System.Drawing.Point(45, 95);
            this.dgvMenu.Name = "dgvMenu";
            this.dgvMenu.RowHeadersWidth = 51;
            this.dgvMenu.RowTemplate.Height = 24;
            this.dgvMenu.Size = new System.Drawing.Size(684, 216);
            this.dgvMenu.TabIndex = 8;
            this.dgvMenu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMenu_CellContentClick);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(455, 44);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(92, 25);
            this.lblCategory.TabIndex = 7;
            this.lblCategory.Text = "Category";
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Items.AddRange(new object[] {
            "Appetizer",
            "Main Dish",
            "Side Dish",
            "Beverage",
            "Dessert"});
            this.cmbCategory.Location = new System.Drawing.Point(553, 41);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(176, 33);
            this.cmbCategory.TabIndex = 6;
            this.cmbCategory.SelectedIndexChanged += new System.EventHandler(this.cmbCategory_SelectedIndexChanged);
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.Location = new System.Drawing.Point(40, 44);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(104, 25);
            this.lblMenu.TabIndex = 5;
            this.lblMenu.Text = "Menu Item";
            // 
            // txtMenu
            // 
            this.txtMenu.Location = new System.Drawing.Point(150, 41);
            this.txtMenu.Name = "txtMenu";
            this.txtMenu.Size = new System.Drawing.Size(143, 30);
            this.txtMenu.TabIndex = 4;
            // 
            // tableSidebar_MMenu
            // 
            this.tableSidebar_MMenu.ColumnCount = 1;
            this.tableSidebar_MMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableSidebar_MMenu.Controls.Add(this.btnMMenu_MMenu, 0, 1);
            this.tableSidebar_MMenu.Controls.Add(this.btnMHall_MMenu, 0, 2);
            this.tableSidebar_MMenu.Controls.Add(this.btn_HRReport_MMenu, 0, 3);
            this.tableSidebar_MMenu.Controls.Add(this.btnUProfile_MMenu, 0, 4);
            this.tableSidebar_MMenu.Location = new System.Drawing.Point(12, 12);
            this.tableSidebar_MMenu.Name = "tableSidebar_MMenu";
            this.tableSidebar_MMenu.RowCount = 6;
            this.tableSidebar_MMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableSidebar_MMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableSidebar_MMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableSidebar_MMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableSidebar_MMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableSidebar_MMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableSidebar_MMenu.Size = new System.Drawing.Size(200, 430);
            this.tableSidebar_MMenu.TabIndex = 2;
            // 
            // btnMMenu_MMenu
            // 
            this.btnMMenu_MMenu.FlatAppearance.BorderSize = 0;
            this.btnMMenu_MMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMMenu_MMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMMenu_MMenu.Location = new System.Drawing.Point(3, 63);
            this.btnMMenu_MMenu.Name = "btnMMenu_MMenu";
            this.btnMMenu_MMenu.Size = new System.Drawing.Size(194, 34);
            this.btnMMenu_MMenu.TabIndex = 0;
            this.btnMMenu_MMenu.Text = "Manage Menu";
            this.btnMMenu_MMenu.UseVisualStyleBackColor = true;
            this.btnMMenu_MMenu.Click += new System.EventHandler(this.btnMMenu_MMenu_Click);
            // 
            // btnMHall_MMenu
            // 
            this.btnMHall_MMenu.FlatAppearance.BorderSize = 0;
            this.btnMHall_MMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMHall_MMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMHall_MMenu.Location = new System.Drawing.Point(3, 103);
            this.btnMHall_MMenu.Name = "btnMHall_MMenu";
            this.btnMHall_MMenu.Size = new System.Drawing.Size(194, 34);
            this.btnMHall_MMenu.TabIndex = 1;
            this.btnMHall_MMenu.Text = "Manage Hall";
            this.btnMHall_MMenu.UseVisualStyleBackColor = true;
            this.btnMHall_MMenu.Click += new System.EventHandler(this.btnMHall_MMenu_Click);
            // 
            // btn_HRReport_MMenu
            // 
            this.btn_HRReport_MMenu.FlatAppearance.BorderSize = 0;
            this.btn_HRReport_MMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_HRReport_MMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_HRReport_MMenu.Location = new System.Drawing.Point(3, 143);
            this.btn_HRReport_MMenu.Name = "btn_HRReport_MMenu";
            this.btn_HRReport_MMenu.Size = new System.Drawing.Size(194, 64);
            this.btn_HRReport_MMenu.TabIndex = 2;
            this.btn_HRReport_MMenu.Text = "Hall Reservation Report";
            this.btn_HRReport_MMenu.UseVisualStyleBackColor = true;
            this.btn_HRReport_MMenu.Click += new System.EventHandler(this.btn_HRReport_MMenu_Click);
            // 
            // btnUProfile_MMenu
            // 
            this.btnUProfile_MMenu.FlatAppearance.BorderSize = 0;
            this.btnUProfile_MMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUProfile_MMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUProfile_MMenu.Location = new System.Drawing.Point(3, 213);
            this.btnUProfile_MMenu.Name = "btnUProfile_MMenu";
            this.btnUProfile_MMenu.Size = new System.Drawing.Size(194, 34);
            this.btnUProfile_MMenu.TabIndex = 3;
            this.btnUProfile_MMenu.Text = "Update Profile";
            this.btnUProfile_MMenu.UseVisualStyleBackColor = true;
            this.btnUProfile_MMenu.Click += new System.EventHandler(this.btnUProfile_MMenu_Click);
            // 
            // ColMenuItem
            // 
            this.ColMenuItem.DataPropertyName = "Item";
            this.ColMenuItem.HeaderText = "Menu Item";
            this.ColMenuItem.MinimumWidth = 6;
            this.ColMenuItem.Name = "ColMenuItem";
            this.ColMenuItem.Width = 140;
            // 
            // colMenuImage
            // 
            this.colMenuImage.HeaderText = "Image";
            this.colMenuImage.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.colMenuImage.MinimumWidth = 6;
            this.colMenuImage.Name = "colMenuImage";
            this.colMenuImage.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colMenuImage.Width = 125;
            // 
            // ColMenuPrice
            // 
            this.ColMenuPrice.DataPropertyName = "Price";
            this.ColMenuPrice.HeaderText = "Price";
            this.ColMenuPrice.MinimumWidth = 6;
            this.ColMenuPrice.Name = "ColMenuPrice";
            this.ColMenuPrice.Width = 110;
            // 
            // ColMenuCategory
            // 
            this.ColMenuCategory.DataPropertyName = "Category";
            this.ColMenuCategory.HeaderText = "Category";
            this.ColMenuCategory.MinimumWidth = 6;
            this.ColMenuCategory.Name = "ColMenuCategory";
            this.ColMenuCategory.Width = 125;
            // 
            // ColMenuAction
            // 
            this.ColMenuAction.HeaderText = "Action";
            this.ColMenuAction.MinimumWidth = 6;
            this.ColMenuAction.Name = "ColMenuAction";
            this.ColMenuAction.Width = 130;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(350, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            // 
            // MainManageMenu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(982, 453);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tableSidebar_MMenu);
            this.Controls.Add(this.gbMMenu);
            this.Name = "MainManageMenu";
            this.Text = "ManageMenu";
            this.Load += new System.EventHandler(this.MainManageMenu_Load);
            this.gbMMenu.ResumeLayout(false);
            this.gbMMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).EndInit();
            this.tableSidebar_MMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAddMenu;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnSearchMenu;
        private System.Windows.Forms.GroupBox gbMMenu;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.TextBox txtMenu;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.TableLayoutPanel tableSidebar_MMenu;
        private System.Windows.Forms.DataGridView dgvMenu;
        private System.Windows.Forms.Button btnMMenu_MMenu;
        private System.Windows.Forms.Button btnMHall_MMenu;
        private System.Windows.Forms.Button btn_HRReport_MMenu;
        private System.Windows.Forms.Button btnUProfile_MMenu;
        private System.Windows.Forms.Button btnResetMMenu;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMenuItem;
        private System.Windows.Forms.DataGridViewImageColumn colMenuImage;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMenuPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMenuCategory;
        private System.Windows.Forms.DataGridViewButtonColumn ColMenuAction;
        private System.Windows.Forms.Button button1;
    }
}