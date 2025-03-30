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
    public partial class DeleteReservation : Form
    {
        public DeleteReservation()
        {
            InitializeComponent();
        }

        private void DeleteReservation_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet5.Reservation' table. You can move, or remove it, as needed.
            this.reservationTableAdapter.Fill(this.database1DataSet5.Reservation);

        }
    }
}
