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
        private static readonly string connectionString = ConfigurationManager.ConnectionStrings["MyDBConnection"].ConnectionString;
        private int currentUserID; // Store the userID

        public RCMainPage(int userID)
        {
            InitializeComponent();
            currentUserID = userID; // Store the userID

        }

        private void btn_Profile_Click(object sender, EventArgs e)
        {
            RCProfile btn_Profile = new RCProfile(currentUserID);
            btn_Profile.Show();
        }

        private void btn_Reservation_Click(object sender, EventArgs e)
        {
            Reservation btn_Reservation = new Reservation();
            btn_Reservation.Show();
        }

        private void btn_Reply_Click(object sender, EventArgs e)
        {
            ReplyRequest btn_Reply = new ReplyRequest();
            btn_Reply.Show();
        }

        private void RCMainPage_Load(object sender, EventArgs e)
        {

        }
    }
}
