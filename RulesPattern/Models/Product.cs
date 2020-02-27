using RulesPattern.Models.Enums;

namespace RulesPattern.Models
{
    public class Product
    {
        public string Name { get; set; }
        public CoverType CoverType { get; set; }
        public bool Dental { get; set; }
        public ExtrasTier ExtrasTier { get; set; }
        public Hospital Hospital { get; set; }
        public bool Nsd { get; set; }
        public AgeRange AgeRange { get; set; }
    }
}
