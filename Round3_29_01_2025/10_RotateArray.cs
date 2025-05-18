namespace Round3_29_01_2025
{
    // Given an array, rotate the array to the right by k steps, where k is non-negative.
    // [1,2,3,4]    => k=1 => [4,1,2,3]
    // [1,2,3,4]    => k=2 => [3,4,1,2]
    // [1,2,3,4]    => k=3 => [2,3,4,1]
    // [1,2,3,4]    => k=4 => [1,2,3,4]
    // [1,2,3,4]    => k=5 % length = 1 => [4,1,2,3]
    // [] => k=n => []
    // [] => k=0 => []
    // [1,2] => k=1 => [2,1]
    public class RotateArray
    {
        // [1,2,3,4]    => k=1 => [4,1,2,3]
        // [0,1,2,3] => [3,0,1,2]

        // k = k % length
        // if k == 0
        //      no movementNedded
        // else
        //      newIndex = currentIndex + k
        //      if newIndex > length
        //          newIndex = newIndex % length
        public int[] GetKRotatedArray(int[] array, int k)
        {
            k = k % array.Length;
            if (k == 0) 
                return array;

            var result = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                var newIndex = (i + k) % array.Length;
                result[newIndex] = array[i];
            }
            return array;
        }
    }
}
