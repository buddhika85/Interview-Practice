namespace Round3_29_01_2025
{
    public class Fibonacci
    {
        // In the Fibonacci sequence, each subsequent term is obtained by adding the preceding 2 terms.
        // This is true for all the numbers except the first 2 numbers of the Fibonacci series as they do not have 2 preceding numbers.
        // The first 2 terms in the Fibonacci series is 0 and 1. F(n) = F(n-1)+F(n-2) for n>1.
        // Write a function that finds F(n) given n where n is an integer greater than equal to 0. For the first term n = 0. 
        // 0,1,1,2,3,5,8,13,21...
        // 0 => 0
        // 4 => 3
        // 8 => 21



        // Space = O(n) - stack space is used for each recursive call. - The maximum depth of recursion is index, meaning the space complexity is O(n)
        // Time = time complexity is O(2ⁿ), not O(n), because each call spawns two more calls.        
        public int GetFib(int index)
        {
            if (index == 0 || index == 1)
                return index;         
            return GetFib(index - 1) + GetFib(index - 2);
        }



        // memoization optimization technique used in programming to store previously computed results,
        // preventing redundant calculations.
        private Dictionary<int, int> memozationDic = new Dictionary<int, int>();

        // Space = O(n) - uses extra memoory in memozation dictionary
        // Time = time complexity is O(n)
        public int GetFibMemoization(int index)
        {
            if (index == 0 || index == 1)
                return index;

            if (memozationDic.TryGetValue(index, out int fibMemorized))           
                return fibMemorized;

            var fibCalculated = GetFib(index - 1) + GetFib(index - 2);
            memozationDic[index] = fibCalculated;

            return fibCalculated;
        }

    }
}
