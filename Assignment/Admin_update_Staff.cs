using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Assignment
{
    public partial class Admin_update_Staff : Form
    {
        private int currentUserID; // Variable to store the current user ID

        public Admin_update_Staff(int userID)
        {
            InitializeComponent();
            currentUserID = userID; // Store the current user ID
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            comboBox1.Items.AddRange(new string[] { "All","Admin", "Manager", "Chef", "Reservation Coordinator" });
            comboBox1.SelectedIndex = 0;
        }

        private void update_Staff_Load(object sender, EventArgs e)
        {
            RefreshDataGrid();

        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            RefreshDataGrid();
        }

        private void RefreshDataGrid()
        {
            string selectedRole = comboBox1.SelectedItem?.ToString() ?? "All";
            AdminClass.RefreshStaffGridView(dataGridView1, selectedRole);
        }


        private void btn_Add_Click(object sender, EventArgs e)
        {
            Admin_addStaff form = new Admin_addStaff(dataGridView1);
            form.ShowDialog();
            RefreshDataGrid();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }


        private void btn_Delete_Click(object sender, EventArgs e)
        {
            Admin_DeleteStaff deleteForm = new Admin_DeleteStaff();
            deleteForm.ShowDialog(); // Show delete staff form
            RefreshDataGrid(); // Refresh the data grid after deleting staff
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            Admin_editStaff form = new Admin_editStaff(dataGridView1);
            form.ShowDialog(); // Show edit staff form
            RefreshDataGrid();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshDataGrid();
        }

        private void btn_Home_Click(object sender, EventArgs e)
        {
            Admin_Homepage adminForm = new Admin_Homepage(currentUserID);
            adminForm.Show();
            this.Close();
        }

        private void update_Staff_Shown(object sender, EventArgs e)
        {
            RefreshDataGrid();
        }

        private void Btn_resetSearchStaff_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}
