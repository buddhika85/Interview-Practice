namespace Round3_29_01_2025
{
    public class TwoSum
    {
        // You are given an array of Integers and another integer targetValue.
        // Write a function that will take these inputs and return the indices of the 2 integers in the array that add up targetValue.
        // [] => []
        // [25], 25 => []
        // [2,7], 9=> [0,1]
        // [2,7,3,-1,4], 2 => [2,3]
        // [1,1,1],3 => []              // cannot make target 
        // [1,2,3], 5 => [1,2]
        // [2,1,3], 5 => [0,2]
        // [2,1,-3], -1 => [0,2]
        // [-2,1,-3],-5 => [0,2]        
        public int[] GetTwoSum(int[] array, int target)
        {
            if (array == null || array.Length < 2)
                return [];

            var dictionary = new Dictionary<int, int>();      // value, first index found
                 
            for (int i = 0; i < array.Length; i++)
            {
                var howManyToTarget = target - array[i];
                if (dictionary.TryGetValue(howManyToTarget, out int index))
                {
                    return [index, i];
                }

                // add to dictionary if the values index is not stored
                if (!dictionary.ContainsKey(array[i]))
                {
                    dictionary[array[i]] = i;                    
                }                
            }
            return [];      // cannot find
        }
    }
}
