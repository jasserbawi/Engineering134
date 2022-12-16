using System;
using System.IO;
namespace Day_3;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(RepeatedItemPrioritySum());
    }

    public static string RepeatedItemPrioritySum()
    {
        var textfile = "C:/Users/Jasser/Desktop/SpartaGlobal/Engineering134/Week 3/AdventOfCode/Day3.txt";
        var AllRucksacks = File.ReadAllLines(textfile);

        // Splitting the text file into separate lists which contain the separate compartments

        var Compartment1 = new List<string>();
        var Compartment2 = new List<string>();

        foreach(string rucksack in AllRucksacks)
        {
            var FirstRuckSackCompartment = rucksack.Substring(0, rucksack.Length / 2);
            var SecondRuckSackCompartment = rucksack.Substring(rucksack.Length / 2);
            Compartment1.Add(FirstRuckSackCompartment);
            Compartment2.Add(SecondRuckSackCompartment);
        }

        // Creating the priority list which will be used later

        char[] AlphabetInLowerAndUpper = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();

        var PriorityScores = new Dictionary<char, int>();
        
        for (int i = 0; i < 52; i++)
        {
            PriorityScores.Add(AlphabetInLowerAndUpper[i], (i + 1));
        }

        // Checking whether there is a repeated letter in the 2 compartments of the same rucksack

        var RepeatedItemList = new List<char>();
        var RepeatedItemPriorityScoreList = new List<int>();

        for (int Rucksack = 0; Rucksack < Compartment1.Count; Rucksack++)
        {
            for (int i = 0; i < Compartment1[Rucksack].Length; i++)
            {
                if (Compartment2[Rucksack].Contains(Compartment1[Rucksack][i]))
                {
                    var RepeatedItem = Compartment1[Rucksack][i];
                    var RepeatedItemPriorityScore = PriorityScores[RepeatedItem];

                    RepeatedItemList.Add(RepeatedItem);
                    RepeatedItemPriorityScoreList.Add(RepeatedItemPriorityScore);
                    break;
                }
            }
        }



        // PART 2

        var GroupRepeatedItemList = new List<char>();
        var GroupRepeatedItemPriorityList = new List<int>();

        for (int Rucksack = 0; Rucksack < AllRucksacks.Length; Rucksack += 3)
        {
            for (int i = 0; i < AllRucksacks[Rucksack+1].Length; i++)
            {
                var item = AllRucksacks[Rucksack+1][i];
                if (AllRucksacks[Rucksack].Contains(item))
                {
                    if (AllRucksacks[Rucksack + 2].Contains(item))
                    {
                        var RepeatedItem = item;
                        var RepeatedItemPriorityScore = PriorityScores[RepeatedItem];

                        GroupRepeatedItemList.Add(RepeatedItem);
                        GroupRepeatedItemPriorityList.Add(RepeatedItemPriorityScore);
                        break;
                    }
                }
            }
        }

        GroupRepeatedItemPriorityList.Average();

        return $"The individual Rucksack total: {RepeatedItemPriorityScoreList.Sum()} and grouped Rucksack total: {GroupRepeatedItemPriorityList.Sum()}";
    }
}