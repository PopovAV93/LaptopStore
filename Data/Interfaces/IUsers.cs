using System.Collections.Generic;
using System.Threading.Tasks;
using LaptopStore.Data.Response;
using LaptopStore.ViewModels;

namespace LaptopStore.Data.Interfaces
{
    public interface IUsers
    {
        Task<BaseResponse<IEnumerable<UserViewModel>>> GetUsers();
    }
}