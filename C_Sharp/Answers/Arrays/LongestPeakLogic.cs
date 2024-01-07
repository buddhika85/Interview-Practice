using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C_Sharp.Answers.Arrays
{
    public class LongestPeakLogic
    {
       
// peaks[] = []
// for i = 1 to end - 1:
// 	if a[i-1] < a[i] && a[i+1] > a[i]
// 		peaks.add(i)	
// longest = 0
// foreach peak in peaks:
// 	leftIndex = peak - 1
// 	rightIndex = peak + 1
// 	while a[leftIndex - 1] < a[leftIndex]:
// 		--leftIndex
// 	while a[rightIndex + 1] < a[rightIndex]:
// 		++rightIndex
// 	length = lengths.add(right - left + 1)	
// 	if length > logest:
// 		longest = length
// return longestPeak

// [1,2,3,3,4,0,10,6,5,-1,-3,2,3]
// [        p    p              ]
// [          5  6         10     ]
        public static int LongestPeak(int[] array)
        {
            var longest = 0;
            // finding all the peaks
            for (int i = 1; i < array.Length - 2; i++)
            {
                if (array[i - 1] < array[i] && array[i + 1] < array[i])
                {
                    var leftCorner = i - 1;
                    var rightCorner = i + 1;
                    while (leftCorner - 1 >= 0 && array[leftCorner - 1] < array[leftCorner])
                        --leftCorner;
                    while (rightCorner + 1 < array.Length - 1 &&  array[rightCorner + 1] < array[rightCorner])
                        ++rightCorner;
                    var length = (rightCorner + 1) - leftCorner;
                    if (length > longest)
                        longest = length;
                }
            }
            return longest;
        }

    }
}