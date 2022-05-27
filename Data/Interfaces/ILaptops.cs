using LaptopStore.Data.Models;
using System.Collections.Generic;

namespace LaptopStore.Data.Interfaces
{
    public interface ILaptops
    {
        IEnumerable<Laptop> Laptops { get;}
        IEnumerable<Laptop> FavCars { get; set; }
        Laptop getObjectLaptop(int laptopId);
    }
}
