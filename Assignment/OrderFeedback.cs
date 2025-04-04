using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    public class OrderFeedback
    {
        private static readonly string connectionString = ConfigurationManager.ConnectionStrings["MyDBConnection"].ConnectionString;

        // Function to search order feedback
        public void SearchOrderFeedback(int userId, int orderId, ListView listView)
        {
            listView.Items.Clear(); // Clear previous results

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
                    SELECT r.Order_ID, r.Item_ID, 
                           m.Item AS Item_Name, 
                           ISNULL(f.Feedback, 'No feedback yet') AS Feedback 
                    FROM Request r
                    JOIN Menu m ON r.Item_ID = m.Item_Id 
                    JOIN [Order] o ON r.Order_ID = o.Order_ID
                    LEFT JOIN Feedback f ON r.Order_ID = f.Order_ID
                    WHERE r.Order_ID = @OrderId AND o.User_ID = @UserId";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@OrderId", orderId);
                    cmd.Parameters.AddWithValue("@UserId", userId);
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ListViewItem item = new ListViewItem(reader["Order_ID"].ToString());
                            item.SubItems.Add(reader["Item_Name"].ToString()); 
                            item.SubItems.Add(reader["Feedback"].ToString());

                            listView.Items.Add(item);
                        }
                    }
                }
            }
        }


        // Function to load orders into ListView
        public void LoadOrders(int userId, ListView listView)
        {
            listView.Items.Clear();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
                    SELECT r.Order_ID, r.Item_ID, 
                           m.Item AS Item_Name, 
                           ISNULL(f.Feedback, 'No feedback yet') AS Feedback 
                    FROM Request r
                    JOIN Menu m ON r.Item_ID = m.Item_Id
                    JOIN [Order] o ON r.Order_ID = o.Order_ID
                    LEFT JOIN Feedback f ON r.Order_ID = f.Order_ID
                    WHERE o.User_ID = @UserId";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@UserId", userId);
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ListViewItem item = new ListViewItem(reader["Order_ID"].ToString());
                            item.SubItems.Add(reader["Item_Name"].ToString()); // ✅ Show Item Name
                            item.SubItems.Add(reader["Feedback"].ToString());

                            listView.Items.Add(item);
                        }
                    }
                }
            }
        }

        // Function to submit feedback for a specific Order and Item
        public bool SubmitFeedback(int userId, int orderId, string feedbackText)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
                IF EXISTS (
                    SELECT 1 FROM Feedback f
                    JOIN [Order] o ON f.Order_ID = o.Order_ID
                    WHERE f.Order_ID = @OrderId AND o.User_ID = @UserId
                )
                    UPDATE Feedback SET Feedback = @Feedback WHERE Order_ID = @OrderId;
                ELSE IF EXISTS (
                    SELECT 1 FROM [Order] WHERE Order_ID = @OrderId AND User_ID = @UserId
                )
                    INSERT INTO Feedback (Order_ID, Feedback) VALUES (@OrderId, @Feedback);";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@OrderId", orderId);
                    cmd.Parameters.AddWithValue("@UserId", userId);
                    cmd.Parameters.AddWithValue("@Feedback", feedbackText);
                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }
    }
}

