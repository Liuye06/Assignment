using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;


namespace Assignment
{
    public class ListItem
    {
        public string Text { get; set; }
        public string Value { get; set; }

        public ListItem(string text, string value)
        {
            Text = text;
            Value = value;
        }
        public override string ToString()
        {
            return Text;
        }
    }

    public partial class EditCus : Form
    {
        private DataGridView dataGridView;
        private string selectedUserId = "";
        public EditCus(DataGridView dgv)
        {
            InitializeComponent();
            this.dataGridView = dgv ?? throw new ArgumentNullException(nameof(dgv), "DataGridView cannot be null.");
        }
   
        private void EditCus_Load(object sender, EventArgs e)
        {
            AdminClass.LoadCustomers(listBox1); 
        }
        private void listBoxUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem is ListItem selectedItem)
            {
                selectedUserId = selectedItem.Value;
            }
        }
        private void btn_EditCus_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedUserId) || comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Please select a user and a field to edit.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string selectedField = comboBox1.SelectedItem.ToString();
            string newValue = txt_EditCus.Text.Trim();

            if (string.IsNullOrWhiteSpace(newValue))
            {
                MessageBox.Show("Please enter a valid value.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Dictionary<string, string> fieldMapping = new Dictionary<string, string>
        {
            { "Real Name", "Real_Name" },
            { "Date of Birth", "DOB" },
            { "Email", "Email" },
            { "Username", "Username" },
            { "Gender", "Gender" }
        };

            if (!fieldMapping.ContainsKey(selectedField))
            {
                MessageBox.Show("Invalid field selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string databaseField = fieldMapping[selectedField];

            bool success = AdminClass.EditUser(selectedUserId, databaseField, newValue, dataGridView);
            if (success)
            {
                MessageBox.Show("User Updated Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AdminClass.LoadCustomers(listBox1); // Use AdminClass method
            }
            else
            {
                MessageBox.Show("Update Failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_EditCus.Clear();
            if (comboBox1.SelectedItem?.ToString() == "Date of Birth")
            {
                txt_EditCus.Text = "DD/MM/YYYY"; // Placeholder
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            listBox1.ClearSelected();
            comboBox1.SelectedIndex = -1;
            txt_EditCus.Clear();
            selectedUserId = "";
        }
        public static void LoadCustomers(ListBox listBox)
        {
            listBox.Items.Clear();

            DataTable dt = GetCustomerData(); // get custmoer data

            foreach (DataRow row in dt.Rows)
            {
                string displayText = $"{row["User_ID"]} - {row["Real_Name"]}";
                listBox.Items.Add(new ListItem(displayText, row["User_ID"].ToString()));
            }
        }
        public static DataTable GetCustomerData()
        {
            DataTable dt = new DataTable();
            string query = "SELECT User_ID, Real_Name FROM [User]";

            using (SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Catherine Ling\\OneDrive\\Documents\\C#\\Assignment\\Assignment\\Database1.mdf\";Integrated Security=True"))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                }
            }
            return dt;
        }

    }

}
public class ListItem
{
    public string Text { get; set; }
    public string Value { get; set; }

    public ListItem(string text, string value)
    {
        Text = text;
        Value = value;
    }

    public override string ToString()
    {
        return Text;
    }
}
