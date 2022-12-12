using NUnit.Framework;
using System;
using Methods_Lib;

namespace Methods_Tests
{
    public class DiceTests
    {
        [TestCase (5 , 6, 11)]
        [TestCase (3 , 2, 5)]
        [TestCase (5 , 1, 6)]
        public void DiceRolls_ReturnValueFrom2To12(int num1, int num2, int totalExpected)
        {
            int answer = num1 + num2;
            Assert.That(answer, Is.EqualTo(totalExpected));
        }

        [TestCase(1111)]
        [TestCase(2222)]
        [TestCase(9999)]
        public void DiceRolls_ReturnCorrectValue(int seed, int expectedOutput)
        {
            Random rnd = new Random(seed);
            int value1 = rnd.Next(1,7);
            int value2 = rnd.Next(1,7);
            int result = value1 + value2;
            int methodOutput = Methods.RollDice(new Random(seed));
            Assert.That(methodOutput, Is.EqualTo(result));
        }


    }

}
