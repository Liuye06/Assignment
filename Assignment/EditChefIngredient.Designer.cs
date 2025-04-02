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
            this.gbECIngredient = new System.Windows.Forms.GroupBox();
            this.btnCancelEditIngredient = new System.Windows.Forms.Button();
            this.btnSaveIngredient = new System.Windows.Forms.Button();
            this.txtEditStock = new System.Windows.Forms.TextBox();
            this.txtEditIngredient = new System.Windows.Forms.TextBox();
            this.lblEditStock = new System.Windows.Forms.Label();
            this.lblEditIngredient = new System.Windows.Forms.Label();
            this.gbECIngredient.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbECIngredient
            // 
            this.gbECIngredient.Controls.Add(this.btnCancelEditIngredient);
            this.gbECIngredient.Controls.Add(this.btnSaveIngredient);
            this.gbECIngredient.Controls.Add(this.txtEditStock);
            this.gbECIngredient.Controls.Add(this.txtEditIngredient);
            this.gbECIngredient.Controls.Add(this.lblEditStock);
            this.gbECIngredient.Controls.Add(this.lblEditIngredient);
            this.gbECIngredient.Location = new System.Drawing.Point(12, 12);
            this.gbECIngredient.Name = "gbECIngredient";
            this.gbECIngredient.Size = new System.Drawing.Size(1058, 429);
            this.gbECIngredient.TabIndex = 8;
            this.gbECIngredient.TabStop = false;
            this.gbECIngredient.Text = "Edit Ingredient";
            // 
            // btnCancelEditIngredient
            // 
            this.btnCancelEditIngredient.Location = new System.Drawing.Point(493, 335);
            this.btnCancelEditIngredient.Name = "btnCancelEditIngredient";
            this.btnCancelEditIngredient.Size = new System.Drawing.Size(370, 34);
            this.btnCancelEditIngredient.TabIndex = 9;
            this.btnCancelEditIngredient.Text = "Cancel";
            this.btnCancelEditIngredient.UseVisualStyleBackColor = true;
            this.btnCancelEditIngredient.Click += new System.EventHandler(this.btnCancelEditIngredient_Click);
            // 
            // btnSaveIngredient
            // 
            this.btnSaveIngredient.Location = new System.Drawing.Point(117, 335);
            this.btnSaveIngredient.Name = "btnSaveIngredient";
            this.btnSaveIngredient.Size = new System.Drawing.Size(370, 34);
            this.btnSaveIngredient.TabIndex = 8;
            this.btnSaveIngredient.Text = "Save Ingredient";
            this.btnSaveIngredient.UseVisualStyleBackColor = true;
            this.btnSaveIngredient.Click += new System.EventHandler(this.btnSaveIngredient_Click);
            // 
            // txtEditStock
            // 
            this.txtEditStock.Location = new System.Drawing.Point(400, 188);
            this.txtEditStock.Name = "txtEditStock";
            this.txtEditStock.Size = new System.Drawing.Size(301, 30);
            this.txtEditStock.TabIndex = 4;
            // 
            // txtEditIngredient
            // 
            this.txtEditIngredient.Location = new System.Drawing.Point(400, 110);
            this.txtEditIngredient.Name = "txtEditIngredient";
            this.txtEditIngredient.Size = new System.Drawing.Size(301, 30);
            this.txtEditIngredient.TabIndex = 3;
            // 
            // lblEditStock
            // 
            this.lblEditStock.AutoSize = true;
            this.lblEditStock.Location = new System.Drawing.Point(261, 191);
            this.lblEditStock.Name = "lblEditStock";
            this.lblEditStock.Size = new System.Drawing.Size(62, 25);
            this.lblEditStock.TabIndex = 1;
            this.lblEditStock.Text = "Stock";
            // 
            // lblEditIngredient
            // 
            this.lblEditIngredient.AutoSize = true;
            this.lblEditIngredient.Location = new System.Drawing.Point(261, 113);
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
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "EditChefIngredient";
            this.Text = "EditChefIngredient";
            this.gbECIngredient.ResumeLayout(false);
            this.gbECIngredient.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbECIngredient;
        private System.Windows.Forms.Button btnCancelEditIngredient;
        private System.Windows.Forms.Button btnSaveIngredient;
        private System.Windows.Forms.TextBox txtEditStock;
        private System.Windows.Forms.TextBox txtEditIngredient;
        private System.Windows.Forms.Label lblEditStock;
        private System.Windows.Forms.Label lblEditIngredient;
    }
}