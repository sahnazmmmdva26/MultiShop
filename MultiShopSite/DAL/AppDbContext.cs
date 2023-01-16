using Microsoft.EntityFrameworkCore;
using MultiShopSite.Models;

namespace MultiShopSite.DAL
{
    public class AppDbContext: DbContext 
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        //DbSet<Product> Products { get; set; }
        //DbSet<Addvertising> Addvertisings { get; set; }
        //DbSet<Category> Categories { get; set; }
        //DbSet<Color> Colors { get; set; }
        //DbSet<Discount> Discounts { get; set; }
        //DbSet<ProductCategory> ProductCategories { get; set; }
        //DbSet<ProductImage> ProductImages { get; set; }
        //DbSet<ProductInformation> ProductInformations { get; set; }
        //DbSet<Setting> Settings { get; set; }
        //DbSet<Size> Sizes { get; set; }
        //DbSet<Slider> Sliders { get; set; }
    }
}
