using System.IO;
namespace Day_2;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(CheatSheet());
    }

    public static (int firstScore, int secondScore) CheatSheet()
    {
        var input = File.ReadAllText("C:/Users/Jasser/Desktop/SpartaGlobal/Engineering134/Week 3/AdventOfCode/Day2.txt");
        
        List<char> opponentsAnswers = new List<char>();

        List<char> myAnswers = new List<char>();

        for (int i = 0; i < input.Length - 2; i = i + 5)
        {
            opponentsAnswers.Add(input[i]);
        }

        for (int i = 2; i < input.Length; i = i + 5)
        {
            myAnswers.Add(input[i]);
        }

        //  A ROCK    B PAPER    C SCISSORS
        //  X ROCK (1)    Y PAPER (2)    Z SCISSORS (3)
        //  WIN = 6   DRAW = 3    LOSS = 0

        // The points given for all possibilities against opponents ROCK
        var myAnswerAgainstRock = new Dictionary<char, int>()
        {
            {'X', 4},
            {'Y', 8},
            {'Z', 3}
        };

        // The points given for all possibilities against opponents PAPER
        var myAnswerAgainstPaper = new Dictionary<char, int>()
        {
            {'X', 1},
            {'Y', 5},
            {'Z', 9}
        };

        // The points given for all possibilities against opponents SCISSORS
        var myAnswerAgainstScissors = new Dictionary<char, int>()
        {
            {'X', 7},
            {'Y', 2},
            {'Z', 6}
        };

        int firstScore = 0;
        for (int i = 0; i < myAnswers.Count; i++)
        {
            if (opponentsAnswers[i] == 'A')
            {
                firstScore += myAnswerAgainstRock[myAnswers[i]];
            }
            else if (opponentsAnswers[i] == 'B')
            {
                firstScore += myAnswerAgainstPaper[myAnswers[i]];
            }
            else if (opponentsAnswers[i] == 'C')
            {
                firstScore += myAnswerAgainstScissors[myAnswers[i]];
            }
        }

        // NEW points going against opponents ROCK
        IDictionary<char, int> newAnswerAgainstRock = new Dictionary<char, int>()
        {
            {'X', 3},
            {'Y', 4},
            {'Z', 8}
        };

        // NEW points going against opponents PAPER
        IDictionary<char, int> newAnswerAgainstPaper = new Dictionary<char, int>()
        {
            {'X', 1},
            {'Y', 5},
            {'Z', 9}
        };

        // NEW points going against opponents SCISSORS
        IDictionary<char, int> newAnswerAgainstScissors = new Dictionary<char, int>()
        {
            {'X', 2},
            {'Y', 6},
            {'Z', 7}
        };

        int secondScore = 0;
        for (int i = 0; i < myAnswers.Count; i++)
        {
            if (opponentsAnswers[i] == 'A')
            {
                secondScore += newAnswerAgainstRock[myAnswers[i]];
            }
            else if (opponentsAnswers[i] == 'B')
            {
                secondScore += newAnswerAgainstPaper[myAnswers[i]];
            }
            else if (opponentsAnswers[i] == 'C')
            {
                secondScore += newAnswerAgainstScissors[myAnswers[i]];
            }
        }

        return (firstScore, secondScore);
    }
}


// 2 Columns, one with their answer the second with the answer to beat it
// total score is the sum of scores for each round
// score for each round is, 1 for rock X, 2 for paper Y, 3 for scissors Z
// each round win is 6, so if you win with rock its 6 + 1 = 7
// draw is 3 points
// loss is 1 point