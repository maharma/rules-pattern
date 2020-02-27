using RulesPattern.Models;
using RulesPattern.Models.Enums;
using System.Collections.Generic;

namespace RulesPattern.Tests
{
    public class MockData
    {
        public static IEnumerable<Product> Products = new List<Product>
        {
            new Product()
            {
                Name = "Basic Single",
                AgeRange = new AgeRange {Min = 18, Max = 45},
                CoverType = CoverType.Single,
                Dental = false,
                ExtrasTier = ExtrasTier.Essential,
                Hospital = Hospital.Public,
                Nsd = false,
            },
            new Product()
            {
                Name = "Intermediate Single",
                AgeRange = new AgeRange {Min = 18, Max = 45},
                CoverType = CoverType.Single,
                Dental = true,
                ExtrasTier = ExtrasTier.Intermediate,
                Hospital = Hospital.PublicPrivate,
                Nsd = false,
            },
            new Product()
            {
                Name = "Top Single",
                AgeRange = new AgeRange {Min = 18, Max = 125},
                CoverType = CoverType.Single,
                Dental = true,
                ExtrasTier = ExtrasTier.Top,
                Hospital = Hospital.PublicPrivate,
                Nsd = false,
            },
            new Product()
            {
                Name = "Basic Couple",
                AgeRange = new AgeRange {Min = 18, Max = 125},
                CoverType = CoverType.Couple,
                Dental = false,
                ExtrasTier = ExtrasTier.Essential,
                Hospital = Hospital.Public,
                Nsd = false,
            },
            new Product()
            {
                Name = "Intermediate Couple",
                AgeRange = new AgeRange {Min = 18, Max = 125},
                CoverType = CoverType.Couple,
                Dental = true,
                ExtrasTier = ExtrasTier.Intermediate,
                Hospital = Hospital.PublicPrivate,
                Nsd = false,
            },
            new Product()
            {
                Name = "Top Couple",
                AgeRange = new AgeRange {Min = 18, Max = 125},
                CoverType = CoverType.Couple,
                Dental = true,
                ExtrasTier = ExtrasTier.Top,
                Hospital = Hospital.PublicPrivate,
                Nsd = false,
            },
            new Product()
            {
                Name = "Basic Family",
                AgeRange = new AgeRange {Min = 18, Max = 50},
                CoverType = CoverType.Family,
                Dental = false,
                ExtrasTier = ExtrasTier.Essential,
                Hospital = Hospital.Public,
                Nsd = false,
            },
            new Product()
            {
                Name = "Intermediate Family",
                AgeRange = new AgeRange {Min = 30, Max = 125},
                CoverType = CoverType.Family,
                Dental = true,
                ExtrasTier = ExtrasTier.Intermediate,
                Hospital = Hospital.PublicPrivate,
                Nsd = true,
            },
            new Product()
            {
                Name = "Top Family",
                AgeRange = new AgeRange {Min = 40, Max = 125},
                CoverType = CoverType.Family,
                Dental = true,
                ExtrasTier = ExtrasTier.Top,
                Hospital = Hospital.PublicPrivate,
                Nsd = true,
            },
        };
    }
}
