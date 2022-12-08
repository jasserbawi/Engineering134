using System;

namespace MoreTypes_Lib
{
    public class StringExercises
    {
        // manipulates and returns a string - see the unit test for requirements
        public static string ManipulateString(string input, int num)
        {
            string numbers = "";

            for(int i = 0; i < num; i++)
            {
                numbers += Convert.ToString(i);
            }
            return input.ToUpper().Trim() + numbers;

            throw new NotImplementedException();
        }

        // returns a formatted address string given its components
        public static string Address(int number, string street, string city, string postcode)
        {
            return $"{Convert.ToString(number)} {street}, {city} {postcode}.";
            throw new NotImplementedException();
        }

        // returns a string representing a test score, written as percentage to 1 decimal place
        public static string Scorer(int score, int outOf)
        {
            return $"You got {score} out of {outOf}: {100*Math.Round((Convert.ToDouble(score) / Convert.ToDouble(outOf)), 1)}%";
            throw new NotImplementedException();
        }

        // returns the double represented by the string, or -999 if conversion is not possible
        public static double ParseNum(string numString)
        {
            try
            {
                double output = Double.Parse(numString);
                return output;
            }
            catch (FormatException)
            {
                return -999;
            }
        }

        // Returns a string containing the count of As, Bs, Cs and Ds in the parameter string
        // all other letters are ignored
        public static string CountLetters(string input)
        {

            int A = 0;
            int B = 0;
            int C = 0;
            int D = 0;

            if (input.Length > 0)
            {
                foreach (char c in input)
                {
                    if (c == 'A')
                    {
                        A++;
                    }
                    else if (c == 'B')
                    {
                        B++;
                    }
                    else if (c == 'C')
                    {
                        C++;
                    }
                    else if (c == 'D')
                    {
                        D++;
                    }
                }
                return $"A:{A} B:{B} C:{C} D:{D}";
            }
            else
            {
                throw new NotImplementedException();
            }
        }
    }
}
