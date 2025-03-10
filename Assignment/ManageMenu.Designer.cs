namespace Assignment
{
    partial class ManageMenu
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
            this.txtMenu = new System.Windows.Forms.TextBox();
            this.lblMenu = new System.Windows.Forms.Label();
            this.tableSidebar_MMenu = new System.Windows.Forms.TableLayoutPanel();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.dgvMenu = new System.Windows.Forms.DataGridView();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Action = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnMMenu_MMenu = new System.Windows.Forms.Button();
            this.btnMHall_MMenu = new System.Windows.Forms.Button();
            this.btn_HallResvReport_MMenu = new System.Windows.Forms.Button();
            this.btnUpdateProfile_MMenu = new System.Windows.Forms.Button();
            this.gbMMenu.SuspendLayout();
            this.tableSidebar_MMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddMenu
            // 
            this.btnAddMenu.Location = new System.Drawing.Point(45, 327);
            this.btnAddMenu.Name = "btnAddMenu";
            this.btnAddMenu.Size = new System.Drawing.Size(219, 34);
            this.btnAddMenu.TabIndex = 0;
            this.btnAddMenu.Text = "Add New Menu Item";
            this.btnAddMenu.UseVisualStyleBackColor = true;
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
            // 
            // gbMMenu
            // 
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
            // txtMenu
            // 
            this.txtMenu.Location = new System.Drawing.Point(150, 41);
            this.txtMenu.Name = "txtMenu";
            this.txtMenu.Size = new System.Drawing.Size(143, 30);
            this.txtMenu.TabIndex = 4;
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
            // tableSidebar_MMenu
            // 
            this.tableSidebar_MMenu.ColumnCount = 1;
            this.tableSidebar_MMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableSidebar_MMenu.Controls.Add(this.btnMMenu_MMenu, 0, 1);
            this.tableSidebar_MMenu.Controls.Add(this.btnMHall_MMenu, 0, 2);
            this.tableSidebar_MMenu.Controls.Add(this.btn_HallResvReport_MMenu, 0, 3);
            this.tableSidebar_MMenu.Controls.Add(this.btnUpdateProfile_MMenu, 0, 4);
            this.tableSidebar_MMenu.Location = new System.Drawing.Point(12, 12);
            this.tableSidebar_MMenu.Name = "tableSidebar_MMenu";
            this.tableSidebar_MMenu.RowCount = 6;
            this.tableSidebar_MMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableSidebar_MMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableSidebar_MMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableSidebar_MMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableSidebar_MMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableSidebar_MMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableSidebar_MMenu.Size = new System.Drawing.Size(200, 430);
            this.tableSidebar_MMenu.TabIndex = 2;
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(553, 41);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(176, 33);
            this.cmbCategory.TabIndex = 6;
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
            // dgvMenu
            // 
            this.dgvMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMenu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name,
            this.Price,
            this.Category,
            this.Action});
            this.dgvMenu.Location = new System.Drawing.Point(45, 95);
            this.dgvMenu.Name = "dgvMenu";
            this.dgvMenu.RowHeadersWidth = 51;
            this.dgvMenu.RowTemplate.Height = 24;
            this.dgvMenu.Size = new System.Drawing.Size(684, 216);
            this.dgvMenu.TabIndex = 8;
            // 
            // Name
            // 
            this.Name.HeaderText = "Name";
            this.Name.MinimumWidth = 6;
            this.Name.Name = "Name";
            this.Name.Width = 182;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.Width = 125;
            // 
            // Category
            // 
            this.Category.HeaderText = "Category";
            this.Category.MinimumWidth = 6;
            this.Category.Name = "Category";
            this.Category.Width = 160;
            // 
            // Action
            // 
            this.Action.HeaderText = "Action";
            this.Action.MinimumWidth = 6;
            this.Action.Name = "Action";
            this.Action.Width = 165;
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
            // 
            // btn_HallResvReport_MMenu
            // 
            this.btn_HallResvReport_MMenu.FlatAppearance.BorderSize = 0;
            this.btn_HallResvReport_MMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_HallResvReport_MMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_HallResvReport_MMenu.Location = new System.Drawing.Point(3, 143);
            this.btn_HallResvReport_MMenu.Name = "btn_HallResvReport_MMenu";
            this.btn_HallResvReport_MMenu.Size = new System.Drawing.Size(194, 34);
            this.btn_HallResvReport_MMenu.TabIndex = 2;
            this.btn_HallResvReport_MMenu.Text = "Hall Resv Report";
            this.btn_HallResvReport_MMenu.UseVisualStyleBackColor = true;
            // 
            // btnUpdateProfile_MMenu
            // 
            this.btnUpdateProfile_MMenu.FlatAppearance.BorderSize = 0;
            this.btnUpdateProfile_MMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateProfile_MMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateProfile_MMenu.Location = new System.Drawing.Point(3, 183);
            this.btnUpdateProfile_MMenu.Name = "btnUpdateProfile_MMenu";
            this.btnUpdateProfile_MMenu.Size = new System.Drawing.Size(194, 34);
            this.btnUpdateProfile_MMenu.TabIndex = 3;
            this.btnUpdateProfile_MMenu.Text = "Update Profile";
            this.btnUpdateProfile_MMenu.UseVisualStyleBackColor = true;
            // 
            // ManageMenu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(982, 453);
            this.Controls.Add(this.tableSidebar_MMenu);
            this.Controls.Add(this.gbMMenu);
            this.Name = "ManageMenu";
            this.Text = "ManageMenu";
            this.Load += new System.EventHandler(this.ManageMenu_Load);
            this.gbMMenu.ResumeLayout(false);
            this.gbMMenu.PerformLayout();
            this.tableSidebar_MMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewButtonColumn Action;
        private System.Windows.Forms.Button btnMMenu_MMenu;
        private System.Windows.Forms.Button btnMHall_MMenu;
        private System.Windows.Forms.Button btn_HallResvReport_MMenu;
        private System.Windows.Forms.Button btnUpdateProfile_MMenu;
    }
}