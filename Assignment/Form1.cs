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
            // TODO: This line of code loads data into the 'assignmentdbDataSet2.Menu' table. You can move, or remove it, as needed.
            this.menuTableAdapter.Fill(this.assignmentdbDataSet2.Menu);
            LoadData();
        }

        public void Insert(byte[] image)
        {
            SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\source\repos\Liuye06\Assignment\Assignment\Assignmentdb.mdf;Integrated Security=True");
            {
                //if (cn.State == ConnectionState.Closed)
                    cn.Open();
                SqlCommand cmd = new SqlCommand("update Menu set Image = @image where Item_ID = @b", cn);
                
                    cmd.Parameters.AddWithValue("@image", image);
                    cmd.Parameters.AddWithValue("@b", textBox2.Text);

                    cmd.ExecuteNonQuery();
                
            }
        }

        public void LoadData()
        {
            SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\source\repos\Liuye06\Assignment\Assignment\Assignmentdb.mdf;Integrated Security=True");
            {
                if (cn.State == ConnectionState.Closed)
                    cn.Open();
                using(DataTable dt = new DataTable("Menu"))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter("select *from Menu", cn);
                    adapter.Fill(dt);
                    dataGridView.DataSource = dt;
                }

            }
        }

        byte[] ConvertImageToBytes(Image img)
        {
            using(MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
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
                    Insert(ConvertImageToBytes(pictureBox1.Image));
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
    }
}