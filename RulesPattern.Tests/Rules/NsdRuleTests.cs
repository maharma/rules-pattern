using RulesPattern.Models;
using RulesPattern.Models.Enums;
using RulesPattern.Rules;
using System.Linq;
using Xunit;

namespace RulesPattern.Tests.Rules
{
    public class NsdRuleTests
    {
        private readonly IRecommendationRule _nsdRule;

        public NsdRuleTests()
        {
            _nsdRule = new NsdRule();
        }

        [Fact]
        public void FilterProducts_Returns_ProductsForNsd()
        {
            // Arrange
            var choices = new Choices { Nsd = true };

            // Act
            var productsQuery = _nsdRule.Evaluate(choices, MockData.Products);
            var products = productsQuery.ToList();

            // Assert
            Assert.Equal(2, products.Count);
        }

        [Fact]
        public void FilterProducts_Returns_ProductsForNonNsd()
        {
            // Arrange
            var choices = new Choices { Nsd = false };

            // Act
            var productsQuery = _nsdRule.Evaluate(choices, MockData.Products);
            var products = productsQuery.ToList();

            // Assert
            Assert.Equal(7, products.Count);
        }
    }
}
