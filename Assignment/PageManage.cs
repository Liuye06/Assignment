using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    internal class PageManage
    {
        private Form _currentForm;

        public SidebarManager(Form startForm)
        {
            _currentForm = startForm;
        }

        public void NavigateTo(Form newForm)
        {
            _currentForm.Hide();
        }

        _currentForm = newForm;
        _currentForm.FormClosed += (s, e) => Application.Exit();
        _currentForm.Show();
}
}
