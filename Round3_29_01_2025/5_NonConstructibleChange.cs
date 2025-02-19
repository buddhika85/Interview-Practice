namespace Round3_29_01_2025
{
    internal static class _5_NonConstructibleChange
    {
        // [1,2,5]
        public static int NonConstructibleChange(int[] coins)
        {
            Array.Sort(coins);

            var lastMadeChange = 0;
            foreach (var item in coins)
            {
                if (item > lastMadeChange + 1)
                    return lastMadeChange + 1;
                lastMadeChange += item;
            }
            return ++lastMadeChange;
        }
    }
}
