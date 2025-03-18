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
        private Form _currentForm; // Track the currently open form

        public SidebarManager(Form startForm)
        {
            _currentForm = startForm;
        }

        public void NavigateTo(Form newForm)
        {
            if (_currentForm != null && !_currentForm.IsDisposed)
            {
                _currentForm.Hide(); // Hide the current form instead of closing it
            }

            _currentForm = newForm; // Set new form as the active form
            _currentForm.FormClosed += (s, e) => Application.Exit(); // Ensure app exits when the last form is closed
            _currentForm.Show();
        }
    }
}
