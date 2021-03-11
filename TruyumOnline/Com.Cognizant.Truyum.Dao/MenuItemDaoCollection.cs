using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Cognizant.Truyum.Model;

namespace Com.Cognizant.Truyum.Dao
{
    public class MenuItemDaoCollection : IMenuItemDao
    {
        private List<MenuItem> menuItemList;

        public MenuItemDaoCollection()
        {
            if (menuItemList is null)
            {
                menuItemList = new List<MenuItem>();
                menuItemList.Add(new MenuItem(1, "Sandwich", 99.00f, true, new DateTime(2017, 3, 15), "Main Course", true));
                menuItemList.Add(new MenuItem(2, "Burger", 129.00f, true, new DateTime(2017, 12, 23), "Main Course", false));
                menuItemList.Add(new MenuItem(3, "Pizza", 149.00f, true, new DateTime(2018, 8, 21), "Main Course", false));
                menuItemList.Add(new MenuItem(4, "French Fries", 57.00f, false, new DateTime(2017, 7, 15), "Starters", true));
                menuItemList.Add(new MenuItem(5, "Chocolate Brownie", 32.00f, true, new DateTime(2020, 11, 2), "Dessert", true));
            }
        }

        public List<MenuItem> GetMenuItemListAdmin()
        {
            return menuItemList;
        }

        public List<MenuItem> GetMenuItemListCustomer()
        {
            var customerItemList = new List<MenuItem>();

            foreach (var item in menuItemList)
            {
                if (item.DateOfLaunch <= DateTime.Now && item.Active) 
                { 
                    customerItemList.Add(item); 
                }
            }
            return customerItemList;
        }

        public void ModifyMenuItem(MenuItem item)
        {
            menuItemList[menuItemList.FindIndex(x => x.Id == item.Id)] = item;
        }

        public MenuItem GetMenuItem(long menuItemId)
        {
            return menuItemList.Find(x => x.Id == menuItemId);
        }
    }
}
