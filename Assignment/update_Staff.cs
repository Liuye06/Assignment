using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    public partial class update_Staff : Form
    {
        private DataGridView _dataGridView; // Store reference to main form's DataGridView

        public update_Staff()
        {
            InitializeComponent();
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
        }

        private void update_Staff_Load(object sender, EventArgs e)
        {
            this.userTableAdapter.Fill(this.database1DataSet6.User);
        }

        private void btn_view_Click(object sender, EventArgs e)
        {
         
            update_Staff btn_view = new update_Staff();
            btn_view.Show();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            addStaff form = new addStaff(dataGridView1);
            form.ShowDialog();
        }
     
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable dt = (DataTable)dataGridView1.DataSource;
            if (dt != null)
            {
                DataView dv = new DataView(dt);
                dv.RowFilter = "Roles = 'Admin','Manager', 'Chef','Reservation Coordinator'"; // just declare roles of staff 
                dataGridView1.DataSource = dt;
            }
        }
    }
}
