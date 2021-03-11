using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Cognizant.Truyum.Model;

namespace Com.Cognizant.Truyum.Dao
{
    public class CartDaoCollection : ICartDao
    {
        Dictionary<long, Cart> userCart;

        public CartDaoCollection()
        {
            if (userCart is null)
            {
                userCart = new Dictionary<long, Cart>();
            }
        }

        public void AddCartItem(long userId, long menuItemId)
        {
            var menuItemDao = new MenuItemDaoCollection();
            var menuItem = menuItemDao.GetMenuItem(menuItemId);

            if (userCart.ContainsKey(userId))
            {
                userCart[userId].MenuItemList.Add(menuItem);
            }
            else
            {
                var cart = new Cart();
                cart.MenuItemList.Add(menuItem);
                userCart[userId] = cart;
            }
        }

        public Cart GetAllCartItems(long userId)
        {
            var menuItemList = userCart[userId].MenuItemList;
            if (menuItemList.Count == 0)
            {
                Console.WriteLine("Empty Cart");
                return null;
            }
            userCart[userId].Total = menuItemList.Sum(x => x.Price);

            return userCart[userId];
        }

        public void RemoveCartItem(long userId, long menuItemId)
        {
            if (userCart.ContainsKey(userId))
            {
                var menuItemList = userCart[userId].MenuItemList;
                menuItemList.RemoveAll(x => x.Id == menuItemId);
            }
            else
            {
                Console.WriteLine("Id not Found");
            }
        }
    }
}
