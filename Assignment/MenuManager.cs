using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class MenuManager
    {
        private List<MenuItem> menuItems;

        public MenuManager()
        {
            menuItems = new List<MenuItem>();
        }

        public void AddMenuItem(MenuItem item)
        {
            menuItems.Add(item);
        }

        public void RemoveMenuItem(int index)
        {
            if (index >= 0 && index < menuItems.Count)
            {
                menuItems.RemoveAt(index);
            }
        }

        public List<MenuItem> GetMenuItems()
        {
            return menuItems;
        }
    }
}
