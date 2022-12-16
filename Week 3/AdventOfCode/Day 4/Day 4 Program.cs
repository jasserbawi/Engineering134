namespace Day_4;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(CampCleanup());
    }

    public static string CampCleanup()
    {
        // Import text file material into string array
        var textfile = "C:/Users/Jasser/Desktop/SpartaGlobal/Engineering134/Week 3/AdventOfCode/Day4.txt";
        var AllPairs = File.ReadAllLines(textfile);

        var FirstPairList = new List<string>();
        var SecondPairList = new List<string>();

        foreach(string pair in AllPairs)
        {
            var FirstPair = pair.Substring(0, pair.IndexOf(',')).Split('-');
            var SecondPair = pair.Substring(pair.IndexOf(',')+1).Split('-');

            FirstPairList.Add(FirstPair[0]);
            FirstPairList.Add(FirstPair[1]);
            SecondPairList.Add(SecondPair[0]);
            SecondPairList.Add(SecondPair[1]);
        }

        // Now each list has single numbers and starting from the top each number down is a pair

        // Check which pair has fully contained ranges
        var ContainedPairs = 0;
        var ContainedAndOverlappingPairs = 0;

        for (int i = 0; i < FirstPairList.Count; i += 2)
        {
            var FirstNumberInPairOne = Convert.ToInt32(FirstPairList[i]);
            var SecondNumberInPairOne = Convert.ToInt32(FirstPairList[i + 1]);

            var FirstNumberInPairTwo = Convert.ToInt32(SecondPairList[i]);
            var SecondNumberInPairTwo = Convert.ToInt32(SecondPairList[i + 1]);

            // Fully overlaps situation 1
            if (FirstNumberInPairOne - FirstNumberInPairTwo >= 0 &&
                SecondNumberInPairOne - SecondNumberInPairTwo <= 0)
            {
                ContainedPairs++;
                ContainedAndOverlappingPairs++;
            }

            // Fully overlaps situation 2
            else if (FirstNumberInPairOne - FirstNumberInPairTwo <= 0 &&
                SecondNumberInPairOne - SecondNumberInPairTwo >= 0)
            {
                ContainedPairs++;
                ContainedAndOverlappingPairs++;
            }

            // One number overlaps situation 1
            else if (SecondNumberInPairOne > FirstNumberInPairTwo && FirstNumberInPairOne < FirstNumberInPairTwo)
            {
                ContainedAndOverlappingPairs++;
            }

            // One number overlaps situation 2
            else if (FirstNumberInPairOne < SecondNumberInPairTwo && SecondNumberInPairOne > SecondNumberInPairTwo)
            {
                ContainedAndOverlappingPairs++;
            }

        }

        return $"Contained only: {ContainedPairs}, Both: {ContainedAndOverlappingPairs}";
        }
}