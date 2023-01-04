using Recursion;

namespace Tests
{
    public class Tests
    {
        [Test]
        public void GivenFactorialRecursion_WhenNumberInputted_ReturnFactorialOfNumber()
        {
            var actual = Program.FactorialRecursion(5);
            var expected = 120;

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void GivenFibonacciRecursion_WhenNumberInputted_ReturnArrayOfFibonacciValuesUntilNumber()
        {
            var actual = Program.FibonacciRecursion(8);
            var expected = new int[] { 0, 1, 1, 2, 3, 5, 8, 13 };

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}