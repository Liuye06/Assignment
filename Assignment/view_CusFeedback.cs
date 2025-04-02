using System;
using System.Windows.Forms;

namespace Assignment
{
    public partial class view_CusFeedback : Form
    {
        private int currentUserID; // Store the userID

        public view_CusFeedback(int userID)
        {
            InitializeComponent();
            this.Load += View_CusFeedback_Load;
            currentUserID = userID; // Store the userID
        }

        private void View_CusFeedback_Load(object sender, EventArgs e)
        {
            RefreshData();
            AdminClass.ConfigureFeedbackGridView(dataGridView1);
        }

        private void RefreshData()
        {
            dataGridView1.DataSource = AdminClass.GetCustomerFeedbacks();
        }

        private void btn_Return_Click(object sender, EventArgs e)
        {
            Admin adminForm = new Admin(currentUserID);
            adminForm.Show();
            this.Close();
        }
    }
}