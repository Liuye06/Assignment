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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admin btnAdmin = new Admin();
            btnAdmin.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            update_Staff btn_UpStaff = new update_Staff();
            btn_UpStaff.Show();
        }

        private void btn_UpCustomer_Click(object sender, EventArgs e)
        {
            update_Customer btn_UpCustomer = new update_Customer();
            btn_UpCustomer.Show();
        }
    }
}
