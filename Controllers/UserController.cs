using System.Threading.Tasks;
using LaptopStore.Data.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace LaptopStore.Controllers
{
    public class UserController : Controller
    {
        private readonly IUsers _userService;

        public UserController(IUsers userService)
        {
            _userService = userService;
        }

        public async Task<IActionResult> GetUsers()
        {
            var response = await _userService.GetUsers();
            if (response.StatusCode == Data.Enum.StatusCode.OK)
            {
                return View(response.Data);
            }
            return RedirectToAction("Index", "Home");
        }
    }
}