using System.IO;

namespace AdventOfCode;

internal class Program
{
    static void Main(string[] args)
    {
        elfCalories(); 
    }

    public static string elfCalories()
    {
        var input = File.ReadAllText("C:/Users/Jasser/Desktop/SpartaGlobal/Engineering134/Week 3/AdventOfCode/Input.txt");
        string[] eachLine = input.Split("\n");

        List<int> eachElfTotalCalories = new List<int>();

        // need to add up the number of calories for each elves into a new array
        
        int total = 0;
        foreach (string cal in eachLine)
        {
            if (Int32.TryParse(cal, out int result))
            {
                total += result;
            }
            else
            {
                eachElfTotalCalories.Add(total);
                total = 0;
            }
        }

        int highestCalories = 0;

        foreach(int top in eachElfTotalCalories)
        {
            if (top > highestCalories)
            {
                highestCalories = top;
            }
        }

        int top1 = 0;
        int top2 = 0;
        int top3 = 0;

        for(int i = 0; i < eachElfTotalCalories.Count; i++)
        {
            if (eachElfTotalCalories[i] > top1)
            {
                top3 = top2;
                top2 = top1;
                top1 = eachElfTotalCalories[i];
            }
            else if (eachElfTotalCalories[i] > top2)
            {
                top3 = top2;
                top2 = eachElfTotalCalories[i];
            }
            else if (eachElfTotalCalories[i] > top3)
            {
                top3 = eachElfTotalCalories[i];
            }
        }

        int totalCaloriesOfTopThree = top1 + top2 + top3;


        return $"The highest total calories is: {highestCalories} and the total of the top 3 is: {totalCaloriesOfTopThree}";
    }
}