namespace CodeToTest
{
    public class Program
    {
        static void Main(string[] args)
        {
            int timeOfDay = 21;
            Console.WriteLine(GetGreeting(timeOfDay));
            
        }

        public static string GetGreeting(int timeOfDay)
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
        }
    }
}