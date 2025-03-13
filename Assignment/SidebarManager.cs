using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    public class SidebarManager
    {
        private Form _parentForm;

        public SidebarManager(Form parentForm)
        {
            _parentForm = parentForm;
        }

        public void NavigateTo(Form newForm)
        {
            _parentForm.Hide(); // Hide the current form
            newForm.FormClosed += (s, e) => _parentForm.Show(); // Show the parent form when the new one is closed
            newForm.Show();
        }
    }
}
