using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;


namespace Assignment
{
    public class OrderManager
    {
        private static readonly string connectionString = ConfigurationManager.ConnectionStrings["MyDBConnection"].ConnectionString;

        public static DataTable GetOrders(int currentUserId)
        {
            DataTable ordersTable = new DataTable();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = @"
            SELECT 
                O.Order_ID AS OrderID, 
                M.Item AS FoodName, 
                O.Status AS OrderStatus, 
                COALESCE(U.Real_Name, 'Unassigned') AS ChefInCharge
            FROM [dbo].[Request] R
            JOIN [dbo].[Menu] M ON R.Item_ID = M.Item_Id
            JOIN [dbo].[Order] O ON R.Order_ID = O.Order_ID
            LEFT JOIN [dbo].[Chef_InCharge] CIC ON O.Order_ID = CIC.Order_ID
            LEFT JOIN [dbo].[User] U ON CIC.User_ID = U.User_ID;";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@CurrentUserId", currentUserId);

                        conn.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            ordersTable.Load(reader);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading orders: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return ordersTable;
        }



        // Update Order Status
        public static bool UpdateOrderStatus(int orderID, string newStatus, int chefID)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = @"
                        UPDATE [dbo].[Order] 
                        SET Status = @NewStatus 
                        WHERE Order_ID = @OrderID";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@NewStatus", newStatus);
                        cmd.Parameters.AddWithValue("@OrderID", orderID);

                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();

                        return rowsAffected > 0; // If rows are affected, return true
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating order status: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        

        public static bool UpdateChefInCharge(int orderID, int chefID)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = @"
                        IF EXISTS (SELECT 1 FROM [dbo].[Chef_InCharge] WHERE Order_ID = @OrderID)
                        BEGIN
                            UPDATE [dbo].[Chef_InCharge]
                            SET User_ID = @ChefID
                            WHERE Order_ID = @OrderID;
                        END
                        ELSE
                        BEGIN
                            INSERT INTO [dbo].[Chef_InCharge] (Order_ID, User_ID)
                            VALUES (@OrderID, @ChefID);
                        END";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@OrderID", orderID);
                        cmd.Parameters.AddWithValue("@ChefID", chefID);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating chef in charge: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }


        public static DataTable GetAvailableChefs()
        {
            DataTable chefsTable = new DataTable();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = @"
                        SELECT 
                            User_ID AS ChefID, 
                            Real_Name AS ChefName 
                        FROM [dbo].[User] 
                        WHERE Role = 'chef';";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        conn.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            chefsTable.Load(reader);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading chefs: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return chefsTable;
        }
    }
}
