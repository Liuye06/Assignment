namespace Assignment
{
    partial class Orders_Confirmation
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
            this.lstV_Items = new System.Windows.Forms.ListView();
            this.lbl_OrderTotal_O = new System.Windows.Forms.Label();
            this.lbl_OrderTotal = new System.Windows.Forms.Label();
            this.btn_Confirm = new System.Windows.Forms.Button();
            this.btnReturn_MakeOrder_S = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstV_Items
            // 
            this.lstV_Items.HideSelection = false;
            this.lstV_Items.Location = new System.Drawing.Point(130, 82);
            this.lstV_Items.Name = "lstV_Items";
            this.lstV_Items.Size = new System.Drawing.Size(203, 253);
            this.lstV_Items.TabIndex = 0;
            this.lstV_Items.UseCompatibleStateImageBehavior = false;
            this.lstV_Items.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // lbl_OrderTotal_O
            // 
            this.lbl_OrderTotal_O.AutoSize = true;
            this.lbl_OrderTotal_O.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_OrderTotal_O.Location = new System.Drawing.Point(185, 360);
            this.lbl_OrderTotal_O.Name = "lbl_OrderTotal_O";
            this.lbl_OrderTotal_O.Size = new System.Drawing.Size(2, 15);
            this.lbl_OrderTotal_O.TabIndex = 6;
            // 
            // lbl_OrderTotal
            // 
            this.lbl_OrderTotal.AutoSize = true;
            this.lbl_OrderTotal.Location = new System.Drawing.Point(127, 360);
            this.lbl_OrderTotal.Name = "lbl_OrderTotal";
            this.lbl_OrderTotal.Size = new System.Drawing.Size(37, 13);
            this.lbl_OrderTotal.TabIndex = 5;
            this.lbl_OrderTotal.Text = "Total :";
            // 
            // btn_Confirm
            // 
            this.btn_Confirm.Location = new System.Drawing.Point(375, 295);
            this.btn_Confirm.Name = "btn_Confirm";
            this.btn_Confirm.Size = new System.Drawing.Size(97, 40);
            this.btn_Confirm.TabIndex = 9;
            this.btn_Confirm.Text = "Confirm Order";
            this.btn_Confirm.UseVisualStyleBackColor = true;
            // 
            // btnReturn_MakeOrder_S
            // 
            this.btnReturn_MakeOrder_S.Location = new System.Drawing.Point(12, 12);
            this.btnReturn_MakeOrder_S.Name = "btnReturn_MakeOrder_S";
            this.btnReturn_MakeOrder_S.Size = new System.Drawing.Size(44, 34);
            this.btnReturn_MakeOrder_S.TabIndex = 72;
            this.btnReturn_MakeOrder_S.Text = "<";
            this.btnReturn_MakeOrder_S.UseVisualStyleBackColor = true;
            // 
            // Orders_Confirmation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReturn_MakeOrder_S);
            this.Controls.Add(this.btn_Confirm);
            this.Controls.Add(this.lbl_OrderTotal_O);
            this.Controls.Add(this.lbl_OrderTotal);
            this.Controls.Add(this.lstV_Items);
            this.Name = "Orders_Confirmation";
            this.Text = "Orders_Last";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstV_Items;
        private System.Windows.Forms.Label lbl_OrderTotal_O;
        private System.Windows.Forms.Label lbl_OrderTotal;
        private System.Windows.Forms.Button btn_Confirm;
        private System.Windows.Forms.Button btnReturn_MakeOrder_S;
    }
}