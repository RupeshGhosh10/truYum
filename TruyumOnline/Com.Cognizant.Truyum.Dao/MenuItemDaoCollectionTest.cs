using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Cognizant.Truyum.Model;

namespace Com.Cognizant.Truyum.Dao
{
    public class MenuItemDaoCollectionTest
    {
        private MenuItemDaoCollection menuItemDao = new MenuItemDaoCollection();

        public void TestGetMenuItemListAdmin()
        {
            var menuItemList = menuItemDao.GetMenuItemListAdmin();

            foreach (var item in menuItemList)
            {
                Console.WriteLine(item);
            }
        }

        public void TestGetMenuItemListCustomer()
        {
            var menuItemList = menuItemDao.GetMenuItemListCustomer();

            foreach (var item in menuItemList)
            {
                Console.WriteLine(item);
            }
        }

        public void TestModifyMenuItem()
        {
            var menuItem = new MenuItem(2, "Burger", 150.00f, true, new DateTime(2021, 01, 27), "Main Course", false);

            menuItemDao.ModifyMenuItem(item: menuItem);
            Console.WriteLine(menuItemDao.GetMenuItem(menuItemId: 2));
        }
    }
}
