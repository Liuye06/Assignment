namespace Assignment
{
    partial class ManagerHomepage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerHomepage));
            this.tableSidebar_MMenu = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pic_logo = new System.Windows.Forms.PictureBox();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnMMenu_MMenu = new System.Windows.Forms.Button();
            this.btnMHall_MMenu = new System.Windows.Forms.Button();
            this.btn_HRReport_MMenu = new System.Windows.Forms.Button();
            this.btnUProfile_MMenu = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableSidebar_MMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableSidebar_MMenu
            // 
            this.tableSidebar_MMenu.BackColor = System.Drawing.Color.Tomato;
            this.tableSidebar_MMenu.ColumnCount = 1;
            this.tableSidebar_MMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableSidebar_MMenu.Controls.Add(this.panel1, 0, 0);
            this.tableSidebar_MMenu.Controls.Add(this.btnLogOut, 0, 5);
            this.tableSidebar_MMenu.Controls.Add(this.btnMMenu_MMenu, 0, 1);
            this.tableSidebar_MMenu.Controls.Add(this.btnMHall_MMenu, 0, 2);
            this.tableSidebar_MMenu.Controls.Add(this.btn_HRReport_MMenu, 0, 3);
            this.tableSidebar_MMenu.Controls.Add(this.btnUProfile_MMenu, 0, 4);
            this.tableSidebar_MMenu.Location = new System.Drawing.Point(12, -1);
            this.tableSidebar_MMenu.Name = "tableSidebar_MMenu";
            this.tableSidebar_MMenu.RowCount = 7;
            this.tableSidebar_MMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableSidebar_MMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableSidebar_MMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableSidebar_MMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableSidebar_MMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableSidebar_MMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableSidebar_MMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableSidebar_MMenu.Size = new System.Drawing.Size(200, 456);
            this.tableSidebar_MMenu.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pic_logo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(194, 144);
            this.panel1.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-12, -17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 67);
            this.label1.TabIndex = 9;
            this.label1.Text = "Manager";
            // 
            // pic_logo
            // 
            this.pic_logo.Image = ((System.Drawing.Image)(resources.GetObject("pic_logo.Image")));
            this.pic_logo.Location = new System.Drawing.Point(-3, 39);
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
            this.btnLogOut.TabIndex = 4;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnMMenu_MMenu
            // 
            this.btnMMenu_MMenu.BackColor = System.Drawing.Color.Gainsboro;
            this.btnMMenu_MMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMMenu_MMenu.FlatAppearance.BorderSize = 0;
            this.btnMMenu_MMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMMenu_MMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnMHall_MMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btn_HRReport_MMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnUProfile_MMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.WindowText;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 26F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(451, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(420, 53);
            this.label2.TabIndex = 9;
            this.label2.Text = "Welcome Back To Work";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(237, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(833, 389);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // ManagerHomepage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(237)))), ((int)(((byte)(225)))));
            this.ClientSize = new System.Drawing.Size(1082, 453);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tableSidebar_MMenu);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ManagerHomepage";
            this.Text = "ManagerHomepage";
            this.tableSidebar_MMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableSidebar_MMenu;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnMMenu_MMenu;
        private System.Windows.Forms.Button btnMHall_MMenu;
        private System.Windows.Forms.Button btn_HRReport_MMenu;
        private System.Windows.Forms.Button btnUProfile_MMenu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pic_logo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}