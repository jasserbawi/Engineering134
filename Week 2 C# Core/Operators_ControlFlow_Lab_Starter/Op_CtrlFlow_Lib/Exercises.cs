using System.Collections.Generic;

namespace Op_CtrlFlow
{
    public class Exercises
    {
        public static bool MyMethod(int num1, int num2)
        {
            return num1 == num2 ? false : (num1 % num2) == 0;
        }
        //if num1 equals num2, then we return false
        //if num1 does not equal num2, then we check the modulus of num1 and num2 and if it is zero then return true otherwise false




        // returns the average of the array nums
        public static double Average(List<int> nums)
        {
            int average;
            var nums = new List<int>() { 3, 8, 1, 7, 3 };
            var nums = list;
            for (i = 0; i < nums.Count; i++)
            {
                average + i
            }
            return average/nums.Count;
        }




        // returns the type of ticket a customer is eligible for based on their age
        // "Standard" if they are between 18 and 59 inclusive
        // "OAP" if they are 60 or over
        // "Student" if they are 13-17 inclusive
        // "Child" if they are 5-12
        // "Free" if they are under 5
        public static string TicketType(int age)
        {
            string ticketType = string.Empty;
            switch (age)
            {
                case >= 60:
                    ticketType = "OAP";
                    break;
                case >= 18:
                    ticketType = "Standard";
                    break;
                case >= 13:
                    ticketType = "Student";
                    break;
                case >= 5:
                    ticketType = "Child";
                    break;
                case >= 0:
                    ticketType = "Free";
                    break;
                default:
                    ticketType = "Error";
                    break;
            }
            return ticketType;
        }

        public static string Grade(int mark)
        {
            var grade = "";
            return grade;
        }

        public static int GetScottishMaxWeddingNumbers(int covidLevel)
        {
            return 0;
        }
    }
}
