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

        private void button3_Click(object sender, EventArgs e)
        {
            Chef_Profile c_profile = new Chef_Profile();
            c_profile.Show();
        }

        private void btn_c_order_Click(object sender, EventArgs e)
        {
            View_Order v_order = new View_Order();
            v_order.Show();
        }

        private void btn_inventory_Click(object sender, EventArgs e)
        {
            Inventory inventory = new Inventory();
            inventory.Show();
        }
    }
}
