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
    public partial class ManagerUpdateProfile : Form
    {
        private SidebarManager _sidebarManager;

        public ManagerUpdateProfile()
        {
            InitializeComponent();
            _sidebarManager = new SidebarManager(this);
        }

        private void btnMMenu_UProfile_Click(object sender, EventArgs e)
        {
            _sidebarManager.NavigateTo(new MainManageMenu());
        }

        private void btnMHall_UProfile_Click(object sender, EventArgs e)
        {
            _sidebarManager.NavigateTo(new MainManageHall());
        }

        private void btnHRReport_UProfile_Click(object sender, EventArgs e)
        {
            _sidebarManager.NavigateTo(new MainHallResvReport());
        }

        private void btnUProfile_UProfile_Click(object sender, EventArgs e)
        {
            _sidebarManager.NavigateTo(new ManagerUpdateProfile());
        }
    }
}
