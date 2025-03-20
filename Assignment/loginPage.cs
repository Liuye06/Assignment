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
    public partial class btnLogin : Form
    {
        public btnLogin()
        {
            InitializeComponent();
        }

        private void loginPage_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string press;
            User obj1 = new User(txtUsername.Text, txtPassword.Text);
            press = obj1.login(txtUsername.Text);
            if (press!= null)
            {
                MessageBox.Show(press);
            }
            txtUsername.Text = String.Empty;
            txtPassword.Text = String.Empty;
        }
    }
}
