using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TruYumMVC.Models.ViewModel
{
    public class MenuItemViewModel
    {
        public MenuItem MenuItem { get; set; }
        public IEnumerable<Category> Categories { get; set; }
    }
}