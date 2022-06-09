﻿using LaptopStore.Data.Interfaces;
using LaptopStore.Data.Models;
using LaptopStore.ViewModels;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace LaptopStore.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrders orders;
        private readonly IUsers users;
        private readonly Cart cart;

        public OrderController(IOrders orders, IUsers users, Cart cart)
        {
            this.orders = orders;
            this.users = users;
            this.cart = cart;
        }

        public IActionResult Checkout()
        {
            var email = User.Identity?.Name;
            if (email != null)
            {
                return View();
            }
            return RedirectToAction("Login","Account");
        }

        [HttpPost]
        public async Task<IActionResult> Checkout(Order order)
        {
            cart.ListCartItems = cart.getCartItems();

            if(cart.ListCartItems.Count == 0)
            {
                ModelState.AddModelError("", "Your shopping cart must contain items");
            }

            if (ModelState.IsValid)
            {
                var email = User.Identity?.Name;
                if (email != null)
                {
                    Order newOrder = order;
                    
                    var user = await users.GetAll().FirstOrDefaultAsync(x => x.email == email);
                    newOrder.userId = user.id;

                    await orders.Create(newOrder);
                    return RedirectToAction("Complete");
                }
            }

            return View(order);
        }

        public IActionResult Complete()
        {
            ViewBag.Message = "Order successfully processed";
            return View();
        }

    }
}
