using System;
using System.Collections.Generic;

namespace Collections_Lib
{
    public class CollectionsExercises
    {

        /* removes and returns the next num entries in the queue, as a comma separated string */
        public static string NextInQueue(int num, Queue<string> queue)
        {
            string peopleLeft = "";

            if (num > queue.Count)
            {
                int numberOfPeopleAtStart = queue.Count;
                for (int i = 0; i <= numberOfPeopleAtStart; i++)
                {
                    if (i == numberOfPeopleAtStart)
                    {
                        peopleLeft += queue.Dequeue();
                    }
                    else
                    {
                        peopleLeft += queue.Dequeue() + ", ";
                    }
                }

            }
            else
            {
                for (int i = 1; i <= num; i++)
                {
                    if (i == num)
                    {
                        peopleLeft += queue.Dequeue();
                    }
                    else
                    {
                        peopleLeft += queue.Dequeue() + ", ";
                    }
                }
            }
            return peopleLeft;
        }

        /* uses a Stack to create and return array of ints in reverse order to the one supplied */
        public static int[] Reverse(int[] original)
        {
            throw new NotImplementedException();
        }
        // using a Dictionary, counts and returns (as a string) the occurence of the digits 0-9 in the given string
        public static string CountDigits(string input)
        {
            throw new NotImplementedException(); 
        }
    }
}
