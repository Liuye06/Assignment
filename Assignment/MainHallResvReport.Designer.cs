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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainHallResvReport));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableSidebar_HRReport = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pic_logo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMMenu_HRReport = new System.Windows.Forms.Button();
            this.btnMHall_HRReport = new System.Windows.Forms.Button();
            this.btnHRReport_HRReport = new System.Windows.Forms.Button();
            this.btnUProfile_HRReport = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.gbHRReport = new System.Windows.Forms.GroupBox();
            this.btnExport = new System.Windows.Forms.Button();
            this.dgvReport = new System.Windows.Forms.DataGridView();
            this.btnResetReport = new System.Windows.Forms.Button();
            this.cmbResvType = new System.Windows.Forms.ComboBox();
            this.lblResvType = new System.Windows.Forms.Label();
            this.cmbMonth = new System.Windows.Forms.ComboBox();
            this.lblMonth = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableSidebar_HRReport.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).BeginInit();
            this.gbHRReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableSidebar_HRReport
            // 
            this.tableSidebar_HRReport.BackColor = System.Drawing.Color.Tomato;
            this.tableSidebar_HRReport.ColumnCount = 1;
            this.tableSidebar_HRReport.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableSidebar_HRReport.Controls.Add(this.panel1, 0, 0);
            this.tableSidebar_HRReport.Controls.Add(this.btnMMenu_HRReport, 0, 1);
            this.tableSidebar_HRReport.Controls.Add(this.btnMHall_HRReport, 0, 2);
            this.tableSidebar_HRReport.Controls.Add(this.btnHRReport_HRReport, 0, 3);
            this.tableSidebar_HRReport.Controls.Add(this.btnUProfile_HRReport, 0, 4);
            this.tableSidebar_HRReport.Controls.Add(this.btnLogOut, 0, 5);
            this.tableSidebar_HRReport.Location = new System.Drawing.Point(13, -1);
            this.tableSidebar_HRReport.Name = "tableSidebar_HRReport";
            this.tableSidebar_HRReport.RowCount = 7;
            this.tableSidebar_HRReport.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableSidebar_HRReport.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableSidebar_HRReport.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableSidebar_HRReport.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableSidebar_HRReport.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableSidebar_HRReport.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableSidebar_HRReport.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableSidebar_HRReport.Size = new System.Drawing.Size(200, 455);
            this.tableSidebar_HRReport.TabIndex = 0;
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
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnMMenu_HRReport
            // 
            this.btnMMenu_HRReport.BackColor = System.Drawing.Color.Gainsboro;
            this.btnMMenu_HRReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMMenu_HRReport.FlatAppearance.BorderSize = 0;
            this.btnMMenu_HRReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMMenu_HRReport.Font = new System.Drawing.Font("Gadugi", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMMenu_HRReport.Image = ((System.Drawing.Image)(resources.GetObject("btnMMenu_HRReport.Image")));
            this.btnMMenu_HRReport.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMMenu_HRReport.Location = new System.Drawing.Point(3, 153);
            this.btnMMenu_HRReport.Name = "btnMMenu_HRReport";
            this.btnMMenu_HRReport.Size = new System.Drawing.Size(194, 34);
            this.btnMMenu_HRReport.TabIndex = 0;
            this.btnMMenu_HRReport.Text = "Manage Menu";
            this.btnMMenu_HRReport.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnMMenu_HRReport.UseVisualStyleBackColor = false;
            this.btnMMenu_HRReport.Click += new System.EventHandler(this.btnMMenu_HRReport_Click);
            // 
            // btnMHall_HRReport
            // 
            this.btnMHall_HRReport.BackColor = System.Drawing.Color.Gainsboro;
            this.btnMHall_HRReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMHall_HRReport.FlatAppearance.BorderSize = 0;
            this.btnMHall_HRReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMHall_HRReport.Font = new System.Drawing.Font("Gadugi", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMHall_HRReport.Image = ((System.Drawing.Image)(resources.GetObject("btnMHall_HRReport.Image")));
            this.btnMHall_HRReport.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMHall_HRReport.Location = new System.Drawing.Point(3, 193);
            this.btnMHall_HRReport.Name = "btnMHall_HRReport";
            this.btnMHall_HRReport.Size = new System.Drawing.Size(194, 34);
            this.btnMHall_HRReport.TabIndex = 1;
            this.btnMHall_HRReport.Text = "Manage Hall";
            this.btnMHall_HRReport.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnMHall_HRReport.UseVisualStyleBackColor = false;
            this.btnMHall_HRReport.Click += new System.EventHandler(this.btnMHall_HRReport_Click);
            // 
            // btnHRReport_HRReport
            // 
            this.btnHRReport_HRReport.BackColor = System.Drawing.Color.Gainsboro;
            this.btnHRReport_HRReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHRReport_HRReport.FlatAppearance.BorderSize = 0;
            this.btnHRReport_HRReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHRReport_HRReport.Font = new System.Drawing.Font("Gadugi", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHRReport_HRReport.Image = ((System.Drawing.Image)(resources.GetObject("btnHRReport_HRReport.Image")));
            this.btnHRReport_HRReport.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHRReport_HRReport.Location = new System.Drawing.Point(3, 233);
            this.btnHRReport_HRReport.Name = "btnHRReport_HRReport";
            this.btnHRReport_HRReport.Size = new System.Drawing.Size(194, 64);
            this.btnHRReport_HRReport.TabIndex = 2;
            this.btnHRReport_HRReport.Text = "Hall Reservation Report";
            this.btnHRReport_HRReport.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnHRReport_HRReport.UseVisualStyleBackColor = false;
            this.btnHRReport_HRReport.Click += new System.EventHandler(this.btnHRReport_HRReport_Click);
            // 
            // btnUProfile_HRReport
            // 
            this.btnUProfile_HRReport.BackColor = System.Drawing.Color.Gainsboro;
            this.btnUProfile_HRReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUProfile_HRReport.FlatAppearance.BorderSize = 0;
            this.btnUProfile_HRReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUProfile_HRReport.Font = new System.Drawing.Font("Gadugi", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUProfile_HRReport.Image = ((System.Drawing.Image)(resources.GetObject("btnUProfile_HRReport.Image")));
            this.btnUProfile_HRReport.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUProfile_HRReport.Location = new System.Drawing.Point(3, 303);
            this.btnUProfile_HRReport.Name = "btnUProfile_HRReport";
            this.btnUProfile_HRReport.Size = new System.Drawing.Size(194, 34);
            this.btnUProfile_HRReport.TabIndex = 3;
            this.btnUProfile_HRReport.Text = "Manager Profile";
            this.btnUProfile_HRReport.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnUProfile_HRReport.UseVisualStyleBackColor = false;
            this.btnUProfile_HRReport.Click += new System.EventHandler(this.btnUProfile_HRReport_Click);
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
            this.btnLogOut.TabIndex = 8;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // gbHRReport
            // 
            this.gbHRReport.BackColor = System.Drawing.Color.Transparent;
            this.gbHRReport.Controls.Add(this.btnExport);
            this.gbHRReport.Controls.Add(this.dgvReport);
            this.gbHRReport.Controls.Add(this.btnResetReport);
            this.gbHRReport.Controls.Add(this.cmbResvType);
            this.gbHRReport.Controls.Add(this.lblResvType);
            this.gbHRReport.Controls.Add(this.cmbMonth);
            this.gbHRReport.Controls.Add(this.lblMonth);
            this.gbHRReport.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbHRReport.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbHRReport.Location = new System.Drawing.Point(32, 45);
            this.gbHRReport.Name = "gbHRReport";
            this.gbHRReport.Size = new System.Drawing.Size(851, 365);
            this.gbHRReport.TabIndex = 1;
            this.gbHRReport.TabStop = false;
            this.gbHRReport.Text = "Hall Reservation Report";
            // 
            // btnExport
            // 
            this.btnExport.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.ForeColor = System.Drawing.Color.RosyBrown;
            this.btnExport.Location = new System.Drawing.Point(45, 316);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(385, 34);
            this.btnExport.TabIndex = 7;
            this.btnExport.Text = "Export to Excel";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click_1);
            // 
            // dgvReport
            // 
            this.dgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvReport.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvReport.Location = new System.Drawing.Point(45, 85);
            this.dgvReport.Name = "dgvReport";
            this.dgvReport.RowHeadersWidth = 51;
            this.dgvReport.RowTemplate.Height = 24;
            this.dgvReport.Size = new System.Drawing.Size(781, 216);
            this.dgvReport.TabIndex = 5;
            // 
            // btnResetReport
            // 
            this.btnResetReport.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetReport.ForeColor = System.Drawing.Color.RosyBrown;
            this.btnResetReport.Location = new System.Drawing.Point(708, 40);
            this.btnResetReport.Name = "btnResetReport";
            this.btnResetReport.Size = new System.Drawing.Size(137, 35);
            this.btnResetReport.TabIndex = 4;
            this.btnResetReport.Text = "Reset";
            this.btnResetReport.UseVisualStyleBackColor = true;
            this.btnResetReport.Click += new System.EventHandler(this.btnResetReport_Click);
            // 
            // cmbResvType
            // 
            this.cmbResvType.FormattingEnabled = true;
            this.cmbResvType.Items.AddRange(new object[] {
            "All",
            "Birthday",
            "Wedding",
            "Conference",
            "Seminar",
            "Ceremony",
            "Anniversary",
            "Competition",
            "Performance"});
            this.cmbResvType.Location = new System.Drawing.Point(513, 41);
            this.cmbResvType.Name = "cmbResvType";
            this.cmbResvType.Size = new System.Drawing.Size(189, 33);
            this.cmbResvType.TabIndex = 3;
            this.cmbResvType.SelectedIndexChanged += new System.EventHandler(this.cmbResvType_SelectedIndexChanged);
            // 
            // lblResvType
            // 
            this.lblResvType.AutoSize = true;
            this.lblResvType.ForeColor = System.Drawing.SystemColors.Control;
            this.lblResvType.Location = new System.Drawing.Point(323, 45);
            this.lblResvType.Name = "lblResvType";
            this.lblResvType.Size = new System.Drawing.Size(186, 25);
            this.lblResvType.TabIndex = 2;
            this.lblResvType.Text = "Reservation Type";
            // 
            // cmbMonth
            // 
            this.cmbMonth.FormattingEnabled = true;
            this.cmbMonth.Items.AddRange(new object[] {
            "Jan",
            "Feb",
            "Mar",
            "Apr",
            "May",
            "Jun",
            "Jul",
            "Aug",
            "Sep",
            "Oct",
            "Nov",
            "Dec"});
            this.cmbMonth.Location = new System.Drawing.Point(113, 40);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Size = new System.Drawing.Size(149, 33);
            this.cmbMonth.TabIndex = 1;
            this.cmbMonth.SelectedIndexChanged += new System.EventHandler(this.cmbMonth_SelectedIndexChanged);
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Location = new System.Drawing.Point(40, 44);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(79, 25);
            this.lblMonth.TabIndex = 0;
            this.lblMonth.Text = "Month";
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.gbHRReport);
            this.panel2.Location = new System.Drawing.Point(191, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(890, 455);
            this.panel2.TabIndex = 2;
            // 
            // MainHallResvReport
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(237)))), ((int)(((byte)(225)))));
            this.ClientSize = new System.Drawing.Size(1082, 453);
            this.Controls.Add(this.tableSidebar_HRReport);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MainHallResvReport";
            this.Text = "HallResvReport";
            this.tableSidebar_HRReport.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).EndInit();
            this.gbHRReport.ResumeLayout(false);
            this.gbHRReport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).EndInit();
            this.panel2.ResumeLayout(false);
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
        private System.Windows.Forms.Button btnResetReport;
        private System.Windows.Forms.ComboBox cmbResvType;
        private System.Windows.Forms.Label lblResvType;
        private System.Windows.Forms.DataGridView dgvReport;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pic_logo;
        private System.Windows.Forms.Panel panel2;
    }
}