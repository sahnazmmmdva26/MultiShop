using Microsoft.AspNetCore.Mvc;

namespace MultiShopSite.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Detail()
        {
            return View();
        }
        public IActionResult Shop()
        {
            return View();
        }  
        public IActionResult Cart()
        {
            return View();
        }
        
    }
}
