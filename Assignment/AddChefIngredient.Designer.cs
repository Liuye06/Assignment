namespace Assignment
{
    partial class AddChefIngredient
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
            this.tableSidebar_ACInventory = new System.Windows.Forms.TableLayoutPanel();
            this.btn_ACinventory = new System.Windows.Forms.Button();
            this.btn_ACCusOrder = new System.Windows.Forms.Button();
            this.btn_ACChefProfile = new System.Windows.Forms.Button();
            this.gbAddNewIngredient = new System.Windows.Forms.GroupBox();
            this.btnCancelIngredient = new System.Windows.Forms.Button();
            this.txtAddStock = new System.Windows.Forms.TextBox();
            this.lblAddStock = new System.Windows.Forms.Label();
            this.btnAddNewIngredient = new System.Windows.Forms.Button();
            this.lblAddIngredient = new System.Windows.Forms.Label();
            this.txtAddIngredient = new System.Windows.Forms.TextBox();
            this.tableSidebar_ACInventory.SuspendLayout();
            this.gbAddNewIngredient.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableSidebar_ACInventory
            // 
            this.tableSidebar_ACInventory.ColumnCount = 1;
            this.tableSidebar_ACInventory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableSidebar_ACInventory.Controls.Add(this.btn_ACinventory, 0, 1);
            this.tableSidebar_ACInventory.Controls.Add(this.btn_ACCusOrder, 0, 2);
            this.tableSidebar_ACInventory.Controls.Add(this.btn_ACChefProfile, 0, 3);
            this.tableSidebar_ACInventory.Location = new System.Drawing.Point(12, 11);
            this.tableSidebar_ACInventory.Name = "tableSidebar_ACInventory";
            this.tableSidebar_ACInventory.RowCount = 5;
            this.tableSidebar_ACInventory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableSidebar_ACInventory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableSidebar_ACInventory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableSidebar_ACInventory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableSidebar_ACInventory.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableSidebar_ACInventory.Size = new System.Drawing.Size(200, 430);
            this.tableSidebar_ACInventory.TabIndex = 6;
            // 
            // btn_ACinventory
            // 
            this.btn_ACinventory.BackColor = System.Drawing.Color.Silver;
            this.btn_ACinventory.FlatAppearance.BorderSize = 0;
            this.btn_ACinventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ACinventory.Location = new System.Drawing.Point(3, 62);
            this.btn_ACinventory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_ACinventory.Name = "btn_ACinventory";
            this.btn_ACinventory.Size = new System.Drawing.Size(194, 36);
            this.btn_ACinventory.TabIndex = 0;
            this.btn_ACinventory.Text = "Manage Inventory";
            this.btn_ACinventory.UseVisualStyleBackColor = false;
            this.btn_ACinventory.Click += new System.EventHandler(this.btn_ACinventory_Click);
            // 
            // btn_ACCusOrder
            // 
            this.btn_ACCusOrder.BackColor = System.Drawing.Color.Silver;
            this.btn_ACCusOrder.FlatAppearance.BorderSize = 0;
            this.btn_ACCusOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ACCusOrder.Location = new System.Drawing.Point(3, 102);
            this.btn_ACCusOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_ACCusOrder.Name = "btn_ACCusOrder";
            this.btn_ACCusOrder.Size = new System.Drawing.Size(194, 36);
            this.btn_ACCusOrder.TabIndex = 1;
            this.btn_ACCusOrder.Text = "Customer\'s Orders";
            this.btn_ACCusOrder.UseVisualStyleBackColor = false;
            this.btn_ACCusOrder.Click += new System.EventHandler(this.btn_ACCusOrder_Click);
            // 
            // btn_ACChefProfile
            // 
            this.btn_ACChefProfile.BackColor = System.Drawing.Color.Silver;
            this.btn_ACChefProfile.FlatAppearance.BorderSize = 0;
            this.btn_ACChefProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ACChefProfile.Location = new System.Drawing.Point(3, 142);
            this.btn_ACChefProfile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_ACChefProfile.Name = "btn_ACChefProfile";
            this.btn_ACChefProfile.Size = new System.Drawing.Size(194, 36);
            this.btn_ACChefProfile.TabIndex = 2;
            this.btn_ACChefProfile.Text = "Chef Profile";
            this.btn_ACChefProfile.UseVisualStyleBackColor = false;
            this.btn_ACChefProfile.Click += new System.EventHandler(this.btn_ACChefProfile_Click);
            // 
            // gbAddNewIngredient
            // 
            this.gbAddNewIngredient.Controls.Add(this.btnCancelIngredient);
            this.gbAddNewIngredient.Controls.Add(this.txtAddStock);
            this.gbAddNewIngredient.Controls.Add(this.lblAddStock);
            this.gbAddNewIngredient.Controls.Add(this.btnAddNewIngredient);
            this.gbAddNewIngredient.Controls.Add(this.lblAddIngredient);
            this.gbAddNewIngredient.Controls.Add(this.txtAddIngredient);
            this.gbAddNewIngredient.Location = new System.Drawing.Point(218, 71);
            this.gbAddNewIngredient.Name = "gbAddNewIngredient";
            this.gbAddNewIngredient.Size = new System.Drawing.Size(852, 370);
            this.gbAddNewIngredient.TabIndex = 7;
            this.gbAddNewIngredient.TabStop = false;
            this.gbAddNewIngredient.Text = "Add New Ingredient";
            // 
            // btnCancelIngredient
            // 
            this.btnCancelIngredient.Location = new System.Drawing.Point(420, 316);
            this.btnCancelIngredient.Name = "btnCancelIngredient";
            this.btnCancelIngredient.Size = new System.Drawing.Size(370, 34);
            this.btnCancelIngredient.TabIndex = 9;
            this.btnCancelIngredient.Text = "Cancel";
            this.btnCancelIngredient.UseVisualStyleBackColor = true;
            this.btnCancelIngredient.Click += new System.EventHandler(this.btnCancelIngredient_Click);
            // 
            // txtAddStock
            // 
            this.txtAddStock.Location = new System.Drawing.Point(197, 144);
            this.txtAddStock.Name = "txtAddStock";
            this.txtAddStock.Size = new System.Drawing.Size(309, 30);
            this.txtAddStock.TabIndex = 7;
            // 
            // lblAddStock
            // 
            this.lblAddStock.AutoSize = true;
            this.lblAddStock.Location = new System.Drawing.Point(65, 147);
            this.lblAddStock.Name = "lblAddStock";
            this.lblAddStock.Size = new System.Drawing.Size(62, 25);
            this.lblAddStock.TabIndex = 5;
            this.lblAddStock.Text = "Stock";
            // 
            // btnAddNewIngredient
            // 
            this.btnAddNewIngredient.Location = new System.Drawing.Point(45, 316);
            this.btnAddNewIngredient.Name = "btnAddNewIngredient";
            this.btnAddNewIngredient.Size = new System.Drawing.Size(370, 34);
            this.btnAddNewIngredient.TabIndex = 3;
            this.btnAddNewIngredient.Text = "Add New Ingredient";
            this.btnAddNewIngredient.UseVisualStyleBackColor = true;
            this.btnAddNewIngredient.Click += new System.EventHandler(this.btnAddNewIngredient_Click);
            // 
            // lblAddIngredient
            // 
            this.lblAddIngredient.AutoSize = true;
            this.lblAddIngredient.Location = new System.Drawing.Point(65, 63);
            this.lblAddIngredient.Name = "lblAddIngredient";
            this.lblAddIngredient.Size = new System.Drawing.Size(98, 25);
            this.lblAddIngredient.TabIndex = 1;
            this.lblAddIngredient.Text = "Ingredient";
            // 
            // txtAddIngredient
            // 
            this.txtAddIngredient.Location = new System.Drawing.Point(197, 60);
            this.txtAddIngredient.Name = "txtAddIngredient";
            this.txtAddIngredient.Size = new System.Drawing.Size(309, 30);
            this.txtAddIngredient.TabIndex = 0;
            // 
            // AddChefIngredient
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1082, 453);
            this.Controls.Add(this.gbAddNewIngredient);
            this.Controls.Add(this.tableSidebar_ACInventory);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "AddChefIngredient";
            this.Text = "AddChefIngredient";
            this.tableSidebar_ACInventory.ResumeLayout(false);
            this.gbAddNewIngredient.ResumeLayout(false);
            this.gbAddNewIngredient.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableSidebar_ACInventory;
        private System.Windows.Forms.Button btn_ACinventory;
        private System.Windows.Forms.Button btn_ACCusOrder;
        private System.Windows.Forms.Button btn_ACChefProfile;
        private System.Windows.Forms.GroupBox gbAddNewIngredient;
        private System.Windows.Forms.Button btnCancelIngredient;
        private System.Windows.Forms.TextBox txtAddStock;
        private System.Windows.Forms.Label lblAddStock;
        private System.Windows.Forms.Button btnAddNewIngredient;
        private System.Windows.Forms.Label lblAddIngredient;
        private System.Windows.Forms.TextBox txtAddIngredient;
    }
}