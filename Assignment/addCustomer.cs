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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace Assignment
{
    public partial class addCustomer : Form
    {
        public object Username { get; private set; }

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
                    txt_CusDOB.Text = String.Empty;
                    txt_CusGender.Text = String.Empty;
                    txt_CusRole.Text = String.Empty;
                    txt_CusPassword.Text = String.Empty;
                    txt_CusName.Text = String.Empty;
                    txt_CusEmail.Text = String.Empty;
                    txt_CusUsername = String.Empty;
                }
            }
        }



        private void addCustomer_Load(object sender, EventArgs e, string v)
        {
            string connectionString = "your_connection_string_here";
            string query = "SELECT Real_Name, DOB, Gender, Role, Email, Password FROM Users WHERE Username = @Username";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        // 这里的 username 来自 TextBox
                        cmd.Parameters.AddWithValue("@Username", Username);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read()) // if find out the data
                            {
                                txt_CusName.Text = reader["Real_Name"].ToString();

                                // process the date
                                if (reader["DOB"] != DBNull.Value)
                                {
                                    txt_CusDOB.Text = Convert.ToDateTime(reader["DOB"]).ToShortDateString();
                                }
                                else
                                {
                                    txt_CusDOB.Text = "";
                                }

                                txt_CusGender.Text = reader["Gender"].ToString();
                                txt_CusRole.Text = reader["Role"].ToString();
                                txt_CusEmail.Text = reader["Email"].ToString();
                                txt_CusPassword.Text = reader["Password"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("User not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }

                    }           
            }
        }
                
    

