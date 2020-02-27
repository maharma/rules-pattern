using RulesPattern.Models;
using RulesPattern.Models.Enums;
using RulesPattern.Rules;
using System.Linq;
using Xunit;

namespace RulesPattern.Tests.Rules
{
    public class CoverTypeRuleTests
    {
        private readonly IRecommendationRule _coverTypeRule;

        public CoverTypeRuleTests()
        {
            _coverTypeRule = new CoverTypeRule();
        }

        [Fact]
        public void FilterProducts_Returns_ProductsForCoverTypeSingle()
        {
            // Arrange
            var choices = new Choices { CoverType = CoverType.Single };

            // Act
            var productsQuery = _coverTypeRule.Evaluate(choices, MockData.Products);
            var products = productsQuery.ToList();

            // Assert
            Assert.Equal(3, products.Count);
            Assert.True(products.All(p => p.CoverType == CoverType.Single));
        }

        [Fact]
        public void FilterProducts_Returns_ProductsForCoverTypeCouple()
        {
            // Arrange
            var choices = new Choices { CoverType = CoverType.Couple };

            // Act
            var productsQuery = _coverTypeRule.Evaluate(choices, MockData.Products);
            var products = productsQuery.ToList();

            // Assert
            Assert.Equal(3, products.Count);
            Assert.True(products.All(p => p.CoverType == CoverType.Couple));
        }

        [Fact]
        public void FilterProducts_Returns_EmptyList_ProductsForCoverTypeSoleParent()
        {
            // Arrange
            var choices = new Choices { CoverType = CoverType.SoleParent };

            // Act
            var productsQuery = _coverTypeRule.Evaluate(choices, MockData.Products);
            var products = productsQuery.ToList();

            // Assert
            Assert.Empty(products);
        }
    }
}
