using System;
using System.Linq;
using NUnit.Framework;

namespace Coterie.UnitTests
{
    public class Tests : TestServiceTestsBase
    {
        static object[] HappyCases =
        {
            new [] { "Summer", "Winter", "Spring" },
            new [] { "Fall", "Winter"},
            new [] { "Fall" }
        };
        
        [TestCaseSource(nameof(HappyCases))]
        public void ReturnListOf5Results(string[] items)
        {
            // Act
            var actual = TestService.GetWeatherItems(items);
            
            // Assert
            Assert.IsNotNull(actual);
            Assert.That(actual.ToList().Count, Is.EqualTo(5));
        }

        [Test]
        public void ThrowExceptionGivenInvalidData()
        {
            // Arrange
            var badData = Array.Empty<string>();
            
            // Assert
            Assert.Throws<IndexOutOfRangeException>(() => TestService.GetWeatherItems(badData));
        }
    }
}