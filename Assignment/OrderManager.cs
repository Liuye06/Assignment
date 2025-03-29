using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Assignment
{
    public class OrderManager
    {
        private static readonly string connectionString = ConfigurationManager.ConnectionStrings["MyDBConnection"].ConnectionString;


        // Load Orders into DataGridView
        public DataTable GetOrders()
        {
            DataTable ordersTable = new DataTable();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
                    SELECT 
                        M.Item AS FoodName, 
                        O.Status AS OrderStatus, 
                        U.Real_Name AS ChefInCharge
                    FROM [dbo].[Request] R
                    JOIN [dbo].[Menu] M ON R.Item_ID = M.Item_Id
                    JOIN [dbo].[Order] O ON R.Order_ID = O.Order_ID
                    LEFT JOIN [dbo].[Chef_InCharge] CIC ON O.Order_ID = CIC.Order_ID
                    LEFT JOIN [dbo].[User] U ON CIC.User_ID = U.User_ID
                    WHERE U.Role = 'Chef';";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        ordersTable.Load(reader);
                    }
                }
            }
            return ordersTable;
        }


        // Update Order Status
        public bool UpdateOrderStatus(int orderID, string newStatus, int chefID)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
                    UPDATE [dbo].[Order] 
                    SET Status = @NewStatus 
                    WHERE Order_ID = @OrderID
                    AND EXISTS (
                        SELECT 1 FROM [dbo].[Chef_InCharge] 
                        WHERE Order_ID = @OrderID AND User_ID = @ChefID
                    )";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@NewStatus", newStatus);
                    cmd.Parameters.AddWithValue("@OrderID", orderID);
                    cmd.Parameters.AddWithValue("@ChefID", chefID);

                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }
    }
}
