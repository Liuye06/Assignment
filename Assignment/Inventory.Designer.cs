namespace Assignment
{
    partial class Inventory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inventory));
            this.txt_search = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.stockIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ingredientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.assignmentdbDataSet = new Assignment.AssignmentdbDataSet();
            this.txt_s_id = new System.Windows.Forms.TextBox();
            this.txt_ingredient = new System.Windows.Forms.TextBox();
            this.txt_stock = new System.Windows.Forms.TextBox();
            this.btn_s_add = new System.Windows.Forms.Button();
            this.btn_s_edit = new System.Windows.Forms.Button();
            this.btn_s_del = new System.Windows.Forms.Button();
            this.btn_i_back = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_stock = new System.Windows.Forms.Label();
            this.lbl_ingredient = new System.Windows.Forms.Label();
            this.lbl_s_id = new System.Windows.Forms.Label();
            this.stockTableAdapter = new Assignment.AssignmentdbDataSetTableAdapters.StockTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assignmentdbDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(477, 67);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(225, 26);
            this.txt_search.TabIndex = 0;
            // 
            // btn_search
            // 
            this.btn_search.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_search.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_search.Image = ((System.Drawing.Image)(resources.GetObject("btn_search.Image")));
            this.btn_search.Location = new System.Drawing.Point(723, 55);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(50, 50);
            this.btn_search.TabIndex = 1;
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.button1_Click);
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
            this.dataGridView1.Location = new System.Drawing.Point(459, 123);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(335, 255);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            this.stockBindingSource.DataSource = this.assignmentdbDataSet;
            // 
            // assignmentdbDataSet
            // 
            this.assignmentdbDataSet.DataSetName = "AssignmentdbDataSet";
            this.assignmentdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txt_s_id
            // 
            this.txt_s_id.Location = new System.Drawing.Point(148, 42);
            this.txt_s_id.Name = "txt_s_id";
            this.txt_s_id.Size = new System.Drawing.Size(100, 26);
            this.txt_s_id.TabIndex = 3;
            // 
            // txt_ingredient
            // 
            this.txt_ingredient.Location = new System.Drawing.Point(148, 101);
            this.txt_ingredient.Name = "txt_ingredient";
            this.txt_ingredient.Size = new System.Drawing.Size(100, 26);
            this.txt_ingredient.TabIndex = 4;
            // 
            // txt_stock
            // 
            this.txt_stock.Location = new System.Drawing.Point(148, 156);
            this.txt_stock.Name = "txt_stock";
            this.txt_stock.Size = new System.Drawing.Size(100, 26);
            this.txt_stock.TabIndex = 5;
            // 
            // btn_s_add
            // 
            this.btn_s_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_s_add.Location = new System.Drawing.Point(32, 218);
            this.btn_s_add.Name = "btn_s_add";
            this.btn_s_add.Size = new System.Drawing.Size(81, 36);
            this.btn_s_add.TabIndex = 6;
            this.btn_s_add.Text = "ADD";
            this.btn_s_add.UseVisualStyleBackColor = true;
            // 
            // btn_s_edit
            // 
            this.btn_s_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_s_edit.Location = new System.Drawing.Point(148, 218);
            this.btn_s_edit.Name = "btn_s_edit";
            this.btn_s_edit.Size = new System.Drawing.Size(84, 36);
            this.btn_s_edit.TabIndex = 7;
            this.btn_s_edit.Text = "EDIT";
            this.btn_s_edit.UseVisualStyleBackColor = true;
            // 
            // btn_s_del
            // 
            this.btn_s_del.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_s_del.Location = new System.Drawing.Point(281, 218);
            this.btn_s_del.Name = "btn_s_del";
            this.btn_s_del.Size = new System.Drawing.Size(91, 36);
            this.btn_s_del.TabIndex = 8;
            this.btn_s_del.Text = "DELETE";
            this.btn_s_del.UseVisualStyleBackColor = true;
            // 
            // btn_i_back
            // 
            this.btn_i_back.Location = new System.Drawing.Point(13, 13);
            this.btn_i_back.Name = "btn_i_back";
            this.btn_i_back.Size = new System.Drawing.Size(89, 33);
            this.btn_i_back.TabIndex = 9;
            this.btn_i_back.Text = "Back";
            this.btn_i_back.UseVisualStyleBackColor = true;
            this.btn_i_back.Click += new System.EventHandler(this.btn_i_back_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.Location = new System.Drawing.Point(32, 292);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(100, 33);
            this.btn_clear.TabIndex = 11;
            this.btn_clear.Text = "CLEAR";
            this.btn_clear.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_stock);
            this.groupBox1.Controls.Add(this.lbl_ingredient);
            this.groupBox1.Controls.Add(this.lbl_s_id);
            this.groupBox1.Controls.Add(this.txt_s_id);
            this.groupBox1.Controls.Add(this.btn_clear);
            this.groupBox1.Controls.Add(this.txt_ingredient);
            this.groupBox1.Controls.Add(this.txt_stock);
            this.groupBox1.Controls.Add(this.btn_s_add);
            this.groupBox1.Controls.Add(this.btn_s_del);
            this.groupBox1.Controls.Add(this.btn_s_edit);
            this.groupBox1.Location = new System.Drawing.Point(24, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(394, 341);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // lbl_stock
            // 
            this.lbl_stock.AutoSize = true;
            this.lbl_stock.Location = new System.Drawing.Point(24, 162);
            this.lbl_stock.Name = "lbl_stock";
            this.lbl_stock.Size = new System.Drawing.Size(54, 20);
            this.lbl_stock.TabIndex = 14;
            this.lbl_stock.Text = "Stock:";
            // 
            // lbl_ingredient
            // 
            this.lbl_ingredient.AutoSize = true;
            this.lbl_ingredient.Location = new System.Drawing.Point(28, 101);
            this.lbl_ingredient.Name = "lbl_ingredient";
            this.lbl_ingredient.Size = new System.Drawing.Size(85, 20);
            this.lbl_ingredient.TabIndex = 13;
            this.lbl_ingredient.Text = "Ingredient:";
            // 
            // lbl_s_id
            // 
            this.lbl_s_id.AutoSize = true;
            this.lbl_s_id.Location = new System.Drawing.Point(28, 42);
            this.lbl_s_id.Name = "lbl_s_id";
            this.lbl_s_id.Size = new System.Drawing.Size(75, 20);
            this.lbl_s_id.TabIndex = 12;
            this.lbl_s_id.Text = "Stock ID:";
            // 
            // stockTableAdapter
            // 
            this.stockTableAdapter.ClearBeforeFill = true;
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 456);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_i_back);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.txt_search);
            this.Name = "Inventory";
            this.Text = "Inventory";
            this.Load += new System.EventHandler(this.Inventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assignmentdbDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_s_id;
        private System.Windows.Forms.TextBox txt_ingredient;
        private System.Windows.Forms.TextBox txt_stock;
        private System.Windows.Forms.Button btn_s_add;
        private System.Windows.Forms.Button btn_s_edit;
        private System.Windows.Forms.Button btn_s_del;
        private System.Windows.Forms.Button btn_i_back;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_stock;
        private System.Windows.Forms.Label lbl_ingredient;
        private System.Windows.Forms.Label lbl_s_id;
        private AssignmentdbDataSet assignmentdbDataSet;
        private System.Windows.Forms.BindingSource stockBindingSource;
        private AssignmentdbDataSetTableAdapters.StockTableAdapter stockTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ingredientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockDataGridViewTextBoxColumn;
    }
}