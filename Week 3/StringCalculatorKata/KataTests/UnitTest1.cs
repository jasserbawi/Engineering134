using StringCalculatorKata;

namespace KataTests;

public class Tests
{
    [Test]
    public void GivenEmptyString_Add_Return0()
    {
        string input = "";

        int expected = Program.Add(input);

        Assert.AreEqual(0, expected);
    }

    [Test]
    public void GivenStringOf1_Add_Return1()
    {
        string input = "1";

        int expected = Program.Add(input);

        Assert.AreEqual(1, expected);
    }

    [Test]
    public void GivenStringOf1and2_Add_Return3()
    {
        string input = "1,2";

        int expected = Program.Add(input);

        Assert.AreEqual(3, expected);
    }

    [Test]
    public void GivenString1to10_Add_Return55()
    {
        string input = "1,2,3,4,5,6,7,8,9,10";

        int expected = Program.Add(input);

        Assert.AreEqual(55, expected);
    }

    [Test]
    public void GivenString123WithNewLineAndComma_Add_Return6()
    {
        string input = "1,2\n3";

        int expected = Program.Add(input);

        Assert.AreEqual(6, expected);
    }
}