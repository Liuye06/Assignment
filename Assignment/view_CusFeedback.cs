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
    public partial class view_CusFeedback : Form
    {
        public view_CusFeedback()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void view_CusFeedback_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet7.Table' table. You can move, or remove it, as needed.
            this.tableTableAdapter.Fill(this.database1DataSet7.Table);

        }
    }
}
