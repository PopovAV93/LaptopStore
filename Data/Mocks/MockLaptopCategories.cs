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
                    new Category {id = 1, categoryName = "Ультрабуки", desc = "Ультратонкие ноутбуки"},
                    new Category {id = 2, categoryName = "Трансформеры", desc = "Ноутбуки с сенсорным экраном, гибрид планшетного компьютера и ноутбука"},
                    new Category {id = 3, categoryName = "Офисные", desc = "Ноутбики для учебы и работы"},
                    new Category {id = 4, categoryName = "Игровые", desc = "Ноутбуки с производительными GPU и CPU"},
                };
            }
        }
    }
}
