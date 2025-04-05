namespace Assignment
{
    partial class update_Customer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(update_Customer));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_viewCus = new System.Windows.Forms.Button();
            this.btn_DeleteCus = new System.Windows.Forms.Button();
            this.btn_EditCus = new System.Windows.Forms.Button();
            this.btn_AddCus = new System.Windows.Forms.Button();
            this.btn_Home = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.userIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.realNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profilePicDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.roleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new Assignment.Database1DataSet();
            this.userTableAdapter = new Assignment.Database1DataSetTableAdapters.UserTableAdapter();
            this.database1DataSet2 = new Assignment.Database1DataSet2();
            this.userBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.userTableAdapter1 = new Assignment.Database1DataSet2TableAdapters.UserTableAdapter();
            this.pic_logo = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pic_logo);
            this.panel1.Controls.Add(this.btn_viewCus);
            this.panel1.Controls.Add(this.btn_DeleteCus);
            this.panel1.Controls.Add(this.btn_EditCus);
            this.panel1.Controls.Add(this.btn_AddCus);
            this.panel1.Controls.Add(this.btn_Home);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(257, 453);
            this.panel1.TabIndex = 4;
            this.panel1.UseWaitCursor = true;
            // 
            // btn_viewCus
            // 
            this.btn_viewCus.BackColor = System.Drawing.Color.PeachPuff;
            this.btn_viewCus.FlatAppearance.BorderColor = System.Drawing.Color.AntiqueWhite;
            this.btn_viewCus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_viewCus.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_viewCus.ForeColor = System.Drawing.Color.Black;
            this.btn_viewCus.Image = ((System.Drawing.Image)(resources.GetObject("btn_viewCus.Image")));
            this.btn_viewCus.Location = new System.Drawing.Point(-2, 170);
            this.btn_viewCus.Name = "btn_viewCus";
            this.btn_viewCus.Size = new System.Drawing.Size(258, 41);
            this.btn_viewCus.TabIndex = 11;
            this.btn_viewCus.Text = "View";
            this.btn_viewCus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_viewCus.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_viewCus.UseVisualStyleBackColor = false;
            this.btn_viewCus.UseWaitCursor = true;
            this.btn_viewCus.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_DeleteCus
            // 
            this.btn_DeleteCus.BackColor = System.Drawing.Color.PeachPuff;
            this.btn_DeleteCus.FlatAppearance.BorderColor = System.Drawing.Color.AntiqueWhite;
            this.btn_DeleteCus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DeleteCus.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DeleteCus.ForeColor = System.Drawing.Color.Black;
            this.btn_DeleteCus.Image = ((System.Drawing.Image)(resources.GetObject("btn_DeleteCus.Image")));
            this.btn_DeleteCus.Location = new System.Drawing.Point(-1, 311);
            this.btn_DeleteCus.Name = "btn_DeleteCus";
            this.btn_DeleteCus.Size = new System.Drawing.Size(258, 41);
            this.btn_DeleteCus.TabIndex = 8;
            this.btn_DeleteCus.Text = "Delete";
            this.btn_DeleteCus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_DeleteCus.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_DeleteCus.UseVisualStyleBackColor = false;
            this.btn_DeleteCus.UseWaitCursor = true;
            this.btn_DeleteCus.Click += new System.EventHandler(this.btn_DeleteCus_Click);
            // 
            // btn_EditCus
            // 
            this.btn_EditCus.BackColor = System.Drawing.Color.PeachPuff;
            this.btn_EditCus.FlatAppearance.BorderColor = System.Drawing.Color.AntiqueWhite;
            this.btn_EditCus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_EditCus.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EditCus.ForeColor = System.Drawing.Color.Black;
            this.btn_EditCus.Image = ((System.Drawing.Image)(resources.GetObject("btn_EditCus.Image")));
            this.btn_EditCus.Location = new System.Drawing.Point(-1, 264);
            this.btn_EditCus.Name = "btn_EditCus";
            this.btn_EditCus.Size = new System.Drawing.Size(258, 41);
            this.btn_EditCus.TabIndex = 7;
            this.btn_EditCus.Text = "Edit";
            this.btn_EditCus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_EditCus.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_EditCus.UseVisualStyleBackColor = false;
            this.btn_EditCus.UseWaitCursor = true;
            this.btn_EditCus.Click += new System.EventHandler(this.btn_EditCus_Click);
            // 
            // btn_AddCus
            // 
            this.btn_AddCus.BackColor = System.Drawing.Color.PeachPuff;
            this.btn_AddCus.FlatAppearance.BorderColor = System.Drawing.Color.AntiqueWhite;
            this.btn_AddCus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddCus.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddCus.ForeColor = System.Drawing.Color.Black;
            this.btn_AddCus.Image = ((System.Drawing.Image)(resources.GetObject("btn_AddCus.Image")));
            this.btn_AddCus.Location = new System.Drawing.Point(-1, 217);
            this.btn_AddCus.Name = "btn_AddCus";
            this.btn_AddCus.Size = new System.Drawing.Size(258, 41);
            this.btn_AddCus.TabIndex = 6;
            this.btn_AddCus.Text = "Add";
            this.btn_AddCus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_AddCus.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_AddCus.UseVisualStyleBackColor = false;
            this.btn_AddCus.UseWaitCursor = true;
            this.btn_AddCus.Click += new System.EventHandler(this.btn_AddCus_Click);
            // 
            // btn_Home
            // 
            this.btn_Home.BackColor = System.Drawing.Color.PeachPuff;
            this.btn_Home.FlatAppearance.BorderColor = System.Drawing.Color.AntiqueWhite;
            this.btn_Home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Home.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Home.ForeColor = System.Drawing.Color.Black;
            this.btn_Home.Image = ((System.Drawing.Image)(resources.GetObject("btn_Home.Image")));
            this.btn_Home.Location = new System.Drawing.Point(-2, 123);
            this.btn_Home.Name = "btn_Home";
            this.btn_Home.Size = new System.Drawing.Size(258, 41);
            this.btn_Home.TabIndex = 2;
            this.btn_Home.Text = "Home";
            this.btn_Home.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Home.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_Home.UseVisualStyleBackColor = false;
            this.btn_Home.UseWaitCursor = true;
            this.btn_Home.Click += new System.EventHandler(this.btn_Home_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userIDDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.realNameDataGridViewTextBoxColumn,
            this.dOBDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.profilePicDataGridViewImageColumn,
            this.roleDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.userBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(285, 110);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(754, 318);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // userIDDataGridViewTextBoxColumn
            // 
            this.userIDDataGridViewTextBoxColumn.DataPropertyName = "User_ID";
            this.userIDDataGridViewTextBoxColumn.HeaderText = "User_ID";
            this.userIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.userIDDataGridViewTextBoxColumn.Name = "userIDDataGridViewTextBoxColumn";
            this.userIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.userIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 125;
            // 
            // realNameDataGridViewTextBoxColumn
            // 
            this.realNameDataGridViewTextBoxColumn.DataPropertyName = "Real_Name";
            this.realNameDataGridViewTextBoxColumn.HeaderText = "Real_Name";
            this.realNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.realNameDataGridViewTextBoxColumn.Name = "realNameDataGridViewTextBoxColumn";
            this.realNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // dOBDataGridViewTextBoxColumn
            // 
            this.dOBDataGridViewTextBoxColumn.DataPropertyName = "DOB";
            this.dOBDataGridViewTextBoxColumn.HeaderText = "DOB";
            this.dOBDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dOBDataGridViewTextBoxColumn.Name = "dOBDataGridViewTextBoxColumn";
            this.dOBDataGridViewTextBoxColumn.Width = 125;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            this.genderDataGridViewTextBoxColumn.Width = 125;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "Username";
            this.usernameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            this.usernameDataGridViewTextBoxColumn.Width = 125;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.Width = 125;
            // 
            // profilePicDataGridViewImageColumn
            // 
            this.profilePicDataGridViewImageColumn.DataPropertyName = "Profile_Pic";
            this.profilePicDataGridViewImageColumn.HeaderText = "Profile_Pic";
            this.profilePicDataGridViewImageColumn.MinimumWidth = 6;
            this.profilePicDataGridViewImageColumn.Name = "profilePicDataGridViewImageColumn";
            this.profilePicDataGridViewImageColumn.Width = 125;
            // 
            // roleDataGridViewTextBoxColumn
            // 
            this.roleDataGridViewTextBoxColumn.DataPropertyName = "Role";
            this.roleDataGridViewTextBoxColumn.HeaderText = "Role";
            this.roleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.roleDataGridViewTextBoxColumn.Name = "roleDataGridViewTextBoxColumn";
            this.roleDataGridViewTextBoxColumn.Width = 125;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataMember = "User";
            this.userBindingSource.DataSource = this.database1DataSet;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userTableAdapter
            // 
            this.userTableAdapter.ClearBeforeFill = true;
            // 
            // database1DataSet2
            // 
            this.database1DataSet2.DataSetName = "Database1DataSet2";
            this.database1DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userBindingSource1
            // 
            this.userBindingSource1.DataMember = "User";
            this.userBindingSource1.DataSource = this.database1DataSet2;
            // 
            // userTableAdapter1
            // 
            this.userTableAdapter1.ClearBeforeFill = true;
            // 
            // pic_logo
            // 
            this.pic_logo.Image = ((System.Drawing.Image)(resources.GetObject("pic_logo.Image")));
            this.pic_logo.Location = new System.Drawing.Point(-2, -1);
            this.pic_logo.Name = "pic_logo";
            this.pic_logo.Size = new System.Drawing.Size(262, 118);
            this.pic_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pic_logo.TabIndex = 20;
            this.pic_logo.TabStop = false;
            // 
            // update_Customer
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1082, 453);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "update_Customer";
            this.Text = "update_Customer";
            this.Load += new System.EventHandler(this.update_Customer_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_DeleteCus;
        private System.Windows.Forms.Button btn_EditCus;
        private System.Windows.Forms.Button btn_AddCus;
        private System.Windows.Forms.Button btn_Home;
        private System.Windows.Forms.Button btn_viewCus;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource userBindingSource;
        private Database1DataSetTableAdapters.UserTableAdapter userTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn realNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn profilePicDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleDataGridViewTextBoxColumn;
        private Database1DataSet2 database1DataSet2;
        private System.Windows.Forms.BindingSource userBindingSource1;
        private Database1DataSet2TableAdapters.UserTableAdapter userTableAdapter1;
        private System.Windows.Forms.PictureBox pic_logo;
    }
}