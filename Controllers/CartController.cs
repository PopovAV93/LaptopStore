using LaptopStore.Data.Interfaces;
using LaptopStore.Data.Models;
using LaptopStore.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace LaptopStore.Controllers
{
    public class CartController : Controller
    {
        private readonly ILaptops _laptopRepository;
        private readonly Cart _cart;

        public CartController(ILaptops laptopRepository, Cart cart)
        {
            _laptopRepository = laptopRepository;
            _cart = cart;
        }

        public ViewResult Index()
        {
            var items = _cart.getCartItems();
            _cart.ListCartItems = items;
            _cart.itemsCount = items.Count();

            var obj = new CartViewModel
            {
                cart = _cart
            };

            return View(obj);
        }

        public RedirectToActionResult addToCart(long id)
        {
            var item = _laptopRepository.GetAll().Single(i => i.id == id);
            if(item != null)
            {
                _cart.addToCart(item);
            }

            return RedirectToAction("Index");
        }

        public RedirectToActionResult deleteFromCart(long id)
        {
            var item = _cart.getCartItems().Single(i => i.id == id);
            if (item != null)
            {
                _cart.deleteFromCart(item);
            }

            return RedirectToAction("Index");
        }

    }
}
