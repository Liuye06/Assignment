using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        public void Insert(string item, string price, string category, byte[] image)
        {
            using(SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["Assignment.Properties.Settings.Assignment dbConnectionString"].ConnectionString))
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand("insert into Menu(Item, Price, Category, Image) values (@item, @price, @category, @image)", cn);
                    cmd.Parameters.AddWithValue("@image", image);
                    cmd.Parameters.AddWithValue("@category", category);
                    cmd.Parameters.AddWithValue("@price", price);
                    cmd.Parameters.AddWithValue("@item", item);
                    cmd.ExecuteNonQuery();
                cn.Close();
                
            }
        }

        public void LoadData()
        {
            using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["Assignment.Properties.Settings.Assignment dBConnectionString"].ConnectionString))
            {
                if (cn.State == ConnectionState.Closed)
                    cn.Open();
                using(DataTable dt = new DataTable("Menu"))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter("select *from Menu", cn);
                    adapter.Fill(dt);
                    dataGridView.DataSource = dt;
                }
                cn.Close();

            }
        }

        byte[] ConvertImageToBytes(Image img)
        {
            using(MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                byte[] imageBytes = ConvertImageToBytes(pictureBox1.Image);
                DisplayImageBytesInTextBox(imageBytes);
                return ms.ToArray();
            }
        }

        public Image ConvertBytetoArrayToImage(byte[] data)
        {
            using (MemoryStream ms = new MemoryStream(data))
            {
                return Image.FromStream(ms);
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Image files (*.jpg;*.jpeg)|*.jpg;*.jpeg", Multiselect = false })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = Image.FromFile(ofd.FileName);
                    textBox2.Text = ofd.FileName;
                    textBox1.Text = ofd.FileName;
                    textBox3.Text = ofd.FileName;
                    Insert(textBox1.Text, textBox2.Text, textBox3.Text,  ConvertImageToBytes(pictureBox1.Image));
                    LoadData();
                }
            }
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable dt = dataGridView.DataSource as DataTable;
            if (dt != null)
            {
                DataRow row = dt.Rows[e.RowIndex];
                pictureBox1.Image = ConvertBytetoArrayToImage((byte[])row["Image"]);
            }
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DisplayImageBytesInTextBox(byte[] imageBytes)
        {
            string base64String = Convert.ToBase64String(imageBytes); // Convert bytes to Base64
            textBox1.Text = base64String; // Display in TextBox
        }
    }
}
