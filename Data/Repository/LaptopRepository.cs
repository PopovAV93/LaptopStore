using LaptopStore.Data.Interfaces;
using LaptopStore.Data.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace LaptopStore.Data.Repository
{
    public class LaptopRepository : ILaptops
    {
        private readonly AppDBContent appDBContent;
        public LaptopRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }

        public IEnumerable<Laptop> getLaptops => appDBContent.Laptop.Include(l => l.Category);

        public IEnumerable<Laptop> getFavLaptops => 
            appDBContent.Laptop.Where(p => p.isFavorite).Include(l => l.Category);

        public Laptop getObjectLaptop(int laptopId) => 
            appDBContent.Laptop.FirstOrDefault(p => p.id == laptopId);
    }
}
