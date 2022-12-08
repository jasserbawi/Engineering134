using Op_CtrlFlow;
using System.Collections.Generic;
using System.Data;

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
            double Avg = 0;
            foreach(double i in nums)
            {
                Avg = Avg + i;
            }
            return Avg/nums.Count;
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


            if (mark >= 60 && mark <= 100)
            {
                if (mark >= 75)
                {
                    grade = "Pass with Distinction";
                } 
                else
                {
                    grade = "Pass with Merit";
                }
            }
            else
            {
                if (mark >= 40)
                {
                    grade = "Pass";
                }
                else
                {
                    grade = "Fail";
                }
            }
            return grade;
        }

        public static int GetScottishMaxWeddingNumbers(int covidLevel)
        {
            int maxNumbers;
            switch (covidLevel)
            {
                case 1:
                    maxNumbers = 100;
                    break;

                case 2:
                    maxNumbers = 50;
                    break;

                case 3:
                    maxNumbers = 50;
                    break;

                case 4:
                    maxNumbers = 20;
                    break;

                default:
                    maxNumbers = 200;
                    break;
            }
            return maxNumbers;
        }

    }
}