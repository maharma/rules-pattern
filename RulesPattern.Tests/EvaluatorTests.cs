using RulesPattern.Models;
using RulesPattern.Models.Enums;
using RulesPattern.Rules;
using System.Linq;
using Xunit;

namespace RulesPattern.Tests
{
    public class EvaluatorTests
    {
        private readonly Evaluator _evaluator;

        public EvaluatorTests()
        {
            _evaluator = new Evaluator(MockData.Products);
        }

        [Fact]
        public void Evaluator_Choices_CoverTypeSingleAge23ExtrasTopHospitalPrivate()
        {
            // Arrange
            var choices = new Choices
            {
                CoverType = CoverType.Single,
                Age = 23,
                ExtrasTier = ExtrasTier.Top,
                Hospital = Hospital.PublicPrivate
            };

            // Act
            var recommendations = _evaluator.Recommendations(choices);

            // Assert
            Assert.NotEmpty(recommendations.Where(p => p.Name == "Top Single"));
        }
    }
}