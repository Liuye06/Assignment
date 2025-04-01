using System;
using System.Windows.Forms;

namespace Assignment
{
    public partial class view_CusFeedback : Form
    {

        public view_CusFeedback()
        {
            InitializeComponent();
            this.Load += View_CusFeedback_Load;
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
            this.Close();
        }
    }
}