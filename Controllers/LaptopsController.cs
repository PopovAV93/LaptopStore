﻿using LaptopStore.Data.Interfaces;
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
            
            IEnumerable<Laptop> laptops = GetLaptopsByCategory(category);
            string currCategory = GetCategory(laptops);

            var laptopObj = new LaptopListViewModel
            {
                allLaptops = laptops ?? _allLaptops.getLaptops.OrderBy(i => i.id),
                currCategory = currCategory
            };

            ViewBag.Title = "Laptops";
            return View(laptopObj);
        }

        [Route("Laptops/LaptopDetails")]
        public ViewResult LaptopDetails(long id)
        {

            Laptop laptop = _allLaptops.getObjectLaptop(id);

            ViewBag.Title = "Details";
            return View(laptop);
        }

        private IEnumerable<Laptop> GetLaptopsByCategory(string category)
        {
            IEnumerable<Laptop> laptops = null;
            if (!string.IsNullOrEmpty(category))
            {
                laptops = _allLaptops.getLaptops.Where(x => x.Category.categoryName.ToLower().Equals(category.ToLower())).OrderBy(i => i.id);
                if (laptops.FirstOrDefault() == null)
                {
                    laptops = null;
                }
            }
            
            return laptops;
        }

        private string GetCategory(IEnumerable<Laptop> laptops)
        {
            return laptops != null ? laptops.FirstOrDefault().Category.categoryName : null;
        }

    }
}
