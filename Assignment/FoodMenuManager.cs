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

        // Class representing a food item
        public class FoodItem
        {
            public int ItemId { get; set; }
            public string Name { get; set; }
            public decimal Price { get; set; }
            public string Category { get; set; }
            public Image FoodImage { get; set; }  // Stores image from VARBINARY
        }

        // Fetch food menu from the database
        public List<FoodItem> GetFoodItems()
        {
            List<FoodItem> foodItems = new List<FoodItem>();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "SELECT Item_Id, Item, Price, Category, Image FROM Menu";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            byte[] imageData = reader["Image"] as byte[];

                            foodItems.Add(new FoodItem
                            {
                                ItemId = Convert.ToInt32(reader["Item_Id"]),
                                Name = reader["Item"].ToString(),
                                Price = Convert.ToDecimal(reader["Price"]),
                                Category = reader["Category"].ToString(),
                                FoodImage = (imageData != null && imageData.Length > 0)
                                ? ImageManager.ByteArrayToImage(imageData)
                                : Properties.Resources.default_image // Default image from resources
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading menu: " + ex.Message);
            }

            return foodItems;
        }
    }
}


