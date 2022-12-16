using Microsoft.VisualBasic;

namespace TestDrivenDevelopmentApp;

public class Program
{   
    static void Main(string[] args)
    {
        Console.WriteLine(FizzBuzz(30));
    }

    // argument is the value passed in when a method is called

    public static string FizzBuzz(int maxValue)
    {
        string outputString = "";
        for (int i = 1; i <= maxValue; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                outputString += "FizzBuzz ";
            }
            else if (i % 3 == 0)
            {
                outputString += "Fizz ";
            }
            else if (i % 5 == 0)
            {
                outputString += "Buzz ";
            }
            else
            {
                outputString += i + " ";
            }
        }
        return outputString.TrimEnd();
    }


    /*            The problem -FizzBuzz
    We want to write an application which:

    Outputs the integers from one to some maximum value as a sequence of strings "1", "2", ….
    If the integer is divisible by 3, it is replaced by "Fizz"
    If the integer is divisible by 5, it is replaced by "Buzz"
    If it is divisible by both 3 and 5, it is replaced by "FizzBuzz"

    Expected output for a maximum value of 30:

    1 2 Fizz 4 Buzz Fizz 7 8 Fizz Buzz 11 Fizz 13 14 FizzBuzz 16 17
    Fizz 19 Buzz Fizz 22 23 Fizz Buzz 26 Fizz 28 29 FizzBuzz*/

    /*
        Requirements:
    Takes in max value

    Given 1, returns the first number, 1

    Given 2, returns number, then 2

    Given some maximum value return all numbers in a row

    Given 3 FizzBuzz returns "1 2 Fizz"

    Prints outputs
     
     */






}