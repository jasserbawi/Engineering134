using TestDrivenDevelopmentApp;

namespace TestDrivenDevelopmentTests;

public class TDDTests
{
    [Test]
    public void Given1_FizzBuzz_Returns1()
    {
        int maxvalue = 1;
        Assert.That(Program.FizzBuzz(maxvalue), Is.EqualTo("1"));
    }

    [Test]
    public void Given2_FizzBuzz_Returns1AndThen2()
    {
        int maxvalue = 2;
        Assert.That(Program.FizzBuzz(maxvalue), Is.EqualTo("1 2"));
    }

    [Test]
    public void GivenSomeMaximumValue_FizzBuzz_ReturnsAllNumbersInARow()
    {
        int maxvalue = 10;
        string expectedValue = "1 2 Fizz 4 Buzz Fizz 7 8 Fizz Buzz";
        Assert.That(Program.FizzBuzz(maxvalue), Is.EqualTo(expectedValue));
    }

    [Test]
    public void Given3_FizzBuzz_Returns12Fizz()
    {
        int maxvalue = 3;
        string expectedValue = "1 2 Fizz";
        Assert.That(Program.FizzBuzz(maxvalue), Is.EqualTo(expectedValue));
    }

    [Test]
    public void Given4_FizzBuzz_Returns1BuzzFizzBuzz()
    {
        int maxvalue = 5;
        string expectedValue = "1 2 Fizz 4 Buzz";
        Assert.That(Program.FizzBuzz(maxvalue), Is.EqualTo(expectedValue));
    }
}