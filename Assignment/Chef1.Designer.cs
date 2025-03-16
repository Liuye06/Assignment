namespace Assignment
{
    partial class Chef1
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
            this.lbl_main = new System.Windows.Forms.Label();
            this.btn_c_order = new System.Windows.Forms.Button();
            this.btn_inventory = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_main
            // 
            this.lbl_main.AutoSize = true;
            this.lbl_main.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_main.Location = new System.Drawing.Point(282, 88);
            this.lbl_main.Name = "lbl_main";
            this.lbl_main.Size = new System.Drawing.Size(246, 37);
            this.lbl_main.TabIndex = 0;
            this.lbl_main.Text = "Chef Mainpage";
            // 
            // btn_c_order
            // 
            this.btn_c_order.Location = new System.Drawing.Point(179, 245);
            this.btn_c_order.Name = "btn_c_order";
            this.btn_c_order.Size = new System.Drawing.Size(160, 53);
            this.btn_c_order.TabIndex = 1;
            this.btn_c_order.Text = "Customers\' Order";
            this.btn_c_order.UseVisualStyleBackColor = true;
            this.btn_c_order.Click += new System.EventHandler(this.btn_c_order_Click);
            // 
            // btn_inventory
            // 
            this.btn_inventory.Location = new System.Drawing.Point(437, 245);
            this.btn_inventory.Name = "btn_inventory";
            this.btn_inventory.Size = new System.Drawing.Size(133, 53);
            this.btn_inventory.TabIndex = 2;
            this.btn_inventory.Text = "Inventory";
            this.btn_inventory.UseVisualStyleBackColor = true;
            this.btn_inventory.Click += new System.EventHandler(this.btn_inventory_Click);
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Image = global::Assignment.Properties.Resources.Screenshot_2025_03_06_114139;
            this.button3.Location = new System.Drawing.Point(657, 35);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(111, 106);
            this.button3.TabIndex = 3;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Chef
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btn_inventory);
            this.Controls.Add(this.btn_c_order);
            this.Controls.Add(this.lbl_main);
            this.Name = "Chef";
            this.Text = "Chef";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_main;
        private System.Windows.Forms.Button btn_c_order;
        private System.Windows.Forms.Button btn_inventory;
        private System.Windows.Forms.Button button3;
    }
}