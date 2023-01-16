using MultiShopSite.Models.BaseEntity;

namespace MultiShopSite.Models
{
    public class Size : BaseId
    {
        public string Name { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
