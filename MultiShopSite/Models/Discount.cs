using MultiShopSite.Models.BaseEntity;

namespace MultiShopSite.Models
{
    public class Discount : BaseId
    {
        public string Name { get; set; }
        public double Amount { get; set; }
        
        public ICollection<Product> Products { get; set; }

    }
}
