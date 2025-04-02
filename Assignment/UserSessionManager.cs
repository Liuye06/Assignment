using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    public static class UserSessionManager
    {
        // This will store the current logged-in user's ID (can be accessed globally)
        private static int currentUserID;

        // Static constructor to initialize session (if needed)
        static UserSessionManager()
        {
            currentUserID = 0; // Assume no user is logged in initially
        }

        // Method to log in the user
        public static void Login(int userID)
        {
            currentUserID = userID;
        }

        // Method to log out the current user
        public static void Logout(Form currentForm)
        {
            // Clear the current user session
            currentUserID = 0;

            // Optionally, clear authentication cookies or sessions if required
            // Example: HttpContext.Current.Session.Clear(); 

            // Show the login form again
            loginPage loginForm = new loginPage();
            loginForm.Show();

            // Close the current form (the one the user is logging out from)
            currentForm.Close();
        }

        // Static method to check if the user is logged in
        public static bool IsUserLoggedIn()
        {
            return currentUserID != 0; // Returns true if the user is logged in
        }

        // Static method to get the current user's ID (if logged in)
        public static int GetCurrentUserID()
        {
            return currentUserID;
        }
    }
}
