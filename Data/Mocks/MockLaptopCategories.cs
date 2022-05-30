using LaptopStore.Data.Interfaces;
using LaptopStore.Data.Models;
using System.Collections.Generic;

namespace LaptopStore.Data.Mocks
{
    public class MockLaptopCategories : ILaptopCategories
    {
        public IEnumerable<Category> AllCategories 
        {
            get
            {
                return new List<Category>
                {
                    new Category {categoryName = "Ultrathin", desc = "Ultrathin laptops"},
                    new Category {categoryName = "Transformer", desc = "Touch screen laptops, tablet/laptop hybrid"},
                    new Category {categoryName = "Office", desc = "Laptops for study and work"},
                    new Category {categoryName = "Gaming", desc = "Laptops with powerful GPUs and CPUs"}
                };
            }
        }
    }
}
