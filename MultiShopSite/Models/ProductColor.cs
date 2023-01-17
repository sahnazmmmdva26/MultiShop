using MultiShopSite.Models.BaseEntity;

namespace MultiShopSite.Models
{
    public class ProductColor:BaseId
    {
        public int ProductId { get; set; }
        public int ColorId { get; set; }
        public Product Product { get; set; }
        public Color Color { get; set; }
    }
}
