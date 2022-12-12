namespace ControlFlowApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*            int mark = 88;
                        var grade = mark >= 65 ? (mark >= 85 ? "distinction" : "Pass") : "Fail";
                        Priority(3);

                        Console.WriteLine(CanDrive(12));*/

            List<int> nums = new List<int> { -10, -6, -22, -17, -3 };
            Console.WriteLine("Highest foreach loop: " + LoopTypes.HighestForEachLoop(nums));
            Console.WriteLine("Highest for- loop: " + LoopTypes.HighestForLoop(nums));
            Console.WriteLine("Highest while- loop: " + LoopTypes.HighestWhileLoop(nums));
            Console.WriteLine("Highest do-while loop: " + LoopTypes.HighestDoWhileLoop(nums));
            Console.WriteLine("TESTER: " + LoopTypes.forEach(nums));
        }

/*        public static string Priority(int level)
        {
            string priority = "Code ";
            switch (level)
            {
                case 3:
                    priority = priority + "Red";
                    break;
                case 2:
                case 1:
                    priority = priority + "Amber";
                    break;
                case 0:
                    priority = priority + "Green";
                    break;
                default:
                    priority = "Error";
                    break;
            }
            return priority;
        }

        public static bool CanDrive(int age)
        {
            switch(age)
            {
                case >= 17:
                    return true;
                default:
                    return false;

            }
        }*/
    }
}