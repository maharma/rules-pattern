using System.Linq;
using RulesPattern.Models;
using RulesPattern.Rules;
using Xunit;

namespace RulesPattern.Tests.Rules
{
    public class AgeRangeRuleTests
    {
        private readonly IRecommendationRule _ageRangeRule;

        public AgeRangeRuleTests()
        {
            _ageRangeRule = new AgeRangeRule();
        }

        [Fact]
        public void FilterProducts_Returns_ProductsForAge25()
        {
            // Arrange
            var choices = new Choices { Age = 25 };

            // Act
            var productQuery = _ageRangeRule.Evaluate(choices, MockData.Products);
            var products = productQuery.ToList();

            // Assert
            Assert.Equal(7, products.Count);
        }

        [Fact]
        public void FilterProducts_Returns_ProductsForAge40()
        {
            // Arrange
            var choices = new Choices { Age = 40 };

            // Act
            var productQuery = _ageRangeRule.Evaluate(choices, MockData.Products);
            var products = productQuery.ToList();

            // Assert
            Assert.Equal(9, products.Count);
        }
    }
}
