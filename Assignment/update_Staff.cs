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
    public partial class update_Staff : Form
    {
        public update_Staff()
        {
            InitializeComponent();
        }

        private void update_Staff_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet6.User' table. You can move, or remove it, as needed.
            this.userTableAdapter.Fill(this.database1DataSet6.User);

        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            update_Staff btn_view = new update_Staff();
            btn_view.Show();
        }
    }
}
