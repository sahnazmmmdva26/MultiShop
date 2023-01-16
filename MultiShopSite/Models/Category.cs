using MultiShopSite.Models.BaseEntity;

namespace MultiShopSite.Models
{
    public class Category : BaseId
    {
        public string Name { get; set; }
        public int Count { get; set; }
        public string ImageUrl { get; set; }
        public ICollection<ProductCategory> ProductCategories { get; set; }
    }
}
