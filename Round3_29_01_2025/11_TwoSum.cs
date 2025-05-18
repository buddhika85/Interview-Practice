namespace Round3_29_01_2025
{
    internal class TwoSum
    {
        // You are given an array of Integers and another integer targetValue.
        // Write a function that will take these inputs and return the indices of the 2 integers in the array that add up targetValue.
        // [] => []
        // [1,1,1],3 => []              // cannot make target 
        // [1,2,3], 5 => [1,2]
        // [2,1,3], 5 => [0,2]
        // [2,1,-3], -1 => [0,2]
        // [-2,1,-3],-5 => [0,2]        
        public int[] GetTwoSum(int[] array, int target)
        {
            if (array == null || array.Length == 0)
                return [];

            var dictionary = new Dictionary<int, int[]>();      // how many for target, indexes
            dictionary[target - array[0]] = [0];                
            for (int i = 1; i < array.Length; i++)
            {
                var howManyToTarget = target - array[i];
                if (dictionary.ContainsKey(howManyToTarget))
                    return [dictionary[howManyToTarget][0], i];
            }

            return [];      // cannot find
        }
    }
}
