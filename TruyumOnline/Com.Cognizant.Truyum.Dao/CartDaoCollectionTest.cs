using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Cognizant.Truyum.Dao
{
    public class CartDaoCollectionTest
    {
        private CartDaoCollection cartDao = new CartDaoCollection();

        public void TestAddCartItem()
        {
            cartDao.AddCartItem(userId: 1, menuItemId: 2);
            cartDao.AddCartItem(userId: 1, menuItemId: 4);

            var cart = cartDao.GetAllCartItems(userId: 1);
            Console.WriteLine(cart);
        }

        public void TestRemoveCartItem()
        {
            cartDao.RemoveCartItem(userId: 1, menuItemId: 2);

            var cart = cartDao.GetAllCartItems(userId: 1);
            Console.WriteLine(cart);
        }
    }
}
