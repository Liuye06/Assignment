using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    public partial class Admin_DeleteCus : Form
    {
        private DataGridView dataGridView;
        public Admin_DeleteCus(DataGridView dataGridView)
        {
            InitializeComponent();
            this.dataGridView = dataGridView;
        }

        private void LoadCustomerNames()
        {
            try
            {
                DataTable dt = AdminClass.GetCustomerData(); // Role = 'Customer'
                comboBox1.DataSource = dt;
                comboBox1.DisplayMember = "Real_Name";
                comboBox1.ValueMember = "User_ID";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading customer names: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadCustomerData()
        {
            try
            {
                dataGridView1.DataSource = AdminClass.GetCustomerData(); // Role = 'Customer'
                ConfigureDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading customer data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ConfigureDataGridView()
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue == null)
            {
                MessageBox.Show("Please select a customer to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string userId = comboBox1.SelectedValue.ToString(); 

            var confirmResult = MessageBox.Show($"Are you sure you want to delete this customer?",
                                                "Confirm Delete",
                                                MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                bool success = AdminClass.DeleteUser(userId, dataGridView1);
                if (success)
                {
                    LoadCustomerNames();
                    LoadCustomerData();
                }
                else
                {
                    MessageBox.Show("Failed to delete customer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void DeleteCus_Load(object sender, EventArgs e)
        {
            LoadCustomerData();
            LoadCustomerNames();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
