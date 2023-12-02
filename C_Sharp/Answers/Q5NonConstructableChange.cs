using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C_Sharp.Answers
{
    public class Q5NonConstructableChange
    {
        public int NonConstructibleChange(int[] coins)
        {
            Array.Sort(coins);
            var lastMadeChange = 0;
            foreach (var item in coins)
            {
                if (item > lastMadeChange + 1)
                    return lastMadeChange + 1;
                else
                    lastMadeChange = lastMadeChange + item ;
            }
            return lastMadeChange + 1;
        }
    }
}