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
    public partial class MainHallResvReport : Form
    {
        private SidebarManager _sidebarManager;

        public MainHallResvReport()
        {
            InitializeComponent();
            _sidebarManager = new SidebarManager(this);
        }

        private void btnMMenu_HRReport_Click(object sender, EventArgs e)
        {
            _sidebarManager.NavigateTo(new MainManageMenu());
        }

        private void btnMHall_HRReport_Click(object sender, EventArgs e)
        {
            _sidebarManager.NavigateTo(new MainManageHall());
        }

        private void btnHRReport_HRReport_Click(object sender, EventArgs e)
        {
            _sidebarManager.NavigateTo(new MainHallResvReport());
        }

        private void btnUProfile_HRReport_Click(object sender, EventArgs e)
        {
            _sidebarManager.NavigateTo(new ManagerProfile());
        }

        private void btnSearchReport_Click(object sender, EventArgs e)
        {

        }
    }
}
