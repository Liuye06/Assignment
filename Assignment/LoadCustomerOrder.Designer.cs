namespace Assignment
{
    partial class LoadCustomerOrder
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
            this.panel_CVO = new System.Windows.Forms.Panel();
            this.lbl_OStatus = new System.Windows.Forms.Label();
            this.cmb_status = new System.Windows.Forms.ComboBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btn_COrder = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel_CVO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_CVO
            // 
            this.panel_CVO.AutoScroll = true;
            this.panel_CVO.BackColor = System.Drawing.SystemColors.Info;
            this.panel_CVO.Controls.Add(this.lbl_OStatus);
            this.panel_CVO.Controls.Add(this.cmb_status);
            this.panel_CVO.Controls.Add(this.dataGridView2);
            this.panel_CVO.Controls.Add(this.btn_COrder);
            this.panel_CVO.Controls.Add(this.label3);
            this.panel_CVO.Location = new System.Drawing.Point(142, 50);
            this.panel_CVO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_CVO.Name = "panel_CVO";
            this.panel_CVO.Size = new System.Drawing.Size(516, 350);
            this.panel_CVO.TabIndex = 3;
            // 
            // lbl_OStatus
            // 
            this.lbl_OStatus.AutoSize = true;
            this.lbl_OStatus.Location = new System.Drawing.Point(92, 70);
            this.lbl_OStatus.Name = "lbl_OStatus";
            this.lbl_OStatus.Size = new System.Drawing.Size(47, 16);
            this.lbl_OStatus.TabIndex = 6;
            this.lbl_OStatus.Text = "Status:";
            // 
            // cmb_status
            // 
            this.cmb_status.FormattingEnabled = true;
            this.cmb_status.Items.AddRange(new object[] {
            "In progress",
            "Completed"});
            this.cmb_status.Location = new System.Drawing.Point(209, 67);
            this.cmb_status.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_status.Name = "cmb_status";
            this.cmb_status.Size = new System.Drawing.Size(108, 24);
            this.cmb_status.TabIndex = 5;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(7, 102);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(506, 167);
            this.dataGridView2.TabIndex = 1;
            // 
            // btn_COrder
            // 
            this.btn_COrder.Location = new System.Drawing.Point(339, 302);
            this.btn_COrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_COrder.Name = "btn_COrder";
            this.btn_COrder.Size = new System.Drawing.Size(141, 30);
            this.btn_COrder.TabIndex = 4;
            this.btn_COrder.Text = "Choose an Order";
            this.btn_COrder.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "Orders";
            // 
            // LoadCustomerOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel_CVO);
            this.Name = "LoadCustomerOrder";
            this.Text = "LoadCustomerOrder";
            this.panel_CVO.ResumeLayout(false);
            this.panel_CVO.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_CVO;
        private System.Windows.Forms.Label lbl_OStatus;
        private System.Windows.Forms.ComboBox cmb_status;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btn_COrder;
        private System.Windows.Forms.Label label3;
    }
}