using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Cognizant.Truyum.Dao
{
    public class CartDaoSqlTest
    {
        private CartDaoSql cartDaoSql = new CartDaoSql();

        public void TestAddCartItem()
        {
            cartDaoSql.AddCartItem(userId: 1, menuItemId: 2);
            cartDaoSql.AddCartItem(userId: 1, menuItemId: 3);
            cartDaoSql.AddCartItem(userId: 1, menuItemId: 5);
        }

        public void TestGetAllCartItems()
        {
            var cart = cartDaoSql.GetAllCartItems(userId: 1);
            Console.WriteLine(cart);
        }

        public void TestRemoveCartItem()
        {
            cartDaoSql.RemoveCartItem(userId: 1, menuItemId: 2);
            var cart = cartDaoSql.GetAllCartItems(userId: 1);
            Console.WriteLine(cart);
        }
    }
}
