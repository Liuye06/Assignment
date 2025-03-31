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
    public partial class salesReport : Form
    {
        public salesReport()
        {
            InitializeComponent();
        }
        private void salesReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet9.Payment' table. You can move, or remove it, as needed.
            this.paymentTableAdapter2.Fill(this.database1DataSet9.Payment);
            // get Menu Item data
            comboBox2.DataSource = AdminClass.GetMenuItems();

            // get the month data
            comboBox1.DataSource = AdminClass.GetPaymentMonths();

            // initialize Payment data
            dataGridView1.DataSource = AdminClass.GetInitialPayments();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null || comboBox2.SelectedItem == null)
            {
                MessageBox.Show("Please select both a Menu Item and a Month.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedItem = comboBox2.SelectedItem.ToString();
            string selectedMonth = comboBox1.SelectedItem.ToString();

            dataGridView1.DataSource = AdminClass.SearchPayments(selectedItem, selectedMonth);
        }
    }
}
