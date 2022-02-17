using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21DaysOfCode
{
    public class NumSubarrayProductLessThanK
    {
        public int Find(int[] nums, int k)
        {
            int count = 0;

            for (var i = 0; i < nums.Length; i++)
            {
                //start a window and slowly increase it to max Length
                int product = 1;
                int j = i;
                while (product < k & j < nums.Length)
                {
                    product = product * nums[j];
                    if (product < k)
                    {
                        count++;
                        j++;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            return count;
        }
    }
}

