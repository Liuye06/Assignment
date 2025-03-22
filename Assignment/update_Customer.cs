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
            // TODO: This line of code loads data into the 'database1DataSet.User' table. You can move, or remove it, as needed.
            this.userTableAdapter.Fill(this.database1DataSet.User);

        }

        private void btn_SalesReport_Click(object sender, EventArgs e)
        {

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
                dataGridView1.DataSource = dv;
            }
        }
    }
}
