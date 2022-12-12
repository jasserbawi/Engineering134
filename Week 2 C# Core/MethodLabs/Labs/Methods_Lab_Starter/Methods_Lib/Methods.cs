using System;

namespace Methods_Lib
{
    public class Methods
    {
        // implement this method so it returns a tuple (weeks, days) 
        // corresponding to a given number of days
        public static (int weeks, int days) DaysAndWeeks(int totalDays)
        {
            if (totalDays < 0)
            {
                throw new ArgumentOutOfRangeException("totalDays must not be negative");
            }
            else
            {
                int weeks = totalDays / 7;
                int days = totalDays % 7;
                return (weeks, days);
            }
        }

        public static int RollDice(Random rng)
        {
            var num1 = rng.Next(1, 7);
            var num2 = rng.Next(1, 7);
            return num1 + num2;
        }

        public static (int squared, int cubed, double sqrt) PowersRoot(int number)
        {
            int squared = number*number;
            int cubed = number*number*number;
            double sqrt = Math.Sqrt(number);
            return (squared, cubed, sqrt);
        }
    }
}
