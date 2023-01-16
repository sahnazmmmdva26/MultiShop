using MultiShopSite.Models.BaseEntity;

namespace MultiShopSite.Models
{
    public class Product : BaseId
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double SellPrice { get; set; }
        public double CostPrice { get; set; }
        public int DisCountId { get; set; }
        public Discount? Discount { get; set; }

        public ICollection<ProductImage> ProductImages { get; set; }
        public ICollection<Size>? Sizes { get; set; }
        public ICollection<Color>? Colors { get; set; }
        public ICollection<ProductCategory> ProductCategories { get; set; }

        public ProductInformation? ProductInformation { get; set; }

    }
}
