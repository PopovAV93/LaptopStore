using LaptopStore.Data.Interfaces;
using LaptopStore.Data.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LaptopStore.Data.Repository
{
    public class CategoryRepository : ICategory
    {
        private readonly AppDBContent _db;
        public CategoryRepository(AppDBContent db)
        {
            this._db = db;
        }

        public async Task Create(Category entity)
        {
            await _db.Categories.AddAsync(entity);
            await _db.SaveChangesAsync();
        }

        public IQueryable<Category> GetAll() 
        {
            return _db.Categories;
        }

        public Task Delete(Category entity)
        {
            throw new System.NotImplementedException();
        }

        public Task<Category> Update(Category entity)
        {
            throw new System.NotImplementedException();
        }

        public Category GetCategoryByLaptop(Laptop laptop)
        {
            return _db.Categories.Where(l => l.id == laptop.categoryId).FirstOrDefault();
        }
    }
}
