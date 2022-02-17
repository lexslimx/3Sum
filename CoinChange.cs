using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21DaysOfCode
{
    public class CoinChange
    {
        public int GetChange(int[] coins, int amount)
        {
            int count = 0;
            for (int i = coins.Length - 1; i >= 0; i--)
            {
                while (amount > 0 && amount >= coins[i])
                {
                    //keep deducting amount i                                    
                    amount = amount - coins[i];
                    count++;
                }
            }

            return count;
        }
    }
}
