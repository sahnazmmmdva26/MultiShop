using MultiShopSite.Models.BaseEntity;

namespace MultiShopSite.Models
{
    public class Color : BaseId
    {
        public string Name { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
