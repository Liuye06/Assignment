using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace Assignment
{
    public partial class addCustomer : Form
    {
        private string connectionString;

        public object Username { get; private set; }

        public addCustomer()
        {
            InitializeComponent();
            this.Load += new EventHandler(addCustomer_Load);
        }

        private void btn_addCus_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_CusName.Text) ||
                 string.IsNullOrWhiteSpace(txt_CusDOB.Text) ||
                 string.IsNullOrWhiteSpace(txt_CusGender.Text) ||
                 string.IsNullOrWhiteSpace(txt_CusRole.Text) ||
                 string.IsNullOrWhiteSpace(txt_CusEmail.Text) ||
                 string.IsNullOrWhiteSpace(txt_CusUsername.Text) ||
                 string.IsNullOrWhiteSpace(txt_CusPassword.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO User (Real_Name, DOB, Gender, Role, Email, Username, Password) VALUES (@Real_Name, @DOB, @Gender, @Role, @Email, @Username, @Password)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Real_Name", txt_CusName.Text);
                    cmd.Parameters.AddWithValue("@DOB", txt_CusDOB.Text);
                    cmd.Parameters.AddWithValue("@Gender", txt_CusGender.Text);
                    cmd.Parameters.AddWithValue("@Role", txt_CusRole.Text);
                    cmd.Parameters.AddWithValue("@Email", txt_CusEmail.Text);
                    cmd.Parameters.AddWithValue("@Username", txt_CusUsername.Text);
                    cmd.Parameters.AddWithValue("@Password", txt_CusPassword.Text); // Consider hashing the password

                    try
                    {
                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("User registered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Refresh(); //Refresh 
                        }
                        else
                        {
                            MessageBox.Show("Registration failed. Try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void refresh(object sender, EventArgs e)
        {
            txt_CusName.Text = "";
            txt_CusDOB.Text = "";
            txt_CusGender.Text = "";
            txt_CusRole.Text = "";
            txt_CusEmail.Text = "";
            txt_CusUsername.Text = "";
            txt_CusPassword.Text = "";
        }

        private void addCustomer_Load(object sender, EventArgs e)
        {

        }
    }
}
       