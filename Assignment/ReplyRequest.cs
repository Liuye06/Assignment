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
        }

        private void ReplyRequest_Load(object sender, EventArgs e)
        {
           
        }

        private void LoadData()
        {
            dataGridView1.DataSource = RersevationCoordinator.GetRequestData();
            listBox1.DataSource = RersevationCoordinator.GetUniqueUserIDs();
            listBox1.DisplayMember = "User_ID";
            listBox1.ValueMember = "User_ID"; 
        }

        private void btn_Send_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null || string.IsNullOrWhiteSpace(txt_Reply.Text))
            {
                MessageBox.Show("Please select a user and enter a reply.");
                return;
            }

            // select the  User_ID
            string userID = (listBox1.SelectedItem as DataRowView)["User_ID"].ToString();
            string status = txt_Reply.Text;

            // insect to R_Request 
            if (RersevationCoordinator.InsertReply(userID, status))
            {
                MessageBox.Show("Reply has been sent!");
                txt_Reply.Clear(); 
            }
            else
            {
                MessageBox.Show("Failed to send reply, please try again.");
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            listBox1.ClearSelected();
            txt_Reply.Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
 }

