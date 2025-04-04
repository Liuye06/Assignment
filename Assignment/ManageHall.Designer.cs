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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainManageHall));
            this.tableSidebar_MHall = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pic_logo = new System.Windows.Forms.PictureBox();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnMMenu_MHall = new System.Windows.Forms.Button();
            this.btnMHall_MHall = new System.Windows.Forms.Button();
            this.btnHRReport_MHall = new System.Windows.Forms.Button();
            this.btnUProfile_MHall = new System.Windows.Forms.Button();
            this.gbMHall = new System.Windows.Forms.GroupBox();
            this.btnResetHallSearch = new System.Windows.Forms.Button();
            this.btnAddNewHall = new System.Windows.Forms.Button();
            this.dgvHall = new System.Windows.Forms.DataGridView();
            this.ColHallName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCapacity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColHallEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColHallDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnSearchHall = new System.Windows.Forms.Button();
            this.txtHall = new System.Windows.Forms.TextBox();
            this.lblHall = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableSidebar_MHall.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).BeginInit();
            this.gbMHall.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHall)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableSidebar_MHall
            // 
            this.tableSidebar_MHall.BackColor = System.Drawing.Color.Tomato;
            this.tableSidebar_MHall.ColumnCount = 1;
            this.tableSidebar_MHall.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableSidebar_MHall.Controls.Add(this.panel1, 0, 0);
            this.tableSidebar_MHall.Controls.Add(this.btnLogOut, 0, 5);
            this.tableSidebar_MHall.Controls.Add(this.btnMMenu_MHall, 0, 1);
            this.tableSidebar_MHall.Controls.Add(this.btnMHall_MHall, 0, 2);
            this.tableSidebar_MHall.Controls.Add(this.btnHRReport_MHall, 0, 3);
            this.tableSidebar_MHall.Controls.Add(this.btnUProfile_MHall, 0, 4);
            this.tableSidebar_MHall.Location = new System.Drawing.Point(12, -2);
            this.tableSidebar_MHall.Name = "tableSidebar_MHall";
            this.tableSidebar_MHall.RowCount = 7;
            this.tableSidebar_MHall.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableSidebar_MHall.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableSidebar_MHall.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableSidebar_MHall.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableSidebar_MHall.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableSidebar_MHall.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableSidebar_MHall.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableSidebar_MHall.Size = new System.Drawing.Size(200, 458);
            this.tableSidebar_MHall.TabIndex = 0;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-12, -14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 67);
            this.label1.TabIndex = 9;
            this.label1.Text = "Manager";
            this.label1.Click += new System.EventHandler(this.label1_Click);
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
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.Gainsboro;
            this.btnLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.Image = ((System.Drawing.Image)(resources.GetObject("btnLogOut.Image")));
            this.btnLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogOut.Location = new System.Drawing.Point(3, 343);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(194, 34);
            this.btnLogOut.TabIndex = 6;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnMMenu_MHall
            // 
            this.btnMMenu_MHall.BackColor = System.Drawing.Color.Gainsboro;
            this.btnMMenu_MHall.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMMenu_MHall.FlatAppearance.BorderSize = 0;
            this.btnMMenu_MHall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMMenu_MHall.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMMenu_MHall.Image = ((System.Drawing.Image)(resources.GetObject("btnMMenu_MHall.Image")));
            this.btnMMenu_MHall.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMMenu_MHall.Location = new System.Drawing.Point(3, 153);
            this.btnMMenu_MHall.Name = "btnMMenu_MHall";
            this.btnMMenu_MHall.Size = new System.Drawing.Size(194, 34);
            this.btnMMenu_MHall.TabIndex = 0;
            this.btnMMenu_MHall.Text = "Manage Menu";
            this.btnMMenu_MHall.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnMMenu_MHall.UseVisualStyleBackColor = false;
            this.btnMMenu_MHall.Click += new System.EventHandler(this.btnMMenu_MHall_Click);
            // 
            // btnMHall_MHall
            // 
            this.btnMHall_MHall.BackColor = System.Drawing.Color.Gainsboro;
            this.btnMHall_MHall.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMHall_MHall.FlatAppearance.BorderSize = 0;
            this.btnMHall_MHall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMHall_MHall.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMHall_MHall.Image = ((System.Drawing.Image)(resources.GetObject("btnMHall_MHall.Image")));
            this.btnMHall_MHall.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMHall_MHall.Location = new System.Drawing.Point(3, 193);
            this.btnMHall_MHall.Name = "btnMHall_MHall";
            this.btnMHall_MHall.Size = new System.Drawing.Size(194, 34);
            this.btnMHall_MHall.TabIndex = 1;
            this.btnMHall_MHall.Text = "Manage Hall";
            this.btnMHall_MHall.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnMHall_MHall.UseVisualStyleBackColor = false;
            this.btnMHall_MHall.Click += new System.EventHandler(this.btnMHall_MHall_Click);
            // 
            // btnHRReport_MHall
            // 
            this.btnHRReport_MHall.BackColor = System.Drawing.Color.Gainsboro;
            this.btnHRReport_MHall.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHRReport_MHall.FlatAppearance.BorderSize = 0;
            this.btnHRReport_MHall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHRReport_MHall.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHRReport_MHall.Image = ((System.Drawing.Image)(resources.GetObject("btnHRReport_MHall.Image")));
            this.btnHRReport_MHall.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHRReport_MHall.Location = new System.Drawing.Point(3, 233);
            this.btnHRReport_MHall.Name = "btnHRReport_MHall";
            this.btnHRReport_MHall.Size = new System.Drawing.Size(194, 64);
            this.btnHRReport_MHall.TabIndex = 2;
            this.btnHRReport_MHall.Text = "Hall Reservation Report";
            this.btnHRReport_MHall.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnHRReport_MHall.UseVisualStyleBackColor = false;
            this.btnHRReport_MHall.Click += new System.EventHandler(this.btnHRReport_MHall_Click);
            // 
            // btnUProfile_MHall
            // 
            this.btnUProfile_MHall.BackColor = System.Drawing.Color.Gainsboro;
            this.btnUProfile_MHall.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUProfile_MHall.FlatAppearance.BorderSize = 0;
            this.btnUProfile_MHall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUProfile_MHall.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUProfile_MHall.Image = ((System.Drawing.Image)(resources.GetObject("btnUProfile_MHall.Image")));
            this.btnUProfile_MHall.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUProfile_MHall.Location = new System.Drawing.Point(3, 303);
            this.btnUProfile_MHall.Name = "btnUProfile_MHall";
            this.btnUProfile_MHall.Size = new System.Drawing.Size(194, 34);
            this.btnUProfile_MHall.TabIndex = 3;
            this.btnUProfile_MHall.Text = "Manager Profile";
            this.btnUProfile_MHall.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnUProfile_MHall.UseVisualStyleBackColor = false;
            this.btnUProfile_MHall.Click += new System.EventHandler(this.btnUProfile_MHall_Click);
            // 
            // gbMHall
            // 
            this.gbMHall.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.gbMHall.Controls.Add(this.btnResetHallSearch);
            this.gbMHall.Controls.Add(this.btnAddNewHall);
            this.gbMHall.Controls.Add(this.dgvHall);
            this.gbMHall.Controls.Add(this.btnSearchHall);
            this.gbMHall.Controls.Add(this.txtHall);
            this.gbMHall.Controls.Add(this.lblHall);
            this.gbMHall.ForeColor = System.Drawing.SystemColors.Menu;
            this.gbMHall.Location = new System.Drawing.Point(48, 55);
            this.gbMHall.Name = "gbMHall";
            this.gbMHall.Size = new System.Drawing.Size(852, 369);
            this.gbMHall.TabIndex = 1;
            this.gbMHall.TabStop = false;
            this.gbMHall.Text = "Manage Hall";
            // 
            // btnResetHallSearch
            // 
            this.btnResetHallSearch.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnResetHallSearch.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnResetHallSearch.Location = new System.Drawing.Point(440, 320);
            this.btnResetHallSearch.Name = "btnResetHallSearch";
            this.btnResetHallSearch.Size = new System.Drawing.Size(390, 35);
            this.btnResetHallSearch.TabIndex = 5;
            this.btnResetHallSearch.Text = "Reset Search Hall Name";
            this.btnResetHallSearch.UseVisualStyleBackColor = false;
            this.btnResetHallSearch.Click += new System.EventHandler(this.btnResetHallSearch_Click);
            // 
            // btnAddNewHall
            // 
            this.btnAddNewHall.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAddNewHall.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnAddNewHall.Location = new System.Drawing.Point(45, 320);
            this.btnAddNewHall.Name = "btnAddNewHall";
            this.btnAddNewHall.Size = new System.Drawing.Size(390, 35);
            this.btnAddNewHall.TabIndex = 4;
            this.btnAddNewHall.Text = "Add New Hall Name";
            this.btnAddNewHall.UseVisualStyleBackColor = false;
            this.btnAddNewHall.Click += new System.EventHandler(this.btnAddNewHall_Click);
            // 
            // dgvHall
            // 
            this.dgvHall.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHall.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColHallName,
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
            this.dgvHall.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHall_CellContentClick);
            // 
            // ColHallName
            // 
            this.ColHallName.DataPropertyName = "Hall_Name";
            this.ColHallName.HeaderText = "Hall Name";
            this.ColHallName.MinimumWidth = 6;
            this.ColHallName.Name = "ColHallName";
            this.ColHallName.Width = 160;
            // 
            // ColCapacity
            // 
            this.ColCapacity.DataPropertyName = "Capacity";
            this.ColCapacity.HeaderText = "Capacity";
            this.ColCapacity.MinimumWidth = 6;
            this.ColCapacity.Name = "ColCapacity";
            this.ColCapacity.Width = 160;
            // 
            // ColPrice
            // 
            this.ColPrice.DataPropertyName = "Price_P_Day";
            this.ColPrice.HeaderText = "Price";
            this.ColPrice.MinimumWidth = 6;
            this.ColPrice.Name = "ColPrice";
            this.ColPrice.Width = 150;
            // 
            // ColHallEdit
            // 
            this.ColHallEdit.DataPropertyName = "Edit";
            this.ColHallEdit.HeaderText = "Action";
            this.ColHallEdit.MinimumWidth = 6;
            this.ColHallEdit.Name = "ColHallEdit";
            this.ColHallEdit.Text = "Edit";
            this.ColHallEdit.UseColumnTextForButtonValue = true;
            this.ColHallEdit.Width = 130;
            // 
            // ColHallDelete
            // 
            this.ColHallDelete.DataPropertyName = "Delete";
            this.ColHallDelete.HeaderText = "Action";
            this.ColHallDelete.MinimumWidth = 6;
            this.ColHallDelete.Name = "ColHallDelete";
            this.ColHallDelete.Text = "Delete";
            this.ColHallDelete.UseColumnTextForButtonValue = true;
            this.ColHallDelete.Width = 130;
            // 
            // btnSearchHall
            // 
            this.btnSearchHall.ForeColor = System.Drawing.SystemColors.Desktop;
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
            this.lblHall.ForeColor = System.Drawing.SystemColors.Info;
            this.lblHall.Location = new System.Drawing.Point(40, 44);
            this.lblHall.Name = "lblHall";
            this.lblHall.Size = new System.Drawing.Size(102, 25);
            this.lblHall.TabIndex = 0;
            this.lblHall.Text = "Hall Name";
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.gbMHall);
            this.panel2.Location = new System.Drawing.Point(170, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(915, 455);
            this.panel2.TabIndex = 2;
            // 
            // MainManageHall
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(237)))), ((int)(((byte)(225)))));
            this.ClientSize = new System.Drawing.Size(1082, 453);
            this.Controls.Add(this.tableSidebar_MHall);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MainManageHall";
            this.Text = " h8";
            this.Load += new System.EventHandler(this.MainManageHall_Load);
            this.tableSidebar_MHall.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).EndInit();
            this.gbMHall.ResumeLayout(false);
            this.gbMHall.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHall)).EndInit();
            this.panel2.ResumeLayout(false);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCapacity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPrice;
        private System.Windows.Forms.DataGridViewButtonColumn ColHallEdit;
        private System.Windows.Forms.DataGridViewButtonColumn ColHallDelete;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pic_logo;
        private System.Windows.Forms.Panel panel2;
    }
}