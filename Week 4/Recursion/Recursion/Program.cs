namespace Recursion;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }


    public static int FactorialRecursion(int number)
    {
        if (number == 0) //base case, so when number reaches 0 lines 20 and 21 execute (exits loop)
        {
            return 1;
        }
        else
        {
            return number * FactorialRecursion(number - 1);
        }
    }

    public static int[] FibonacciRecursion(int numbers) // 8  -> 0 1 1 2 3 5 8 13
    {
        if (numbers == 1)
        {
            return new int[] { 0 };
        }
        else if (numbers == 2)
        {
            return new int[] { 0, 1 };
        }
        else // the work we are going to do
        {
            int[] newSequence = new int[numbers];

            //this will keep adding arrays to the stack until it hits a base case
            //if we input 4, we will get an array on the stack with size 4
            //then array with stack size of 3
            //then it hits base case numbers == 2 which returns an array {0, 1} to the top of the stack
            //which is the array with size 3, this array undergoes the code underneath the recursion
            var oldSequence = FibonacciRecursion(numbers - 1);

            //Add the last two numbers of oldSequence together
            //Add the new number to newSequence

            //copies the returned array of {0, 1} from base case to the newSequence of size 3 (for the first recursion) starting from index 0
            oldSequence.CopyTo(newSequence, 0);

            int newFibonacciNumber = oldSequence[oldSequence.Length - 1] + oldSequence[oldSequence.Length - 2];
            newSequence[newSequence.Length - 1] = newFibonacciNumber;

            return newSequence;
        }
    }
}