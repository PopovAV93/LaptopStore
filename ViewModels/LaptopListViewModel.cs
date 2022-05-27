using LaptopStore.Data.Models;
using System.Collections.Generic;

namespace LaptopStore.ViewModels
{
    public class LaptopListViewModel
    {
        public IEnumerable<Laptop> allLaptops { get; set; }
        public string currCategory { get; set; }
    }
}
