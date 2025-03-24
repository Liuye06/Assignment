namespace Assignment
{
    partial class CustomersOrder
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
            this.components = new System.ComponentModel.Container();
            this.btn_VO_b = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.orderIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.assignmentdbDataSet3 = new Assignment.AssignmentdbDataSet3();
            this.orderTableAdapter = new Assignment.AssignmentdbDataSet3TableAdapters.OrderTableAdapter();
            this.cmb_UOS = new System.Windows.Forms.ComboBox();
            this.ldl_OrderID = new System.Windows.Forms.Label();
            this.lbl_status = new System.Windows.Forms.Label();
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assignmentdbDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_VO_b
            // 
            this.btn_VO_b.Location = new System.Drawing.Point(27, 13);
            this.btn_VO_b.Name = "btn_VO_b";
            this.btn_VO_b.Size = new System.Drawing.Size(75, 32);
            this.btn_VO_b.TabIndex = 0;
            this.btn_VO_b.Text = "Back";
            this.btn_VO_b.UseVisualStyleBackColor = true;
            this.btn_VO_b.Click += new System.EventHandler(this.btn_VO_b_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderIDDataGridViewTextBoxColumn,
            this.userIDDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.orderBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(420, 89);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(298, 252);
            this.dataGridView1.TabIndex = 1;
            // 
            // orderIDDataGridViewTextBoxColumn
            // 
            this.orderIDDataGridViewTextBoxColumn.DataPropertyName = "Order_ID";
            this.orderIDDataGridViewTextBoxColumn.HeaderText = "Order_ID";
            this.orderIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.orderIDDataGridViewTextBoxColumn.Name = "orderIDDataGridViewTextBoxColumn";
            this.orderIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.orderIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // userIDDataGridViewTextBoxColumn
            // 
            this.userIDDataGridViewTextBoxColumn.DataPropertyName = "User_ID";
            this.userIDDataGridViewTextBoxColumn.HeaderText = "User_ID";
            this.userIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.userIDDataGridViewTextBoxColumn.Name = "userIDDataGridViewTextBoxColumn";
            this.userIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.Width = 150;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.Width = 150;
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataMember = "Order";
            this.orderBindingSource.DataSource = this.assignmentdbDataSet3;
            // 
            // assignmentdbDataSet3
            // 
            this.assignmentdbDataSet3.DataSetName = "AssignmentdbDataSet3";
            this.assignmentdbDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // orderTableAdapter
            // 
            this.orderTableAdapter.ClearBeforeFill = true;
            // 
            // cmb_UOS
            // 
            this.cmb_UOS.FormattingEnabled = true;
            this.cmb_UOS.Items.AddRange(new object[] {
            "In progress",
            "Completed"});
            this.cmb_UOS.Location = new System.Drawing.Point(193, 256);
            this.cmb_UOS.Name = "cmb_UOS";
            this.cmb_UOS.Size = new System.Drawing.Size(121, 28);
            this.cmb_UOS.TabIndex = 2;
            // 
            // ldl_OrderID
            // 
            this.ldl_OrderID.AutoSize = true;
            this.ldl_OrderID.Location = new System.Drawing.Point(81, 195);
            this.ldl_OrderID.Name = "ldl_OrderID";
            this.ldl_OrderID.Size = new System.Drawing.Size(74, 20);
            this.ldl_OrderID.TabIndex = 3;
            this.ldl_OrderID.Text = "Order ID:";
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Location = new System.Drawing.Point(81, 259);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(60, 20);
            this.lbl_status.TabIndex = 4;
            this.lbl_status.Text = "Status:";
            // 
            // txtOrderID
            // 
            this.txtOrderID.Location = new System.Drawing.Point(193, 195);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.Size = new System.Drawing.Size(121, 26);
            this.txtOrderID.TabIndex = 6;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(608, 382);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(95, 42);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // CustomersOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtOrderID);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lbl_status);
            this.Controls.Add(this.ldl_OrderID);
            this.Controls.Add(this.cmb_UOS);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_VO_b);
            this.Name = "CustomersOrder";
            this.Text = "CustomersOders";
            this.Load += new System.EventHandler(this.View_Order_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assignmentdbDataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_VO_b;
        private System.Windows.Forms.DataGridView dataGridView1;
        private AssignmentdbDataSet3 assignmentdbDataSet3;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private AssignmentdbDataSet3TableAdapters.OrderTableAdapter orderTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox cmb_UOS;
        private System.Windows.Forms.Label ldl_OrderID;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.TextBox txtOrderID;
        private System.Windows.Forms.Button btnSave;
    }
}