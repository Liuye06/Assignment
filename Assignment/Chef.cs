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
    public partial class Chef: Form
    {
        private SidebarManager _sidebarManager;
        private BindingSource bindingSource = new BindingSource();

        public Chef()
        {
            InitializeComponent();
            _sidebarManager = new SidebarManager(this);
        }


        private void Chef_Load(object sender, EventArgs e)
        {
            LoadChefData();
        }


        private void LoadChefData()
        {
            DataTable dt = HallManager.LoadHallData();
            if (dt != null)
            {
                bindingSource.DataSource = dt;
                dgvIngredient.AutoGenerateColumns = false;
                dgvIngredient.DataSource = bindingSource;
            }
        }


        private void dgvIngredient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0) // Ensure valid cell
            {
                string columnName = dgvIngredient.Columns[e.ColumnIndex].Name; // Get clicked column name

                if (columnName == "ColIngredientEdit")
                {
                    // 📝 Edit Button Clicked
                    string ingredient = dgvIngredient.Rows[e.RowIndex].Cells["ColIngredientName"].Value.ToString();
                    EditChefName(ingredient);
                }
                else if (columnName == "ColIngredientDelete")
                {
                    // ❌ Delete Button Clicked
                    string ingredient = dgvIngredient.Rows[e.RowIndex].Cells["ColIngredientName"].Value.ToString();
                    DeleteHallName(ingredient);
                }
            }
        }

        private void EditChefName(string ingredient)
        {
            // Ensure the SidebarManager is passed
            SidebarManager sidebarManager = new SidebarManager(this);
            EditHallData editForm = new EditHallData(hallName, sidebarManager);

            if (editForm.ShowDialog() == DialogResult.OK)
            {
                LoadHallData(); // Refresh menu items after editing
            }
        }

        private void btnAddNewIngredient_Click(object sender, EventArgs e)
        {
            AddNewHall form = new AddNewHall();

            if (form.ShowDialog() == DialogResult.OK) // Wait until form is closed
            {
                LoadChefData();
            }
        }

    }
}
