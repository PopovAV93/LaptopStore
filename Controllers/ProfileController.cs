using System.Threading.Tasks;
using LaptopStore.ViewModels;
using LaptopStore.Data.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace LaptopStore.Controllers
{
    public class ProfileController : Controller
    {
        private readonly IProfiles _profileService;

        public ProfileController(IProfiles profileService)
        {
            _profileService = profileService;
        }

        [HttpGet]
        public async Task<IActionResult> ProfileInfo()
        {
            var userName = User.Identity?.Name;
            var response = await _profileService.Get(userName);
            if (response.StatusCode == Data.Enum.StatusCode.OK)
            {
                return View(response.Data);
            }
            return View();
        }

        [HttpGet]
        public IActionResult Save() => PartialView();

        [HttpPost]
        public async Task<IActionResult> Save(ProfileViewModel model)
        {
            if (ModelState.IsValid)
            {
                if (model.Id == 0)
                {
                    await _profileService.Create(model);
                }
                else
                {
                    await _profileService.Edit(model.Id, model);
                }
                return RedirectToAction("ProfileInfo");   
            }
            return View();
        }
    }
}