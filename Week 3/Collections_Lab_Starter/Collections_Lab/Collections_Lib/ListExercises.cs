using System;
using System.Collections.Generic;

namespace Collections_Lib
{
    public class ListExercises
    {
        // returns a list of all the integers between 1 to max inclusive
        // that are multiples of 5
        public static List<int> MakeFiveList(int max)
        {
            List<int> listOfInts = new();

            for (int i = 1; i <= max; i++)
            {
                if (i % 5 == 0)
                {
                    listOfInts.Add(i);
                }
            }
            return listOfInts;
        }

        // returns a list of all the strings in sourceList that start with the letter 'A' or 'a'
        public static List<string> MakeAList(List<string> sourceList)
        {
            List<string> StartsWithAora = new();

            foreach(string str in sourceList)
            {
                if (str[0] == 'a' || str[0] == 'A')
                {
                    StartsWithAora.Add(str);
                }
            }

            return StartsWithAora;
        }
    }
}
