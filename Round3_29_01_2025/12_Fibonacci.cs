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
        public int GetFib(int index)
        {
            if (index == 0 || index == 1)
                return index;
            return GetFib(index - 1) + GetFib(index - 2);
        }

    }
}
