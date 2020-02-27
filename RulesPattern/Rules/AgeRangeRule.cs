using RulesPattern.Models;
using System.Collections.Generic;
using System.Linq;

namespace RulesPattern.Rules
{
    public class AgeRangeRule : IRecommendationRule
    {
        public IQueryable<Product> Evaluate(Choices choices, IEnumerable<Product> products)
        {
            return products.Where(p => choices.Age >= p.AgeRange.Min && choices.Age <= p.AgeRange.Max).AsQueryable();
        }
    }
}
