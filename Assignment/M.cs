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
    public partial class M: Form
    {
        public M()
        {
            InitializeComponent();
        }

        private void M_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'assignmentdbDataSet1.Menu' table. You can move, or remove it, as needed.
            this.menuTableAdapter.Fill(this.assignmentdbDataSet1.Menu);

        }

        private void btnUpload_Click(object sender, EventArgs e)
        {

        }
    }
}
