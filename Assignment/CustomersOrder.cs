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
    public partial class CustomersOrder: Form
    {
        public CustomersOrder()
        {
            InitializeComponent();
        }

        private void View_Order_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'assignmentdbDataSet3.Order' table. You can move, or remove it, as needed.
            this.orderTableAdapter.Fill(this.assignmentdbDataSet3.Order);

        }

        private void btn_VO_b_Click(object sender, EventArgs e)
        {
            Chef chef = new Chef();
            chef.Show();
        }
    }
}
