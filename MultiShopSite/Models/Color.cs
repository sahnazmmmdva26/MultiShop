using MultiShopSite.Models.BaseEntity;

namespace MultiShopSite.Models
{
    public class Color : BaseId
    {
        public string Name { get; set; }
        public ICollection<ProductColor> ProductColors { get; set; }
    }
}
