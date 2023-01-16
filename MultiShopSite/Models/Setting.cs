using MultiShopSite.Models.BaseEntity;

namespace MultiShopSite.Models
{
    public class Setting : BaseId
    {
        public string Key { get; set; }
        public string Value { get; set; }
    }
}
