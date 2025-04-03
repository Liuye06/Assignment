using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    public class ViewCustomerReservationNPayment
    {
        private static readonly string connectionString = ConfigurationManager.ConnectionStrings["MyDBConnection"].ConnectionString;

        public void LoadDataWithPaymentStatus(ListView listView, int currentUserID)
        {
            string query = @"
                SELECT 
                    r.Reservation_ID, 
                    u.Real_Name, 
                    r.Hall_ID, 
                    h.Hall_Name, 
                    r.Status, 
                    rr.Head_Count,
                    h.Price_P_Day, 
                    rr.Start_Date,
                    rr.End_Date,
                    p.Status AS Payment_Status
                FROM 
                    Reservation r
                JOIN 
                    [User] u ON r.User_ID = u.User_ID
                LEFT JOIN 
                    Hall h ON r.Hall_ID = h.Hall_ID
                JOIN 
                    R_Request rr ON r.R_Req_ID = rr.R_Req_ID
                LEFT JOIN
                    Payment p ON r.Reservation_ID = p.Reservation_ID
                WHERE
                    r.User_ID = @UserID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@UserID", currentUserID); // Use currentUserID to filter
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                listView.Items.Clear();

                while (reader.Read())
                {
                    // Get reservation data
                    string reservationID = reader["Reservation_ID"].ToString();
                    string realName = reader["Real_Name"].ToString();
                    string hallID = reader["Hall_ID"].ToString();
                    string hallName = reader["Hall_Name"].ToString();
                    string status = reader["Status"].ToString();
                    string headCount = reader["Head_Count"].ToString();
                    string pricePerDay = reader["Price_P_Day"].ToString();

                    // Safe date handling: Parse the date values
                    DateTime startDate = Convert.ToDateTime(reader["Start_Date"]);
                    DateTime endDate = Convert.ToDateTime(reader["End_Date"]);

                    // Get payment status (if available)
                    string paymentStatus = reader["Payment_Status"] != DBNull.Value ? reader["Payment_Status"].ToString() : "Pending";

                    // Calculate total price
                    decimal pricePerDayDecimal = Convert.ToDecimal(pricePerDay);
                    TimeSpan duration = endDate - startDate;
                    decimal totalPrice = pricePerDayDecimal * duration.Days;

                    // Add items to ListView
                    ListViewItem item = new ListViewItem(reservationID);  // First column (Reservation ID)
                    item.SubItems.Add(realName);  // Second column (Real Name)
                    item.SubItems.Add(hallID);    // Third column (Hall ID)
                    item.SubItems.Add(hallName);  // Fourth column (Hall Name)
                    item.SubItems.Add(status);    // Fifth column (Status)
                    item.SubItems.Add(headCount); // Sixth column (Head Count)
                    item.SubItems.Add(pricePerDayDecimal.ToString("C"));  // Seventh column (Price Per Day)
                    item.SubItems.Add(totalPrice.ToString("C"));  // Eighth column (Total Price)
                    item.SubItems.Add(paymentStatus);  // Ninth column (Payment Status)
                    item.SubItems.Add(startDate.ToString("dd/MM/yyyy"));   // Tenth column (Start Date)
                    item.SubItems.Add(endDate.ToString("dd/MM/yyyy"));    // Eleventh column (End Date)

                    item.SubItems[9].Tag = startDate;  // Store Start Date DateTime in Tag
                    item.SubItems[10].Tag = endDate;  // Store End Date DateTime in Tag

                    listView.Items.Add(item);  // Add the item to the ListView
                }

                reader.Close();
            }
        }

        public void InsertPayment(DateTime paymentDate, decimal amount, int reservationId, string status, int? orderId = null, int? itemId = null)
        {
            string insertQuery = @"
                INSERT INTO [dbo].[Payment] 
                ([Payment_date], [Amount], [Order_ID], [Reservation_ID], [Status], [Item_ID])
                VALUES 
                (@PaymentDate, @Amount, @OrderId, @ReservationId, @Status, @ItemId)";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Start a transaction to ensure the payment insert is handled properly
                    using (SqlTransaction transaction = connection.BeginTransaction())
                    {
                        // Insert payment record
                        using (SqlCommand command = new SqlCommand(insertQuery, connection, transaction))
                        {
                            // Adding parameters with explicit types for better control
                            command.Parameters.Add("@PaymentDate", SqlDbType.DateTime).Value = paymentDate;
                            command.Parameters.Add("@Amount", SqlDbType.Decimal).Value = amount;
                            command.Parameters.Add("@OrderId", SqlDbType.Int).Value = (object)orderId ?? DBNull.Value;
                            command.Parameters.Add("@ReservationId", SqlDbType.Int).Value = reservationId;
                            command.Parameters.Add("@Status", SqlDbType.VarChar, 50).Value = status;
                            command.Parameters.Add("@ItemId", SqlDbType.Int).Value = (object)itemId ?? DBNull.Value;

                            command.ExecuteNonQuery();
                        }

                        // Commit the transaction
                        transaction.Commit();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error processing payment: " + ex.Message);
            }
        }
    }
}

