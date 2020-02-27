using System.Collections.Generic;
using RulesPattern.Models;
using System.Linq;

namespace RulesPattern.Rules
{
    public class CoverTypeRule : IRecommendationRule
    {
        public IQueryable<Product> Evaluate(Choices choices, IEnumerable<Product> products)
        {
            return products.Where(p => p.CoverType == choices.CoverType).AsQueryable();
        }
    }
}
