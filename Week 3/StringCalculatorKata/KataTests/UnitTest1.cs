using StringCalculatorKata;

namespace KataTests;

public class Tests
{
    [Test]
    public void GivenEmptyString_Add_Return0()
    {
        string input = "";

        int expected = Program.Add(input);

        Assert.That(0, Is.EqualTo(expected));
    }

    [Test]
    public void GivenStringOf1_Add_Return1()
    {
        string input = "1";

        int expected = Program.Add(input);

        Assert.That(1, Is.EqualTo(expected));
    }

    [Test]
    public void GivenStringOf1and2_Add_Return3()
    {
        string input = "1,2";

        int expected = Program.Add(input);

        Assert.That(3, Is.EqualTo(expected));
    }

    [Test]
    public void GivenString1to10_Add_Return55()
    {
        string input = "1,2,3,4,5,6,7,8,9,10";

        int expected = Program.Add(input);

        Assert.That(55, Is.EqualTo(expected));
    }

    [Test]
    public void GivenString123WithNewLineAndComma_Add_Return6()
    {
        string input = "1,2\n3";

        int expected = Program.Add(input);

        Assert.That(6, Is.EqualTo(expected));
    }
}