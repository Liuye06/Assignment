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
        public update_Customer()
        {
            InitializeComponent();
        }

        private void update_Customer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet2.User' table. 
            this.userTableAdapter1.Fill(this.database1DataSet2.User);
            // TODO: This line of code loads data into the 'database1DataSet.User' table.
            this.userTableAdapter.Fill(this.database1DataSet.User);

        }

        private void btn_AddCus_Click(object sender, EventArgs e)
        {
            addCustomer form = new addCustomer(dataGridView1);
            form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            update_Customer btn_viewCus = new update_Customer();
            btn_viewCus.Show();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable dt = (DataTable)dataGridView1.DataSource;
            if (dt != null)
            {
                DataView dv = new DataView(dt);
                dv.RowFilter = "Roles = 'Customer'"; // just declare roles of Customer 
                dataGridView1.DataSource = dt;
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
            DeleteCus btn_DeleteCus = new DeleteCus();
            btn_DeleteCus.Show();
        }


    }
}
