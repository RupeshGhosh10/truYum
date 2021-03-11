using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Cognizant.Truyum.Dao;

namespace TruyumOnline
{
    class Program
    {   
        static void Main(string[] args)
        {
/*            Console.WriteLine("Menu List Admin:");
            var menuItemDaoTest = new MenuItemDaoCollectionTest();
            menuItemDaoTest.TestGetMenuItemListAdmin();

            Console.WriteLine("\nMenu List Customer");
            menuItemDaoTest.TestGetMenuItemListCustomer();

            Console.WriteLine("\nModify price of Burger");
            menuItemDaoTest.TestModifyMenuItem();*/

/*            Console.WriteLine("\nCart with Items: ");
            var cartDaoTest = new CartDaoCollectionTest();
            cartDaoTest.TestAddCartItem();

            Console.WriteLine("\nRemoved Burger from Cart");
            cartDaoTest.TestRemoveCartItem();*/

/*            Console.WriteLine("\nMenu List Admin from Sql: ");
            var menuItemDaoSqlTest = new MenuItemDaoSqlTest();
            menuItemDaoSqlTest.TestGetMenuItemListAdmin();

            Console.WriteLine("\nMenu List Customer from Sql: ");
            menuItemDaoSqlTest.TestGetMenuItemListCustomer();

            Console.WriteLine("\nData of id = 3 from sql");
            menuItemDaoSqlTest.TestGetMenuItem();

            Console.WriteLine("\nModify Test");
            menuItemDaoSqlTest.TestModifyMenuItem();*/

            Console.WriteLine("\nAdd Cart with items");
            var cartDaoSqlTest = new CartDaoSqlTest();
            cartDaoSqlTest.TestAddCartItem();

            Console.WriteLine("\nGet all cart items from sql");
            cartDaoSqlTest.TestGetAllCartItems();

            Console.WriteLine("\nDelete from sql");
            cartDaoSqlTest.TestRemoveCartItem();
        }
    }
}
