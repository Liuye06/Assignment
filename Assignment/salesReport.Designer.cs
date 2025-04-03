namespace Assignment
{
    partial class salesReport
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
            this.lbl_month = new System.Windows.Forms.Label();
            this.cmbMonth = new System.Windows.Forms.ComboBox();
            this.lbl_salesR = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ChefName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet9 = new Assignment.Database1DataSet9();
            this.paymentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet3 = new Assignment.Database1DataSet3();
            this.paymentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet1 = new Assignment.Database1DataSet1();
            this.paymentTableAdapter = new Assignment.Database1DataSet1TableAdapters.PaymentTableAdapter();
            this.paymentTableAdapter1 = new Assignment.Database1DataSet3TableAdapters.PaymentTableAdapter();
            this.paymentTableAdapter2 = new Assignment.Database1DataSet9TableAdapters.PaymentTableAdapter();
            this.cmbUserName = new System.Windows.Forms.ComboBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.btnResetSearch = new System.Windows.Forms.Button();
            this.cmbTransactionType = new System.Windows.Forms.ComboBox();
            this.lblTransactionType = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_month
            // 
            this.lbl_month.AutoSize = true;
            this.lbl_month.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_month.Location = new System.Drawing.Point(434, 95);
            this.lbl_month.Name = "lbl_month";
            this.lbl_month.Size = new System.Drawing.Size(67, 25);
            this.lbl_month.TabIndex = 1;
            this.lbl_month.Text = "Month";
            // 
            // cmbMonth
            // 
            this.cmbMonth.FormattingEnabled = true;
            this.cmbMonth.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "Jun",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.cmbMonth.Location = new System.Drawing.Point(507, 92);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Size = new System.Drawing.Size(228, 33);
            this.cmbMonth.TabIndex = 2;
            this.cmbMonth.SelectedIndexChanged += new System.EventHandler(this.cmbMonth_SelectedIndexChanged);
            // 
            // lbl_salesR
            // 
            this.lbl_salesR.AutoSize = true;
            this.lbl_salesR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_salesR.Location = new System.Drawing.Point(22, 26);
            this.lbl_salesR.Name = "lbl_salesR";
            this.lbl_salesR.Size = new System.Drawing.Size(136, 25);
            this.lbl_salesR.TabIndex = 0;
            this.lbl_salesR.Text = "Sales Report";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ChefName});
            this.dataGridView1.Location = new System.Drawing.Point(23, 150);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1032, 219);
            this.dataGridView1.TabIndex = 6;
            // 
            // ChefName
            // 
            this.ChefName.HeaderText = "Chef Name";
            this.ChefName.MinimumWidth = 6;
            this.ChefName.Name = "ChefName";
            this.ChefName.Width = 125;
            // 
            // paymentBindingSource2
            // 
            this.paymentBindingSource2.DataMember = "Payment";
            this.paymentBindingSource2.DataSource = this.database1DataSet9;
            // 
            // database1DataSet9
            // 
            this.database1DataSet9.DataSetName = "Database1DataSet9";
            this.database1DataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // paymentBindingSource1
            // 
            this.paymentBindingSource1.DataMember = "Payment";
            this.paymentBindingSource1.DataSource = this.database1DataSet3;
            // 
            // database1DataSet3
            // 
            this.database1DataSet3.DataSetName = "Database1DataSet3";
            this.database1DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // paymentBindingSource
            // 
            this.paymentBindingSource.DataMember = "Payment";
            this.paymentBindingSource.DataSource = this.database1DataSet1;
            // 
            // database1DataSet1
            // 
            this.database1DataSet1.DataSetName = "Database1DataSet1";
            this.database1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // paymentTableAdapter
            // 
            this.paymentTableAdapter.ClearBeforeFill = true;
            // 
            // paymentTableAdapter1
            // 
            this.paymentTableAdapter1.ClearBeforeFill = true;
            // 
            // paymentTableAdapter2
            // 
            this.paymentTableAdapter2.ClearBeforeFill = true;
            // 
            // cmbUserName
            // 
            this.cmbUserName.FormattingEnabled = true;
            this.cmbUserName.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "Jun",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.cmbUserName.Location = new System.Drawing.Point(857, 92);
            this.cmbUserName.Name = "cmbUserName";
            this.cmbUserName.Size = new System.Drawing.Size(198, 33);
            this.cmbUserName.TabIndex = 7;
            this.cmbUserName.SelectedIndexChanged += new System.EventHandler(this.cmbUserName_SelectedIndexChanged);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(741, 92);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(111, 25);
            this.lblUser.TabIndex = 8;
            this.lblUser.Text = "Chef Name";
            // 
            // btnResetSearch
            // 
            this.btnResetSearch.Location = new System.Drawing.Point(23, 389);
            this.btnResetSearch.Name = "btnResetSearch";
            this.btnResetSearch.Size = new System.Drawing.Size(499, 34);
            this.btnResetSearch.TabIndex = 72;
            this.btnResetSearch.Text = "Reset Search ";
            this.btnResetSearch.UseVisualStyleBackColor = true;
            this.btnResetSearch.Click += new System.EventHandler(this.btnResetSearch_Click_1);
            // 
            // cmbTransactionType
            // 
            this.cmbTransactionType.FormattingEnabled = true;
            this.cmbTransactionType.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "Jun",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.cmbTransactionType.Location = new System.Drawing.Point(193, 92);
            this.cmbTransactionType.Name = "cmbTransactionType";
            this.cmbTransactionType.Size = new System.Drawing.Size(228, 33);
            this.cmbTransactionType.TabIndex = 74;
            this.cmbTransactionType.SelectedIndexChanged += new System.EventHandler(this.cmbTransactionType_SelectedIndexChanged);
            // 
            // lblTransactionType
            // 
            this.lblTransactionType.AutoSize = true;
            this.lblTransactionType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransactionType.Location = new System.Drawing.Point(22, 95);
            this.lblTransactionType.Name = "lblTransactionType";
            this.lblTransactionType.Size = new System.Drawing.Size(165, 25);
            this.lblTransactionType.TabIndex = 73;
            this.lblTransactionType.Text = "Transaction Type";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(528, 389);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(527, 34);
            this.btnCancel.TabIndex = 75;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click_1);
            // 
            // salesReport
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Linen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1082, 453);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.cmbTransactionType);
            this.Controls.Add(this.lblTransactionType);
            this.Controls.Add(this.btnResetSearch);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.cmbUserName);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cmbMonth);
            this.Controls.Add(this.lbl_month);
            this.Controls.Add(this.lbl_salesR);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "salesReport";
            this.Text = "salesReport";
            this.Load += new System.EventHandler(this.salesReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_month;
        private System.Windows.Forms.ComboBox cmbMonth;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lbl_salesR;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Database1DataSet1 database1DataSet1;
        private System.Windows.Forms.BindingSource paymentBindingSource;
        private Database1DataSet1TableAdapters.PaymentTableAdapter paymentTableAdapter;
        private Database1DataSet3 database1DataSet3;
        private System.Windows.Forms.BindingSource paymentBindingSource1;
        private Database1DataSet3TableAdapters.PaymentTableAdapter paymentTableAdapter1;
        private Database1DataSet9 database1DataSet9;
        private System.Windows.Forms.BindingSource paymentBindingSource2;
        private Database1DataSet9TableAdapters.PaymentTableAdapter paymentTableAdapter2;
        private System.Windows.Forms.ComboBox cmbUserName;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Button btnResetSearch;
        private System.Windows.Forms.ComboBox cmbTransactionType;
        private System.Windows.Forms.Label lblTransactionType;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChefName;
    }
}