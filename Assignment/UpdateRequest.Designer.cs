namespace Assignment
{
    partial class UpdateRequest
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
            this.btn_Complete = new System.Windows.Forms.Button();
            this.btn_Reject = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.database1DataSet = new Assignment.Database1DataSet();
            this.reservationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reservationTableAdapter = new Assignment.Database1DataSetTableAdapters.ReservationTableAdapter();
            this.reservationIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hallIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rReqIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Complete
            // 
            this.btn_Complete.Location = new System.Drawing.Point(227, 376);
            this.btn_Complete.Name = "btn_Complete";
            this.btn_Complete.Size = new System.Drawing.Size(103, 34);
            this.btn_Complete.TabIndex = 0;
            this.btn_Complete.Text = "Complete";
            this.btn_Complete.UseVisualStyleBackColor = true;
            // 
            // btn_Reject
            // 
            this.btn_Reject.Location = new System.Drawing.Point(441, 376);
            this.btn_Reject.Name = "btn_Reject";
            this.btn_Reject.Size = new System.Drawing.Size(103, 34);
            this.btn_Reject.TabIndex = 1;
            this.btn_Reject.Text = "Reject";
            this.btn_Reject.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.reservationIDDataGridViewTextBoxColumn,
            this.hallIDDataGridViewTextBoxColumn,
            this.userIDDataGridViewTextBoxColumn,
            this.rReqIDDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.reservationBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(31, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(677, 150);
            this.dataGridView1.TabIndex = 2;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reservationBindingSource
            // 
            this.reservationBindingSource.DataMember = "Reservation";
            this.reservationBindingSource.DataSource = this.database1DataSet;
            // 
            // reservationTableAdapter
            // 
            this.reservationTableAdapter.ClearBeforeFill = true;
            // 
            // reservationIDDataGridViewTextBoxColumn
            // 
            this.reservationIDDataGridViewTextBoxColumn.DataPropertyName = "Reservation_ID";
            this.reservationIDDataGridViewTextBoxColumn.HeaderText = "Reservation_ID";
            this.reservationIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.reservationIDDataGridViewTextBoxColumn.Name = "reservationIDDataGridViewTextBoxColumn";
            this.reservationIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.reservationIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // hallIDDataGridViewTextBoxColumn
            // 
            this.hallIDDataGridViewTextBoxColumn.DataPropertyName = "Hall_ID";
            this.hallIDDataGridViewTextBoxColumn.HeaderText = "Hall_ID";
            this.hallIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hallIDDataGridViewTextBoxColumn.Name = "hallIDDataGridViewTextBoxColumn";
            this.hallIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // userIDDataGridViewTextBoxColumn
            // 
            this.userIDDataGridViewTextBoxColumn.DataPropertyName = "User_ID";
            this.userIDDataGridViewTextBoxColumn.HeaderText = "User_ID";
            this.userIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.userIDDataGridViewTextBoxColumn.Name = "userIDDataGridViewTextBoxColumn";
            this.userIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // rReqIDDataGridViewTextBoxColumn
            // 
            this.rReqIDDataGridViewTextBoxColumn.DataPropertyName = "R_Req_ID";
            this.rReqIDDataGridViewTextBoxColumn.HeaderText = "R_Req_ID";
            this.rReqIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rReqIDDataGridViewTextBoxColumn.Name = "rReqIDDataGridViewTextBoxColumn";
            this.rReqIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.Width = 125;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(47, 223);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(223, 84);
            this.listBox1.TabIndex = 3;
            // 
            // UpdateRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_Reject);
            this.Controls.Add(this.btn_Complete);
            this.Name = "UpdateRequest";
            this.Text = "UpdateRequest";
            this.Load += new System.EventHandler(this.UpdateRequest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Complete;
        private System.Windows.Forms.Button btn_Reject;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource reservationBindingSource;
        private Database1DataSetTableAdapters.ReservationTableAdapter reservationTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn reservationIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hallIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rReqIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.ListBox listBox1;
    }
}