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
    public partial class MainManageHall : Form
    {
        private SidebarManager _sidebarManager;

        public MainManageHall()
        {
            InitializeComponent();
            _sidebarManager = new SidebarManager(this);
        }


        private void btnMMenu_MHall_Click(object sender, EventArgs e)
        {
            _sidebarManager.NavigateTo(new MainManageMenu());
        }

        private void btnMHall_MHall_Click(object sender, EventArgs e)
        {
            _sidebarManager.NavigateTo(new MainManageHall());
        }

        private void btnHRReport_MHall_Click(object sender, EventArgs e)
        {
            _sidebarManager.NavigateTo(new MainHallResvReport());
        }

        private void btnUProfile_MHall_Click(object sender, EventArgs e)
        {
            _sidebarManager.NavigateTo(new ManagerUpdateProfile());
        }
    }
}
