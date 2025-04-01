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
    public partial class loginPage : Form
    {
        public loginPage()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            User obj1 = new User(txtUsername.Text, txtPassword.Text);
            string result = obj1.Login(this);  // Pass the current login form to Login() method

            if (result != null)
            {
                MessageBox.Show(result, "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Clear the textboxes after the login attempt
            txtUsername.Clear();
            txtPassword.Clear();
        }
    }
}
