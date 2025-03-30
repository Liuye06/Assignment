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
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            Reservation btn_view = new Reservation();
            btn_view.Show();
        }

        private void btn_Home_Click(object sender, EventArgs e)
        {
            RCMainPage btn_Home = new RCMainPage();
            btn_Home.Show();
        }

        private void btn_Assign_Click(object sender, EventArgs e)
        {
            AddReservation form = new AddReservation(); 
            form.Show();
            RefreshDataGrid();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            DeleteReservation btn_Delete = new DeleteReservation();
            btn_Delete.Show();
        }

        private void Reservation_Load(object sender, EventArgs e)
        {
            this.reservationTableAdapter.Fill(this.database1DataSet2.Reservation);
            RefreshDataGrid();
        }

        private void RefreshDataGrid()
        {
            this.reservationTableAdapter.Fill(this.database1DataSet2.Reservation);
            dataGridView1.DataSource = this.database1DataSet2.Reservation;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
 
        }
    }
}