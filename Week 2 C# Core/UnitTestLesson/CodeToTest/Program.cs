﻿namespace CodeToTest
{
    public class Program
    {
        static void Main(string[] args)
        {
            int timeOfDay = 21;
            Console.WriteLine(GetGreeting(timeOfDay));
            
        }

        private static string GetGreeting(int timeOfDay)
        {
            string message;
            if (timeOfDay >= 5 && timeOfDay <= 12)
            {
                message = "Good morning!";
            }
            else if (timeOfDay >= 12 && timeOfDay <= 18)
            {
                message = "Good afternoon!";
            }
            else
            {
                message = "Good evening!";
            }
            
            return message;
        }
    }
}