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
    public partial class ManageMenu : Form
    {
        public ManageMenu()
        {
            InitializeComponent();
        }

        private void ManageMenu_Load(object sender, EventArgs e)
        {
            // Ensure the DataGridView has no duplicate columns
            if (dgvMenu.Columns["Action"] == null)
            {
                // Create an Action column
                DataGridViewButtonColumn actionColumn = new DataGridViewButtonColumn();
                actionColumn.Name = "Action";
                actionColumn.HeaderText = "Action";
                actionColumn.Text = "Edit | Delete"; // Display both actions
                actionColumn.UseColumnTextForButtonValue = true; // Show button text

                // Add the column to DataGridView
                dgvMenu.Columns.Add(actionColumn);
            }
        }
    }
}
