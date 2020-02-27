using RulesPattern.Models;
using RulesPattern.Models.Enums;
using RulesPattern.Rules;
using System.Linq;
using Xunit;

namespace RulesPattern.Tests.Rules
{
    public class ExtrasTierTests
    {
        private readonly IRecommendationRule _extrasTierRule;

        public ExtrasTierTests()
        {
            _extrasTierRule = new ExtrasTierRule();
        }

        [Fact]
        public void FilterProducts_Returns_ProductsForExtrasTierEssential()
        {
            // Arrange
            var choices = new Choices { ExtrasTier = ExtrasTier.Essential };

            // Act
            var productsQuery = _extrasTierRule.Evaluate(choices, MockData.Products);
            var products = productsQuery.ToList();

            // Assert
            Assert.Equal(3, products.Count);
        }

        [Fact]
        public void FilterProducts_Returns_ProductsForExtrasTierIntermediate()
        {
            // Arrange
            var choices = new Choices { ExtrasTier = ExtrasTier.Intermediate };

            // Act
            var productsQuery = _extrasTierRule.Evaluate(choices, MockData.Products);
            var products = productsQuery.ToList();

            // Assert
            Assert.Equal(3, products.Count);
        }

        [Fact]
        public void FilterProducts_Returns_ProductsForExtrasTierTop()
        {
            // Arrange
            var choices = new Choices { ExtrasTier = ExtrasTier.Top };

            // Act
            var productsQuery = _extrasTierRule.Evaluate(choices, MockData.Products);
            var products = productsQuery.ToList();

            // Assert
            Assert.Equal(3, products.Count);
        }
    }
}
