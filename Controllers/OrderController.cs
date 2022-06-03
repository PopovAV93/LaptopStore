using LaptopStore.Data.Interfaces;
using LaptopStore.Data.Models;
using Microsoft.AspNetCore.Mvc;

namespace LaptopStore.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrders orders;
        private readonly Cart cart;

        public OrderController(IOrders orders, Cart cart)
        {
            this.orders = orders;
            this.cart = cart;
        }

        public IActionResult Checkout()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Checkout(Order order)
        {
            cart.ListCartItems = cart.getCartItems();

            if(cart.ListCartItems.Count == 0)
            {
                ModelState.AddModelError("", "Your shopping _cart must contain items");
            }

            if (ModelState.IsValid)
            {
                orders.Create(order);
                return RedirectToAction("Complete");
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
