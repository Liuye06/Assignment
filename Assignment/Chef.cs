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
    public partial class Chef: Form
    {
        public Chef()
        {
            InitializeComponent();
        }

        private void Chef_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'assignmentdbDataSet.Stock' table. You can move, or remove it, as needed.
            this.stockTableAdapter.Fill(this.assignmentdbDataSet.Stock);

        }
    }
}
