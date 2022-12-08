using System.IO;

namespace CodeToTest
{
    public class Program
    {
        static void Main(string[] args)
        {
            int timeOfDay = 177;
            int age = -5;

            Console.WriteLine(AvailableClassifications(age));
            Console.WriteLine(GetGreeting(timeOfDay));

        }

        public static string GetGreeting(int timeOfDay)
        {
            string message;

            if (timeOfDay < 0 || timeOfDay > 23)
            {
                throw new ArgumentOutOfRangeException("Greeting cannot be out of the range 0-23");
            }

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
        }

        public static string AvailableClassifications(int ageOfViewer)
        {
            if (ageOfViewer < 0)
            {
                throw new ArgumentOutOfRangeException("Age of the viewer cannot be negative (< 0).");
            }

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