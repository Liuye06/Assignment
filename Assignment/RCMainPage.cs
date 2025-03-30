using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    public partial class RCMainPage : Form
    {
        private static readonly string connectionString = ConfigurationManager.ConnectionStrings["myCS"].ConnectionString;
        public RCMainPage()
        {
            InitializeComponent();
        }

        private void btn_Profile_Click(object sender, EventArgs e)
        {
            string username = "admin123"; // get the username from login
            RCProfile btn_Profile = new RCProfile(username);
            btn_Profile.Show();
        }

        private void btn_Reservation_Click(object sender, EventArgs e)
        {

        }

        private void btn_Reply_Click(object sender, EventArgs e)
        {
            ReplyRequest btn_Reply = new ReplyRequest();
            btn_Reply.Show();
        }
    }
}
