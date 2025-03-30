using System;
using System.Data;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Assignment
{
    public partial class ReplyRequest : Form
    {
        public ReplyRequest()
        {
            InitializeComponent();
            LoadUserIDs();
            LoadRequestData();
        }
        private void LoadUserIDs()
        {
            DataTable dt = RersevationCoordinator.GetUniqueUserIDs();
            listBox1.DataSource = dt;
            listBox1.DisplayMember = "User_ID";
            listBox1.ValueMember = "User_ID";
        }

        private void LoadRequestData()
        {
            DataTable dt = RersevationCoordinator.GetRequestData();
            dataGridView1.DataSource = dt;
        }

        private void btn_Reply_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
            {
                MessageBox.Show("Please select a user first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txt_Reply.Text))
            {
                MessageBox.Show("Please enter a reply message.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataRowView selectedRow = (DataRowView)listBox1.SelectedItem;
            int userID = Convert.ToInt32(selectedRow["User_ID"]);
            string status = txt_Reply.Text;

            RersevationCoordinator.UpdateRequestStatus(userID, status);
            MessageBox.Show("Reply sent successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Refresh the data
            LoadUserIDs();
            LoadRequestData();
            txt_Reply.Clear();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

