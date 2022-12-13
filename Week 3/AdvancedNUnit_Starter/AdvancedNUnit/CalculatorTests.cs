using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace AdvancedNUnit
{
    public class CalculatorTests
    {
        [SetUp]
        public void Setup() { }

        [Test]
        public void Add_Always_ReturnsExpectedResult()
        {
            // Arrange
            var expectedResult = 6;
            var subject = new Calculator { Num1 = 2, Num2 = 4 };
            // Act
            var result = subject.Add();
            // Assert
            Assert.That(result, Is.EqualTo(expectedResult), "optional failure message");
        }

        [Test]
        public void PlayingWithConstraints()
        {
            // Arrange
            var subject = new Calculator { Num1 = 6 };

            // Act & Assert
            Assert.That(subject.DivisibleBy3);
            subject.Num1 = 7;
            Assert.That(subject.DivisibleBy3, Is.False);
            Assert.That(subject.ToString(), Does.Contain("Calculator"));

        }

        [Test]
        public void StringConstraints()
        {
            var subject = new Calculator { Num1 = 2, Num2 = 4 };

            var expectedString = "AdvancedNUnit.Calculator";
            Assert.That(subject.ToString(), Is.EqualTo(expectedString));
            Assert.That(subject.ToString(), Does.Not.Contain("Potato").IgnoreCase);
            Assert.That(subject.ToString(), Is.Not.Empty);
        }

        [Test]
        public void RangeConstraint()
        {
            List<int> myDiceRolls = new() { 6, 6 };
            // var myDiceRolls2 = new List<int> { 6, 6 };

            Assert.That(myDiceRolls[0], Is.InRange(1, 6));
            Assert.That(myDiceRolls, Is.All.InRange(1, 6)); // checks each item in list
            Assert.That(myDiceRolls, Has.Member(6)); // checks if 6 is a part of the list
        }

        [Test]
        public void StringChecker()
        {
            string world = "world";

            Assert.That(world, Does.StartWith("wor"));
        }

        [Test]
        public void ArrayChecker()
        {
            int[] arraytest = {2, 16, -5, 7, 20};
            Assert.That(arraytest, Has.Exactly(2).InRange(1,10));
        }

        [Test]
        public void ArrayChecker2()
        {
            int[] arraytest = new int[99];
            Assert.That(arraytest, Has.Exactly(99).Items);
        }

    }
    
}