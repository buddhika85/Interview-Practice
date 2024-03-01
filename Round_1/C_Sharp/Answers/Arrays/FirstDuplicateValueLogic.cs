using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C_Sharp.Answers.Arrays
{
    public class FirstDuplicateValueLogic
    {
        // Time - O(n)
        // space - O(n) -- because additional dictionary was used
        public static int FirstDuplicateValue(int[] array)
        {
            if (array != null && array.Length > 0)
            {
                var seen = new Dictionary<int, int> { { array[0], 1 } };
                for (var i = 1; i < array.Length; i++)
                {
                    if (seen.ContainsKey(array[i]))
                        return array[i];
                    seen.Add(array[i], 1);
                }
            }
            return -1;
        }

        // make the position negative
        // using the facts that - all array items are positive,
        // and if arrays length is n - it should have values 1...n
        // and array can be mutated
        // logic
        // for each element
        //      indexIfSorted = Math.abs(element) - 1
        //      if array[indexIfSorted] < 0:
        //              return element   --> we have seen element before
        //      else
        //              array[indexIfSorted] = array[indexIfSorted] * -1            --> make it negative, to indicate that we saw element of this index before
        // return -1   
        public static int FirstDuplicateValueOptimal(int[] array)
        {
            for (var i = 0; i < array.Length; i++)
            {
                var indexIfSorted = Math.Abs(array[i]) - 1;
                if (array[indexIfSorted] < 0)
                    return Math.Abs(array[i]);
                array[indexIfSorted] *= -1;
            }
            return -1;
        }

    }
}