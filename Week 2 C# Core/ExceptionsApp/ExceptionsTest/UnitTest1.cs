using ExceptionsApp;

namespace ExceptionsTest
{
    public class Tests
    {
        [TestCase(0)]
        [TestCase(-99)]
        public void WhenMarkIsLessThan1_Grade_ThrowsArgumentOutOfRangeException(int mark)
        {
            Assert.That(() => Program.Grade(mark), Throws.TypeOf<ArgumentOutOfRangeException>().With.Message.Contain("Mark cannot be out of the range 1-100."));
        }
    }
}