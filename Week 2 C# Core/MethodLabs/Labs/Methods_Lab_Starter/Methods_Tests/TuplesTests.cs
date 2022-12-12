using NUnit.Framework;
using Methods_Lib;
using System;

namespace Methods_Tests
{
    public class TuplesTests
    {
        [TestCase(25, 3, 4)]
        [TestCase(0, 0, 0)]
        [TestCase(33, 4, 5)]
        public void GivenANumber_DaysAndWeeks_ReturnsCorrectTuple(
            int totalDays, int expectedWeeks, int expectedDays)
        {
            var answer = Methods.DaysAndWeeks(totalDays);
            Assert.That(answer.weeks, Is.EqualTo(expectedWeeks), "Weeks");
            Assert.That(answer.days, Is.EqualTo(expectedDays), "Days");
        }

        [Test]
        public void GivenANegativeNumber_DaysAndWeeks_ThrowsAnException()
        {
            Assert.That(() => Methods.DaysAndWeeks(-1), Throws.TypeOf<ArgumentOutOfRangeException>()
        .With.Message.Contain("totalDays must not be negative"));
        }

        [TestCase (4, 16, 64, 2)]
        public void GivenNumber_SquaredCubedSqrt_ReturnCorrectTuple(int number, int expectedSquared, int expectedCubed, double expectedSqrt)
        {
            var answer = Methods.PowersRoot(number);
            Assert.That(answer.squared, Is.EqualTo(expectedSquared));
            Assert.That(answer.cubed, Is.EqualTo(expectedCubed));
            Assert.That(answer.sqrt, Is.EqualTo(expectedSqrt));
        }
    }
}