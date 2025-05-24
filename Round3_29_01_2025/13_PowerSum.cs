namespace Round3_29_01_2025
{
    // "Let’s define a peculiar type of array in which each element is either an integer or another peculiar array.
    // Assume that a peculiar array is never empty. Write a function that will take a peculiar array as its input and find the sum of its elements.
    // If an array is an element in the peculiar array you have to convert it to it’s equivalent value so that you can sum it with the other elements.
    // Equivalent value of an array is the sum of its elements raised to the number which represents how far nested it is.
    // For e.g. [2,3[4,1,2]] = 2+3+ (4+1+2)^2 [1,2,[7,[3,4],2]] = 1 + 2 +( 7+(3+4)^3+2)^2"

    public class PowerSum
    {
        /*
            [1,2, [3,4], [[2]]]  
            = [1, 2, 7^2, 2^3^2]^1
            = [1, 2, 49, 64]^1
            = [116]^1
            = 116

            object[] jaggedArray = 
            {
                1,
                2,
                new int[] { 3, 4 },
                new int[][] { new int[] { 2 } }
            };
         */
        public double GetPowerSum(object[] jaggedArray, int power = 1)
        {
            var result = 0.0;
            foreach (var item in jaggedArray)
            {
                if (item is int num)
                {
                    result += num;
                }
                else if (item is object[] nestedArray)
                {
                    result += Math.Pow(GetPowerSum(nestedArray, power + 1), power + 1);
                }
            }
            return result;
        }
    }
}
