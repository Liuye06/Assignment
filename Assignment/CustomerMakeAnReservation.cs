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
    public partial class CustomerMakeAnReservation : Form
    {
        private SidebarManager _sidebarManager;

        public CustomerMakeAnReservation()
        {
            InitializeComponent();
            _sidebarManager = new SidebarManager(this);
        }

        private void btn_SendReq_Click(object sender, EventArgs e)
        {

        }

        
    }
}
