using LaptopStore.Data.Models;
using LaptopStore.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace LaptopStore.Controllers
{
    public class PrivacyController : Controller
    {
        
        public ViewResult Index()
        {
            var privacyPolicy = new PrivacyViewModel { privacy = "Use this page to detail your site's Privacy policy." };
            return View(privacyPolicy);
        }
    }
}
