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
    public class OrderDetails
    {
        private static readonly string connectionString = ConfigurationManager.ConnectionStrings["MyDBConnection"].ConnectionString;


        public int OrderID { get; set; }
        public string FoodName { get; set; }
        public string Status { get; set; }
        public decimal TotalPrice { get; set; }

        public OrderDetails(int orderId, string foodName, string status, decimal totalPrice)
        {
            OrderID = orderId;
            FoodName = foodName;
            Status = status;
            TotalPrice = totalPrice;
        }

        public override string ToString()
        {
            return $"Order ID: {OrderID} | {FoodName} | Status: {Status} | Total: RM {TotalPrice:F2}";
        }

        // 🔹 Static method to fetch order details from the database
        public static List<OrderDetails> GetOrderDetails(int userId, string connectionString)
        {
            List<OrderDetails> orderList = new List<OrderDetails>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"
                SELECT 
                    o.Order_ID,
                    m.Item AS FoodName,
                    o.Status,
                    SUM(r.Quantity * m.Price) AS TotalPrice
                FROM [dbo].[Order] o
                JOIN [dbo].[Request] r ON o.Order_ID = r.Order_ID
                JOIN [dbo].[Menu] m ON r.Item_ID = m.Item_ID
                WHERE o.User_ID = @UserID
                GROUP BY o.Order_ID, m.Item, o.Status;
            ";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@UserID", userId);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int orderId = reader.GetInt32(0);
                    string foodName = reader.GetString(1);
                    string status = reader.GetString(2);
                    decimal totalPrice = reader.GetDecimal(3);

                    orderList.Add(new OrderDetails(orderId, foodName, status, totalPrice));
                }
            }

            return orderList;
        }
    }
}
