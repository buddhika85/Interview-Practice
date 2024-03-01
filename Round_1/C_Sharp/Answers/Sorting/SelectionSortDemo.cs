using static System.Console;
using C_Sharp.Answers.Extensions;

namespace C_Sharp.Answers.Sorting
{
    public class SelectionSortDemo
    {
        public static void Demo()
        {
            var nums = new int[] {4,3,2,1};
            WriteLine($"{SelectionSort(nums).Display(",")}");
            WriteLine($"{SelectionSort(nums).Display(",")}");
            nums = new int[] {8, 5, 2, 9, 5, 6, 3};
            WriteLine($"{SelectionSort(nums).Display(",")}");
        }

        // Time : O(n)^2 --> as it uses 2 nested loops
        // Space: O(1)  --> as we did not use any additional space
        public static int[] SelectionSort(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                var minIndex = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[minIndex])
                        minIndex = j;
                }
                if (minIndex != i)
                    Swap(array, i, minIndex);
            }
            return array;
        }

        private static void Swap(int[] array, int right, int left)
        {
            (array[left], array[right]) = (array[right], array[left]);
        }
    }
}