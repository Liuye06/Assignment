using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows.Forms;
using System.Drawing;

namespace Assignment
{
    public class FoodMenuManager
    {
        private static readonly string connectionString = ConfigurationManager.ConnectionStrings["MyDBConnection"].ConnectionString;


        //  List to store selected orders
        public static List<OrderItem> orderList = new List<OrderItem>();

        //  OrderItem Class (Nested Inside FoodMenuManager)
        public class OrderItem
        {
            public int ItemId { get; set; }
            public string ItemName { get; set; }
            public decimal Price { get; set; }
            public int Quantity { get; set; }
            public decimal TotalPrice => Price * Quantity;
        }

        //  Method to Add Order
        public static void AddOrderToList(List<OrderItem> cartList, int itemId, string itemName, decimal price, int quantity)
        {
            if (quantity > 0)
            {
                var existingItem = cartList.FirstOrDefault(item => item.ItemId == itemId);
                if (existingItem != null)
                {
                    existingItem.Quantity += quantity; // Increase quantity if item exists
                }
                else
                {
                    cartList.Add(new OrderItem
                    {
                        ItemId = itemId,
                        ItemName = itemName,
                        Price = price,
                        Quantity = quantity
                    });
                }

                MessageBox.Show($"{quantity}x {itemName} added to cart!", "Order Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please select at least 1 quantity!", "Invalid Quantity", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        public static DataTable GetFoodMenuFromDB(string category = null)
        {

            DataTable foodTable = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "SELECT Item_Id, Item, Price, Category, Image FROM Menu";

                    if (!string.IsNullOrEmpty(category) && category != "All")
                        query += " WHERE Category = @Category";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        if (!string.IsNullOrEmpty(category) && category != "All")
                            cmd.Parameters.AddWithValue("@Category", category);

                        conn.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            foodTable.Load(reader);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading menu: " + ex.Message);
            }
            return foodTable;
        }


        // Get unique categories from the database
        public static List<string> GetCategories()
        {
            List<string> categories = new List<string>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT DISTINCT Category FROM Menu";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                        categories.Add(reader["Category"].ToString());
                }
            }
            return categories;
        }


        public static void PlaceOrder(int userId, List<OrderItem> cartList)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    // Insert new order
                    string orderQuery = "INSERT INTO [dbo].[Order] (User_ID, Status) OUTPUT INSERTED.Order_ID VALUES (@UserID, 'Pending')";
                    SqlCommand orderCmd = new SqlCommand(orderQuery, conn, transaction);
                    orderCmd.Parameters.AddWithValue("@UserID", userId);
                    int orderId = (int)orderCmd.ExecuteScalar();

                    decimal totalAmount = 0;

                    // Insert cart items into Request table
                    string requestQuery = "INSERT INTO [dbo].[Request] (User_ID, Item_ID, Order_ID, DateTime, Quantity) VALUES (@UserID, @ItemID, @OrderID, GETDATE(), @Quantity)";
                    foreach (var item in cartList)
                    {
                        SqlCommand requestCmd = new SqlCommand(requestQuery, conn, transaction);
                        requestCmd.Parameters.AddWithValue("@UserID", userId); // Add User_ID here
                        requestCmd.Parameters.AddWithValue("@ItemID", item.ItemId);
                        requestCmd.Parameters.AddWithValue("@OrderID", orderId);
                        requestCmd.Parameters.AddWithValue("@Quantity", item.Quantity);
                        requestCmd.ExecuteNonQuery();

                        // Calculate total amount
                        totalAmount += item.TotalPrice;
                    }

                    // Insert payment record
                    string paymentQuery = "INSERT INTO [dbo].[Payment] (Payment_date, Amount, Order_ID, Status) VALUES (GETDATE(), @Amount, @OrderID, 'Done')";
                    SqlCommand paymentCmd = new SqlCommand(paymentQuery, conn, transaction);
                    paymentCmd.Parameters.AddWithValue("@Amount", totalAmount);
                    paymentCmd.Parameters.AddWithValue("@OrderID", orderId);
                    paymentCmd.ExecuteNonQuery();

                    transaction.Commit();
                    cartList.Clear(); // Empty cart after placing order

                    MessageBox.Show("Order and payment recorded successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Error placing order: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}


