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
    public partial class Admin_Homepage : Form
    {
        private int currentUserID; // Store the userID

        public Admin_Homepage(int userID)
        {
            InitializeComponent();
            currentUserID = userID; // Store the userID
            UserSessionManager.Login(userID);
        }


        private void btn_SalesReport_Click_1(object sender, EventArgs e)
        {
            Admin_salesReport btn_SalesReport = new Admin_salesReport(currentUserID);
            btn_SalesReport.Show();
            this.Close();
        }

        private void btn_Feedback_Click_1(object sender, EventArgs e)
        {
            Admin_view_CusFeedback btn_Feedback = new Admin_view_CusFeedback(currentUserID);
            btn_Feedback.Show();
            this.Close();
        }

        private void btn_UpStaff_Click(object sender, EventArgs e)
        {
            Admin_update_Staff btn_UpStaff = new Admin_update_Staff(currentUserID);
            btn_UpStaff.Show();
            this.Close();
        }

        private void btn_UpCustomer_Click_1(object sender, EventArgs e)
        {
            Admin_update_Customer btn_UpCustomer = new Admin_update_Customer(currentUserID);
            btn_UpCustomer.Show();
            this.Close();
        }

        private void btn_AdminProfile_Click(object sender, EventArgs e)
        {
            Admin_Profile adminProfileForm = new Admin_Profile(currentUserID);
            adminProfileForm.Show();
            this.Close();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            UserSessionManager.Logout(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void lbl1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }
    }
}
