using System.Collections.Generic;
using RulesPattern.Models;
using System.Linq;

namespace RulesPattern.Rules
{
    public class CoverTypeRule : IRecommendationRule
    {
        public IQueryable<Product> Evaluate(Choices customerChoices, IEnumerable<Product> products)
        {
            return products.Where(p => p.CoverType == customerChoices.CoverType).AsQueryable();
        }
    }
}
