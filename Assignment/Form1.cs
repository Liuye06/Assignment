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
    public partial class Main_page : Form
    {
        public Main_page()
        {
            InitializeComponent();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            Customer btnCustomer = new Customer();
            btnCustomer.Show();
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            Staff btnStaff = new Staff();
            btnStaff.Show();
        }

        private void Main_page_Load(object sender, EventArgs e)
        {

        }
    }
}
