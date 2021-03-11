using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Cognizant.Truyum.Model;

namespace Com.Cognizant.Truyum.Dao
{
    public class CartDaoSql : ICartDao
    {
        public void AddCartItem(long userId, long menuItemId)
        {
            using (var conn = new SqlConnection(Helper.ConnectionString))
            {
                string query = $"insert into carts values ({menuItemId}, {userId});";
                var cmd = new SqlCommand(query, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public Cart GetAllCartItems(long userId)
        {
            var menuItemDaoSql = new MenuItemDaoSql();
            var menuItemList = menuItemDaoSql.GetMenuItemListAdmin();
            var cart = new Cart();

            using (var conn = new SqlConnection(Helper.ConnectionString))
            {
                string query = $"select * from carts";
                var cmd = new SqlCommand(query, conn);
                conn.Open();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int itemId = (int)reader["item_id"];
                    cart.MenuItemList.Add(menuItemList[itemId - 1]);
                }
            }
            cart.Total = cart.MenuItemList.Sum(x => x.Price);

            return cart;
        }

        public void RemoveCartItem(long userId, long menuItemId)
        {
            using (var conn = new SqlConnection(Helper.ConnectionString))
            {
                string query = $"delete from carts where user_id = {userId} and item_id = {menuItemId};";
                var cmd = new SqlCommand(query, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
