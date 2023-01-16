using MultiShopSite.Models.BaseEntity;

namespace MultiShopSite.Models
{
    public class ProductImage : BaseId
    {
        public string ImageUrl { get; set; }
        public bool? IsCover { get; set; }
        public string Alt { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }
    }                                                 
}
