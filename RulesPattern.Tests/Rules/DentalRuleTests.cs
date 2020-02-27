using RulesPattern.Models;
using RulesPattern.Models.Enums;
using RulesPattern.Rules;
using System.Linq;
using Xunit;

namespace RulesPattern.Tests.Rules
{
    public class DentalRuleTests
    {
        private readonly IRecommendationRule _dentalRule;

        public DentalRuleTests()
        {
            _dentalRule = new DentalRule();
        }

        [Fact]
        public void FilterProducts_Returns_ProductsForDental()
        {
            // Arrange
            var choices = new Choices { Dental = true };

            // Act
            var productsQuery = _dentalRule.Evaluate(choices, MockData.Products);
            var products = productsQuery.ToList();

            // Assert
            Assert.Equal(6, products.Count);
        }

        [Fact]
        public void FilterProducts_Returns_ProductsForNonDental()
        {
            // Arrange
            var choices = new Choices { Dental = false };

            // Act
            var productsQuery = _dentalRule.Evaluate(choices, MockData.Products);
            var products = productsQuery.ToList();

            // Assert
            Assert.Equal(3, products.Count);
        }
    }
}
