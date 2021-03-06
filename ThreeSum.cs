using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21DaysOfCode
{
    internal class ThreeSum
    {

        IList<IList<int>> Solve(int[] nums)
        {
            IList<IList<int>> result = new List<IList<int>>();

            for (var i = 0; i < nums.Length; i++)
            {
                //check if were doing the same num
                if (i > 0 && nums[i] == nums[i - 1]) continue;
                string s = "";
                var t = s[0];
                int left = i + 1;
                int right = nums.Length - 1;

                int n = 0 - nums[i];
                //look for two that add up to n
                while (left < right)
                {

                    // if(left == i) left++;
                    //if(right == i) right --;


                    if (nums[left] + nums[right] == n)
                    {
                        result.Add(new List<int> { nums[left], nums[right], nums[i] });
                        //check for duplicates
                        while (left < right && nums[left] == nums[left + 1]) left++;
                        while (left < right && nums[right] == nums[right - 1]) right--;
                        //do ain increment at the right spot
                        left++;
                        right--;
                    }
                    else if (nums[left] + nums[right] > n)
                    {
                        right--;
                    }
                    else if (nums[left] + nums[right] < n)
                    {
                        left++;
                    }
                    else
                    {
                        left++;
                        right--;
                    }
                }
            }

            return result;
        }

    }
}
