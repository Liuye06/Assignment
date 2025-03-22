using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Assignment
{
    internal class User
    {
        public object ConfigurationManager { get; private set; }    }

    public string login(string un)
        {
            string status = null;

            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionString["myCS"].ToString());
            con.Open();

            SqlCommand cmd = new SqlCommand("select count(*) from User where username=@a and password = @b", con);
            cmd.Parameters.AddWithValue("@a", Username);
            cmd.Parameters.AddWithValue("@b", Password);

            int count = Convert.ToTnt32(cmd.ExecuteScalar());
            if (count > 0)
            {
                SqlCommand cmd2 = new SqlCommand("select count(*) from User where username=@a and password = @b", con);
                cmd2.Parameters.AddWithValue("@a", Username);
                cmd2.Parameters.AddWithValue("@b", Password);

                string userRole = cmd2.ExecuteScalar().ToString();

                if (userRole.Equals("admin", StringComparison.OrdinalIgnoreCase))
                {
                    Admin a = new Admin(un);
                    a.ShowDialog();
                }
                else if (userRole.Equals("customer", StringComparison.OrdinalIgnoreCase))
                {
                    C_Homepage s = new C_Homepage(un);
                    s.ShowDialog();
                }
            }
            else
                status = "Incorrect username/password";
            con.Close();

            return status;

}
    }
