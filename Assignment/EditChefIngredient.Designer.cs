namespace Assignment
{
    partial class EditChefIngredient
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
            this.tableSidebar_ECInventory = new System.Windows.Forms.TableLayoutPanel();
            this.btn_ECinventory = new System.Windows.Forms.Button();
            this.btn_ECCusOrder = new System.Windows.Forms.Button();
            this.btn_ECChefProfile = new System.Windows.Forms.Button();
            this.gbECIngredient = new System.Windows.Forms.GroupBox();
            this.btnCancelEditIngredient = new System.Windows.Forms.Button();
            this.btnSaveIngredient = new System.Windows.Forms.Button();
            this.txtEditStock = new System.Windows.Forms.TextBox();
            this.txtEditIngredient = new System.Windows.Forms.TextBox();
            this.lblEditStock = new System.Windows.Forms.Label();
            this.lblEditIngredient = new System.Windows.Forms.Label();
            this.tableSidebar_ECInventory.SuspendLayout();
            this.gbECIngredient.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableSidebar_ECInventory
            // 
            this.tableSidebar_ECInventory.ColumnCount = 1;
            this.tableSidebar_ECInventory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableSidebar_ECInventory.Controls.Add(this.btn_ECinventory, 0, 1);
            this.tableSidebar_ECInventory.Controls.Add(this.btn_ECCusOrder, 0, 2);
            this.tableSidebar_ECInventory.Controls.Add(this.btn_ECChefProfile, 0, 3);
            this.tableSidebar_ECInventory.Location = new System.Drawing.Point(12, 11);
            this.tableSidebar_ECInventory.Name = "tableSidebar_ECInventory";
            this.tableSidebar_ECInventory.RowCount = 5;
            this.tableSidebar_ECInventory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableSidebar_ECInventory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableSidebar_ECInventory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableSidebar_ECInventory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableSidebar_ECInventory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableSidebar_ECInventory.Size = new System.Drawing.Size(200, 430);
            this.tableSidebar_ECInventory.TabIndex = 7;
            // 
            // btn_ECinventory
            // 
            this.btn_ECinventory.BackColor = System.Drawing.Color.Silver;
            this.btn_ECinventory.FlatAppearance.BorderSize = 0;
            this.btn_ECinventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ECinventory.Location = new System.Drawing.Point(3, 62);
            this.btn_ECinventory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_ECinventory.Name = "btn_ECinventory";
            this.btn_ECinventory.Size = new System.Drawing.Size(194, 36);
            this.btn_ECinventory.TabIndex = 0;
            this.btn_ECinventory.Text = "Manage Inventory";
            this.btn_ECinventory.UseVisualStyleBackColor = false;
            this.btn_ECinventory.Click += new System.EventHandler(this.btn_ECinventory_Click);
            // 
            // btn_ECCusOrder
            // 
            this.btn_ECCusOrder.BackColor = System.Drawing.Color.Silver;
            this.btn_ECCusOrder.FlatAppearance.BorderSize = 0;
            this.btn_ECCusOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ECCusOrder.Location = new System.Drawing.Point(3, 102);
            this.btn_ECCusOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_ECCusOrder.Name = "btn_ECCusOrder";
            this.btn_ECCusOrder.Size = new System.Drawing.Size(194, 36);
            this.btn_ECCusOrder.TabIndex = 1;
            this.btn_ECCusOrder.Text = "Customer\'s Orders";
            this.btn_ECCusOrder.UseVisualStyleBackColor = false;
            this.btn_ECCusOrder.Click += new System.EventHandler(this.btn_ECCusOrder_Click);
            // 
            // btn_ECChefProfile
            // 
            this.btn_ECChefProfile.BackColor = System.Drawing.Color.Silver;
            this.btn_ECChefProfile.FlatAppearance.BorderSize = 0;
            this.btn_ECChefProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ECChefProfile.Location = new System.Drawing.Point(3, 142);
            this.btn_ECChefProfile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_ECChefProfile.Name = "btn_ECChefProfile";
            this.btn_ECChefProfile.Size = new System.Drawing.Size(194, 36);
            this.btn_ECChefProfile.TabIndex = 2;
            this.btn_ECChefProfile.Text = "Chef Profile";
            this.btn_ECChefProfile.UseVisualStyleBackColor = false;
            this.btn_ECChefProfile.Click += new System.EventHandler(this.btn_ECChefProfile_Click);
            // 
            // gbECIngredient
            // 
            this.gbECIngredient.Controls.Add(this.btnCancelEditIngredient);
            this.gbECIngredient.Controls.Add(this.btnSaveIngredient);
            this.gbECIngredient.Controls.Add(this.txtEditStock);
            this.gbECIngredient.Controls.Add(this.txtEditIngredient);
            this.gbECIngredient.Controls.Add(this.lblEditStock);
            this.gbECIngredient.Controls.Add(this.lblEditIngredient);
            this.gbECIngredient.Location = new System.Drawing.Point(220, 71);
            this.gbECIngredient.Name = "gbECIngredient";
            this.gbECIngredient.Size = new System.Drawing.Size(850, 370);
            this.gbECIngredient.TabIndex = 8;
            this.gbECIngredient.TabStop = false;
            this.gbECIngredient.Text = "Edit Ingredient";
            // 
            // btnCancelEditIngredient
            // 
            this.btnCancelEditIngredient.Location = new System.Drawing.Point(421, 316);
            this.btnCancelEditIngredient.Name = "btnCancelEditIngredient";
            this.btnCancelEditIngredient.Size = new System.Drawing.Size(370, 34);
            this.btnCancelEditIngredient.TabIndex = 9;
            this.btnCancelEditIngredient.Text = "Cancel";
            this.btnCancelEditIngredient.UseVisualStyleBackColor = true;
            this.btnCancelEditIngredient.Click += new System.EventHandler(this.btnCancelEditIngredient_Click);
            // 
            // btnSaveIngredient
            // 
            this.btnSaveIngredient.Location = new System.Drawing.Point(45, 316);
            this.btnSaveIngredient.Name = "btnSaveIngredient";
            this.btnSaveIngredient.Size = new System.Drawing.Size(370, 34);
            this.btnSaveIngredient.TabIndex = 8;
            this.btnSaveIngredient.Text = "Save Ingredient";
            this.btnSaveIngredient.UseVisualStyleBackColor = true;
            this.btnSaveIngredient.Click += new System.EventHandler(this.btnSaveIngredient_Click);
            // 
            // txtEditStock
            // 
            this.txtEditStock.Location = new System.Drawing.Point(207, 141);
            this.txtEditStock.Name = "txtEditStock";
            this.txtEditStock.Size = new System.Drawing.Size(301, 30);
            this.txtEditStock.TabIndex = 4;
            // 
            // txtEditIngredient
            // 
            this.txtEditIngredient.Location = new System.Drawing.Point(207, 63);
            this.txtEditIngredient.Name = "txtEditIngredient";
            this.txtEditIngredient.Size = new System.Drawing.Size(301, 30);
            this.txtEditIngredient.TabIndex = 3;
            // 
            // lblEditStock
            // 
            this.lblEditStock.AutoSize = true;
            this.lblEditStock.Location = new System.Drawing.Point(68, 144);
            this.lblEditStock.Name = "lblEditStock";
            this.lblEditStock.Size = new System.Drawing.Size(62, 25);
            this.lblEditStock.TabIndex = 1;
            this.lblEditStock.Text = "Stock";
            // 
            // lblEditIngredient
            // 
            this.lblEditIngredient.AutoSize = true;
            this.lblEditIngredient.Location = new System.Drawing.Point(68, 66);
            this.lblEditIngredient.Name = "lblEditIngredient";
            this.lblEditIngredient.Size = new System.Drawing.Size(98, 25);
            this.lblEditIngredient.TabIndex = 0;
            this.lblEditIngredient.Text = "Ingredient";
            // 
            // EditChefIngredient
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1082, 453);
            this.Controls.Add(this.gbECIngredient);
            this.Controls.Add(this.tableSidebar_ECInventory);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "EditChefIngredient";
            this.Text = "EditChefIngredient";
            this.tableSidebar_ECInventory.ResumeLayout(false);
            this.gbECIngredient.ResumeLayout(false);
            this.gbECIngredient.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableSidebar_ECInventory;
        private System.Windows.Forms.Button btn_ECinventory;
        private System.Windows.Forms.Button btn_ECCusOrder;
        private System.Windows.Forms.Button btn_ECChefProfile;
        private System.Windows.Forms.GroupBox gbECIngredient;
        private System.Windows.Forms.Button btnCancelEditIngredient;
        private System.Windows.Forms.Button btnSaveIngredient;
        private System.Windows.Forms.TextBox txtEditStock;
        private System.Windows.Forms.TextBox txtEditIngredient;
        private System.Windows.Forms.Label lblEditStock;
        private System.Windows.Forms.Label lblEditIngredient;
    }
}