using LaptopStore.Data.Interfaces;
using LaptopStore.Data.Models;
using System.Collections.Generic;

namespace LaptopStore.Data.Repository
{
    public class CategoryRepository : ILaptopCategories
    {
        private readonly AppDBContent appDBContent;
        public CategoryRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }
        public IEnumerable<Category> AllCategories => appDBContent.Category;
    }
}
