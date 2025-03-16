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
    public partial class Chef: Form
    {
        public Chef()
        {
            InitializeComponent();
        }

        private void Chef_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'assignmentdbDataSet3.Order' table. You can move, or remove it, as needed.
            this.orderTableAdapter.Fill(this.assignmentdbDataSet3.Order);
            // TODO: This line of code loads data into the 'assignmentdbDataSet.Stock' table. You can move, or remove it, as needed.
            this.stockTableAdapter.Fill(this.assignmentdbDataSet.Stock);
            panel_CVI.Visible = false;
            panel_CVO.Visible = false;
            panel_CVP.Visible = false;
        }

        private void btn_inventory_Click(object sender, EventArgs e)
        {
            panel_CVI.Visible = !panel_CVI.Visible;
        }

        private void btn_CusOrder_Click(object sender, EventArgs e)
        {
            panel_CVO.Visible = !panel_CVO.Visible;
        }

        private void btn_ChefProfile_Click(object sender, EventArgs e)
        {
            panel_CVP.Visible = !panel_CVP.Visible;
        }

        private void btn_CUI_Click(object sender, EventArgs e)
        {
            Inventory inventory = new Inventory();
            inventory.Show();
        }

        private void btn_COrder_Click(object sender, EventArgs e)
        {
            CustomersOrder v_order = new CustomersOrder();
            v_order.Show();
        }

        private void btn_CUP_Click(object sender, EventArgs e)
        {
            Chef_Profile c_profile = new Chef_Profile();
            c_profile.Show();
        }
    }
}
