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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddChefIngredient));
            this.gbAddNewIngredient = new System.Windows.Forms.GroupBox();
            this.btnCancelIngredient = new System.Windows.Forms.Button();
            this.txtAddStock = new System.Windows.Forms.TextBox();
            this.lblAddStock = new System.Windows.Forms.Label();
            this.btnAddNewIngredient = new System.Windows.Forms.Button();
            this.lblAddIngredient = new System.Windows.Forms.Label();
            this.txtAddIngredient = new System.Windows.Forms.TextBox();
            this.gbAddNewIngredient.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbAddNewIngredient
            // 
            this.gbAddNewIngredient.BackColor = System.Drawing.Color.Transparent;
            this.gbAddNewIngredient.Controls.Add(this.btnCancelIngredient);
            this.gbAddNewIngredient.Controls.Add(this.txtAddStock);
            this.gbAddNewIngredient.Controls.Add(this.lblAddStock);
            this.gbAddNewIngredient.Controls.Add(this.btnAddNewIngredient);
            this.gbAddNewIngredient.Controls.Add(this.lblAddIngredient);
            this.gbAddNewIngredient.Controls.Add(this.txtAddIngredient);
            this.gbAddNewIngredient.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAddNewIngredient.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.gbAddNewIngredient.Location = new System.Drawing.Point(73, 28);
            this.gbAddNewIngredient.Name = "gbAddNewIngredient";
            this.gbAddNewIngredient.Size = new System.Drawing.Size(963, 402);
            this.gbAddNewIngredient.TabIndex = 7;
            this.gbAddNewIngredient.TabStop = false;
            this.gbAddNewIngredient.Text = "Add New Ingredient";
            // 
            // btnCancelIngredient
            // 
            this.btnCancelIngredient.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelIngredient.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnCancelIngredient.Location = new System.Drawing.Point(492, 324);
            this.btnCancelIngredient.Name = "btnCancelIngredient";
            this.btnCancelIngredient.Size = new System.Drawing.Size(370, 34);
            this.btnCancelIngredient.TabIndex = 9;
            this.btnCancelIngredient.Text = "Cancel";
            this.btnCancelIngredient.UseVisualStyleBackColor = true;
            this.btnCancelIngredient.Click += new System.EventHandler(this.btnCancelIngredient_Click);
            // 
            // txtAddStock
            // 
            this.txtAddStock.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtAddStock.Location = new System.Drawing.Point(408, 188);
            this.txtAddStock.Name = "txtAddStock";
            this.txtAddStock.Size = new System.Drawing.Size(309, 36);
            this.txtAddStock.TabIndex = 7;
            // 
            // lblAddStock
            // 
            this.lblAddStock.AutoSize = true;
            this.lblAddStock.Location = new System.Drawing.Point(217, 188);
            this.lblAddStock.Name = "lblAddStock";
            this.lblAddStock.Size = new System.Drawing.Size(81, 30);
            this.lblAddStock.TabIndex = 5;
            this.lblAddStock.Text = "Stock";
            // 
            // btnAddNewIngredient
            // 
            this.btnAddNewIngredient.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewIngredient.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnAddNewIngredient.Location = new System.Drawing.Point(117, 324);
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
            this.lblAddIngredient.Location = new System.Drawing.Point(217, 104);
            this.lblAddIngredient.Name = "lblAddIngredient";
            this.lblAddIngredient.Size = new System.Drawing.Size(142, 30);
            this.lblAddIngredient.TabIndex = 1;
            this.lblAddIngredient.Text = "Ingredient";
            // 
            // txtAddIngredient
            // 
            this.txtAddIngredient.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtAddIngredient.Location = new System.Drawing.Point(408, 104);
            this.txtAddIngredient.Name = "txtAddIngredient";
            this.txtAddIngredient.Size = new System.Drawing.Size(309, 36);
            this.txtAddIngredient.TabIndex = 0;
            // 
            // AddChefIngredient
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(237)))), ((int)(((byte)(225)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1082, 453);
            this.Controls.Add(this.gbAddNewIngredient);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "AddChefIngredient";
            this.Text = "AddChefIngredient";
            this.gbAddNewIngredient.ResumeLayout(false);
            this.gbAddNewIngredient.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbAddNewIngredient;
        private System.Windows.Forms.Button btnCancelIngredient;
        private System.Windows.Forms.TextBox txtAddStock;
        private System.Windows.Forms.Label lblAddStock;
        private System.Windows.Forms.Button btnAddNewIngredient;
        private System.Windows.Forms.Label lblAddIngredient;
        private System.Windows.Forms.TextBox txtAddIngredient;
    }
}