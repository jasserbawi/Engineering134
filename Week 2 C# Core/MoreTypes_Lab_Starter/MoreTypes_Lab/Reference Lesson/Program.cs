using System.Text;
namespace MoreDataTypesApp;

internal class Program
{
    static void Main(string[] args)
    {
        ONeDArrays();

        MultiDArrays();

        JaggedArrays();
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

        foreach (var element in gridTwo)
        {
            Console.WriteLine(element);
        }

        for (int i = gridTwo.GetLowerBound(0); i <= gridTwo.GetUpperBound(0); i++)
        {
            for (int j = gridTwo.GetLowerBound(1); j <= gridTwo.GetUpperBound(1); i++)
            {
                /*Console.WriteLine($"({i}, {j}) {gridTwo[i, j]} ");*/
            }
        }

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
}