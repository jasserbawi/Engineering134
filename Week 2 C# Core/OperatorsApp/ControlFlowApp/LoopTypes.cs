using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlFlowApp
{
    public static class LoopTypes
    {
        internal static int HighestDoWhileLoop(List<int> nums)
        {
            int highest = nums[0];
            int i = 0;
            do
            {
                if (nums[i] > highest)
                {
                    highest = nums[i];
                }
                i++;
            }
            while (i < nums.Count());
            return highest;
        }

        internal static int HighestForEachLoop(List<int> nums)
        {
            int highest = nums[0];
            foreach (int i in nums)
            {
                if (i > highest)
                {
                    highest = i;
                }
            }
            return highest;
        }

        internal static int HighestForLoop(List<int> nums)
        {
            int highest = nums[0];
            for (int i = 0; i < nums.Count(); i++)
            {
                if (nums[i] > highest)
                {
                    highest = nums[i];
                }
            }
            return highest;
        }

        internal static int HighestWhileLoop(List<int> nums)
        {
            int highest = nums[0];
            int i = 0;
            while (i < nums.Count())
            {
                if (nums[i] > highest)
                {
                    highest = nums[i];
                }
                i++;
            }
            return highest;
        }
    }
}
