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
    public partial class Reservation : Form
    {
        public Reservation()
        {
            InitializeComponent();
        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            Reservation btn_view = Reservation();
            btn_view.Show();
        }

        private void btn_Home_Click(object sender, EventArgs e)
        {
            RCMainPage btn_Home = new RCMainPage();
            btn_Home.Show();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            AddReservation btn_Add = new AddReservation();
            btn_Add.Show();
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            EditReservation btn_Edit = new EditReservation();
            btn_Edit.Show();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            DeleteReservation btn_Delete = new DeleteReservation();
            btn_Delete.Show();
        }

        private void Reservation_Load(object sender, EventArgs e)
        {
            RefreshDataGrid()
        }

        private void RefreshDataGrid()
        {
            ReservationCoordinator.RefreshDataGridView(dataGridView1);
        }

    }
}
