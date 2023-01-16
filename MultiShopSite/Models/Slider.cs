using MultiShopSite.Models.BaseEntity;

namespace MultiShopSite.Models
{
    public class Slider:BaseId
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int Order { get; set; }

        public string ImageUrl { get; set; }
    }
}
