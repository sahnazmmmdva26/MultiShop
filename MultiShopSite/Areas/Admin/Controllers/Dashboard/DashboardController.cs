using Microsoft.AspNetCore.Mvc;

namespace MultiShopSite.Areas.Admin.Controllers.Dashboard
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
