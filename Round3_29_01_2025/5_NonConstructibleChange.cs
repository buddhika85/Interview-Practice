using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Round3_29_01_2025
{
    internal class _5_NonConstructibleChange
    {
        public int NonConstructibleChange(int[] coins)
        {
            if (coins == null || coins.Length == 0 || coins[1] > 1) 
                return 1;
            var lastMadeChange = 1;
            for (var i = 1; i < coins.Length; i++)
            {
                if (coins[i] > ++lastMadeChange)
                    return lastMadeChange;
            }
            return ++lastMadeChange;
        }
    }
}
