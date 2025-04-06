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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainManageMenu));
            this.btnAddMenu = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnSearchMenu = new System.Windows.Forms.Button();
            this.gbMMenu = new System.Windows.Forms.GroupBox();
            this.btnResetMMenu = new System.Windows.Forms.Button();
            this.dgvMenu = new System.Windows.Forms.DataGridView();
            this.ColMenuItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMenuImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.ColMenuPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColMenuCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColMenuEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColMenuDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.lblMenu = new System.Windows.Forms.Label();
            this.txtMenu = new System.Windows.Forms.TextBox();
            this.tableSidebar_MMenu = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pic_logo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMMenu_MMenu = new System.Windows.Forms.Button();
            this.btnMHall_MMenu = new System.Windows.Forms.Button();
            this.btn_HRReport_MMenu = new System.Windows.Forms.Button();
            this.btnUProfile_MMenu = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gbMMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).BeginInit();
            this.tableSidebar_MMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddMenu
            // 
            this.btnAddMenu.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMenu.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnAddMenu.Location = new System.Drawing.Point(64, 369);
            this.btnAddMenu.Name = "btnAddMenu";
            this.btnAddMenu.Size = new System.Drawing.Size(390, 34);
            this.btnAddMenu.TabIndex = 0;
            this.btnAddMenu.Text = "Add New Menu Item";
            this.btnAddMenu.UseVisualStyleBackColor = true;
            this.btnAddMenu.Click += new System.EventHandler(this.btnAddMenu_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(191, 239);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Delete";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(318, 239);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Update";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnSearchMenu
            // 
            this.btnSearchMenu.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchMenu.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnSearchMenu.Location = new System.Drawing.Point(391, 83);
            this.btnSearchMenu.Name = "btnSearchMenu";
            this.btnSearchMenu.Size = new System.Drawing.Size(133, 35);
            this.btnSearchMenu.TabIndex = 3;
            this.btnSearchMenu.Text = "Search";
            this.btnSearchMenu.UseVisualStyleBackColor = true;
            this.btnSearchMenu.Click += new System.EventHandler(this.btnSearchMenu_Click);
            // 
            // gbMMenu
            // 
            this.gbMMenu.BackColor = System.Drawing.Color.Transparent;
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
            this.gbMMenu.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbMMenu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbMMenu.Location = new System.Drawing.Point(3, 14);
            this.gbMMenu.Name = "gbMMenu";
            this.gbMMenu.Size = new System.Drawing.Size(900, 462);
            this.gbMMenu.TabIndex = 1;
            this.gbMMenu.TabStop = false;
            this.gbMMenu.Text = "Manage Menu";
            // 
            // btnResetMMenu
            // 
            this.btnResetMMenu.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetMMenu.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnResetMMenu.Location = new System.Drawing.Point(465, 369);
            this.btnResetMMenu.Name = "btnResetMMenu";
            this.btnResetMMenu.Size = new System.Drawing.Size(390, 34);
            this.btnResetMMenu.TabIndex = 9;
            this.btnResetMMenu.Text = "Reset Search Menu Item";
            this.btnResetMMenu.UseVisualStyleBackColor = true;
            this.btnResetMMenu.Click += new System.EventHandler(this.btnResetMMenu_Click);
            // 
            // dgvMenu
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMenu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMenu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColMenuItem,
            this.colMenuImage,
            this.ColMenuPrice,
            this.ColMenuCategory,
            this.ColMenuEdit,
            this.ColMenuDelete});
            this.dgvMenu.Location = new System.Drawing.Point(64, 139);
            this.dgvMenu.Name = "dgvMenu";
            this.dgvMenu.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dgvMenu.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMenu.RowTemplate.Height = 60;
            this.dgvMenu.Size = new System.Drawing.Size(791, 216);
            this.dgvMenu.TabIndex = 8;
            this.dgvMenu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMenu_CellContentClick);
            this.dgvMenu.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvMenu_CellFormatting);
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
            this.colMenuImage.DataPropertyName = "Image";
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
            // ColMenuEdit
            // 
            this.ColMenuEdit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColMenuEdit.DataPropertyName = "Edit";
            this.ColMenuEdit.HeaderText = "Action";
            this.ColMenuEdit.MinimumWidth = 6;
            this.ColMenuEdit.Name = "ColMenuEdit";
            this.ColMenuEdit.Text = "Edit";
            this.ColMenuEdit.UseColumnTextForButtonValue = true;
            this.ColMenuEdit.Width = 105;
            // 
            // ColMenuDelete
            // 
            this.ColMenuDelete.HeaderText = "Action";
            this.ColMenuDelete.MinimumWidth = 6;
            this.ColMenuDelete.Name = "ColMenuDelete";
            this.ColMenuDelete.Text = "Delete";
            this.ColMenuDelete.UseColumnTextForButtonValue = true;
            this.ColMenuDelete.Width = 115;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(542, 88);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(99, 25);
            this.lblCategory.TabIndex = 7;
            this.lblCategory.Text = "Category";
            // 
            // cmbCategory
            // 
            this.cmbCategory.BackColor = System.Drawing.Color.Silver;
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Items.AddRange(new object[] {
            "All",
            "Appetizer",
            "Main Dish",
            "Side ",
            "Beverage",
            "Dessert"});
            this.cmbCategory.Location = new System.Drawing.Point(640, 85);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(215, 33);
            this.cmbCategory.TabIndex = 6;
            this.cmbCategory.SelectedIndexChanged += new System.EventHandler(this.cmbCategory_SelectedIndexChanged);
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.Location = new System.Drawing.Point(40, 88);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(123, 25);
            this.lblMenu.TabIndex = 5;
            this.lblMenu.Text = "Menu Item";
            // 
            // txtMenu
            // 
            this.txtMenu.BackColor = System.Drawing.Color.Silver;
            this.txtMenu.Location = new System.Drawing.Point(169, 85);
            this.txtMenu.Name = "txtMenu";
            this.txtMenu.Size = new System.Drawing.Size(216, 32);
            this.txtMenu.TabIndex = 4;
            // 
            // tableSidebar_MMenu
            // 
            this.tableSidebar_MMenu.BackColor = System.Drawing.Color.Tomato;
            this.tableSidebar_MMenu.ColumnCount = 1;
            this.tableSidebar_MMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableSidebar_MMenu.Controls.Add(this.panel1, 0, 0);
            this.tableSidebar_MMenu.Controls.Add(this.btnMMenu_MMenu, 0, 1);
            this.tableSidebar_MMenu.Controls.Add(this.btnMHall_MMenu, 0, 2);
            this.tableSidebar_MMenu.Controls.Add(this.btn_HRReport_MMenu, 0, 3);
            this.tableSidebar_MMenu.Controls.Add(this.btnUProfile_MMenu, 0, 4);
            this.tableSidebar_MMenu.Controls.Add(this.btnLogOut, 0, 5);
            this.tableSidebar_MMenu.Location = new System.Drawing.Point(12, -2);
            this.tableSidebar_MMenu.Name = "tableSidebar_MMenu";
            this.tableSidebar_MMenu.RowCount = 7;
            this.tableSidebar_MMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableSidebar_MMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableSidebar_MMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableSidebar_MMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableSidebar_MMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableSidebar_MMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableSidebar_MMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableSidebar_MMenu.Size = new System.Drawing.Size(200, 462);
            this.tableSidebar_MMenu.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pic_logo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(194, 144);
            this.panel1.TabIndex = 18;
            // 
            // pic_logo
            // 
            this.pic_logo.Image = ((System.Drawing.Image)(resources.GetObject("pic_logo.Image")));
            this.pic_logo.Location = new System.Drawing.Point(0, 42);
            this.pic_logo.Name = "pic_logo";
            this.pic_logo.Size = new System.Drawing.Size(138, 102);
            this.pic_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pic_logo.TabIndex = 8;
            this.pic_logo.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-12, -13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 67);
            this.label1.TabIndex = 9;
            this.label1.Text = "Manager";
            // 
            // btnMMenu_MMenu
            // 
            this.btnMMenu_MMenu.BackColor = System.Drawing.Color.Gainsboro;
            this.btnMMenu_MMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMMenu_MMenu.FlatAppearance.BorderSize = 0;
            this.btnMMenu_MMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMMenu_MMenu.Font = new System.Drawing.Font("Gadugi", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMMenu_MMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMMenu_MMenu.Image")));
            this.btnMMenu_MMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMMenu_MMenu.Location = new System.Drawing.Point(3, 153);
            this.btnMMenu_MMenu.Name = "btnMMenu_MMenu";
            this.btnMMenu_MMenu.Size = new System.Drawing.Size(194, 34);
            this.btnMMenu_MMenu.TabIndex = 0;
            this.btnMMenu_MMenu.Text = "Manage Menu";
            this.btnMMenu_MMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnMMenu_MMenu.UseVisualStyleBackColor = false;
            this.btnMMenu_MMenu.Click += new System.EventHandler(this.btnMMenu_MMenu_Click);
            // 
            // btnMHall_MMenu
            // 
            this.btnMHall_MMenu.BackColor = System.Drawing.Color.Gainsboro;
            this.btnMHall_MMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMHall_MMenu.FlatAppearance.BorderSize = 0;
            this.btnMHall_MMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMHall_MMenu.Font = new System.Drawing.Font("Gadugi", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMHall_MMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMHall_MMenu.Image")));
            this.btnMHall_MMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMHall_MMenu.Location = new System.Drawing.Point(3, 193);
            this.btnMHall_MMenu.Name = "btnMHall_MMenu";
            this.btnMHall_MMenu.Size = new System.Drawing.Size(194, 34);
            this.btnMHall_MMenu.TabIndex = 1;
            this.btnMHall_MMenu.Text = "Manage Hall";
            this.btnMHall_MMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnMHall_MMenu.UseVisualStyleBackColor = false;
            this.btnMHall_MMenu.Click += new System.EventHandler(this.btnMHall_MMenu_Click);
            // 
            // btn_HRReport_MMenu
            // 
            this.btn_HRReport_MMenu.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_HRReport_MMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_HRReport_MMenu.FlatAppearance.BorderSize = 0;
            this.btn_HRReport_MMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_HRReport_MMenu.Font = new System.Drawing.Font("Gadugi", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_HRReport_MMenu.Image = ((System.Drawing.Image)(resources.GetObject("btn_HRReport_MMenu.Image")));
            this.btn_HRReport_MMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_HRReport_MMenu.Location = new System.Drawing.Point(3, 233);
            this.btn_HRReport_MMenu.Name = "btn_HRReport_MMenu";
            this.btn_HRReport_MMenu.Size = new System.Drawing.Size(194, 64);
            this.btn_HRReport_MMenu.TabIndex = 2;
            this.btn_HRReport_MMenu.Text = "Hall Reservation Report";
            this.btn_HRReport_MMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_HRReport_MMenu.UseVisualStyleBackColor = false;
            this.btn_HRReport_MMenu.Click += new System.EventHandler(this.btn_HRReport_MMenu_Click);
            // 
            // btnUProfile_MMenu
            // 
            this.btnUProfile_MMenu.BackColor = System.Drawing.Color.Gainsboro;
            this.btnUProfile_MMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUProfile_MMenu.FlatAppearance.BorderSize = 0;
            this.btnUProfile_MMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUProfile_MMenu.Font = new System.Drawing.Font("Gadugi", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUProfile_MMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnUProfile_MMenu.Image")));
            this.btnUProfile_MMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUProfile_MMenu.Location = new System.Drawing.Point(3, 303);
            this.btnUProfile_MMenu.Name = "btnUProfile_MMenu";
            this.btnUProfile_MMenu.Size = new System.Drawing.Size(194, 34);
            this.btnUProfile_MMenu.TabIndex = 3;
            this.btnUProfile_MMenu.Text = "Manager Profile";
            this.btnUProfile_MMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnUProfile_MMenu.UseVisualStyleBackColor = false;
            this.btnUProfile_MMenu.Click += new System.EventHandler(this.btnUProfile_MMenu_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.Gainsboro;
            this.btnLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Gadugi", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.Image = ((System.Drawing.Image)(resources.GetObject("btnLogOut.Image")));
            this.btnLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogOut.Location = new System.Drawing.Point(3, 343);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(194, 34);
            this.btnLogOut.TabIndex = 5;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.gbMMenu);
            this.panel2.Location = new System.Drawing.Point(198, -2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(884, 462);
            this.panel2.TabIndex = 3;
            // 
            // MainManageMenu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(237)))), ((int)(((byte)(225)))));
            this.ClientSize = new System.Drawing.Size(1082, 453);
            this.Controls.Add(this.tableSidebar_MMenu);
            this.Controls.Add(this.panel2);
            this.DoubleBuffered = true;
            this.Name = "MainManageMenu";
            this.Text = "ManageMenu";
            this.Load += new System.EventHandler(this.MainManageMenu_Load);
            this.gbMMenu.ResumeLayout(false);
            this.gbMMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).EndInit();
            this.tableSidebar_MMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).EndInit();
            this.panel2.ResumeLayout(false);
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
        private System.Windows.Forms.DataGridViewButtonColumn ColMenuEdit;
        private System.Windows.Forms.DataGridViewButtonColumn ColMenuDelete;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pic_logo;
        private System.Windows.Forms.Panel panel2;
    }
}