namespace Assignment
{
    partial class AddNewMenuItem
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
            this.gbAddMenu = new System.Windows.Forms.GroupBox();
            this.btnCancelMenu = new System.Windows.Forms.Button();
            this.btnAddMenuItem = new System.Windows.Forms.Button();
            this.btnBrowseImageMenu = new System.Windows.Forms.Button();
            this.picAddMenu = new System.Windows.Forms.PictureBox();
            this.cmbCategoryMenu = new System.Windows.Forms.ComboBox();
            this.txtPriceMenu = new System.Windows.Forms.TextBox();
            this.txtAddMenu = new System.Windows.Forms.TextBox();
            this.lblCategoryMenu = new System.Windows.Forms.Label();
            this.lblPriceMenu = new System.Windows.Forms.Label();
            this.lblAddMenu = new System.Windows.Forms.Label();
            this.btnUProfile_AddMenu = new System.Windows.Forms.Button();
            this.btnMRReport_AddMenu = new System.Windows.Forms.Button();
            this.btnMHall_AddMenu = new System.Windows.Forms.Button();
            this.btnMMenu_AddMenu = new System.Windows.Forms.Button();
            this.tableSidebar_AddMenu = new System.Windows.Forms.TableLayoutPanel();
            this.gbAddMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAddMenu)).BeginInit();
            this.tableSidebar_AddMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbAddMenu
            // 
            this.gbAddMenu.Controls.Add(this.btnCancelMenu);
            this.gbAddMenu.Controls.Add(this.btnAddMenuItem);
            this.gbAddMenu.Controls.Add(this.btnBrowseImageMenu);
            this.gbAddMenu.Controls.Add(this.picAddMenu);
            this.gbAddMenu.Controls.Add(this.cmbCategoryMenu);
            this.gbAddMenu.Controls.Add(this.txtPriceMenu);
            this.gbAddMenu.Controls.Add(this.txtAddMenu);
            this.gbAddMenu.Controls.Add(this.lblCategoryMenu);
            this.gbAddMenu.Controls.Add(this.lblPriceMenu);
            this.gbAddMenu.Controls.Add(this.lblAddMenu);
            this.gbAddMenu.Location = new System.Drawing.Point(216, 71);
            this.gbAddMenu.Name = "gbAddMenu";
            this.gbAddMenu.Size = new System.Drawing.Size(850, 370);
            this.gbAddMenu.TabIndex = 1;
            this.gbAddMenu.TabStop = false;
            this.gbAddMenu.Text = "Add New Menu Item";
            // 
            // btnCancelMenu
            // 
            this.btnCancelMenu.Location = new System.Drawing.Point(421, 316);
            this.btnCancelMenu.Name = "btnCancelMenu";
            this.btnCancelMenu.Size = new System.Drawing.Size(370, 34);
            this.btnCancelMenu.TabIndex = 9;
            this.btnCancelMenu.Text = "Cancel";
            this.btnCancelMenu.UseVisualStyleBackColor = true;
            this.btnCancelMenu.Click += new System.EventHandler(this.btnCancelMenu_Click);
            // 
            // btnAddMenuItem
            // 
            this.btnAddMenuItem.Location = new System.Drawing.Point(45, 316);
            this.btnAddMenuItem.Name = "btnAddMenuItem";
            this.btnAddMenuItem.Size = new System.Drawing.Size(370, 34);
            this.btnAddMenuItem.TabIndex = 8;
            this.btnAddMenuItem.Text = "Add New Menu Item";
            this.btnAddMenuItem.UseVisualStyleBackColor = true;
            this.btnAddMenuItem.Click += new System.EventHandler(this.btnAddMenuItem_Click);
            // 
            // btnBrowseImageMenu
            // 
            this.btnBrowseImageMenu.Location = new System.Drawing.Point(572, 265);
            this.btnBrowseImageMenu.Name = "btnBrowseImageMenu";
            this.btnBrowseImageMenu.Size = new System.Drawing.Size(219, 34);
            this.btnBrowseImageMenu.TabIndex = 7;
            this.btnBrowseImageMenu.Text = "Browse Image";
            this.btnBrowseImageMenu.UseVisualStyleBackColor = true;
            this.btnBrowseImageMenu.Click += new System.EventHandler(this.btnBrowseImageMenu_Click);
            // 
            // picAddMenu
            // 
            this.picAddMenu.Location = new System.Drawing.Point(572, 45);
            this.picAddMenu.Name = "picAddMenu";
            this.picAddMenu.Size = new System.Drawing.Size(219, 210);
            this.picAddMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAddMenu.TabIndex = 6;
            this.picAddMenu.TabStop = false;
            // 
            // cmbCategoryMenu
            // 
            this.cmbCategoryMenu.FormattingEnabled = true;
            this.cmbCategoryMenu.Items.AddRange(new object[] {
            "Appetizer",
            "Main Dish",
            "Side ",
            "Beverage",
            "Dessert"});
            this.cmbCategoryMenu.Location = new System.Drawing.Point(207, 222);
            this.cmbCategoryMenu.Name = "cmbCategoryMenu";
            this.cmbCategoryMenu.Size = new System.Drawing.Size(301, 33);
            this.cmbCategoryMenu.TabIndex = 5;
            // 
            // txtPriceMenu
            // 
            this.txtPriceMenu.Location = new System.Drawing.Point(207, 141);
            this.txtPriceMenu.Name = "txtPriceMenu";
            this.txtPriceMenu.Size = new System.Drawing.Size(301, 30);
            this.txtPriceMenu.TabIndex = 4;
            // 
            // txtAddMenu
            // 
            this.txtAddMenu.Location = new System.Drawing.Point(207, 63);
            this.txtAddMenu.Name = "txtAddMenu";
            this.txtAddMenu.Size = new System.Drawing.Size(301, 30);
            this.txtAddMenu.TabIndex = 3;
            // 
            // lblCategoryMenu
            // 
            this.lblCategoryMenu.AutoSize = true;
            this.lblCategoryMenu.Location = new System.Drawing.Point(68, 225);
            this.lblCategoryMenu.Name = "lblCategoryMenu";
            this.lblCategoryMenu.Size = new System.Drawing.Size(92, 25);
            this.lblCategoryMenu.TabIndex = 2;
            this.lblCategoryMenu.Text = "Category";
            // 
            // lblPriceMenu
            // 
            this.lblPriceMenu.AutoSize = true;
            this.lblPriceMenu.Location = new System.Drawing.Point(68, 144);
            this.lblPriceMenu.Name = "lblPriceMenu";
            this.lblPriceMenu.Size = new System.Drawing.Size(56, 25);
            this.lblPriceMenu.TabIndex = 1;
            this.lblPriceMenu.Text = "Price";
            // 
            // lblAddMenu
            // 
            this.lblAddMenu.AutoSize = true;
            this.lblAddMenu.Location = new System.Drawing.Point(68, 66);
            this.lblAddMenu.Name = "lblAddMenu";
            this.lblAddMenu.Size = new System.Drawing.Size(64, 25);
            this.lblAddMenu.TabIndex = 0;
            this.lblAddMenu.Text = "Name";
            // 
            // btnUProfile_AddMenu
            // 
            this.btnUProfile_AddMenu.FlatAppearance.BorderSize = 0;
            this.btnUProfile_AddMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUProfile_AddMenu.Location = new System.Drawing.Point(3, 213);
            this.btnUProfile_AddMenu.Name = "btnUProfile_AddMenu";
            this.btnUProfile_AddMenu.Size = new System.Drawing.Size(194, 34);
            this.btnUProfile_AddMenu.TabIndex = 3;
            this.btnUProfile_AddMenu.Text = "Manager Profile";
            this.btnUProfile_AddMenu.UseVisualStyleBackColor = true;
            this.btnUProfile_AddMenu.Click += new System.EventHandler(this.btnUProfile_AddMenu_Click);
            // 
            // btnMRReport_AddMenu
            // 
            this.btnMRReport_AddMenu.FlatAppearance.BorderSize = 0;
            this.btnMRReport_AddMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMRReport_AddMenu.Location = new System.Drawing.Point(3, 143);
            this.btnMRReport_AddMenu.Name = "btnMRReport_AddMenu";
            this.btnMRReport_AddMenu.Size = new System.Drawing.Size(194, 64);
            this.btnMRReport_AddMenu.TabIndex = 2;
            this.btnMRReport_AddMenu.Text = "Hall Reservation Report";
            this.btnMRReport_AddMenu.UseVisualStyleBackColor = true;
            this.btnMRReport_AddMenu.Click += new System.EventHandler(this.btnMRReport_AddMenu_Click);
            // 
            // btnMHall_AddMenu
            // 
            this.btnMHall_AddMenu.FlatAppearance.BorderSize = 0;
            this.btnMHall_AddMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMHall_AddMenu.Location = new System.Drawing.Point(3, 103);
            this.btnMHall_AddMenu.Name = "btnMHall_AddMenu";
            this.btnMHall_AddMenu.Size = new System.Drawing.Size(194, 34);
            this.btnMHall_AddMenu.TabIndex = 1;
            this.btnMHall_AddMenu.Text = "Manage Hall";
            this.btnMHall_AddMenu.UseVisualStyleBackColor = true;
            this.btnMHall_AddMenu.Click += new System.EventHandler(this.btnMHall_AddMenu_Click);
            // 
            // btnMMenu_AddMenu
            // 
            this.btnMMenu_AddMenu.FlatAppearance.BorderSize = 0;
            this.btnMMenu_AddMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMMenu_AddMenu.Location = new System.Drawing.Point(3, 63);
            this.btnMMenu_AddMenu.Name = "btnMMenu_AddMenu";
            this.btnMMenu_AddMenu.Size = new System.Drawing.Size(194, 34);
            this.btnMMenu_AddMenu.TabIndex = 0;
            this.btnMMenu_AddMenu.Text = "Manage Menu";
            this.btnMMenu_AddMenu.UseVisualStyleBackColor = true;
            this.btnMMenu_AddMenu.Click += new System.EventHandler(this.btnMMenu_AddMenu_Click);
            // 
            // tableSidebar_AddMenu
            // 
            this.tableSidebar_AddMenu.AutoScroll = true;
            this.tableSidebar_AddMenu.ColumnCount = 1;
            this.tableSidebar_AddMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableSidebar_AddMenu.Controls.Add(this.btnMMenu_AddMenu, 0, 1);
            this.tableSidebar_AddMenu.Controls.Add(this.btnMHall_AddMenu, 0, 2);
            this.tableSidebar_AddMenu.Controls.Add(this.btnMRReport_AddMenu, 0, 3);
            this.tableSidebar_AddMenu.Controls.Add(this.btnUProfile_AddMenu, 0, 4);
            this.tableSidebar_AddMenu.Location = new System.Drawing.Point(12, 13);
            this.tableSidebar_AddMenu.Name = "tableSidebar_AddMenu";
            this.tableSidebar_AddMenu.RowCount = 6;
            this.tableSidebar_AddMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableSidebar_AddMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableSidebar_AddMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableSidebar_AddMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableSidebar_AddMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableSidebar_AddMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableSidebar_AddMenu.Size = new System.Drawing.Size(200, 428);
            this.tableSidebar_AddMenu.TabIndex = 0;
            // 
            // AddNewMenuItem
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1082, 453);
            this.Controls.Add(this.gbAddMenu);
            this.Controls.Add(this.tableSidebar_AddMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "AddNewMenuItem";
            this.Text = "Add New Menu Item";
            this.gbAddMenu.ResumeLayout(false);
            this.gbAddMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAddMenu)).EndInit();
            this.tableSidebar_AddMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbAddMenu;
        private System.Windows.Forms.Label lblAddMenu;
        private System.Windows.Forms.TextBox txtAddMenu;
        private System.Windows.Forms.Label lblCategoryMenu;
        private System.Windows.Forms.Label lblPriceMenu;
        private System.Windows.Forms.ComboBox cmbCategoryMenu;
        private System.Windows.Forms.TextBox txtPriceMenu;
        private System.Windows.Forms.PictureBox picAddMenu;
        private System.Windows.Forms.Button btnBrowseImageMenu;
        private System.Windows.Forms.Button btnCancelMenu;
        private System.Windows.Forms.Button btnAddMenuItem;
        private System.Windows.Forms.Button btnUProfile_AddMenu;
        private System.Windows.Forms.Button btnMRReport_AddMenu;
        private System.Windows.Forms.Button btnMHall_AddMenu;
        private System.Windows.Forms.Button btnMMenu_AddMenu;
        private System.Windows.Forms.TableLayoutPanel tableSidebar_AddMenu;
    }
}