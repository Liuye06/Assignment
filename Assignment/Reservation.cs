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

        public Reservation(int userID)
        {
            InitializeComponent();
            _sidebarManager = new SidebarManager(this);
            currentUserID = userID; // Store the userID
            UserSessionManager.Login(userID);
        }

        private void Reservation_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddNewHall form = new AddNewHall(currentUserID);

            if (form.ShowDialog() == DialogResult.OK) // Wait until form is closed
            {
               
            }
        }
    }
}