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
        private void btn_SalesReport_Click(object sender, EventArgs e)
        {
            salesReport btn_SalesReport = new salesReport();
            btn_SalesReport.Show();
        }

        private void btn_Feedback_Click(object sender, EventArgs e)
        {
            view_CusFeedback btn_Feedback = new view_CusFeedback();
            btn_Feedback.Show();
        }
        private void Admin_Load(object sender, EventArgs e)
        {
        }
        private void button2_Click_1(object sender, EventArgs e)//update admin profile only
        {
            string username = "admin123"; // get from the login page
            AdminProfile button2 = new AdminProfile(username);
            button2.Show();
        }


        //private void btn_exit_Click(object sender, EventArgs e)
        //{
        //login btn_exit = new login();
        //btn_exit.Show();
        //}
    }
}
