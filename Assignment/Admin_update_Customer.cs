using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Assignment
{
    public partial class Admin_update_Customer : Form
    {
        private int currentUserID;

        public Admin_update_Customer(int userID)
        {
            InitializeComponent();
            currentUserID = userID;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
        }


        private void update_Customer_Load(object sender, EventArgs e)
        {
            RefreshDataGrid();
        }

        private void RefreshDataGrid()
        {    
            AdminClass.RefreshDataGridView(dataGridView1);
        }



        private void button1_Click(object sender, EventArgs e)//view customer
        {
            RefreshDataGrid();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btn_AddCus_Click(object sender, EventArgs e)
        {
            Admin_addCustomer form = new Admin_addCustomer(dataGridView1);
            form.ShowDialog();
            RefreshDataGrid();
        }


        private void btn_Home_Click(object sender, EventArgs e)
        {
            Admin_Homepage adminForm = new Admin_Homepage(currentUserID);
            adminForm.Show();
            this.Close();
        }

        private void btn_EditCus_Click(object sender, EventArgs e)
        {
            Admin_EditCus editCusForm = new Admin_EditCus(this.dataGridView1);
            editCusForm.ShowDialog();
            RefreshDataGrid();
        }

        private void btn_DeleteCus_Click(object sender, EventArgs e)
        {
            Admin_DeleteCus deleteForm = new Admin_DeleteCus(this.dataGridView1);
            deleteForm.ShowDialog();
            RefreshDataGrid();
        }
    }
}
