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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewMenuItem));
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
            this.gbAddMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAddMenu)).BeginInit();
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
            this.gbAddMenu.Location = new System.Drawing.Point(152, 34);
            this.gbAddMenu.Name = "gbAddMenu";
            this.gbAddMenu.Size = new System.Drawing.Size(852, 407);
            this.gbAddMenu.TabIndex = 1;
            this.gbAddMenu.TabStop = false;
            this.gbAddMenu.Text = "Add New Menu Item";
            // 
            // btnCancelMenu
            // 
            this.btnCancelMenu.Location = new System.Drawing.Point(419, 331);
            this.btnCancelMenu.Name = "btnCancelMenu";
            this.btnCancelMenu.Size = new System.Drawing.Size(370, 34);
            this.btnCancelMenu.TabIndex = 9;
            this.btnCancelMenu.Text = "Cancel";
            this.btnCancelMenu.UseVisualStyleBackColor = true;
            this.btnCancelMenu.Click += new System.EventHandler(this.btnCancelMenu_Click);
            // 
            // btnAddMenuItem
            // 
            this.btnAddMenuItem.Location = new System.Drawing.Point(43, 331);
            this.btnAddMenuItem.Name = "btnAddMenuItem";
            this.btnAddMenuItem.Size = new System.Drawing.Size(370, 34);
            this.btnAddMenuItem.TabIndex = 8;
            this.btnAddMenuItem.Text = "Add New Menu Item";
            this.btnAddMenuItem.UseVisualStyleBackColor = true;
            this.btnAddMenuItem.Click += new System.EventHandler(this.btnAddMenuItem_Click);
            // 
            // btnBrowseImageMenu
            // 
            this.btnBrowseImageMenu.Location = new System.Drawing.Point(570, 280);
            this.btnBrowseImageMenu.Name = "btnBrowseImageMenu";
            this.btnBrowseImageMenu.Size = new System.Drawing.Size(219, 34);
            this.btnBrowseImageMenu.TabIndex = 7;
            this.btnBrowseImageMenu.Text = "Browse Image";
            this.btnBrowseImageMenu.UseVisualStyleBackColor = true;
            this.btnBrowseImageMenu.Click += new System.EventHandler(this.btnBrowseImageMenu_Click);
            // 
            // picAddMenu
            // 
            this.picAddMenu.Location = new System.Drawing.Point(570, 60);
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
            this.cmbCategoryMenu.Location = new System.Drawing.Point(205, 237);
            this.cmbCategoryMenu.Name = "cmbCategoryMenu";
            this.cmbCategoryMenu.Size = new System.Drawing.Size(301, 33);
            this.cmbCategoryMenu.TabIndex = 5;
            // 
            // txtPriceMenu
            // 
            this.txtPriceMenu.Location = new System.Drawing.Point(205, 156);
            this.txtPriceMenu.Name = "txtPriceMenu";
            this.txtPriceMenu.Size = new System.Drawing.Size(301, 30);
            this.txtPriceMenu.TabIndex = 4;
            // 
            // txtAddMenu
            // 
            this.txtAddMenu.Location = new System.Drawing.Point(205, 78);
            this.txtAddMenu.Name = "txtAddMenu";
            this.txtAddMenu.Size = new System.Drawing.Size(301, 30);
            this.txtAddMenu.TabIndex = 3;
            // 
            // lblCategoryMenu
            // 
            this.lblCategoryMenu.AutoSize = true;
            this.lblCategoryMenu.Location = new System.Drawing.Point(66, 240);
            this.lblCategoryMenu.Name = "lblCategoryMenu";
            this.lblCategoryMenu.Size = new System.Drawing.Size(92, 25);
            this.lblCategoryMenu.TabIndex = 2;
            this.lblCategoryMenu.Text = "Category";
            // 
            // lblPriceMenu
            // 
            this.lblPriceMenu.AutoSize = true;
            this.lblPriceMenu.Location = new System.Drawing.Point(66, 159);
            this.lblPriceMenu.Name = "lblPriceMenu";
            this.lblPriceMenu.Size = new System.Drawing.Size(56, 25);
            this.lblPriceMenu.TabIndex = 1;
            this.lblPriceMenu.Text = "Price";
            // 
            // lblAddMenu
            // 
            this.lblAddMenu.AutoSize = true;
            this.lblAddMenu.Location = new System.Drawing.Point(66, 81);
            this.lblAddMenu.Name = "lblAddMenu";
            this.lblAddMenu.Size = new System.Drawing.Size(64, 25);
            this.lblAddMenu.TabIndex = 0;
            this.lblAddMenu.Text = "Name";
            // 
            // AddNewMenuItem
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(237)))), ((int)(((byte)(225)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1082, 453);
            this.Controls.Add(this.gbAddMenu);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "AddNewMenuItem";
            this.Text = "Add New Menu Item";
            this.gbAddMenu.ResumeLayout(false);
            this.gbAddMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAddMenu)).EndInit();
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
    }
}