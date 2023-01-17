using MultiShopSite.Models.BaseEntity;

namespace MultiShopSite.Models
{
    public class ProductInformation: BaseId
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public ICollection<Product> Products { get; set;}
    }
}
