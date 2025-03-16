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
    public partial class Reservation_Main : Form
    {
        public Reservation_Main()
        {
            InitializeComponent();
        }

        private void btnHall1_Click(object sender, EventArgs e)
        {
            Hall_Reservation_H1 h_reservation1 = new Hall_Reservation_H1();
            h_reservation1.Show();
        }

        private void btnHall2_Click(object sender, EventArgs e)
        {
            Hall_Reservation_H2 h_reservation2 = new Hall_Reservation_H2();
            h_reservation2.Show();
        }

        private void btnHall3_Click(object sender, EventArgs e)
        {
            Hall_Reservation_H3 h_reservation3 = new Hall_Reservation_H3();
            h_reservation3.Show();
        }
    }
}
