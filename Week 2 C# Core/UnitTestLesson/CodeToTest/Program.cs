using System.IO;

namespace CodeToTest
{
    public class Program
    {
        static void Main(string[] args)
        {
            int timeOfDay = 21;
            int age = 11;

            /*Console.WriteLine(GetGreeting(timeOfDay));*/


            Console.WriteLine(AvailableClassifications(age));

        }

        /*public static string GetGreeting(int timeOfDay)
        {
            string message;
            //0 to 5
            if (timeOfDay >= 5 && timeOfDay < 12)
            {
                message = "Good Morning!";
            }
            else if (timeOfDay >= 12 && timeOfDay <= 18)
            {
                message = "Good Afternoon!";
            }
            else
            //19 to 23
            {
                message = "Good Evening!";
            }
            
            return message;
        }*/

        public static string AvailableClassifications(int ageOfViewer)
        {
            string result;
            if (ageOfViewer < 12)
            {
                result = "U & PG films are available.";
            }
            else if (ageOfViewer < 15)
            {
                result = "U, PG & 12 films are available.";
            }
            else if (ageOfViewer <= 17)
            {
                result = "U, PG, 12 & 15 films are available.";
            }
            else if (ageOfViewer <= 18)
            {
                result = "U, PG, 12, 15 & 18 films are available.";
            }
            else
            {
                result = "All films are available.";
            }
            return result;
        }
    }
}