namespace Assignment
{
    partial class EditHallData
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
            this.gbEditHall = new System.Windows.Forms.GroupBox();
            this.txtEditPriceHall = new System.Windows.Forms.TextBox();
            this.btnCancelEditHall = new System.Windows.Forms.Button();
            this.btnSaveHallName = new System.Windows.Forms.Button();
            this.txtEditCapacityHall = new System.Windows.Forms.TextBox();
            this.txtEditHall = new System.Windows.Forms.TextBox();
            this.lblEditPriceHall = new System.Windows.Forms.Label();
            this.lblEditCapacityHall = new System.Windows.Forms.Label();
            this.lblEditHallName = new System.Windows.Forms.Label();
            this.gbEditHall.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbEditHall
            // 
            this.gbEditHall.Controls.Add(this.txtEditPriceHall);
            this.gbEditHall.Controls.Add(this.btnCancelEditHall);
            this.gbEditHall.Controls.Add(this.btnSaveHallName);
            this.gbEditHall.Controls.Add(this.txtEditCapacityHall);
            this.gbEditHall.Controls.Add(this.txtEditHall);
            this.gbEditHall.Controls.Add(this.lblEditPriceHall);
            this.gbEditHall.Controls.Add(this.lblEditCapacityHall);
            this.gbEditHall.Controls.Add(this.lblEditHallName);
            this.gbEditHall.Location = new System.Drawing.Point(12, 12);
            this.gbEditHall.Name = "gbEditHall";
            this.gbEditHall.Size = new System.Drawing.Size(1058, 429);
            this.gbEditHall.TabIndex = 6;
            this.gbEditHall.TabStop = false;
            this.gbEditHall.Text = "Edit Hall Name";
            // 
            // txtEditPriceHall
            // 
            this.txtEditPriceHall.Location = new System.Drawing.Point(451, 255);
            this.txtEditPriceHall.Name = "txtEditPriceHall";
            this.txtEditPriceHall.Size = new System.Drawing.Size(301, 30);
            this.txtEditPriceHall.TabIndex = 10;
            // 
            // btnCancelEditHall
            // 
            this.btnCancelEditHall.Location = new System.Drawing.Point(522, 333);
            this.btnCancelEditHall.Name = "btnCancelEditHall";
            this.btnCancelEditHall.Size = new System.Drawing.Size(370, 34);
            this.btnCancelEditHall.TabIndex = 9;
            this.btnCancelEditHall.Text = "Cancel";
            this.btnCancelEditHall.UseVisualStyleBackColor = true;
            this.btnCancelEditHall.Click += new System.EventHandler(this.btnCancelEditHall_Click);
            // 
            // btnSaveHallName
            // 
            this.btnSaveHallName.Location = new System.Drawing.Point(146, 333);
            this.btnSaveHallName.Name = "btnSaveHallName";
            this.btnSaveHallName.Size = new System.Drawing.Size(370, 34);
            this.btnSaveHallName.TabIndex = 8;
            this.btnSaveHallName.Text = "Save Hall Name";
            this.btnSaveHallName.UseVisualStyleBackColor = true;
            this.btnSaveHallName.Click += new System.EventHandler(this.btnSaveHallName_Click);
            // 
            // txtEditCapacityHall
            // 
            this.txtEditCapacityHall.Location = new System.Drawing.Point(451, 174);
            this.txtEditCapacityHall.Name = "txtEditCapacityHall";
            this.txtEditCapacityHall.Size = new System.Drawing.Size(301, 30);
            this.txtEditCapacityHall.TabIndex = 4;
            // 
            // txtEditHall
            // 
            this.txtEditHall.Location = new System.Drawing.Point(451, 96);
            this.txtEditHall.Name = "txtEditHall";
            this.txtEditHall.Size = new System.Drawing.Size(301, 30);
            this.txtEditHall.TabIndex = 3;
            // 
            // lblEditPriceHall
            // 
            this.lblEditPriceHall.AutoSize = true;
            this.lblEditPriceHall.Location = new System.Drawing.Point(312, 258);
            this.lblEditPriceHall.Name = "lblEditPriceHall";
            this.lblEditPriceHall.Size = new System.Drawing.Size(56, 25);
            this.lblEditPriceHall.TabIndex = 2;
            this.lblEditPriceHall.Text = "Price";
            // 
            // lblEditCapacityHall
            // 
            this.lblEditCapacityHall.AutoSize = true;
            this.lblEditCapacityHall.Location = new System.Drawing.Point(312, 177);
            this.lblEditCapacityHall.Name = "lblEditCapacityHall";
            this.lblEditCapacityHall.Size = new System.Drawing.Size(89, 25);
            this.lblEditCapacityHall.TabIndex = 1;
            this.lblEditCapacityHall.Text = "Capacity";
            // 
            // lblEditHallName
            // 
            this.lblEditHallName.AutoSize = true;
            this.lblEditHallName.Location = new System.Drawing.Point(312, 99);
            this.lblEditHallName.Name = "lblEditHallName";
            this.lblEditHallName.Size = new System.Drawing.Size(102, 25);
            this.lblEditHallName.TabIndex = 0;
            this.lblEditHallName.Text = "Hall Name";
            // 
            // EditHallData
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1082, 453);
            this.Controls.Add(this.gbEditHall);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "EditHallData";
            this.Text = "Edit Hall Data";
            this.gbEditHall.ResumeLayout(false);
            this.gbEditHall.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbEditHall;
        private System.Windows.Forms.Button btnCancelEditHall;
        private System.Windows.Forms.Button btnSaveHallName;
        private System.Windows.Forms.TextBox txtEditCapacityHall;
        private System.Windows.Forms.TextBox txtEditHall;
        private System.Windows.Forms.Label lblEditPriceHall;
        private System.Windows.Forms.Label lblEditCapacityHall;
        private System.Windows.Forms.Label lblEditHallName;
        private System.Windows.Forms.TextBox txtEditPriceHall;
    }
}