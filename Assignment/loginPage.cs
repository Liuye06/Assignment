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

        private void loginPage_Load(object sender, EventArgs e)
        {

        }

   

        private void button1_Click(object sender, EventArgs e)
        {
            User obj1 = new User(txtUsername.Text, txtPassword.Text);
            string result = obj1.login(txtUsername.Text);

            if (result != null)
            {
                MessageBox.Show(result, "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.Hide();  // Hide login page after successful login
            }

            txtUsername.Clear();
            txtPassword.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
