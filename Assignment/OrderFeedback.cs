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
        public void SearchOrderFeedback(int orderId, ListView listView)
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
                    LEFT JOIN Feedback f ON r.Order_ID = f.Order_ID
                    WHERE r.Order_ID = @OrderId";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@OrderId", orderId);
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
        public void LoadOrders(ListView listView)
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
                    LEFT JOIN Feedback f ON r.Order_ID = f.Order_ID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
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
        public bool SubmitFeedback(int orderId, string feedbackText)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
                IF EXISTS (SELECT 1 FROM Feedback WHERE Order_ID = @OrderId)
                    UPDATE Feedback SET Feedback = @Feedback WHERE Order_ID = @OrderId;
                ELSE
                    INSERT INTO Feedback (Order_ID, Feedback) VALUES (@OrderId, @Feedback);";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@OrderId", orderId);
                    cmd.Parameters.AddWithValue("@Feedback", feedbackText);
                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }
    }
}

