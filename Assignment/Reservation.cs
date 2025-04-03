using System;
using System.Data;
using System.Windows.Forms;

namespace Assignment
{
    public partial class Reservation : Form
    {
        private SidebarManager _sidebarManager;
        private BindingSource bindingSource = new BindingSource();
        private int currentUserID; // Store the userID
        private ReservationManager reservationManager;

        public Reservation(int userID)
        {
            InitializeComponent();
            _sidebarManager = new SidebarManager(this);
            currentUserID = userID; // Store the userID
            UserSessionManager.Login(userID);
        }

        private void Reservation_Load(object sender, EventArgs e)
        {
            LoadReservationData();
            
        }

        private void LoadReservationData()
        {
            
            
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
           
        }

        private void btnSearchReservation_Click(object sender, EventArgs e)
        {
            string searchText = txtReservation.Text.Trim().Replace("'", "''");

            if (!string.IsNullOrEmpty(searchText))
            {
                bindingSource.Filter = $"Reservation_ID LIKE '%{searchText}%'";
            }
            else
            {
                bindingSource.RemoveFilter();
            }
        }
    }
}