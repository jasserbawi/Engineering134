using System.IO;

namespace ExceptionsApp;

public class Program
{
    static void Main(string[] args)
    {
        /*        string textfile;
                try
                {
                    textfile = File.ReadAllText("SuperSecretDiary.txt");
                    Console.WriteLine(textfile);
                }
                catch (FileNotFoundException e)
                {
                    Console.WriteLine("Sorry, I can't find the file :(");
                    Console.WriteLine(e.Message);
                }
                catch (NotImplementedException e)
                {
                    Console.WriteLine("Write the Method!");
                }
                finally
                {
                    Console.WriteLine("I am always run!");
                }*/

        Console.WriteLine("Alex's Grade was: " + Grade(81));

        Console.WriteLine("Jasser's Grade was: " + Grade(-77));
    }

public static string Grade(int mark)
    {
        if (mark < 1 || mark > 100)
        {
            throw new ArgumentOutOfRangeException("Mark cannot be out of the range 1-100.");
        }

        return mark >= 65 ? (mark >= 85 ? "Distinction" : "Pass") : "Fail";
    }
}