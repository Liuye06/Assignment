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
    public partial class update_Customer : Form
    {
        private DataGridView dataGridView;

        public update_Customer()
        {
            InitializeComponent();
        }
        public update_Customer(DataGridView dataGridView)
        {
            InitializeComponent();
            this.dataGridView = dataGridView;
        }
        private void update_Customer_Load(object sender, EventArgs e)
        {
            this.userTableAdapter.Fill(this.database1DataSet.User);
            dataGridView1.DataSource = this.database1DataSet.User; 

        }

        private void btn_AddCus_Click(object sender, EventArgs e)
        {
            addCustomer form = new addCustomer(dataGridView1);
            form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            update_Customer form = new update_Customer(dataGridView1);
            form.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.DataSource is DataTable dt)
            {
                DataView dv = dt.DefaultView;
                dv.RowFilter = "Roles = 'Customer'";
                dataGridView1.DataSource = dv;  
            }
        }
        private void btn_Home_Click(object sender, EventArgs e)
        {
            Admin btn_Home = new Admin();
            btn_Home.Show();
        }

        private void btn_EditCus_Click(object sender, EventArgs e)
        {
            EditCus editCusForm = new EditCus(this.dataGridView1);
            editCusForm.ShowDialog();
        }

        private void btn_DeleteCus_Click(object sender, EventArgs e)
        {
            DeleteCus deleteForm = new DeleteCus(this.dataGridView1);
            deleteForm.ShowDialog();
        }
    }
}
