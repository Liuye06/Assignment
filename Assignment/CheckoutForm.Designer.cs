namespace Assignment
{
    partial class CheckoutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckoutForm));
            this.lstCartFood = new System.Windows.Forms.ListView();
            this.btnConfirm_Pay = new System.Windows.Forms.Button();
            this.lblTotalFood = new System.Windows.Forms.Label();
            this.lbl_Total_O = new System.Windows.Forms.Label();
            this.lbl_OrderID_O = new System.Windows.Forms.Label();
            this.lbl_Items = new System.Windows.Forms.Label();
            this.btn_Return = new System.Windows.Forms.Button();
            this.btnUpdateOrder = new System.Windows.Forms.Button();
            this.btnRemoveButton = new System.Windows.Forms.Button();
            this.numQuantity = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // lstCartFood
            // 
            this.lstCartFood.BackColor = System.Drawing.SystemColors.MenuBar;
            this.lstCartFood.HideSelection = false;
            this.lstCartFood.Location = new System.Drawing.Point(205, 135);
            this.lstCartFood.Name = "lstCartFood";
            this.lstCartFood.Size = new System.Drawing.Size(461, 210);
            this.lstCartFood.TabIndex = 0;
            this.lstCartFood.UseCompatibleStateImageBehavior = false;
            this.lstCartFood.SelectedIndexChanged += new System.EventHandler(this.lstCartFood_SelectedIndexChanged);
            // 
            // btnConfirm_Pay
            // 
            this.btnConfirm_Pay.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm_Pay.ForeColor = System.Drawing.Color.Coral;
            this.btnConfirm_Pay.Location = new System.Drawing.Point(739, 367);
            this.btnConfirm_Pay.Name = "btnConfirm_Pay";
            this.btnConfirm_Pay.Size = new System.Drawing.Size(308, 46);
            this.btnConfirm_Pay.TabIndex = 1;
            this.btnConfirm_Pay.Text = "Confirm and Pay";
            this.btnConfirm_Pay.UseVisualStyleBackColor = true;
            this.btnConfirm_Pay.Click += new System.EventHandler(this.btnConfirm_Pay_Click);
            // 
            // lblTotalFood
            // 
            this.lblTotalFood.AutoSize = true;
            this.lblTotalFood.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalFood.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalFood.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTotalFood.Location = new System.Drawing.Point(734, 315);
            this.lblTotalFood.Name = "lblTotalFood";
            this.lblTotalFood.Size = new System.Drawing.Size(86, 30);
            this.lblTotalFood.TabIndex = 2;
            this.lblTotalFood.Text = "Total:";
            // 
            // lbl_Total_O
            // 
            this.lbl_Total_O.AutoSize = true;
            this.lbl_Total_O.Location = new System.Drawing.Point(734, 213);
            this.lbl_Total_O.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Total_O.Name = "lbl_Total_O";
            this.lbl_Total_O.Size = new System.Drawing.Size(0, 25);
            this.lbl_Total_O.TabIndex = 76;
            // 
            // lbl_OrderID_O
            // 
            this.lbl_OrderID_O.AutoSize = true;
            this.lbl_OrderID_O.Location = new System.Drawing.Point(257, 202);
            this.lbl_OrderID_O.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_OrderID_O.Name = "lbl_OrderID_O";
            this.lbl_OrderID_O.Size = new System.Drawing.Size(0, 25);
            this.lbl_OrderID_O.TabIndex = 75;
            // 
            // lbl_Items
            // 
            this.lbl_Items.AutoSize = true;
            this.lbl_Items.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Items.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Items.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Items.Location = new System.Drawing.Point(200, 84);
            this.lbl_Items.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Items.Name = "lbl_Items";
            this.lbl_Items.Size = new System.Drawing.Size(88, 30);
            this.lbl_Items.TabIndex = 73;
            this.lbl_Items.Text = "Items:";
            // 
            // btn_Return
            // 
            this.btn_Return.BackColor = System.Drawing.Color.Transparent;
            this.btn_Return.FlatAppearance.BorderSize = 0;
            this.btn_Return.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Return.Image = ((System.Drawing.Image)(resources.GetObject("btn_Return.Image")));
            this.btn_Return.Location = new System.Drawing.Point(32, 13);
            this.btn_Return.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Return.Name = "btn_Return";
            this.btn_Return.Size = new System.Drawing.Size(66, 61);
            this.btn_Return.TabIndex = 70;
            this.btn_Return.UseVisualStyleBackColor = false;
            this.btn_Return.Click += new System.EventHandler(this.btn_Return_Click);
            // 
            // btnUpdateOrder
            // 
            this.btnUpdateOrder.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateOrder.ForeColor = System.Drawing.Color.Coral;
            this.btnUpdateOrder.Location = new System.Drawing.Point(883, 129);
            this.btnUpdateOrder.Name = "btnUpdateOrder";
            this.btnUpdateOrder.Size = new System.Drawing.Size(176, 41);
            this.btnUpdateOrder.TabIndex = 80;
            this.btnUpdateOrder.Text = "Update Order";
            this.btnUpdateOrder.UseVisualStyleBackColor = true;
            this.btnUpdateOrder.Click += new System.EventHandler(this.btnUpdateOrder_Click);
            // 
            // btnRemoveButton
            // 
            this.btnRemoveButton.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveButton.ForeColor = System.Drawing.Color.Coral;
            this.btnRemoveButton.Location = new System.Drawing.Point(883, 187);
            this.btnRemoveButton.Name = "btnRemoveButton";
            this.btnRemoveButton.Size = new System.Drawing.Size(176, 40);
            this.btnRemoveButton.TabIndex = 81;
            this.btnRemoveButton.Text = "Remove Order";
            this.btnRemoveButton.UseVisualStyleBackColor = true;
            this.btnRemoveButton.Click += new System.EventHandler(this.btnRemoveButton_Click);
            // 
            // numQuantity
            // 
            this.numQuantity.Location = new System.Drawing.Point(725, 135);
            this.numQuantity.Name = "numQuantity";
            this.numQuantity.Size = new System.Drawing.Size(120, 30);
            this.numQuantity.TabIndex = 82;
            // 
            // CheckoutForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1082, 453);
            this.Controls.Add(this.numQuantity);
            this.Controls.Add(this.btnRemoveButton);
            this.Controls.Add(this.btnUpdateOrder);
            this.Controls.Add(this.lbl_Total_O);
            this.Controls.Add(this.lbl_OrderID_O);
            this.Controls.Add(this.lbl_Items);
            this.Controls.Add(this.btn_Return);
            this.Controls.Add(this.lblTotalFood);
            this.Controls.Add(this.btnConfirm_Pay);
            this.Controls.Add(this.lstCartFood);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "CheckoutForm";
            this.Text = "CheckoutForm";
            this.Load += new System.EventHandler(this.CheckoutForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstCartFood;
        private System.Windows.Forms.Button btnConfirm_Pay;
        private System.Windows.Forms.Label lblTotalFood;
        private System.Windows.Forms.Label lbl_Total_O;
        private System.Windows.Forms.Label lbl_OrderID_O;
        private System.Windows.Forms.Label lbl_Items;
        private System.Windows.Forms.Button btn_Return;
        private System.Windows.Forms.Button btnUpdateOrder;
        private System.Windows.Forms.Button btnRemoveButton;
        private System.Windows.Forms.NumericUpDown numQuantity;
    }
}