namespace Assignment
{
    partial class ChefHomepage
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
            this.tableSidebar_ChefCustomerOrder = new System.Windows.Forms.TableLayoutPanel();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.lbl_chef = new System.Windows.Forms.Label();
            this.btnChefProfile_ChefCustomerOrder = new System.Windows.Forms.Button();
            this.btnCusOrder_ChefCustomerOrder = new System.Windows.Forms.Button();
            this.btninventory_ChefCustomerOrder = new System.Windows.Forms.Button();
            this.tableSidebar_ChefCustomerOrder.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableSidebar_ChefCustomerOrder
            // 
            this.tableSidebar_ChefCustomerOrder.BackColor = System.Drawing.Color.SandyBrown;
            this.tableSidebar_ChefCustomerOrder.ColumnCount = 1;
            this.tableSidebar_ChefCustomerOrder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableSidebar_ChefCustomerOrder.Controls.Add(this.lbl_chef, 0, 0);
            this.tableSidebar_ChefCustomerOrder.Controls.Add(this.btninventory_ChefCustomerOrder, 0, 1);
            this.tableSidebar_ChefCustomerOrder.Controls.Add(this.btnCusOrder_ChefCustomerOrder, 0, 2);
            this.tableSidebar_ChefCustomerOrder.Controls.Add(this.btnChefProfile_ChefCustomerOrder, 0, 3);
            this.tableSidebar_ChefCustomerOrder.Controls.Add(this.btnLogOut, 0, 4);
            this.tableSidebar_ChefCustomerOrder.Location = new System.Drawing.Point(12, -1);
            this.tableSidebar_ChefCustomerOrder.Name = "tableSidebar_ChefCustomerOrder";
            this.tableSidebar_ChefCustomerOrder.RowCount = 6;
            this.tableSidebar_ChefCustomerOrder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableSidebar_ChefCustomerOrder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableSidebar_ChefCustomerOrder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableSidebar_ChefCustomerOrder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableSidebar_ChefCustomerOrder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableSidebar_ChefCustomerOrder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 154F));
            this.tableSidebar_ChefCustomerOrder.Size = new System.Drawing.Size(236, 458);
            this.tableSidebar_ChefCustomerOrder.TabIndex = 7;
            this.tableSidebar_ChefCustomerOrder.Paint += new System.Windows.Forms.PaintEventHandler(this.tableSidebar_ChefCustomerOrder_Paint);
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.Gainsboro;
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.Location = new System.Drawing.Point(3, 238);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(230, 39);
            this.btnLogOut.TabIndex = 15;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // lbl_chef
            // 
            this.lbl_chef.AutoSize = true;
            this.lbl_chef.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_chef.Location = new System.Drawing.Point(3, 0);
            this.lbl_chef.Name = "lbl_chef";
            this.lbl_chef.Size = new System.Drawing.Size(93, 39);
            this.lbl_chef.TabIndex = 14;
            this.lbl_chef.Text = "Chef";
            // 
            // btnChefProfile_ChefCustomerOrder
            // 
            this.btnChefProfile_ChefCustomerOrder.BackColor = System.Drawing.Color.Gainsboro;
            this.btnChefProfile_ChefCustomerOrder.FlatAppearance.BorderSize = 0;
            this.btnChefProfile_ChefCustomerOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChefProfile_ChefCustomerOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChefProfile_ChefCustomerOrder.Location = new System.Drawing.Point(3, 192);
            this.btnChefProfile_ChefCustomerOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnChefProfile_ChefCustomerOrder.Name = "btnChefProfile_ChefCustomerOrder";
            this.btnChefProfile_ChefCustomerOrder.Size = new System.Drawing.Size(230, 40);
            this.btnChefProfile_ChefCustomerOrder.TabIndex = 2;
            this.btnChefProfile_ChefCustomerOrder.Text = "Chef Profile";
            this.btnChefProfile_ChefCustomerOrder.UseVisualStyleBackColor = false;
            this.btnChefProfile_ChefCustomerOrder.Click += new System.EventHandler(this.btnChefProfile_ChefCustomerOrder_Click);
            // 
            // btnCusOrder_ChefCustomerOrder
            // 
            this.btnCusOrder_ChefCustomerOrder.BackColor = System.Drawing.Color.Gainsboro;
            this.btnCusOrder_ChefCustomerOrder.FlatAppearance.BorderSize = 0;
            this.btnCusOrder_ChefCustomerOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCusOrder_ChefCustomerOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCusOrder_ChefCustomerOrder.Location = new System.Drawing.Point(3, 147);
            this.btnCusOrder_ChefCustomerOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCusOrder_ChefCustomerOrder.Name = "btnCusOrder_ChefCustomerOrder";
            this.btnCusOrder_ChefCustomerOrder.Size = new System.Drawing.Size(230, 40);
            this.btnCusOrder_ChefCustomerOrder.TabIndex = 1;
            this.btnCusOrder_ChefCustomerOrder.Text = "Customer\'s Orders";
            this.btnCusOrder_ChefCustomerOrder.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCusOrder_ChefCustomerOrder.UseVisualStyleBackColor = false;
            this.btnCusOrder_ChefCustomerOrder.Click += new System.EventHandler(this.btnCusOrder_ChefCustomerOrder_Click);
            // 
            // btninventory_ChefCustomerOrder
            // 
            this.btninventory_ChefCustomerOrder.BackColor = System.Drawing.Color.Gainsboro;
            this.btninventory_ChefCustomerOrder.FlatAppearance.BorderSize = 0;
            this.btninventory_ChefCustomerOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btninventory_ChefCustomerOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninventory_ChefCustomerOrder.Image = global::Assignment.Properties.Resources.inventory;
            this.btninventory_ChefCustomerOrder.Location = new System.Drawing.Point(3, 102);
            this.btninventory_ChefCustomerOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btninventory_ChefCustomerOrder.Name = "btninventory_ChefCustomerOrder";
            this.btninventory_ChefCustomerOrder.Size = new System.Drawing.Size(230, 40);
            this.btninventory_ChefCustomerOrder.TabIndex = 0;
            this.btninventory_ChefCustomerOrder.Text = "Manage Inventory";
            this.btninventory_ChefCustomerOrder.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btninventory_ChefCustomerOrder.UseVisualStyleBackColor = false;
            this.btninventory_ChefCustomerOrder.Click += new System.EventHandler(this.btninventory_ChefCustomerOrder_Click);
            // 
            // ChefHomepage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(237)))), ((int)(((byte)(225)))));
            this.ClientSize = new System.Drawing.Size(1082, 453);
            this.Controls.Add(this.tableSidebar_ChefCustomerOrder);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ChefHomepage";
            this.Text = "ChefHomepage";
            this.Load += new System.EventHandler(this.ChefHomepage_Load);
            this.tableSidebar_ChefCustomerOrder.ResumeLayout(false);
            this.tableSidebar_ChefCustomerOrder.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableSidebar_ChefCustomerOrder;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Label lbl_chef;
        private System.Windows.Forms.Button btninventory_ChefCustomerOrder;
        private System.Windows.Forms.Button btnCusOrder_ChefCustomerOrder;
        private System.Windows.Forms.Button btnChefProfile_ChefCustomerOrder;
    }
}