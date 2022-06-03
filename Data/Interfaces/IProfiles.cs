using System.Threading.Tasks;
using LaptopStore.Data.Models;
using LaptopStore.Data.Response;
using LaptopStore.ViewModels;

namespace LaptopStore.Data.Interfaces
{
    public interface IProfiles
    {
        Task<IBaseResponse<Profile>> Get(string userName);

        Task<IBaseResponse<Profile>> Create(ProfileViewModel model);
        
        Task<IBaseResponse<Laptop>> Edit(long id, ProfileViewModel model);
    }
}