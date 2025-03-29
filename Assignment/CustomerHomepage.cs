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
    public partial class CustomerHomepage : Form
    {
        public CustomerHomepage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel_ReservationRequest.Visible = !panel_ReservationRequest.Visible;
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            panel_OrderMenu.Visible = !panel_OrderMenu.Visible;
        }

        private void pb_ProfilePic_Click(object sender, EventArgs e)
        {
            Customer_EditProfile c_profile = new Customer_EditProfile();
            c_profile.Show();
        }

        private void CustomerHomepage_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'assignmentdbDataSet6.Order' table. You can move, or remove it, as needed.
            panel_ViewOrders.Visible = false;
            panel_ViewReservation.Visible = false;
            panel_OrderMenu.Visible = false;
            panel_ReservationRequest.Visible = false;
            panel_Payment.Visible = false;
            panel_Feedback.Visible = false;

        }

        private void btnViewOrders_Click(object sender, EventArgs e)
        {
            panel_ViewOrders.Visible = !panel_ViewOrders.Visible;
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            panel_ViewProfile.Visible = !panel_ViewProfile.Visible;
        }

        private void btnViewReservations_Click(object sender, EventArgs e)
        {
            panel_ViewReservation.Visible = !panel_ViewReservation.Visible;
        }

        private void btnMakePayment_Click(object sender, EventArgs e)
        {
            panel_Payment.Visible = !panel_Payment.Visible;
        }

        private void btnFeedback_Click(object sender, EventArgs e)
        {
            panel_Feedback.Visible = !panel_Feedback.Visible;
        }

        private void btn_ReturnViewOrders_Click(object sender, EventArgs e)
        {
            panel_ViewOrders.Visible = false;
        }

        private void btn_ViewReservation_Click(object sender, EventArgs e)
        {
            panel_ViewReservation.Visible = false;
        }

        private void btn_ReturnOrdersMenu_Click(object sender, EventArgs e)
        {
            panel_OrderMenu.Visible = false;
        }

        private void btn_ReturnReserveReq_Click(object sender, EventArgs e)
        {
            panel_ReservationRequest.Visible = false;
        }

        private void btn_ReturnPayment_Click(object sender, EventArgs e)
        {
            panel_Payment.Visible = false;
        }

        private void btn_ReturnFeedback_Click(object sender, EventArgs e)
        {
            panel_Feedback.Visible = false;
        }

        private void btnOrderMenu_Next_Click(object sender, EventArgs e)
        {
            Orders_Confirmation o_confirmation = new Orders_Confirmation();
            o_confirmation.Show();
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            Customer_EditProfile c_editprof = new Customer_EditProfile();
            c_editprof.Show();
        }

        private void btn_Reservations_Click(object sender, EventArgs e)
        {
            MakePayment_Reservations mp_reservation = new MakePayment_Reservations();
            mp_reservation.Show();
        }

        private void btn_Orders_Click(object sender, EventArgs e)
        {
            MakePayment_Orders mp_orders = new MakePayment_Orders();
            mp_orders.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
