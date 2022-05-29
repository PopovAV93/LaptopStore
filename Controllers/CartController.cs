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

            var obj = new CartViewModel
            {
                cart = _cart
            };

            return View(obj);
        }

        public RedirectToActionResult addToCart(int id)
        {
            var item = _laptopRepository.getLaptops.FirstOrDefault(i => i.id == id);
            if(item != null)
            {
                _cart.addToCart(item);
            }

            return RedirectToAction("Index");
        }

    }
}
