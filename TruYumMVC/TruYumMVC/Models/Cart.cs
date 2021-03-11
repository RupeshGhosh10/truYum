using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TruYumMVC.Models
{
    public class Cart
    {
        public int Id { get; set; }

        public ICollection<MenuItem> MenuItems { get; set; }

        public int UserId { get; set; }
    }
}