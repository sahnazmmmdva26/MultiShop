﻿using Microsoft.EntityFrameworkCore;
using MultiShopSite.Models;

namespace MultiShopSite.DAL
{
    public class AppDbContext: DbContext 
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Addvertising> Addvertisings { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Discount> Discounts { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<ProductInformation> ProductInformations { get; set; }
        public DbSet<Setting> Settings { get; set; }
        public DbSet<Size> Sizes { get; set; }
        public DbSet<Slider> Sliders { get; set; }
    }
}
