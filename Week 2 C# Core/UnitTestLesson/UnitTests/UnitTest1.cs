using CodeToTest;

namespace UnitTests
{
    public class Tests
    {
        [Test]
        public void GivenTimeOf21_GetGreeting_ReturnsGoodEvening()
        {
            //given a time of 21
            //Arrange our Precondition
            int time = 21;

            //when i Call GetGreeting, it returns Good Evening
            //Act
            string output = Program.GetGreeting(time);

            //Assert that it returned "Good Evening!"
            Assert.That(output, Is.EqualTo("Good Evening!"));
        }

        //lower boundary morning
        [TestCase(5)]
        //middle boundary morning
        [TestCase(8)]
        //upper boundary morning
        [TestCase(11)]
        public void GivenTimeMorningBoundaryValues_GetGreeting_ReturnsGoodMorning(int timeOfDay)
        {
            //Arrange our Precondition
            int time = timeOfDay;

            //when i Call GetGreeting, it returns Good Morning
            //Act
            string output = Program.GetGreeting(time);

            //Assert that it returned "Good Morning!"
            Assert.That(output, Is.EqualTo("Good Morning!"));
        }

        //lower boundary afternoon
        [TestCase(12)]
        //middle boundary afternoon
        [TestCase(15)]
        //upper boundary afternoon
        [TestCase(17)]
        public void GivenTimeAfternoonBoundaryValues_GetGreeting_ReturnsGoodAfternoon(int timeOfDay)
        {
            //Arrange our Precondition
            int time = timeOfDay;

            //when i Call GetGreeting, it returns Good Afternoon
            //Act
            string output = Program.GetGreeting(time);

            //Assert that it returned "Good Afternoon!"
            Assert.That(output, Is.EqualTo("Good Afternoon!"));
        }

        //lower boundary evening
        [TestCase(0)]
        //middle boundary evening
        [TestCase(2)]
        //upper boundary evening
        [TestCase(4)]
        public void GivenTimeEvening1BoundaryValues_GetGreeting_ReturnsGoodEvening(int timeOfDay)
        {
            //Arrange our Precondition
            int time = timeOfDay;

            //when i Call GetGreeting, it returns Good Evening
            //Act
            string output = Program.GetGreeting(time);

            //Assert that it returned "Good Evening!"
            Assert.That(output, Is.EqualTo("Good Evening!"));
        }

        //lower boundary evening
        [TestCase(19)]
        //middle boundary evening
        [TestCase(21)]
        //upper boundary evening
        [TestCase(23)]
        public void GivenTimeEvening2BoundaryValues_GetGreeting_ReturnsGoodEvening(int timeOfDay)
        {
            //Arrange our Precondition
            int time = timeOfDay;

            //when i Call GetGreeting, it returns Good Evening
            //Act
            string output = Program.GetGreeting(time);

            //Assert that it returned "Good Evening!"
            Assert.That(output, Is.EqualTo("Good Evening!"));
        }
    }
}