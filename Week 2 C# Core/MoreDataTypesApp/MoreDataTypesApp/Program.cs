using System.Text;
namespace MoreDataTypesApp;

internal class Program
{
    static void Main(string[] args)
    {
        var myString = " C# list fundamentals";
        Console.WriteLine(StringExercise(myString));
        StringInterpolation("Jasser");
        ParsingStrings();
    }

    public static string StringExercise(string myString)
    {
        var intermediate = myString.Trim().ToUpper().Replace('L', '*').Replace('T', '*');
        var nPos = intermediate.IndexOf('N');
        var finalString = intermediate.Remove(nPos + 1);
        return finalString;
    }

    public static string StringBuilderExercise(string myString)
    {
        var trimmedUpperString = myString.Trim().ToUpper();
        var nPos = trimmedUpperString.IndexOf('N');
        StringBuilder sb = new StringBuilder(trimmedUpperString);
        sb.Replace('L', '*').Replace('T', '*').Remove(nPos + 1, sb.Length - nPos - 1);
        return sb.ToString();
    }

    public static void StringInterpolation(string str)
    {
        Console.WriteLine("My name is: " + str + " Using +");
        Console.WriteLine($"My name is: {str} Using +"); // this is called interpolation and we use $ before the string and {str} to input the other string
        var num1 = 14;
        var num2 = 7;
        var fString = $"{num1} to the power of {num2} is {Math.Pow(num1, num2)}";
        var fString2 = $"Log to the base {num2} of {num1} is {Math.Log(num2, num1):0.####}"; // 0.#### gives it to 4 decimal places
        var fString3 = $"That will be {num2 / 3.0:C} Please"; // :C after causes it to turn into money so instead of 2.333333 it becomes £2.33
    }

    // TRY AND PARSE METHOD TO HANDLE DATA TYPES
    public static void ParsingStrings()
    {
        // parsing strings
        Console.WriteLine("How many apples?");
        string input = Console.ReadLine();
        // int numApples = Int32.Parse(input); this will be a problem because if you input 2.5 it will not work as it only takes integers
        var success = Int32.TryParse(input, out int parsedApples);
    }
}