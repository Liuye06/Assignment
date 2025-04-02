namespace Assignment
{
    partial class AddNewHall
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
            this.gbAddNewHall = new System.Windows.Forms.GroupBox();
            this.btnCancelHall = new System.Windows.Forms.Button();
            this.txtPriceHall = new System.Windows.Forms.TextBox();
            this.txtCapacity = new System.Windows.Forms.TextBox();
            this.lblPriceHall = new System.Windows.Forms.Label();
            this.lblCapacity = new System.Windows.Forms.Label();
            this.btnAddNewHall = new System.Windows.Forms.Button();
            this.lblAddHall = new System.Windows.Forms.Label();
            this.txtHallName = new System.Windows.Forms.TextBox();
            this.gbAddNewHall.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbAddNewHall
            // 
            this.gbAddNewHall.Controls.Add(this.btnCancelHall);
            this.gbAddNewHall.Controls.Add(this.txtPriceHall);
            this.gbAddNewHall.Controls.Add(this.txtCapacity);
            this.gbAddNewHall.Controls.Add(this.lblPriceHall);
            this.gbAddNewHall.Controls.Add(this.lblCapacity);
            this.gbAddNewHall.Controls.Add(this.btnAddNewHall);
            this.gbAddNewHall.Controls.Add(this.lblAddHall);
            this.gbAddNewHall.Controls.Add(this.txtHallName);
            this.gbAddNewHall.Location = new System.Drawing.Point(12, 12);
            this.gbAddNewHall.Name = "gbAddNewHall";
            this.gbAddNewHall.Size = new System.Drawing.Size(1059, 429);
            this.gbAddNewHall.TabIndex = 1;
            this.gbAddNewHall.TabStop = false;
            this.gbAddNewHall.Text = "Add New Hall";
            // 
            // btnCancelHall
            // 
            this.btnCancelHall.Location = new System.Drawing.Point(510, 342);
            this.btnCancelHall.Name = "btnCancelHall";
            this.btnCancelHall.Size = new System.Drawing.Size(370, 34);
            this.btnCancelHall.TabIndex = 9;
            this.btnCancelHall.Text = "Cancel";
            this.btnCancelHall.UseVisualStyleBackColor = true;
            this.btnCancelHall.Click += new System.EventHandler(this.btnCancelHall_Click);
            // 
            // txtPriceHall
            // 
            this.txtPriceHall.Location = new System.Drawing.Point(400, 248);
            this.txtPriceHall.Name = "txtPriceHall";
            this.txtPriceHall.Size = new System.Drawing.Size(309, 30);
            this.txtPriceHall.TabIndex = 8;
            // 
            // txtCapacity
            // 
            this.txtCapacity.Location = new System.Drawing.Point(400, 166);
            this.txtCapacity.Name = "txtCapacity";
            this.txtCapacity.Size = new System.Drawing.Size(309, 30);
            this.txtCapacity.TabIndex = 7;
            // 
            // lblPriceHall
            // 
            this.lblPriceHall.AutoSize = true;
            this.lblPriceHall.Location = new System.Drawing.Point(268, 251);
            this.lblPriceHall.Name = "lblPriceHall";
            this.lblPriceHall.Size = new System.Drawing.Size(56, 25);
            this.lblPriceHall.TabIndex = 6;
            this.lblPriceHall.Text = "Price";
            // 
            // lblCapacity
            // 
            this.lblCapacity.AutoSize = true;
            this.lblCapacity.Location = new System.Drawing.Point(268, 169);
            this.lblCapacity.Name = "lblCapacity";
            this.lblCapacity.Size = new System.Drawing.Size(89, 25);
            this.lblCapacity.TabIndex = 5;
            this.lblCapacity.Text = "Capacity";
            // 
            // btnAddNewHall
            // 
            this.btnAddNewHall.Location = new System.Drawing.Point(135, 342);
            this.btnAddNewHall.Name = "btnAddNewHall";
            this.btnAddNewHall.Size = new System.Drawing.Size(370, 34);
            this.btnAddNewHall.TabIndex = 3;
            this.btnAddNewHall.Text = "Add New Hall";
            this.btnAddNewHall.UseVisualStyleBackColor = true;
            this.btnAddNewHall.Click += new System.EventHandler(this.btnAddNewHall_Click);
            // 
            // lblAddHall
            // 
            this.lblAddHall.AutoSize = true;
            this.lblAddHall.Location = new System.Drawing.Point(268, 85);
            this.lblAddHall.Name = "lblAddHall";
            this.lblAddHall.Size = new System.Drawing.Size(102, 25);
            this.lblAddHall.TabIndex = 1;
            this.lblAddHall.Text = "Hall Name";
            // 
            // txtHallName
            // 
            this.txtHallName.Location = new System.Drawing.Point(400, 82);
            this.txtHallName.Name = "txtHallName";
            this.txtHallName.Size = new System.Drawing.Size(309, 30);
            this.txtHallName.TabIndex = 0;
            // 
            // AddNewHall
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1082, 453);
            this.Controls.Add(this.gbAddNewHall);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "AddNewHall";
            this.Text = "Add New Hall";
            this.gbAddNewHall.ResumeLayout(false);
            this.gbAddNewHall.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbAddNewHall;
        private System.Windows.Forms.Label lblAddHall;
        private System.Windows.Forms.TextBox txtHallName;
        private System.Windows.Forms.Button btnAddNewHall;
        private System.Windows.Forms.TextBox txtPriceHall;
        private System.Windows.Forms.TextBox txtCapacity;
        private System.Windows.Forms.Label lblPriceHall;
        private System.Windows.Forms.Label lblCapacity;
        private System.Windows.Forms.Button btnCancelHall;
    }
}