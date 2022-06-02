using LaptopStore.Data.Models;
using System.Collections.Generic;

namespace LaptopStore.Data.Interfaces
{
    public interface ILaptops
    {
        IEnumerable<Laptop> getLaptops { get; }
        IEnumerable<Laptop> getFavLaptops { get; }
        Laptop getObjectLaptop(long laptopId);
    }
}
