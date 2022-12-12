using System.Text;
namespace MoreDataTypesApp;

internal class Program
{
    static void Main(string[] args)
    {
        var myString = " C# list fundamentals";
        Console.WriteLine(StringExercise(myString));
        StringInterpolation("Jasser");
        /*ParsingStrings();*/

        ONeDArrays();

        MultiDArrays();

        JaggedArrays();

        DateTimeMethods();

        Enums();
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

    public static void ONeDArrays()
    {
        int[] myIntArray = { 12, 23, 34, 45, 56 };

        Array.Reverse(myIntArray); // using Array.Reverse(the array) we can reverse the array

        foreach (var element in myIntArray.Reverse()) // or you can reverse the array here using the method .Reverse() for arrays
        {
            Console.WriteLine(element);
        }
    }

    public static void MultiDArrays()
    {
        //2D Arrays
        int[,] grid = new int[2, 4]; // rows and columns which are indexed, so when referred to you need to understand that 4 rows means 0, 1, 2, 3
        grid[0, 1] = 6;
        grid[1, 0] = 8;
        grid[1, 3] = 10;

        char[,] gridTwo =
        {
            {'a', 'b' },
            {'c', 'd' },
            {'e', 'f' },
            {'e', 'f' },
            {'g', 'h' },
            /*{'i', 'j', 'k' },*/ //this would not work because arrays are set and cannot be changed
        };

        Console.WriteLine("All of grid two");

        foreach(var element in gridTwo)
        {
            Console.WriteLine(element);
        }

/*        for (int i = gridTwo.GetLowerBound(0); i <= gridTwo.GetUpperBound(0); i++)
        {
            for (int j= gridTwo.GetLowerBound(1); j <= gridTwo.GetUpperBound(1); i++)
            {                                                                                                       //      this messes everything up
                Console.WriteLine($"({i}, {j}) {gridTwo[i, j]} ");     
            }
        }*/

    }
    public static void JaggedArrays()
    {
        int[][] intJArray = new int[2][]; // we can initialise jaggedarrays as we are declaring
        intJArray[0] = new int[4]; // we declare the number of variables in the position 0 out of the 2 declared at the start
        intJArray[1] = new int[2];

        intJArray[0][2] = 3;
        intJArray[1][0] = 5;

        string[][] animalJArray = new string[][]
        {
            new string[] {"Hyena", "Lion", "Cheetah", "Panther"},
            new string[] { "Peacock", "Canary" },
        };

        Console.WriteLine("Jagged array of animals");
        foreach (var element in animalJArray)
        {
            foreach (var animal in element)
            {
                Console.WriteLine(animal);
            }
        }
    }
    public static void DateTimeMethods()
    {
        var now = DateTime.Now;
        Console.WriteLine($"Then time now is {now}");
        Console.WriteLine($"The time in ticks is {now.Ticks}");
        var tomorrow = now.AddDays(1);
        Console.WriteLine($"Tomorrow it will be {tomorrow} which is {tomorrow.Ticks}");
    }

    public static void Enums()
    {
        Suit theSuit = Suit.HEARTS;
        if(theSuit == Suit.SPADES)
        {
            Console.WriteLine($"Suit is {Suit.SPADES}");
        }
        else
        {
            Console.WriteLine($"the suit is {theSuit} not {Suit.SPADES}");
        }
        var anotherSuit = Enum.Parse(typeof(Suit), "CLUBS");

        var mediumValue = (int)Size.MEDIUM;    // enums are a 2 faced mix mapping where you can as for the value that a name has been assigned and it will give the name or call the name and it will give the value
        var mySize = (Size)50;
    }

public enum Suit
    {
        HEARTS, CLUBS, DIAMONDS, SPADES
    }   

public enum Size
    {
        SMALL = 10, LARGE = 50, MEDIUM = 25
    }
}