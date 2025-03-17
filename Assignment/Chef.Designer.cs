namespace Assignment
{
    partial class Chef
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_inventory = new System.Windows.Forms.Button();
            this.btn_ChefProfile = new System.Windows.Forms.Button();
            this.btn_CusOrder = new System.Windows.Forms.Button();
            this.lbl_chef = new System.Windows.Forms.Label();
            this.panel_CVI = new System.Windows.Forms.Panel();
            this.btn_SI = new System.Windows.Forms.Button();
            this.txt_CSI = new System.Windows.Forms.TextBox();
            this.lbl_inventory = new System.Windows.Forms.Label();
            this.btn_CUI = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.stockIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ingredientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.assignmentdbDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.assignmentdbDataSet = new Assignment.AssignmentdbDataSet();
            this.panel_CVP = new System.Windows.Forms.Panel();
            this.btn_CUP = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_CUsername = new System.Windows.Forms.Label();
            this.lbl_CEmail = new System.Windows.Forms.Label();
            this.lbl_CName = new System.Windows.Forms.Label();
            this.lbl_CDOB = new System.Windows.Forms.Label();
            this.lbl_CRole = new System.Windows.Forms.Label();
            this.panel_CVO = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.orderIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.assignmentdbDataSet3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.assignmentdbDataSet3 = new Assignment.AssignmentdbDataSet3();
            this.btn_COrder = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.stockTableAdapter = new Assignment.AssignmentdbDataSetTableAdapters.StockTableAdapter();
            this.orderTableAdapter = new Assignment.AssignmentdbDataSet3TableAdapters.OrderTableAdapter();
            this.cmb_status = new System.Windows.Forms.ComboBox();
            this.lbl_OStatus = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel_CVI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assignmentdbDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assignmentdbDataSet)).BeginInit();
            this.panel_CVP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel_CVO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assignmentdbDataSet3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assignmentdbDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.btn_inventory, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_ChefProfile, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btn_CusOrder, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbl_chef, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 126F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 11F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(195, 1323);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btn_inventory
            // 
            this.btn_inventory.BackColor = System.Drawing.Color.Silver;
            this.btn_inventory.FlatAppearance.BorderSize = 0;
            this.btn_inventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_inventory.Location = new System.Drawing.Point(3, 129);
            this.btn_inventory.Name = "btn_inventory";
            this.btn_inventory.Size = new System.Drawing.Size(189, 59);
            this.btn_inventory.TabIndex = 0;
            this.btn_inventory.Text = "Inventory";
            this.btn_inventory.UseVisualStyleBackColor = false;
            this.btn_inventory.Click += new System.EventHandler(this.btn_inventory_Click);
            // 
            // btn_ChefProfile
            // 
            this.btn_ChefProfile.BackColor = System.Drawing.Color.Silver;
            this.btn_ChefProfile.FlatAppearance.BorderSize = 0;
            this.btn_ChefProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ChefProfile.Location = new System.Drawing.Point(3, 256);
            this.btn_ChefProfile.Name = "btn_ChefProfile";
            this.btn_ChefProfile.Size = new System.Drawing.Size(189, 56);
            this.btn_ChefProfile.TabIndex = 2;
            this.btn_ChefProfile.Text = "Profile";
            this.btn_ChefProfile.UseVisualStyleBackColor = false;
            this.btn_ChefProfile.Click += new System.EventHandler(this.btn_ChefProfile_Click);
            // 
            // btn_CusOrder
            // 
            this.btn_CusOrder.BackColor = System.Drawing.Color.Silver;
            this.btn_CusOrder.FlatAppearance.BorderSize = 0;
            this.btn_CusOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CusOrder.Location = new System.Drawing.Point(3, 194);
            this.btn_CusOrder.Name = "btn_CusOrder";
            this.btn_CusOrder.Size = new System.Drawing.Size(189, 56);
            this.btn_CusOrder.TabIndex = 1;
            this.btn_CusOrder.Text = "Customer\'s Orders";
            this.btn_CusOrder.UseVisualStyleBackColor = false;
            this.btn_CusOrder.Click += new System.EventHandler(this.btn_CusOrder_Click);
            // 
            // lbl_chef
            // 
            this.lbl_chef.AutoSize = true;
            this.lbl_chef.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_chef.Location = new System.Drawing.Point(3, 0);
            this.lbl_chef.Name = "lbl_chef";
            this.lbl_chef.Size = new System.Drawing.Size(108, 46);
            this.lbl_chef.TabIndex = 3;
            this.lbl_chef.Text = "Chef";
            // 
            // panel_CVI
            // 
            this.panel_CVI.AutoScroll = true;
            this.panel_CVI.BackColor = System.Drawing.Color.AliceBlue;
            this.panel_CVI.Controls.Add(this.btn_SI);
            this.panel_CVI.Controls.Add(this.txt_CSI);
            this.panel_CVI.Controls.Add(this.lbl_inventory);
            this.panel_CVI.Controls.Add(this.btn_CUI);
            this.panel_CVI.Controls.Add(this.dataGridView1);
            this.panel_CVI.Location = new System.Drawing.Point(196, 0);
            this.panel_CVI.Name = "panel_CVI";
            this.panel_CVI.Size = new System.Drawing.Size(580, 436);
            this.panel_CVI.TabIndex = 1;
            // 
            // btn_SI
            // 
            this.btn_SI.Location = new System.Drawing.Point(441, 74);
            this.btn_SI.Name = "btn_SI";
            this.btn_SI.Size = new System.Drawing.Size(91, 39);
            this.btn_SI.TabIndex = 4;
            this.btn_SI.Text = "Search";
            this.btn_SI.UseVisualStyleBackColor = true;
            // 
            // txt_CSI
            // 
            this.txt_CSI.Location = new System.Drawing.Point(44, 80);
            this.txt_CSI.Name = "txt_CSI";
            this.txt_CSI.Size = new System.Drawing.Size(350, 26);
            this.txt_CSI.TabIndex = 3;
            // 
            // lbl_inventory
            // 
            this.lbl_inventory.AutoSize = true;
            this.lbl_inventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_inventory.Location = new System.Drawing.Point(22, 21);
            this.lbl_inventory.Name = "lbl_inventory";
            this.lbl_inventory.Size = new System.Drawing.Size(155, 37);
            this.lbl_inventory.TabIndex = 2;
            this.lbl_inventory.Text = "Inventory";
            // 
            // btn_CUI
            // 
            this.btn_CUI.Location = new System.Drawing.Point(396, 377);
            this.btn_CUI.Name = "btn_CUI";
            this.btn_CUI.Size = new System.Drawing.Size(172, 36);
            this.btn_CUI.TabIndex = 1;
            this.btn_CUI.Text = "Update Inventory";
            this.btn_CUI.UseVisualStyleBackColor = true;
            this.btn_CUI.Click += new System.EventHandler(this.btn_CUI_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stockIDDataGridViewTextBoxColumn,
            this.ingredientDataGridViewTextBoxColumn,
            this.stockDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.stockBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(2, 142);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(575, 215);
            this.dataGridView1.TabIndex = 0;
            // 
            // stockIDDataGridViewTextBoxColumn
            // 
            this.stockIDDataGridViewTextBoxColumn.DataPropertyName = "Stock_ID";
            this.stockIDDataGridViewTextBoxColumn.HeaderText = "Stock_ID";
            this.stockIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.stockIDDataGridViewTextBoxColumn.Name = "stockIDDataGridViewTextBoxColumn";
            this.stockIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.stockIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // ingredientDataGridViewTextBoxColumn
            // 
            this.ingredientDataGridViewTextBoxColumn.DataPropertyName = "Ingredient";
            this.ingredientDataGridViewTextBoxColumn.HeaderText = "Ingredient";
            this.ingredientDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.ingredientDataGridViewTextBoxColumn.Name = "ingredientDataGridViewTextBoxColumn";
            this.ingredientDataGridViewTextBoxColumn.Width = 150;
            // 
            // stockDataGridViewTextBoxColumn
            // 
            this.stockDataGridViewTextBoxColumn.DataPropertyName = "Stock";
            this.stockDataGridViewTextBoxColumn.HeaderText = "Stock";
            this.stockDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.stockDataGridViewTextBoxColumn.Name = "stockDataGridViewTextBoxColumn";
            this.stockDataGridViewTextBoxColumn.Width = 150;
            // 
            // stockBindingSource
            // 
            this.stockBindingSource.DataMember = "Stock";
            this.stockBindingSource.DataSource = this.assignmentdbDataSetBindingSource;
            // 
            // assignmentdbDataSetBindingSource
            // 
            this.assignmentdbDataSetBindingSource.DataSource = this.assignmentdbDataSet;
            this.assignmentdbDataSetBindingSource.Position = 0;
            // 
            // assignmentdbDataSet
            // 
            this.assignmentdbDataSet.DataSetName = "AssignmentdbDataSet";
            this.assignmentdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel_CVP
            // 
            this.panel_CVP.AutoScroll = true;
            this.panel_CVP.BackColor = System.Drawing.Color.PeachPuff;
            this.panel_CVP.Controls.Add(this.btn_CUP);
            this.panel_CVP.Controls.Add(this.pictureBox1);
            this.panel_CVP.Controls.Add(this.groupBox1);
            this.panel_CVP.Location = new System.Drawing.Point(196, 902);
            this.panel_CVP.Name = "panel_CVP";
            this.panel_CVP.Size = new System.Drawing.Size(580, 421);
            this.panel_CVP.TabIndex = 2;
            // 
            // btn_CUP
            // 
            this.btn_CUP.Location = new System.Drawing.Point(425, 336);
            this.btn_CUP.Name = "btn_CUP";
            this.btn_CUP.Size = new System.Drawing.Size(132, 41);
            this.btn_CUP.TabIndex = 7;
            this.btn_CUP.Text = "Update Profile";
            this.btn_CUP.UseVisualStyleBackColor = true;
            this.btn_CUP.Click += new System.EventHandler(this.btn_CUP_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(411, 61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 145);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lbl_CUsername);
            this.groupBox1.Controls.Add(this.lbl_CEmail);
            this.groupBox1.Controls.Add(this.lbl_CName);
            this.groupBox1.Controls.Add(this.lbl_CDOB);
            this.groupBox1.Controls.Add(this.lbl_CRole);
            this.groupBox1.Location = new System.Drawing.Point(29, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(342, 304);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Profile";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(206, 273);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 22);
            this.label6.TabIndex = 9;
            this.label6.Text = "label6";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(206, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 22);
            this.label5.TabIndex = 8;
            this.label5.Text = "label5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(206, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 22);
            this.label4.TabIndex = 7;
            this.label4.Text = "label4";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(206, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(206, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // lbl_CUsername
            // 
            this.lbl_CUsername.AutoSize = true;
            this.lbl_CUsername.Location = new System.Drawing.Point(32, 46);
            this.lbl_CUsername.Name = "lbl_CUsername";
            this.lbl_CUsername.Size = new System.Drawing.Size(87, 20);
            this.lbl_CUsername.TabIndex = 0;
            this.lbl_CUsername.Text = "Username:";
            // 
            // lbl_CEmail
            // 
            this.lbl_CEmail.AutoSize = true;
            this.lbl_CEmail.Location = new System.Drawing.Point(32, 273);
            this.lbl_CEmail.Name = "lbl_CEmail";
            this.lbl_CEmail.Size = new System.Drawing.Size(52, 20);
            this.lbl_CEmail.TabIndex = 4;
            this.lbl_CEmail.Text = "Email:";
            // 
            // lbl_CName
            // 
            this.lbl_CName.AutoSize = true;
            this.lbl_CName.Location = new System.Drawing.Point(32, 102);
            this.lbl_CName.Name = "lbl_CName";
            this.lbl_CName.Size = new System.Drawing.Size(55, 20);
            this.lbl_CName.TabIndex = 1;
            this.lbl_CName.Text = "Name:";
            // 
            // lbl_CDOB
            // 
            this.lbl_CDOB.AutoSize = true;
            this.lbl_CDOB.Location = new System.Drawing.Point(32, 210);
            this.lbl_CDOB.Name = "lbl_CDOB";
            this.lbl_CDOB.Size = new System.Drawing.Size(103, 20);
            this.lbl_CDOB.TabIndex = 3;
            this.lbl_CDOB.Text = "Date of Birth:";
            // 
            // lbl_CRole
            // 
            this.lbl_CRole.AutoSize = true;
            this.lbl_CRole.Location = new System.Drawing.Point(32, 159);
            this.lbl_CRole.Name = "lbl_CRole";
            this.lbl_CRole.Size = new System.Drawing.Size(46, 20);
            this.lbl_CRole.TabIndex = 2;
            this.lbl_CRole.Text = "Role:";
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
            this.panel_CVO.Location = new System.Drawing.Point(196, 450);
            this.panel_CVO.Name = "panel_CVO";
            this.panel_CVO.Size = new System.Drawing.Size(580, 438);
            this.panel_CVO.TabIndex = 2;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderIDDataGridViewTextBoxColumn,
            this.userIDDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.orderBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(8, 127);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(569, 209);
            this.dataGridView2.TabIndex = 1;
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
            this.orderBindingSource.DataSource = this.assignmentdbDataSet3BindingSource;
            // 
            // assignmentdbDataSet3BindingSource
            // 
            this.assignmentdbDataSet3BindingSource.DataSource = this.assignmentdbDataSet3;
            this.assignmentdbDataSet3BindingSource.Position = 0;
            // 
            // assignmentdbDataSet3
            // 
            this.assignmentdbDataSet3.DataSetName = "AssignmentdbDataSet3";
            this.assignmentdbDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_COrder
            // 
            this.btn_COrder.Location = new System.Drawing.Point(381, 378);
            this.btn_COrder.Name = "btn_COrder";
            this.btn_COrder.Size = new System.Drawing.Size(159, 38);
            this.btn_COrder.TabIndex = 4;
            this.btn_COrder.Text = "Choose an Order";
            this.btn_COrder.UseVisualStyleBackColor = true;
            this.btn_COrder.Click += new System.EventHandler(this.btn_COrder_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 32);
            this.label3.TabIndex = 0;
            this.label3.Text = "Orders";
            // 
            // stockTableAdapter
            // 
            this.stockTableAdapter.ClearBeforeFill = true;
            // 
            // orderTableAdapter
            // 
            this.orderTableAdapter.ClearBeforeFill = true;
            // 
            // cmb_status
            // 
            this.cmb_status.FormattingEnabled = true;
            this.cmb_status.Items.AddRange(new object[] {
            "In progress",
            "Completed"});
            this.cmb_status.Location = new System.Drawing.Point(235, 84);
            this.cmb_status.Name = "cmb_status";
            this.cmb_status.Size = new System.Drawing.Size(121, 28);
            this.cmb_status.TabIndex = 5;
            // 
            // lbl_OStatus
            // 
            this.lbl_OStatus.AutoSize = true;
            this.lbl_OStatus.Location = new System.Drawing.Point(104, 87);
            this.lbl_OStatus.Name = "lbl_OStatus";
            this.lbl_OStatus.Size = new System.Drawing.Size(60, 20);
            this.lbl_OStatus.TabIndex = 6;
            this.lbl_OStatus.Text = "Status:";
            // 
            // Chef
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel_CVO);
            this.Controls.Add(this.panel_CVP);
            this.Controls.Add(this.panel_CVI);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Chef";
            this.Text = "Chef";
            this.Load += new System.EventHandler(this.Chef_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel_CVI.ResumeLayout(false);
            this.panel_CVI.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assignmentdbDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assignmentdbDataSet)).EndInit();
            this.panel_CVP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel_CVO.ResumeLayout(false);
            this.panel_CVO.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assignmentdbDataSet3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assignmentdbDataSet3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btn_inventory;
        private System.Windows.Forms.Button btn_ChefProfile;
        private System.Windows.Forms.Button btn_CusOrder;
        private System.Windows.Forms.Panel panel_CVI;
        private System.Windows.Forms.Panel panel_CVP;
        private System.Windows.Forms.Panel panel_CVO;
        private System.Windows.Forms.Label lbl_chef;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource assignmentdbDataSetBindingSource;
        private AssignmentdbDataSet assignmentdbDataSet;
        private System.Windows.Forms.BindingSource stockBindingSource;
        private AssignmentdbDataSetTableAdapters.StockTableAdapter stockTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ingredientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btn_CUI;
        private System.Windows.Forms.Button btn_SI;
        private System.Windows.Forms.TextBox txt_CSI;
        private System.Windows.Forms.Label lbl_inventory;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource assignmentdbDataSet3BindingSource;
        private AssignmentdbDataSet3 assignmentdbDataSet3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private AssignmentdbDataSet3TableAdapters.OrderTableAdapter orderTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btn_COrder;
        private System.Windows.Forms.Label lbl_CEmail;
        private System.Windows.Forms.Label lbl_CDOB;
        private System.Windows.Forms.Label lbl_CRole;
        private System.Windows.Forms.Label lbl_CName;
        private System.Windows.Forms.Label lbl_CUsername;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_CUP;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_OStatus;
        private System.Windows.Forms.ComboBox cmb_status;
    }
}