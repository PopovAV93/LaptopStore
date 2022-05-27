using LaptopStore.Data.Interfaces;
using LaptopStore.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace LaptopStore.Controllers
{
    public class LaptopsController : Controller
    {
        private readonly ILaptops _allLaptops;
        private readonly ILaptopCategories _allCategories;

        public LaptopsController(ILaptops allLaptops, ILaptopCategories allCategories)
        {
            _allLaptops = allLaptops;
            _allCategories = allCategories;
        }
        
        public ViewResult List()
        {

            //var laptops = _allLaptops.Laptops;
            //ViewBag.Title = "Goods List";
            LaptopListViewModel obj = new LaptopListViewModel();
            obj.allLaptops = _allLaptops.Laptops;
            obj.currCategory = "Laptops";
            return View(obj);
        }
        
    }
}
