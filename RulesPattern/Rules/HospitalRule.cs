using System.Collections.Generic;
using RulesPattern.Models;
using System.Linq;

namespace RulesPattern.Rules
{
    public class HospitalRule : IRecommendationRule
    {
        public IQueryable<Product> Evaluate(Choices choices, IEnumerable<Product> products)
        {
            return products.Where(p => p.Hospital == choices.Hospital).AsQueryable();
        }
    }
}
