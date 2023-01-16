using MultiShopSite.Models.BaseEntity;

namespace MultiShopSite.Models
{
    public class Addvertising : BaseId
    {
        public string FirstTitle { get; set; }
        public string SecondTitle { get; set; }
        public string ImageUrl { get; set; }
    }
}
