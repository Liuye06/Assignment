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
    public partial class ReplyRequest : Form
    {
        public ReplyRequest()
        {
            InitializeComponent();
        }

        private void btn_Send_Click(object sender, EventArgs e)
        {

        }

        private void ReplyRequest_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet1.R_Request' table. You can move, or remove it, as needed.
            this.r_RequestTableAdapter.Fill(this.database1DataSet1.R_Request);

        }
    }
}
