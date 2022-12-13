using NUnit.Framework;

namespace AdvancedNUnit
{
    [TestFixture]
    // [Ignore("Not using these tests yet")]
    public class CounterTests
    {
        private Counter _sut;
        [SetUp]
        public void Setup()
        {
            _sut = new Counter(6);
        }

        [Test]
        public void Increment_IncreaseCountByOne()
        {
            _sut.Increment();
            Assert.That(_sut.Count, Is.EqualTo(7));
        }
        [Test]
        public void Decrement_DecreasesCountByOne()
        {
            _sut.Decrement();
            Assert.That(_sut.Count, Is.EqualTo(5));
        }

        [TestCaseSource("AddCases")]
        public void Add_Always_ReturnsExpectedResult(int x, int y, int expResult)
        {
            var subject = new Calculator { Num1 = x, Num2 = y };
            Assert.That(subject.Add(), Is.EqualTo(expResult));
        }

        private static object[] AddCases =   {
        new int[] {2, 4, 6},
        new int[] {-2, 3, 1}
        };
    }
}
