using RulesPattern.Models;
using System.Collections.Generic;
using System.Linq;

namespace RulesPattern
{
    public interface IRecommendationRule
    {
        IQueryable<Product> Evaluate(Choices choices, IEnumerable<Product> products);
    }
}
