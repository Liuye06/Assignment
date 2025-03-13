using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public class MenuItem
    {
        public string Name { get; set; }
        public Image Image { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }

        // Constructor
        public MenuItem(string name, Image image, decimal price, string category)
        {
            Name = name;
            Image = image;
            Price = price;
            Category = category;
        }
    }
}
