using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TruYumMVC.Models
{
    public class TruYumContext : DbContext
    {
        public TruYumContext()
            :base("name=connectionString")
        {
        }

        public DbSet<MenuItem> MenuItems { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Cart> Carts { get; set; }
    }
}