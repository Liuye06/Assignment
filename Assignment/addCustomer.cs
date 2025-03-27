using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace Assignment
{
    public partial class addCustomer : Form
    {
        private string connectionString;

        public addCustomer()
        {
            InitializeComponent();
            this.Load += new EventHandler(addCustomer_Load);

            // direct use the System.Configuration.ConfigurationManager
            connectionString = ConfigurationManager.ConnectionStrings["myCS"].ConnectionString;
        }

        private void btn_addCus_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_CusName.Text) ||
                 string.IsNullOrWhiteSpace(txt_CusDOB.Text) ||
                 string.IsNullOrWhiteSpace(txt_CusGender.Text) ||
                 string.IsNullOrWhiteSpace(txt_CusEmail.Text) ||
                 string.IsNullOrWhiteSpace(txt_CusUsername.Text) ||
                 string.IsNullOrWhiteSpace(txt_CusPassword.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                
                string query = "INSERT INTO [User] (Real_Name, DOB, Gender, Role, Email, Username, Password) VALUES (@Real_Name, @DOB, @Gender, @Role, @Email, @Username, @Password)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Real_Name", txt_CusName.Text);
                    cmd.Parameters.AddWithValue("@DOB", txt_CusDOB.Text);
                    cmd.Parameters.AddWithValue("@Gender", txt_CusGender.Text);
                    cmd.Parameters.AddWithValue("@Role", "Customer");
                    cmd.Parameters.AddWithValue("@Email", txt_CusEmail.Text);
                    cmd.Parameters.AddWithValue("@Username", txt_CusUsername.Text);
                    cmd.Parameters.AddWithValue("@Password", txt_CusPassword.Text);

                    try
                    {
                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("User registered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            refresh();
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

        private void refresh()
        {
            txt_CusName.Text = "";
            txt_CusDOB.Text = "";
            txt_CusGender.Text = "";
            txt_CusEmail.Text = "";
            txt_CusUsername.Text = "";
            txt_CusPassword.Text = "";
        }

        private void addCustomer_Load(object sender, EventArgs e)
        {

        }
    }
}
