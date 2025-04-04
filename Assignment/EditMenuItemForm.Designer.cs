namespace Assignment
{
    partial class EditMenuItemForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditMenuItemForm));
            this.gbEditMenu = new System.Windows.Forms.GroupBox();
            this.btnCancelEditMenu = new System.Windows.Forms.Button();
            this.btnSaveMenuItem = new System.Windows.Forms.Button();
            this.btnEditBrowseImageMenu = new System.Windows.Forms.Button();
            this.picEditMenu = new System.Windows.Forms.PictureBox();
            this.cmbEditCategoryMenu = new System.Windows.Forms.ComboBox();
            this.txtEditPriceMenu = new System.Windows.Forms.TextBox();
            this.txtEditMenu = new System.Windows.Forms.TextBox();
            this.lblEditCategoryMenu = new System.Windows.Forms.Label();
            this.lblEditPriceMenu = new System.Windows.Forms.Label();
            this.lblEditMenu = new System.Windows.Forms.Label();
            this.gbEditMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEditMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // gbEditMenu
            // 
            this.gbEditMenu.Controls.Add(this.btnCancelEditMenu);
            this.gbEditMenu.Controls.Add(this.btnSaveMenuItem);
            this.gbEditMenu.Controls.Add(this.btnEditBrowseImageMenu);
            this.gbEditMenu.Controls.Add(this.picEditMenu);
            this.gbEditMenu.Controls.Add(this.cmbEditCategoryMenu);
            this.gbEditMenu.Controls.Add(this.txtEditPriceMenu);
            this.gbEditMenu.Controls.Add(this.txtEditMenu);
            this.gbEditMenu.Controls.Add(this.lblEditCategoryMenu);
            this.gbEditMenu.Controls.Add(this.lblEditPriceMenu);
            this.gbEditMenu.Controls.Add(this.lblEditMenu);
            this.gbEditMenu.Location = new System.Drawing.Point(91, 34);
            this.gbEditMenu.Name = "gbEditMenu";
            this.gbEditMenu.Size = new System.Drawing.Size(877, 397);
            this.gbEditMenu.TabIndex = 4;
            this.gbEditMenu.TabStop = false;
            this.gbEditMenu.Text = "Edit Menu Item";
            // 
            // btnCancelEditMenu
            // 
            this.btnCancelEditMenu.Location = new System.Drawing.Point(432, 333);
            this.btnCancelEditMenu.Name = "btnCancelEditMenu";
            this.btnCancelEditMenu.Size = new System.Drawing.Size(370, 34);
            this.btnCancelEditMenu.TabIndex = 9;
            this.btnCancelEditMenu.Text = "Cancel";
            this.btnCancelEditMenu.UseVisualStyleBackColor = true;
            this.btnCancelEditMenu.Click += new System.EventHandler(this.btnCancelEditMenu_Click);
            // 
            // btnSaveMenuItem
            // 
            this.btnSaveMenuItem.Location = new System.Drawing.Point(56, 333);
            this.btnSaveMenuItem.Name = "btnSaveMenuItem";
            this.btnSaveMenuItem.Size = new System.Drawing.Size(370, 34);
            this.btnSaveMenuItem.TabIndex = 8;
            this.btnSaveMenuItem.Text = "Save Menu Item";
            this.btnSaveMenuItem.UseVisualStyleBackColor = true;
            this.btnSaveMenuItem.Click += new System.EventHandler(this.btnSaveMenuItem_Click);
            // 
            // btnEditBrowseImageMenu
            // 
            this.btnEditBrowseImageMenu.Location = new System.Drawing.Point(583, 282);
            this.btnEditBrowseImageMenu.Name = "btnEditBrowseImageMenu";
            this.btnEditBrowseImageMenu.Size = new System.Drawing.Size(219, 34);
            this.btnEditBrowseImageMenu.TabIndex = 7;
            this.btnEditBrowseImageMenu.Text = "Browse Image";
            this.btnEditBrowseImageMenu.UseVisualStyleBackColor = true;
            this.btnEditBrowseImageMenu.Click += new System.EventHandler(this.btnEditBrowseImageMenu_Click);
            // 
            // picEditMenu
            // 
            this.picEditMenu.Location = new System.Drawing.Point(583, 62);
            this.picEditMenu.Name = "picEditMenu";
            this.picEditMenu.Size = new System.Drawing.Size(219, 210);
            this.picEditMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picEditMenu.TabIndex = 6;
            this.picEditMenu.TabStop = false;
            // 
            // cmbEditCategoryMenu
            // 
            this.cmbEditCategoryMenu.FormattingEnabled = true;
            this.cmbEditCategoryMenu.Items.AddRange(new object[] {
            "Appetizer",
            "Main Dish",
            "Side ",
            "Beverage",
            "Dessert"});
            this.cmbEditCategoryMenu.Location = new System.Drawing.Point(218, 239);
            this.cmbEditCategoryMenu.Name = "cmbEditCategoryMenu";
            this.cmbEditCategoryMenu.Size = new System.Drawing.Size(301, 33);
            this.cmbEditCategoryMenu.TabIndex = 5;
            // 
            // txtEditPriceMenu
            // 
            this.txtEditPriceMenu.Location = new System.Drawing.Point(218, 158);
            this.txtEditPriceMenu.Name = "txtEditPriceMenu";
            this.txtEditPriceMenu.Size = new System.Drawing.Size(301, 30);
            this.txtEditPriceMenu.TabIndex = 4;
            // 
            // txtEditMenu
            // 
            this.txtEditMenu.Location = new System.Drawing.Point(218, 80);
            this.txtEditMenu.Name = "txtEditMenu";
            this.txtEditMenu.Size = new System.Drawing.Size(301, 30);
            this.txtEditMenu.TabIndex = 3;
            // 
            // lblEditCategoryMenu
            // 
            this.lblEditCategoryMenu.AutoSize = true;
            this.lblEditCategoryMenu.Location = new System.Drawing.Point(79, 242);
            this.lblEditCategoryMenu.Name = "lblEditCategoryMenu";
            this.lblEditCategoryMenu.Size = new System.Drawing.Size(92, 25);
            this.lblEditCategoryMenu.TabIndex = 2;
            this.lblEditCategoryMenu.Text = "Category";
            // 
            // lblEditPriceMenu
            // 
            this.lblEditPriceMenu.AutoSize = true;
            this.lblEditPriceMenu.Location = new System.Drawing.Point(79, 161);
            this.lblEditPriceMenu.Name = "lblEditPriceMenu";
            this.lblEditPriceMenu.Size = new System.Drawing.Size(56, 25);
            this.lblEditPriceMenu.TabIndex = 1;
            this.lblEditPriceMenu.Text = "Price";
            // 
            // lblEditMenu
            // 
            this.lblEditMenu.AutoSize = true;
            this.lblEditMenu.Location = new System.Drawing.Point(79, 83);
            this.lblEditMenu.Name = "lblEditMenu";
            this.lblEditMenu.Size = new System.Drawing.Size(64, 25);
            this.lblEditMenu.TabIndex = 0;
            this.lblEditMenu.Text = "Name";
            // 
            // EditMenuItemForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(237)))), ((int)(((byte)(225)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1082, 453);
            this.Controls.Add(this.gbEditMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "EditMenuItemForm";
            this.Text = "Edit Menu Item";
            this.gbEditMenu.ResumeLayout(false);
            this.gbEditMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEditMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbEditMenu;
        private System.Windows.Forms.Button btnCancelEditMenu;
        private System.Windows.Forms.Button btnSaveMenuItem;
        private System.Windows.Forms.Button btnEditBrowseImageMenu;
        private System.Windows.Forms.PictureBox picEditMenu;
        private System.Windows.Forms.ComboBox cmbEditCategoryMenu;
        private System.Windows.Forms.TextBox txtEditPriceMenu;
        private System.Windows.Forms.TextBox txtEditMenu;
        private System.Windows.Forms.Label lblEditCategoryMenu;
        private System.Windows.Forms.Label lblEditPriceMenu;
        private System.Windows.Forms.Label lblEditMenu;
    }
}