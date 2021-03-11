using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Cognizant.Truyum.Model;

namespace Com.Cognizant.Truyum.Dao
{
    public class MenuItemDaoSqlTest
    {
        private MenuItemDaoSql menuItemDao = new MenuItemDaoSql();

        public void TestGetMenuItemListAdmin()
        {
            var menuListAdmin = menuItemDao.GetMenuItemListAdmin();
            foreach (var item in menuListAdmin) 
            { 
                Console.WriteLine(item); 
            }
        }

        public void TestGetMenuItemListCustomer()
        {
            var menuListCustomer = menuItemDao.GetMenuItemListCustomer();
            foreach (var item in menuListCustomer)
            {
                Console.WriteLine(item);
            }
        }

        public void TestGetMenuItem()
        {
            Console.WriteLine(menuItemDao.GetMenuItem(3));
        }

        public void TestModifyMenuItem()
        {
            var menuItem = new MenuItem(2, "Burger", 129.00f, true, new DateTime(2021, 01, 27), "Main Course", false);

            menuItemDao.ModifyMenuItem(menuItem);
            Console.WriteLine(menuItemDao.GetMenuItem(2));
        }
    }
}
