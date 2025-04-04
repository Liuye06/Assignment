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
    public partial class MainHallResvReport : Form
    {
        private SidebarManager _sidebarManager;
        private int currentUserID; // Store the userID
        private HallReservationManager reservationManager;
        private BindingSource bindingSourceReservations;

        public MainHallResvReport(int userID)
        {
            InitializeComponent();
            _sidebarManager = new SidebarManager(this);
            currentUserID = userID; // Store the userID
            reservationManager = new HallReservationManager(); // Initialize the reservationManager
            UserSessionManager.Login(userID);
            bindingSourceReservations = new BindingSource();
            LoadReservations();
        }



        private void LoadReservations()
        {
            List<Reservation> reservations = reservationManager.LoadReservations();

            if (reservations.Count == 0)
            {
                MessageBox.Show("No reservations found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                bindingSourceReservations.DataSource = reservations;
                dgvReport.DataSource = bindingSourceReservations;
            }

            LoadMonthFilter();
        }


        private void LoadMonthFilter()
        {
            cmbMonth .Items.Clear();
            cmbMonth.Items.Add("All"); // Default option

            var months = bindingSourceReservations
                .Cast<Reservation>()
                .Select(r => r.StartDate.ToString("MMMM"))
                .Distinct()
                .ToList();

            cmbMonth.Items.AddRange(months.ToArray());
            cmbMonth.SelectedIndex = 0;
        }


        private void ApplyFilters()
        {
            string selectedMonth = cmbMonth.SelectedItem?.ToString();
            string selectedFunctionType = cmbResvType.SelectedItem?.ToString();

            var filteredReservations = reservationManager.LoadReservations();

            if (!string.IsNullOrEmpty(selectedMonth) && selectedMonth != "All")
            {
                int monthNumber = DateTime.ParseExact(selectedMonth, "MMMM", null).Month;
                filteredReservations = filteredReservations
                    .Where(r => r.StartDate.Month == monthNumber)
                    .ToList();
            }

            if (!string.IsNullOrEmpty(selectedFunctionType) && selectedFunctionType != "All")
            {
                filteredReservations = filteredReservations
                    .Where(r => r.Function.Equals(selectedFunctionType, StringComparison.OrdinalIgnoreCase))
                    .ToList();
            }

            bindingSourceReservations.DataSource = filteredReservations;
            dgvReport.DataSource = bindingSourceReservations;
        }

        private void cmbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void cmbResvType_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void btnResetReport_Click(object sender, EventArgs e)
        {
            cmbMonth.SelectedIndex = 0; // Reset to "All"
            cmbResvType.SelectedIndex = 0; // Reset to "All"
            bindingSourceReservations.DataSource = reservationManager.LoadReservations();
            dgvReport.DataSource = bindingSourceReservations;
        }

        private void btnExport_Click_1(object sender, EventArgs e)
        {
            if (dgvReport.Rows.Count == 0)
            {
                MessageBox.Show("No data to export.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV Files (*.csv)|*.csv";
            saveFileDialog.FileName = "Reservations.csv";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                StringBuilder csvContent = new StringBuilder();

                // Add column headers
                foreach (DataGridViewColumn column in dgvReport.Columns)
                {
                    csvContent.Append(column.HeaderText + ",");
                }
                csvContent.AppendLine();

                // Add rows
                foreach (DataGridViewRow row in dgvReport.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        csvContent.Append(cell.Value + ",");
                    }
                    csvContent.AppendLine();
                }

                // Write to file
                System.IO.File.WriteAllText(saveFileDialog.FileName, csvContent.ToString());
                MessageBox.Show("Data exported successfully!", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void btnMMenu_HRReport_Click(object sender, EventArgs e)
        {
            _sidebarManager.NavigateTo(new MainManageMenu(currentUserID));
        }

        private void btnMHall_HRReport_Click(object sender, EventArgs e)
        {
            _sidebarManager.NavigateTo(new MainManageHall(currentUserID));
        }

        private void btnHRReport_HRReport_Click(object sender, EventArgs e)
        {
            _sidebarManager.NavigateTo(new MainHallResvReport(currentUserID));
        }

        private void btnUProfile_HRReport_Click(object sender, EventArgs e)
        {
            _sidebarManager.NavigateTo(new ManagerProfile(currentUserID));
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            UserSessionManager.Logout(this);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
