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
    public partial class MainManageMenu : Form
    {
        private MenuManager menuManager;
        private SidebarManager _sidebarManager;

        public MainManageMenu()
        {
            InitializeComponent();
            menuManager = new MenuManager();
            InitializeDataGridView();
            _sidebarManager = new SidebarManager(this);
        }

        private void InitializeDataGridView()
        {
            dgvMenu.Columns.Add("Name", "Name");
            dgvMenu.Columns.Add(new DataGridViewImageColumn() { Name = "Image", HeaderText = "Image", ImageLayout = DataGridViewImageCellLayout.Zoom });
            dgvMenu.Columns.Add("Price", "Price");
            dgvMenu.Columns.Add("Category", "Category");
            dgvMenu.Columns.Add("Action", "Action");

            UpdateDataGridView();
        }

        private void btnAddMenu_Click(object sender, EventArgs e)
        {
            AddNewMenuItem form = new AddNewMenuItem();

            if (form.ShowDialog() == DialogResult.OK) // Wait until form is closed
            {
                menuManager.AddMenuItem(form.NewMenuItem); // Add new item from form
                UpdateDataGridView();
            }
        }

        private void dgvMenu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UpdateDataGridView()
        {
            dgvMenu.Rows.Clear();
            foreach (var item in menuManager.GetMenuItems())
            {
                dgvMenu.Rows.Add(item.Name, item.Image, item.Price, item.Category, "Edit/Delete");
            }
        }

        private void btnMMenu_MMenu_Click(object sender, EventArgs e)
        {
            _sidebarManager.NavigateTo(new MainManageMenu());
        }

        private void btnMHall_MMenu_Click(object sender, EventArgs e)
        {
            _sidebarManager.NavigateTo(new MainManageHall());
        }

        private void btn_HRReport_MMenu_Click(object sender, EventArgs e)
        {
            _sidebarManager.NavigateTo(new MainHallResvReport());
        }

        private void btnUProfile_MMenu_Click(object sender, EventArgs e)
        {
            _sidebarManager.NavigateTo(new ManagerUpdateProfile());
        }
    }
}
