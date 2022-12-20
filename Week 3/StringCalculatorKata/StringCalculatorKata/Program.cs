namespace StringCalculatorKata;

public class Program
{
    static void Main(string[] args)
    {
        
    }

    public static int Add(string numbers)
    {
        if (numbers == "")
        {
            return 0;
        }

        int total = 0;

        var newList = numbers.Split(',', '\n');

        foreach(string number in newList)
        {
            if (Int32.TryParse(number, out int result))
            {
                total += result;
            }
        }
        return total;
    }
}   