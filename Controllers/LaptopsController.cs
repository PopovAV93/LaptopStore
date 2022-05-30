using LaptopStore.Data.Interfaces;
using LaptopStore.Data.Models;
using LaptopStore.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

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

        [Route("Laptops/List")]
        [Route("Laptops/List/{category}")]
        public ViewResult List(string category)
        {
            
            //string _category = category;
            IEnumerable<Laptop> laptops;
            string currCategory = category;

            if (string.IsNullOrEmpty(category))
            {
                laptops = _allLaptops.getLaptops.OrderBy(i => i.id);
            }
            else
            {
                laptops = _allLaptops.getLaptops.Where(x => x.Category.categoryName.ToLower().Equals(category.ToLower())).OrderBy(i => i.id);

                if (laptops.FirstOrDefault() == null)
                {
                    currCategory = null;
                    laptops = _allLaptops.getLaptops.OrderBy(i => i.id);
                }
                else
                {
                    currCategory = laptops.FirstOrDefault().Category.categoryName;
                }
            }

            var laptopObj = new LaptopListViewModel
            {
                allLaptops = laptops,
                currCategory = currCategory
            };


            //LaptopListViewModel obj = new LaptopListViewModel();
            //obj.allLaptops = _allLaptops.getLaptops;
            //obj.currCategory = "Laptops";

            ViewBag.Title = "Laptops";
            return View(laptopObj);
        }
        
    }
}
