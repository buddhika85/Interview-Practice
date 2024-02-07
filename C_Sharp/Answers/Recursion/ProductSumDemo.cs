using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static System.Console;

namespace C_Sharp.Answers.Recursion
{
    public class ProductSumDemo
    {
        public static void Demo()
        {
            List<object> list = new();
            
            list.AddRange(new List<object> {5,2, new List<object> {7, -1}, 3, new List<object> {6, new List<object> {-13, 8}, 4}});
            // list.Add(5);
            // list.Add(2);
            // list.Add(new List<object> {7, -1});
            // list.Add(3);
            // list.Add(new List<object> {6, 4});       // 42
            WriteLine(ProductSum(list));
        }

        public static int ProductSum(List<object> array) 
        {
            return ProductSumHelper(array, 1);
        }

        private static int ProductSumHelper(List<object> array, int depth)
        {
            var sum = 0;
            for (int i = 0; i < array.Count; i++)
            {
                object? item = array[i];                
                if (item is int)
                {
                    sum += Convert.ToInt32(item);
                }
                else
                {
                    sum += ProductSumHelper((List<object>)item, depth + 1);
                }
            }
            sum *= depth;
            return sum;
        }
    }
}