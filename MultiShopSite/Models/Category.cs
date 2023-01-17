using MultiShopSite.Models.BaseEntity;

namespace MultiShopSite.Models
{
    public class Category : BaseId
    {
        public string Name { get; set; }
        public string ImageUrl { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
