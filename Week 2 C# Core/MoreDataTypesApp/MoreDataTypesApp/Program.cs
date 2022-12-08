namespace MoreDataTypesApp;

internal class Program
{
    static void Main(string[] args)
    {
        var myString = " C# list fundamentals";
        Console.WriteLine(StringExercise(myString));
    }

    public static string StringExercise(string myString)
    {
        var intermediate = myString.Trim().ToUpper().Replace('L', '*').Replace('T', '*');
        var nPos = intermediate.IndexOf('N');
        var finalString = intermediate.Remove(nPos);
        return finalString;
    }
}