namespace Round_2.ArrayQs
{
    internal class NonConstructibleChangeDemo
    {
        //[1,2,5] => 4
        //[5,7,1,1,2,3,22] => 20
        // no coin => 1

        //[5,7,1,1,2,3,22] => 20
        //[1,1,2,3,5,7,22]
        public static int NonConstructibleChange(int[] coins)
        {
            Array.Sort(coins);
            var minChange = 0;
            foreach (var coin in coins) 
            {
                if (coin > minChange + 1)
                    return minChange + 1;
                minChange += coin;
            }
            return minChange + 1;
        }
    }
}
