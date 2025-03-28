using System;
using System.Windows.Forms;

namespace Assignment
{
    public partial class view_CusFeedback : Form
    {
        private Timer refreshTimer;

        public view_CusFeedback()
        {
            InitializeComponent();
            this.Load += View_CusFeedback_Load;

            // Set up auto-refresh every 30 seconds
            refreshTimer = new Timer { Interval = 30000 };
            refreshTimer.Tick += (s, e) => RefreshData();
            refreshTimer.Start();
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

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            refreshTimer?.Stop();
            base.OnFormClosing(e);
        }

        private void view_CusFeedback_Load_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}