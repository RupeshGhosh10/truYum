using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Cognizant.Truyum.Model
{
    public class MenuItem
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public bool Active { get; set; }
        public DateTime DateOfLaunch { get; set; }
        public string Category { get; set; }
        public bool FreeDelivery { get; set; }

        public MenuItem() { }

        public MenuItem(long id, string name, float price, bool active, DateTime dateOfLaunch, string category, bool freeDelivery)
        {
            Id = id;
            Name = name;
            Price = price;
            Active = active;
            DateOfLaunch = dateOfLaunch;
            Category = category;
            FreeDelivery = freeDelivery;
        }

        public bool Equals(MenuItem menuItem)
        {
            if (menuItem.Id == this.Id) { return true; }
            return false;
        }

        public override string ToString()
        {
            return $"Id:{Id}  Name:{Name}  Price:{Price}  Active:{Active}  DateOfLaunch:{DateOfLaunch.ToShortDateString()}  Category:{Category}  FreeDelivery:{FreeDelivery}";
        }
    }
}
