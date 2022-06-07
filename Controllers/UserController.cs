using System.Threading.Tasks;
using LaptopStore.Data.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace LaptopStore.Controllers
{
    public class UserController : Controller
    {
        private readonly IUsers _users;

        public UserController(IUsers users)
        {
            _users = users;
        }
        
        public async Task<IActionResult> GetUsers()
        {
            var response = await _users.GetUsers();
            if (response.StatusCode == Data.Enum.StatusCode.OK)
            {
                return View(response.Data);
            }
            return RedirectToAction("Index", "Home");
        }
    }
}