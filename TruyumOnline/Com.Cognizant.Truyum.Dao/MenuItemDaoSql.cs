using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Cognizant.Truyum.Model;

namespace Com.Cognizant.Truyum.Dao
{
    public class MenuItemDaoSql : IMenuItemDao
    {
        public List<MenuItem> GetMenuItemListAdmin()
        {
            var menuItemList = new List<MenuItem>();

            using (var conn = new SqlConnection(Helper.ConnectionString))
            {
                var cmd = new SqlCommand("select * from menu_items", conn);
                conn.Open();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    var menuItem = new MenuItem();

                    menuItem.Id = (int)reader["item_id"];
                    menuItem.Name = (string)reader["item_name"];
                    menuItem.Price = (float)((decimal)reader["price"]);
                    menuItem.Active = (bool)reader["active"];
                    menuItem.DateOfLaunch = (DateTime)reader["date_of_launch"];
                    menuItem.Category = (string)reader["category"];
                    menuItem.FreeDelivery = (bool)reader["free_delivery"];

                    menuItemList.Add(menuItem);
                }
            }
            return menuItemList;
        }

        public List<MenuItem> GetMenuItemListCustomer()
        {
            var menuItemList = new List<MenuItem>();

            using (var conn = new SqlConnection(Helper.ConnectionString))
            {
                var cmd = new SqlCommand("select * from menu_items", conn);
                conn.Open();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if ((bool)reader["active"])
                    {
                        var menuItem = new MenuItem();

                        menuItem.Id = (int)reader["item_id"];
                        menuItem.Name = (string)reader["item_name"];
                        menuItem.Price = (float)((decimal)reader["price"]);
                        menuItem.Active = (bool)reader["active"];
                        menuItem.DateOfLaunch = (DateTime)reader["date_of_launch"];
                        menuItem.Category = (string)reader["category"];
                        menuItem.FreeDelivery = (bool)reader["free_delivery"];

                        menuItemList.Add(menuItem);
                    }
                }
            }
            return menuItemList;
        }

        public MenuItem GetMenuItem(long menuItemId)
        {
            using (var conn = new SqlConnection(Helper.ConnectionString))
            {
                var cmd = new SqlCommand($"select * from menu_items where item_id = {menuItemId}", conn);
                conn.Open();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    var menuItem = new MenuItem();

                    menuItem.Id = (int)reader["item_id"];
                    menuItem.Name = (string)reader["item_name"];
                    menuItem.Price = (float)((decimal)reader["price"]);
                    menuItem.Active = (bool)reader["active"];
                    menuItem.DateOfLaunch = (DateTime)reader["date_of_launch"];
                    menuItem.Category = (string)reader["category"];
                    menuItem.FreeDelivery = (bool)reader["free_delivery"];

                    return menuItem;
                }
            }
            Console.WriteLine("Item not Found");
            return null;
        }

        public void ModifyMenuItem(MenuItem menuItem)
        {
            using (var conn = new SqlConnection(Helper.ConnectionString))
            {
                string query = $"update menu_items set item_name = '{menuItem.Name}', price = {menuItem.Price}," +
                               $"active = {(menuItem.Active ? 1 : 0)}, " +
                               $"date_of_launch = '{menuItem.DateOfLaunch.ToString("yyyy-MM-dd")}', " +
                               $"category = '{menuItem.Category}', free_delivery = {(menuItem.Active ? 1 : 0)}" +
                               $"where item_id = {menuItem.Id}";
                
                var cmd = new SqlCommand(query, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
