namespace Assignment
{
    partial class ReservationPayment
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
            this.lbl_OrderID_O = new System.Windows.Forms.Label();
            this.lbl_Reservation = new System.Windows.Forms.Label();
            this.btn_Return = new System.Windows.Forms.Button();
            this.lblTotalFood = new System.Windows.Forms.Label();
            this.btnConfirm_Pay = new System.Windows.Forms.Button();
            this.lstCartFood = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // lbl_OrderID_O
            // 
            this.lbl_OrderID_O.AutoSize = true;
            this.lbl_OrderID_O.Location = new System.Drawing.Point(258, 206);
            this.lbl_OrderID_O.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_OrderID_O.Name = "lbl_OrderID_O";
            this.lbl_OrderID_O.Size = new System.Drawing.Size(0, 25);
            this.lbl_OrderID_O.TabIndex = 88;
            // 
            // lbl_Reservation
            // 
            this.lbl_Reservation.AutoSize = true;
            this.lbl_Reservation.Location = new System.Drawing.Point(31, 78);
            this.lbl_Reservation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Reservation.Name = "lbl_Reservation";
            this.lbl_Reservation.Size = new System.Drawing.Size(169, 25);
            this.lbl_Reservation.TabIndex = 87;
            this.lbl_Reservation.Text = "Reservation Detail";
            // 
            // btn_Return
            // 
            this.btn_Return.Location = new System.Drawing.Point(23, 17);
            this.btn_Return.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Return.Name = "btn_Return";
            this.btn_Return.Size = new System.Drawing.Size(95, 44);
            this.btn_Return.TabIndex = 86;
            this.btn_Return.Text = "<";
            this.btn_Return.UseVisualStyleBackColor = true;
            // 
            // lblTotalFood
            // 
            this.lblTotalFood.AutoSize = true;
            this.lblTotalFood.Location = new System.Drawing.Point(726, 348);
            this.lblTotalFood.Name = "lblTotalFood";
            this.lblTotalFood.Size = new System.Drawing.Size(62, 25);
            this.lblTotalFood.TabIndex = 85;
            this.lblTotalFood.Text = "Total:";
            // 
            // btnConfirm_Pay
            // 
            this.btnConfirm_Pay.Location = new System.Drawing.Point(687, 389);
            this.btnConfirm_Pay.Name = "btnConfirm_Pay";
            this.btnConfirm_Pay.Size = new System.Drawing.Size(364, 46);
            this.btnConfirm_Pay.TabIndex = 84;
            this.btnConfirm_Pay.Text = "Confirm and Pay";
            this.btnConfirm_Pay.UseVisualStyleBackColor = true;
            this.btnConfirm_Pay.Click += new System.EventHandler(this.btnConfirm_Pay_Click);
            // 
            // lstCartFood
            // 
            this.lstCartFood.HideSelection = false;
            this.lstCartFood.Location = new System.Drawing.Point(36, 119);
            this.lstCartFood.Name = "lstCartFood";
            this.lstCartFood.Size = new System.Drawing.Size(1015, 210);
            this.lstCartFood.TabIndex = 83;
            this.lstCartFood.UseCompatibleStateImageBehavior = false;
            // 
            // ReservationPayment
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1082, 453);
            this.Controls.Add(this.lbl_OrderID_O);
            this.Controls.Add(this.lbl_Reservation);
            this.Controls.Add(this.btn_Return);
            this.Controls.Add(this.lblTotalFood);
            this.Controls.Add(this.btnConfirm_Pay);
            this.Controls.Add(this.lstCartFood);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ReservationPayment";
            this.Text = "ReservationPayment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_OrderID_O;
        private System.Windows.Forms.Label lbl_Reservation;
        private System.Windows.Forms.Button btn_Return;
        private System.Windows.Forms.Label lblTotalFood;
        private System.Windows.Forms.Button btnConfirm_Pay;
        private System.Windows.Forms.ListView lstCartFood;
    }
}