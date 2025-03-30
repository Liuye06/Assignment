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
    public partial class AddReservation : Form
    {
        public AddReservation()
        {
            InitializeComponent();
        }

        private void AddReservation_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet6.R_Request' table. You can move, or remove it, as needed.
            this.r_RequestTableAdapter.Fill(this.database1DataSet6.R_Request);
            // TODO: This line of code loads data into the 'database1DataSet4.Reservation' table. You can move, or remove it, as needed.
            this.reservationTableAdapter.Fill(this.database1DataSet4.Reservation);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            string hallID = txt_HallID.Text;
            

            if (string.IsNullOrWhiteSpace(hallID) 
            {
                MessageBox.Show("Please fill in all fields");
                return;
            }

            if (RersevationCoordinator.AddReservation(hallID))
            {
                MessageBox.Show("Reservation added successfully");
                RersevationCoordinator.RefreshDataGridView(dataGridView1);

                // Clear the fields after successful addition
                txt_HallID.Clear();
               
            }
            else
            {
                MessageBox.Show("Failed to add reservation");
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        { 
            txt_HallID.Clear();
        }
    }
}
