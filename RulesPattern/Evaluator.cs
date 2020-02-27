using RulesPattern.Models;
using RulesPattern.Rules;
using System.Collections.Generic;

namespace RulesPattern
{
    public class Evaluator
    {
        private IList<IRecommendationRule> _rules = new List<IRecommendationRule>();
        private IEnumerable<Product> _products;

        public Evaluator(IEnumerable<Product> products)
        {
            _products = products;

            _rules.Add(new CoverTypeRule());
            _rules.Add(new AgeRangeRule());
            _rules.Add(new ExtrasTierRule());
            _rules.Add(new HospitalRule());
        }

        public IEnumerable<Product> Recommendations(Choices choices)
        {
            IEnumerable<Product> recommendations = _products;

            foreach (var rule in _rules)
            {
                recommendations = rule.Evaluate(choices, recommendations);
            }
            return recommendations;
        }
    }
}
