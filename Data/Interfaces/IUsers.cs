using System.Collections.Generic;
using System.Threading.Tasks;
using LaptopStore.Data.Models;
using LaptopStore.Data.Response;
using LaptopStore.ViewModels;

namespace LaptopStore.Data.Interfaces
{
    public interface IUsers : IBaseRepository<User>
    {
        public Task Delete(long id);
    }
}