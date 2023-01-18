using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MultiShopSite.DAL;
using MultiShopSite.Models;

namespace MultiShopSite.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {
        readonly AppDbContext _context;

        public ProductController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            IEnumerable<Product> products = _context.Products.Include(p => p.ProductColors).ThenInclude(pc=>pc.Color).Include(p => p.ProductSizes).ThenInclude(pc => pc.Size).Include(p => p.ProductImages).ToList();
            return View(products);
        }
        public IActionResult Create() 
        { 

            return View();
        }
        public IActionResult Delete() 
        { 
            return View();
        }
    }
}
