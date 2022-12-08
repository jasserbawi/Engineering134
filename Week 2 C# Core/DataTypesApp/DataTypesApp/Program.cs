using System.Collections.Generic;
namespace DataTypesApp;

public class Program
{
    static void Main(string[] args)
    {
        int number = 5;
        //number = "hello";

        int[] numbers = new int[3];
        numbers[0] = 1;
        numbers[1] = 2;
        numbers[2] = 4;

        //VARIABLES

        //Var is a shortcut which needs to be a assigned a data type such as a string below
        var greeting = "Hello there";

        string greeting2;
        //Var greeting3; will give an error because you havent given it any data.

        var age = 33; //This defaults to an int

        var height = 182.4; //This defaults to a double

        var height2 = 182.4f; //This specifies a single, not a double

        var ageOfUniverse = 13_128_347_125uL;

        var grade = 'A'; //This assigns a single character

        //Implicit using - using System.Collections.Generic;
        List<int> nums;

        //Decimal data type is used for money as it has precision
        List<decimal> prices = new List<decimal>();

        //We can use var to create lists aswell
        var prices2 = new List<decimal>();


        // FLOATS

        float sum = 0;
        for (int i = 0; i < 700_000; i++) // adding 7ths, 700,000 times should give 100,000 as a sum
        {
            sum += 1 / 7f; // 7f makes it a single
        }

        Console.WriteLine(sum); // Instead of printing 100,000, it prints 99793.02
        Console.WriteLine(700_000 * (1 / 7f)); // This should give 100,000 but gives 100,000.01

        if (700_000 / 7f == 100_000)
        {
            Console.WriteLine("700,000 is divisble by 7!");
        }
        else
        {
            Console.WriteLine("700,000 is not divisble by 7!");
        }


        //              TYPE CONVERISONS
        //.................................................................................................


        var a = 12;
        var b = 7;
        var c = a / b; // c will be an integer so instead of printing the mathematical decimal answer it prints 1 instead of 1.714..

        var d = 12;
        var e = 7.0;
        var f = d / e; // this will make d a double too, e was already set as one so f becomes a decimal



        // OVERFLOW AND UNDERFLOW

        unchecked // if we didnt make it unchecked then the line in the block would be underlined red
        {
            int bigNumber = Int32.MaxValue + 1; // syntatically this is fine, however, C# cant run this because integers have a max data value and adding 1 will OVERFLOW it
            Console.WriteLine(bigNumber);

            int smallNumber = Int32.MinValue - 1;
            Console.WriteLine(smallNumber);
        }


        // UNSAFE CONVERSIONS (CASTING OPERATOR)

        int trees = 5000;
        short greenery = (short)trees;  // the (short) is a casting operator which forces unsafe conversions to take place

    }

}