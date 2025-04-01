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
    public partial class update_Customer : Form
    {
        private DataGridView dataGridView;

        public update_Customer()
        {
            InitializeComponent();
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

        private void btn_AddCus_Click(object sender, EventArgs e)
        {
            addCustomer form = new addCustomer(dataGridView1);
            form.ShowDialog();
            RefreshDataGrid();
        }

        private void button1_Click(object sender, EventArgs e)//view customer
        {
            RefreshDataGrid();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void btn_Home_Click(object sender, EventArgs e)
        {
            this.Close();
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
