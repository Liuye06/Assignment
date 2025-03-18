namespace Assignment
{
    partial class MainManageHall
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
            this.tableSidebar_MHall = new System.Windows.Forms.TableLayoutPanel();
            this.btnMMenu_MHall = new System.Windows.Forms.Button();
            this.btnMHall_MHall = new System.Windows.Forms.Button();
            this.btnHRReport_MHall = new System.Windows.Forms.Button();
            this.btnUProfile_MHall = new System.Windows.Forms.Button();
            this.gbMHall = new System.Windows.Forms.GroupBox();
            this.btnResetHallSearch = new System.Windows.Forms.Button();
            this.btnAddNewHall = new System.Windows.Forms.Button();
            this.dgvHall = new System.Windows.Forms.DataGridView();
            this.btnSearchHall = new System.Windows.Forms.Button();
            this.txtHall = new System.Windows.Forms.TextBox();
            this.lblHall = new System.Windows.Forms.Label();
            this.ColHallName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColHallImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.ColCapacity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColHallEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColHallDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tableSidebar_MHall.SuspendLayout();
            this.gbMHall.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHall)).BeginInit();
            this.SuspendLayout();
            // 
            // tableSidebar_MHall
            // 
            this.tableSidebar_MHall.ColumnCount = 1;
            this.tableSidebar_MHall.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableSidebar_MHall.Controls.Add(this.btnMMenu_MHall, 0, 1);
            this.tableSidebar_MHall.Controls.Add(this.btnMHall_MHall, 0, 2);
            this.tableSidebar_MHall.Controls.Add(this.btnHRReport_MHall, 0, 3);
            this.tableSidebar_MHall.Controls.Add(this.btnUProfile_MHall, 0, 4);
            this.tableSidebar_MHall.Location = new System.Drawing.Point(12, 12);
            this.tableSidebar_MHall.Name = "tableSidebar_MHall";
            this.tableSidebar_MHall.RowCount = 6;
            this.tableSidebar_MHall.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableSidebar_MHall.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableSidebar_MHall.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableSidebar_MHall.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableSidebar_MHall.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableSidebar_MHall.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableSidebar_MHall.Size = new System.Drawing.Size(200, 430);
            this.tableSidebar_MHall.TabIndex = 0;
            // 
            // btnMMenu_MHall
            // 
            this.btnMMenu_MHall.FlatAppearance.BorderSize = 0;
            this.btnMMenu_MHall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMMenu_MHall.Location = new System.Drawing.Point(3, 63);
            this.btnMMenu_MHall.Name = "btnMMenu_MHall";
            this.btnMMenu_MHall.Size = new System.Drawing.Size(194, 34);
            this.btnMMenu_MHall.TabIndex = 0;
            this.btnMMenu_MHall.Text = "Manage Menu";
            this.btnMMenu_MHall.UseVisualStyleBackColor = true;
            this.btnMMenu_MHall.Click += new System.EventHandler(this.btnMMenu_MHall_Click);
            // 
            // btnMHall_MHall
            // 
            this.btnMHall_MHall.FlatAppearance.BorderSize = 0;
            this.btnMHall_MHall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMHall_MHall.Location = new System.Drawing.Point(3, 103);
            this.btnMHall_MHall.Name = "btnMHall_MHall";
            this.btnMHall_MHall.Size = new System.Drawing.Size(194, 34);
            this.btnMHall_MHall.TabIndex = 1;
            this.btnMHall_MHall.Text = "Manage Hall";
            this.btnMHall_MHall.UseVisualStyleBackColor = true;
            this.btnMHall_MHall.Click += new System.EventHandler(this.btnMHall_MHall_Click);
            // 
            // btnHRReport_MHall
            // 
            this.btnHRReport_MHall.FlatAppearance.BorderSize = 0;
            this.btnHRReport_MHall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHRReport_MHall.Location = new System.Drawing.Point(3, 143);
            this.btnHRReport_MHall.Name = "btnHRReport_MHall";
            this.btnHRReport_MHall.Size = new System.Drawing.Size(194, 64);
            this.btnHRReport_MHall.TabIndex = 2;
            this.btnHRReport_MHall.Text = "Hall Reservation Report";
            this.btnHRReport_MHall.UseVisualStyleBackColor = true;
            this.btnHRReport_MHall.Click += new System.EventHandler(this.btnHRReport_MHall_Click);
            // 
            // btnUProfile_MHall
            // 
            this.btnUProfile_MHall.FlatAppearance.BorderSize = 0;
            this.btnUProfile_MHall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUProfile_MHall.Location = new System.Drawing.Point(3, 213);
            this.btnUProfile_MHall.Name = "btnUProfile_MHall";
            this.btnUProfile_MHall.Size = new System.Drawing.Size(194, 34);
            this.btnUProfile_MHall.TabIndex = 3;
            this.btnUProfile_MHall.Text = "Update Profile";
            this.btnUProfile_MHall.UseVisualStyleBackColor = true;
            this.btnUProfile_MHall.Click += new System.EventHandler(this.btnUProfile_MHall_Click);
            // 
            // gbMHall
            // 
            this.gbMHall.Controls.Add(this.btnResetHallSearch);
            this.gbMHall.Controls.Add(this.btnAddNewHall);
            this.gbMHall.Controls.Add(this.dgvHall);
            this.gbMHall.Controls.Add(this.btnSearchHall);
            this.gbMHall.Controls.Add(this.txtHall);
            this.gbMHall.Controls.Add(this.lblHall);
            this.gbMHall.Location = new System.Drawing.Point(218, 73);
            this.gbMHall.Name = "gbMHall";
            this.gbMHall.Size = new System.Drawing.Size(852, 369);
            this.gbMHall.TabIndex = 1;
            this.gbMHall.TabStop = false;
            this.gbMHall.Text = "Manage Hall";
            // 
            // btnResetHallSearch
            // 
            this.btnResetHallSearch.Location = new System.Drawing.Point(440, 320);
            this.btnResetHallSearch.Name = "btnResetHallSearch";
            this.btnResetHallSearch.Size = new System.Drawing.Size(390, 35);
            this.btnResetHallSearch.TabIndex = 5;
            this.btnResetHallSearch.Text = "Reset Search Hall Name";
            this.btnResetHallSearch.Click += new System.EventHandler(this.btnResetHallSearch_Click);
            // 
            // btnAddNewHall
            // 
            this.btnAddNewHall.Location = new System.Drawing.Point(45, 320);
            this.btnAddNewHall.Name = "btnAddNewHall";
            this.btnAddNewHall.Size = new System.Drawing.Size(390, 35);
            this.btnAddNewHall.TabIndex = 4;
            this.btnAddNewHall.Text = "Add New Hall Name";
            this.btnAddNewHall.Click += new System.EventHandler(this.btnAddNewHall_Click);
            // 
            // dgvHall
            // 
            this.dgvHall.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHall.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColHallName,
            this.ColHallImage,
            this.ColCapacity,
            this.ColPrice,
            this.ColHallEdit,
            this.ColHallDelete});
            this.dgvHall.Location = new System.Drawing.Point(45, 91);
            this.dgvHall.Name = "dgvHall";
            this.dgvHall.RowHeadersWidth = 51;
            this.dgvHall.RowTemplate.Height = 24;
            this.dgvHall.Size = new System.Drawing.Size(785, 216);
            this.dgvHall.TabIndex = 3;
            // 
            // btnSearchHall
            // 
            this.btnSearchHall.Location = new System.Drawing.Point(416, 39);
            this.btnSearchHall.Name = "btnSearchHall";
            this.btnSearchHall.Size = new System.Drawing.Size(106, 35);
            this.btnSearchHall.TabIndex = 2;
            this.btnSearchHall.Text = "Search";
            this.btnSearchHall.UseVisualStyleBackColor = true;
            this.btnSearchHall.Click += new System.EventHandler(this.btnSearchHall_Click);
            // 
            // txtHall
            // 
            this.txtHall.Location = new System.Drawing.Point(148, 41);
            this.txtHall.Name = "txtHall";
            this.txtHall.Size = new System.Drawing.Size(262, 30);
            this.txtHall.TabIndex = 1;
            // 
            // lblHall
            // 
            this.lblHall.AutoSize = true;
            this.lblHall.Location = new System.Drawing.Point(40, 44);
            this.lblHall.Name = "lblHall";
            this.lblHall.Size = new System.Drawing.Size(102, 25);
            this.lblHall.TabIndex = 0;
            this.lblHall.Text = "Hall Name";
            // 
            // ColHallName
            // 
            this.ColHallName.DataPropertyName = "Hall_Name";
            this.ColHallName.HeaderText = "Hall Name";
            this.ColHallName.MinimumWidth = 6;
            this.ColHallName.Name = "ColHallName";
            this.ColHallName.Width = 135;
            // 
            // ColHallImage
            // 
            this.ColHallImage.HeaderText = "Image";
            this.ColHallImage.MinimumWidth = 6;
            this.ColHallImage.Name = "ColHallImage";
            this.ColHallImage.Width = 125;
            // 
            // ColCapacity
            // 
            this.ColCapacity.DataPropertyName = "Capacity";
            this.ColCapacity.HeaderText = "Capacity";
            this.ColCapacity.MinimumWidth = 6;
            this.ColCapacity.Name = "ColCapacity";
            this.ColCapacity.Width = 125;
            // 
            // ColPrice
            // 
            this.ColPrice.DataPropertyName = "Price_P_Day";
            this.ColPrice.HeaderText = "Price";
            this.ColPrice.MinimumWidth = 6;
            this.ColPrice.Name = "ColPrice";
            this.ColPrice.Width = 115;
            // 
            // ColHallEdit
            // 
            this.ColHallEdit.DataPropertyName = "Edit";
            this.ColHallEdit.HeaderText = "Action";
            this.ColHallEdit.MinimumWidth = 6;
            this.ColHallEdit.Name = "ColHallEdit";
            this.ColHallEdit.Width = 115;
            // 
            // ColHallDelete
            // 
            this.ColHallDelete.DataPropertyName = "Delete";
            this.ColHallDelete.HeaderText = "Action";
            this.ColHallDelete.MinimumWidth = 6;
            this.ColHallDelete.Name = "ColHallDelete";
            this.ColHallDelete.Width = 115;
            // 
            // MainManageHall
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1082, 453);
            this.Controls.Add(this.gbMHall);
            this.Controls.Add(this.tableSidebar_MHall);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MainManageHall";
            this.Text = "ManageHall";
            this.Load += new System.EventHandler(this.MainManageHall_Load);
            this.tableSidebar_MHall.ResumeLayout(false);
            this.gbMHall.ResumeLayout(false);
            this.gbMHall.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHall)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableSidebar_MHall;
        private System.Windows.Forms.GroupBox gbMHall;
        private System.Windows.Forms.Button btnMMenu_MHall;
        private System.Windows.Forms.Button btnMHall_MHall;
        private System.Windows.Forms.Button btnHRReport_MHall;
        private System.Windows.Forms.Button btnUProfile_MHall;
        private System.Windows.Forms.Label lblHall;
        private System.Windows.Forms.TextBox txtHall;
        private System.Windows.Forms.Button btnSearchHall;
        private System.Windows.Forms.DataGridView dgvHall;
        private System.Windows.Forms.Button btnAddNewHall;
        private System.Windows.Forms.Button btnResetHallSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColHallName;
        private System.Windows.Forms.DataGridViewImageColumn ColHallImage;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCapacity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPrice;
        private System.Windows.Forms.DataGridViewButtonColumn ColHallEdit;
        private System.Windows.Forms.DataGridViewButtonColumn ColHallDelete;
    }
}