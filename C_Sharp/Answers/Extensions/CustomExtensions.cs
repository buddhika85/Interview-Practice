using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C_Sharp.Answers.Extensions
{
    public static class CustomExtensions
    {
        public static string Display(this int[] array, string delimeter)
        {
            return string.Join(delimeter, array);
        }

        public static string Display(this string[] array, string delimeter)
        {
            return string.Join(delimeter, array);
        }

        public static string Display<T>(this IEnumerable<T> enumerable, string delimeter)
        {
            return string.Join(delimeter, enumerable);
        }


        public static string BoolYesNo(this bool value)
        {
            return value ? "yes" : "no";
        }
    }
}