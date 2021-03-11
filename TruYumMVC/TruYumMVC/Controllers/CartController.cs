using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TruYumMVC.Models;

namespace TruYumMVC.Controllers
{
    public class CartController : Controller
    {
        private TruYumContext _context;

        public CartController()
        {
            _context = new TruYumContext();
        }

        public ActionResult Index()
        {
            var cart = _context.Carts.Include(m => m.MenuItems).SingleOrDefault(c => c.UserId == 1);

            if (cart is null)
            {
                var newCart = new Cart()
                {
                    MenuItems = new List<MenuItem>(),
                    UserId = 1
                };
                _context.Carts.Add(newCart);
                _context.SaveChanges();

                cart = newCart;
            }

            if (cart.MenuItems.Count == 0) { return View("EmptyCart"); }

            return View(cart);
        }

        public ActionResult AddToCart(int id)
        {
            var cartInDb = _context.Carts.Include(m => m.MenuItems).SingleOrDefault(c => c.UserId == 1);
            var menuItem = _context.MenuItems.Find(id);

            if (menuItem is null) { return View("Error"); }

            cartInDb.MenuItems.Add(menuItem);
            _context.SaveChanges();

            return View("AddToCartSuccess");
        }

        public ActionResult Delete(int id)
        {
            var cartInDb = _context.Carts.Include(m => m.MenuItems).SingleOrDefault(c => c.UserId == 1);
            var menuItem = _context.MenuItems.Find(id);

            if (menuItem is null) { return View("Error"); }
            if (!cartInDb.MenuItems.Contains(menuItem)) { return View("Error"); }

            cartInDb.MenuItems.Remove(menuItem);
            _context.SaveChanges();

            return RedirectToAction("Index", "Cart");
        }
    }
}