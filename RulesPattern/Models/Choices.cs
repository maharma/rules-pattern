using RulesPattern.Models.Enums;

namespace RulesPattern.Models
{
    public class Choices
    {
        public CoverType CoverType { get; set; } = CoverType.Single;
        public bool Dental { get; set; } = false;
        public ExtrasTier ExtrasTier { get; set; } = ExtrasTier.Essential;
        public Hospital Hospital { get; set; } = Hospital.Public;
        public bool Nsd { get; set; } = false;
        public int Age { get; set; } = 125;
    }
}
