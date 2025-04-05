namespace Assignment
{
    partial class view_CusFeedback
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(view_CusFeedback));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.feedbackIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.feedbackDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet7 = new Assignment.Database1DataSet7();
            this.tableTableAdapter = new Assignment.Database1DataSet7TableAdapters.TableTableAdapter();
            this.btn_Return = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet7)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.feedbackIDDataGridViewTextBoxColumn,
            this.orderIDDataGridViewTextBoxColumn,
            this.feedbackDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tableBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(128, 85);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(842, 306);
            this.dataGridView1.TabIndex = 0;
            // 
            // feedbackIDDataGridViewTextBoxColumn
            // 
            this.feedbackIDDataGridViewTextBoxColumn.DataPropertyName = "Feedback_ID";
            this.feedbackIDDataGridViewTextBoxColumn.HeaderText = "Feedback_ID";
            this.feedbackIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.feedbackIDDataGridViewTextBoxColumn.Name = "feedbackIDDataGridViewTextBoxColumn";
            this.feedbackIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.feedbackIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // orderIDDataGridViewTextBoxColumn
            // 
            this.orderIDDataGridViewTextBoxColumn.DataPropertyName = "Order_ID";
            this.orderIDDataGridViewTextBoxColumn.HeaderText = "Order_ID";
            this.orderIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.orderIDDataGridViewTextBoxColumn.Name = "orderIDDataGridViewTextBoxColumn";
            this.orderIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // feedbackDataGridViewTextBoxColumn
            // 
            this.feedbackDataGridViewTextBoxColumn.DataPropertyName = "Feedback";
            this.feedbackDataGridViewTextBoxColumn.HeaderText = "Feedback";
            this.feedbackDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.feedbackDataGridViewTextBoxColumn.Name = "feedbackDataGridViewTextBoxColumn";
            this.feedbackDataGridViewTextBoxColumn.Width = 150;
            // 
            // tableBindingSource
            // 
            this.tableBindingSource.DataMember = "Table";
            this.tableBindingSource.DataSource = this.database1DataSet7;
            // 
            // database1DataSet7
            // 
            this.database1DataSet7.DataSetName = "Database1DataSet7";
            this.database1DataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableTableAdapter
            // 
            this.tableTableAdapter.ClearBeforeFill = true;
            // 
            // btn_Return
            // 
            this.btn_Return.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Return.BackgroundImage")));
            this.btn_Return.FlatAppearance.BorderSize = 0;
            this.btn_Return.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Return.Location = new System.Drawing.Point(42, 15);
            this.btn_Return.Margin = new System.Windows.Forms.Padding(6);
            this.btn_Return.Name = "btn_Return";
            this.btn_Return.Size = new System.Drawing.Size(61, 52);
            this.btn_Return.TabIndex = 71;
            this.btn_Return.UseVisualStyleBackColor = true;
            this.btn_Return.Click += new System.EventHandler(this.btn_Return_Click);
            // 
            // view_CusFeedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(237)))), ((int)(((byte)(225)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1082, 453);
            this.Controls.Add(this.btn_Return);
            this.Controls.Add(this.dataGridView1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "view_CusFeedback";
            this.Text = "view_CusFeedback";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet7)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Database1DataSet7 database1DataSet7;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private Database1DataSet7TableAdapters.TableTableAdapter tableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn feedbackIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn feedbackDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btn_Return;
    }
}