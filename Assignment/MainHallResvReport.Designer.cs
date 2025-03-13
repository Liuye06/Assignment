namespace Assignment
{
    partial class MainHallResvReport
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
            this.tableSidebar_HRReport = new System.Windows.Forms.TableLayoutPanel();
            this.btnMMenu_HRReport = new System.Windows.Forms.Button();
            this.btnMHall_HRReport = new System.Windows.Forms.Button();
            this.btnHRReport_HRReport = new System.Windows.Forms.Button();
            this.btnUProfile_HRReport = new System.Windows.Forms.Button();
            this.gbHRReport = new System.Windows.Forms.GroupBox();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.dgvReport = new System.Windows.Forms.DataGridView();
            this.ColDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColHallName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSearchReport = new System.Windows.Forms.Button();
            this.cmbResvType = new System.Windows.Forms.ComboBox();
            this.lblResvType = new System.Windows.Forms.Label();
            this.cmbMonth = new System.Windows.Forms.ComboBox();
            this.lblMonth = new System.Windows.Forms.Label();
            this.tableSidebar_HRReport.SuspendLayout();
            this.gbHRReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).BeginInit();
            this.SuspendLayout();
            // 
            // tableSidebar_HRReport
            // 
            this.tableSidebar_HRReport.ColumnCount = 1;
            this.tableSidebar_HRReport.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableSidebar_HRReport.Controls.Add(this.btnMMenu_HRReport, 0, 1);
            this.tableSidebar_HRReport.Controls.Add(this.btnMHall_HRReport, 0, 2);
            this.tableSidebar_HRReport.Controls.Add(this.btnHRReport_HRReport, 0, 3);
            this.tableSidebar_HRReport.Controls.Add(this.btnUProfile_HRReport, 0, 4);
            this.tableSidebar_HRReport.Location = new System.Drawing.Point(13, 13);
            this.tableSidebar_HRReport.Name = "tableSidebar_HRReport";
            this.tableSidebar_HRReport.RowCount = 6;
            this.tableSidebar_HRReport.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableSidebar_HRReport.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableSidebar_HRReport.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableSidebar_HRReport.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableSidebar_HRReport.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableSidebar_HRReport.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableSidebar_HRReport.Size = new System.Drawing.Size(200, 428);
            this.tableSidebar_HRReport.TabIndex = 0;
            // 
            // btnMMenu_HRReport
            // 
            this.btnMMenu_HRReport.FlatAppearance.BorderSize = 0;
            this.btnMMenu_HRReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMMenu_HRReport.Location = new System.Drawing.Point(3, 63);
            this.btnMMenu_HRReport.Name = "btnMMenu_HRReport";
            this.btnMMenu_HRReport.Size = new System.Drawing.Size(194, 34);
            this.btnMMenu_HRReport.TabIndex = 0;
            this.btnMMenu_HRReport.Text = "Manage Menu";
            this.btnMMenu_HRReport.Click += new System.EventHandler(this.btnMMenu_HRReport_Click);
            // 
            // btnMHall_HRReport
            // 
            this.btnMHall_HRReport.FlatAppearance.BorderSize = 0;
            this.btnMHall_HRReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMHall_HRReport.Location = new System.Drawing.Point(3, 103);
            this.btnMHall_HRReport.Name = "btnMHall_HRReport";
            this.btnMHall_HRReport.Size = new System.Drawing.Size(194, 34);
            this.btnMHall_HRReport.TabIndex = 1;
            this.btnMHall_HRReport.Text = "Manage Hall";
            this.btnMHall_HRReport.UseVisualStyleBackColor = true;
            this.btnMHall_HRReport.Click += new System.EventHandler(this.btnMHall_HRReport_Click);
            // 
            // btnHRReport_HRReport
            // 
            this.btnHRReport_HRReport.FlatAppearance.BorderSize = 0;
            this.btnHRReport_HRReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHRReport_HRReport.Location = new System.Drawing.Point(3, 143);
            this.btnHRReport_HRReport.Name = "btnHRReport_HRReport";
            this.btnHRReport_HRReport.Size = new System.Drawing.Size(194, 64);
            this.btnHRReport_HRReport.TabIndex = 2;
            this.btnHRReport_HRReport.Text = "Hall Reservation Report";
            this.btnHRReport_HRReport.UseVisualStyleBackColor = true;
            this.btnHRReport_HRReport.Click += new System.EventHandler(this.btnHRReport_HRReport_Click);
            // 
            // btnUProfile_HRReport
            // 
            this.btnUProfile_HRReport.FlatAppearance.BorderSize = 0;
            this.btnUProfile_HRReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUProfile_HRReport.Location = new System.Drawing.Point(3, 213);
            this.btnUProfile_HRReport.Name = "btnUProfile_HRReport";
            this.btnUProfile_HRReport.Size = new System.Drawing.Size(194, 34);
            this.btnUProfile_HRReport.TabIndex = 3;
            this.btnUProfile_HRReport.Text = "Update Profile";
            this.btnUProfile_HRReport.UseVisualStyleBackColor = true;
            this.btnUProfile_HRReport.Click += new System.EventHandler(this.btnUProfile_HRReport_Click);
            // 
            // gbHRReport
            // 
            this.gbHRReport.Controls.Add(this.btnExport);
            this.gbHRReport.Controls.Add(this.btnGenerate);
            this.gbHRReport.Controls.Add(this.dgvReport);
            this.gbHRReport.Controls.Add(this.btnSearchReport);
            this.gbHRReport.Controls.Add(this.cmbResvType);
            this.gbHRReport.Controls.Add(this.lblResvType);
            this.gbHRReport.Controls.Add(this.cmbMonth);
            this.gbHRReport.Controls.Add(this.lblMonth);
            this.gbHRReport.Location = new System.Drawing.Point(219, 76);
            this.gbHRReport.Name = "gbHRReport";
            this.gbHRReport.Size = new System.Drawing.Size(752, 365);
            this.gbHRReport.TabIndex = 1;
            this.gbHRReport.TabStop = false;
            this.gbHRReport.Text = "Hall Reservation Report";
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(384, 316);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(345, 34);
            this.btnExport.TabIndex = 7;
            this.btnExport.Text = "Export to Excel";
            this.btnExport.UseVisualStyleBackColor = true;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(45, 316);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(333, 34);
            this.btnGenerate.TabIndex = 6;
            this.btnGenerate.Text = "Generate PDF Report";
            this.btnGenerate.UseVisualStyleBackColor = true;
            // 
            // dgvReport
            // 
            this.dgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColDate,
            this.ColCustomerName,
            this.ColHallName,
            this.ColStatus});
            this.dgvReport.Location = new System.Drawing.Point(45, 85);
            this.dgvReport.Name = "dgvReport";
            this.dgvReport.RowHeadersWidth = 51;
            this.dgvReport.RowTemplate.Height = 24;
            this.dgvReport.Size = new System.Drawing.Size(684, 216);
            this.dgvReport.TabIndex = 5;
            // 
            // ColDate
            // 
            this.ColDate.HeaderText = "Date";
            this.ColDate.MinimumWidth = 6;
            this.ColDate.Name = "ColDate";
            this.ColDate.Width = 125;
            // 
            // ColCustomerName
            // 
            this.ColCustomerName.HeaderText = "Customer";
            this.ColCustomerName.MinimumWidth = 6;
            this.ColCustomerName.Name = "ColCustomerName";
            this.ColCustomerName.Width = 180;
            // 
            // ColHallName
            // 
            this.ColHallName.HeaderText = "Hall Name";
            this.ColHallName.MinimumWidth = 6;
            this.ColHallName.Name = "ColHallName";
            this.ColHallName.Width = 165;
            // 
            // ColStatus
            // 
            this.ColStatus.HeaderText = "Status";
            this.ColStatus.MinimumWidth = 6;
            this.ColStatus.Name = "ColStatus";
            this.ColStatus.Width = 160;
            // 
            // btnSearchReport
            // 
            this.btnSearchReport.Location = new System.Drawing.Point(623, 38);
            this.btnSearchReport.Name = "btnSearchReport";
            this.btnSearchReport.Size = new System.Drawing.Size(106, 35);
            this.btnSearchReport.TabIndex = 4;
            this.btnSearchReport.Text = "Search";
            this.btnSearchReport.UseVisualStyleBackColor = true;
            // 
            // cmbResvType
            // 
            this.cmbResvType.FormattingEnabled = true;
            this.cmbResvType.Location = new System.Drawing.Point(459, 40);
            this.cmbResvType.Name = "cmbResvType";
            this.cmbResvType.Size = new System.Drawing.Size(149, 33);
            this.cmbResvType.TabIndex = 3;
            // 
            // lblResvType
            // 
            this.lblResvType.AutoSize = true;
            this.lblResvType.Location = new System.Drawing.Point(288, 43);
            this.lblResvType.Name = "lblResvType";
            this.lblResvType.Size = new System.Drawing.Size(165, 25);
            this.lblResvType.TabIndex = 2;
            this.lblResvType.Text = "Reservation Type";
            // 
            // cmbMonth
            // 
            this.cmbMonth.FormattingEnabled = true;
            this.cmbMonth.Location = new System.Drawing.Point(113, 40);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Size = new System.Drawing.Size(149, 33);
            this.cmbMonth.TabIndex = 1;
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Location = new System.Drawing.Point(40, 44);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(67, 25);
            this.lblMonth.TabIndex = 0;
            this.lblMonth.Text = "Month";
            // 
            // MainHallResvReport
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(982, 453);
            this.Controls.Add(this.gbHRReport);
            this.Controls.Add(this.tableSidebar_HRReport);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MainHallResvReport";
            this.Text = "HallResvReport";
            this.tableSidebar_HRReport.ResumeLayout(false);
            this.gbHRReport.ResumeLayout(false);
            this.gbHRReport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableSidebar_HRReport;
        private System.Windows.Forms.Button btnMMenu_HRReport;
        private System.Windows.Forms.Button btnMHall_HRReport;
        private System.Windows.Forms.Button btnHRReport_HRReport;
        private System.Windows.Forms.Button btnUProfile_HRReport;
        private System.Windows.Forms.GroupBox gbHRReport;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.ComboBox cmbMonth;
        private System.Windows.Forms.Button btnSearchReport;
        private System.Windows.Forms.ComboBox cmbResvType;
        private System.Windows.Forms.Label lblResvType;
        private System.Windows.Forms.DataGridView dgvReport;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColHallName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColStatus;
        private System.Windows.Forms.Button btnExport;
    }
}