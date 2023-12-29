



namespace C_Sharp.Answers.Arrays
{
    public static class QThreeNumberSum
    {
        // [12, 3, 1, 2, -6, 5, -8, 6]
        // target Sum = 0
        // [[-8, 2, 6], [-8, 3, 5], [-6, 1, 5]]
        public static List<int[]> ThreeNumberSum(int[] array, int targetSum)
        {
            var result = new List<int[]>();
            foreach (var itemOne in array)
            {
                foreach (var itemTwo in array)
                {
                    if (itemOne != itemTwo)
                        foreach (var itemThree in array)
                        {
                            if (itemOne != itemThree && itemTwo != itemThree)
                            {
                                var sum = itemOne + itemTwo + itemThree;
                                if (sum == targetSum)
                                {
                                    var sortedResult = GetOrderedArray(itemOne, itemTwo, itemThree);
                                    if (IsUnique(result, sortedResult))
                                        result.Add(sortedResult);
                                }
                            }
                        }

                }
            }
            return result.OrderBy(x => x[0]).ThenBy(x => x[1]).ToList();
        }

        private static bool IsUnique(List<int[]> result, int[] sortedResult)
        {
            return !result.Any(x => x[0] == sortedResult[0] && x[1] == sortedResult[1] && x[2] == sortedResult[2]);
        }

        private static int[] GetOrderedArray(int itemOne, int itemTwo, int itemThree)
        {
            var array = new int[] { itemOne, itemTwo, itemThree };
            Sort(array);
            return array;
        }

        // Bubble sort
        private static void Sort(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - 1 - i; j++)
                {
                    if (array[j] > array[j + 1])
                        Swap(j, j + 1, array);
                }
            }
        }

        private static void Swap(int left, int right, int[] array)
        {
            var temp = array[left];
            array[left] = array[right];
            array[right] = temp;
        }
    }
}