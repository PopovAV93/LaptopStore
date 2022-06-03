using LaptopStore.Data.Interfaces;
using LaptopStore.Data.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LaptopStore.Data.Mocks
{
    public class MockLaptopCategories : IBaseRepository<Category>
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

        public Task Create(Category entity)
        {
            throw new System.NotImplementedException();
        }

        public Task Delete(Category entity)
        {
            throw new System.NotImplementedException();
        }

        public IQueryable<Category> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public Task<Category> Update(Category entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
