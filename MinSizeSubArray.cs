using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21DaysOfCode
{
    public class MinSizeSubArray
    {
        public int MinSubArrayLen(int target, int[] nums)
        {
            int minLength = int.MaxValue; ;
            if (nums.Length == 0) return minLength;

            for (var start = 0; start < nums.Length; start++)
            {
                int current = start;
                int currentSum = 0;
                int currentLength = 0;
                while (current < nums.Length && (currentSum + nums[current]) <= target)
                {
                    currentSum += nums[current];
                    current++;
                    currentLength++;
                }

                minLength = Math.Min(minLength, currentLength);
            }

            return minLength;
        }
    }
}
