namespace Round3_29_01_2025
{
    internal class _7_ArrayOfProducts
    {
        // Time = O(n) -- because even though we have 2 loops they are'nt nested
        // Space = O(n)  -- additional result array i used
        internal static int[] ArrayOfProducts(int[] array)
        {
            var result = new int[array.Length];
            result[0] = array[1];

            // 0th index
            for (var i = 2; i < array.Length; i++)
            {
                result[0] = result[0] * array[i];
            }

            // other indexes
            for (var i = 1; i < array.Length; i++)
            {
                result[i] = (result[i - 1] * array[i - 1]);
                if (result[i] != 0)
                    result[i] = result[i] / array[i];
            }

            return result;
        }
    }
}
