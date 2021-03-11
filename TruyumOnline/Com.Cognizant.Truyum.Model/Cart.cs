using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Cognizant.Truyum.Model
{
    public class Cart
    {
        public List<MenuItem> MenuItemList { get; set; }
        public double Total { get ; set; }

        public Cart() 
        {
            MenuItemList = new List<MenuItem>();
            Total = 0;
        }

        public Cart(List<MenuItem> menuItemList, double total)
        {
            MenuItemList = menuItemList;
            Total = total;
        }

        public override string ToString()
        {
            string str = "";
            foreach (var item in MenuItemList)
            {
                str += item.ToString() + "\n";
            }
            str += $"Total: {Total}";

            return str;
        }
    }
}
