using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Assignment
{
    public partial class update_Staff : Form
    {
        public update_Staff()
        {
            InitializeComponent();
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            comboBox1.Items.AddRange(new string[] { "Admin", "Manager", "Chef", "Reservation Coordinator" });
            comboBox1.SelectedIndex = 0;
        }

        private void update_Staff_Load(object sender, EventArgs e)
        {
            // direct use via AdminClass to get data
            RefreshDataGrid();
        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            RefreshDataGrid();
        }
        private void RefreshDataGrid()
        {
            string selectedRole = comboBox1.SelectedItem.ToString();
            AdminClass.RefreshStaffGridView(dataGridView1, selectedRole);
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            addStaff form = new addStaff(dataGridView1);
            form.ShowDialog();
            RefreshDataGrid();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void Btn_viewStaff_Click(object sender, EventArgs e)
        {
            RefreshDataGrid();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            DeleteStaff btn_Delete = new DeleteStaff();
            btn_Delete.ShowDialog();
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            editStaff form = new editStaff(dataGridView1);
            form.ShowDialog();
        }
    }

}
