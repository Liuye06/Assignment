using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Assignment
{
    public class ViewCustomerOrderManager
    {
        private static readonly string connectionString = ConfigurationManager.ConnectionStrings["MyDBConnection"].ConnectionString;


        public static DataTable GetUserOrders(int userId)
        {
            DataTable ordersTable = new DataTable();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
            SELECT 
                O.Order_ID,
                O.Order_Date,
                O.Status,
                O.Total_Amount AS TotalPrice,
                STRING_AGG(M.Item, ', ') AS FoodItems
            FROM [dbo].[Order] O
            JOIN [dbo].[Request] R ON O.Order_ID = R.Order_ID
            JOIN [dbo].[Menu] M ON R.Item_ID = M.Item_Id
            WHERE O.User_ID = @UserID
            GROUP BY O.Order_ID, O.Order_Date, O.Status, O.Total_Amount
            ORDER BY O.Order_Date DESC";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@UserID", userId);
                    conn.Open();
                    ordersTable.Load(cmd.ExecuteReader());
                }
            }
            return ordersTable;
        }
    }
}
