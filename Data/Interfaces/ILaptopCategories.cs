using LaptopStore.Data.Models;
using System.Collections.Generic;

namespace LaptopStore.Data.Interfaces
{
    public interface ILaptopCategories
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
