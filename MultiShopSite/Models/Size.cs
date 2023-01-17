using MultiShopSite.Models.BaseEntity;

namespace MultiShopSite.Models
{
    public class Size : BaseId
    {
        public string Name { get; set; }
        public ICollection<ProductSize> ProductSizes { get; set; }
    }
}
