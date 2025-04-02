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


        // Load Orders into DataGridView
        public static DataTable GetOrders()
        {
            DataTable ordersTable = new DataTable();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = @"
                SELECT 
                    O.Order_ID As OrderID, 
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

                        if (rowsAffected > 0)
                        {
                            // Automatically assign chef if none is assigned yet
                            return UpdateChefInCharge(orderID, chefID);
                        }
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating order status: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static List<ChefDetails> GetAvailableChefs()
        {
            List<ChefDetails> chefs = new List<ChefDetails>();

            string query = "SELECT User_ID, Real_Name FROM [User] WHERE Role = 'Chef'";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                chefs.Add(new ChefDetails
                                {
                                    ChefID = Convert.ToInt32(reader["User_ID"]),
                                    ChefName = reader["Real_Name"].ToString()
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching chefs: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return chefs;
        }

        public static bool UpdateChefInCharge(int foodID, int chefID)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = @"
                MERGE INTO [dbo].[Chef_InCharge] AS target
                USING (
                    SELECT O.Order_ID
                    FROM [dbo].[Request] R
                    JOIN [dbo].[Order] O ON R.Order_ID = O.Order_ID
                    WHERE R.Item_ID = @FoodID
                ) AS source
                ON target.Order_ID = source.Order_ID
                WHEN MATCHED THEN 
                    UPDATE SET User_ID = @ChefID
                WHEN NOT MATCHED THEN
                    INSERT (Order_ID, User_ID) VALUES (source.Order_ID, @ChefID);";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@FoodID", foodID);
                        cmd.Parameters.AddWithValue("@ChefID", chefID);

                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating Chef In Charge: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
