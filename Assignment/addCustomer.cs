using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Assignment
{
    public partial class addCustomer : Form
    {
        public addCustomer()
        {
            InitializeComponent();
        }

        private void btn_addCus_Click(object sender, EventArgs e)
        {
            string connectionString = "your_connection_string_here";

            string query = "INSERT INTO Users (Email, Real_Name, DOB, Gender, Username, Password, Role) " +
                   "VALUES (@Email, @Real_Name, @DOB, @Gender, @Username, @Password, @Role)";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Real_Name", txt_CusName);
                        cmd.Parameters.AddWithValue("@DOB", txt_CusDOB);
                        cmd.Parameters.AddWithValue("@Gender", txt_CusGender);
                        cmd.Parameters.AddWithValue("@Role", txt_CusRole);
                        cmd.Parameters.AddWithValue("@Email", txt_CusEmail);
                        cmd.Parameters.AddWithValue("@Username", txt_CusUsername);
                        cmd.Parameters.AddWithValue("@Password", txt_CusPassword);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Registration Successfull!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Registration Failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
    }
}
