using RulesPattern.Models;
using RulesPattern.Models.Enums;
using RulesPattern.Rules;
using System.Linq;
using Xunit;

namespace RulesPattern.Tests.Rules
{
    public class HospitalRuleTests
    {
        private readonly IRecommendationRule _hospitalRule;

        public HospitalRuleTests()
        {
            _hospitalRule = new HospitalRule();
        }

        [Fact]
        public void FilterProducts_Returns_ProductsForExtrasTierEssential()
        {
            // Arrange
            var choices = new Choices { Hospital = Hospital.Public };

            // Act
            var productsQuery = _hospitalRule.Evaluate(choices, MockData.Products);
            var products = productsQuery.ToList();

            // Assert
            Assert.Equal(3, products.Count);
        }

        [Fact]
        public void FilterProducts_Returns_ProductsForExtrasTierIntermediate()
        {
            // Arrange
            var choices = new Choices { Hospital = Hospital.PublicPrivate };

            // Act
            var productsQuery = _hospitalRule.Evaluate(choices, MockData.Products);
            var products = productsQuery.ToList();

            // Assert
            Assert.Equal(6, products.Count);
        }
    }
}
