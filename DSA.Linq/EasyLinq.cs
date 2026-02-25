using System;
using System.Collections.Generic;
using System.Text;

namespace DSA.Linq
{
    public class EasyLinq
    {
        #region Filter even numbers from a list
        public int[] GetEven(int[] arr)
        {
            var result = arr.Where(x => x % 2 == 0).ToArray();
            return result;
        }
        #endregion

        #region Find numbers greater than a given value
        public int[] GetGreaterThan(int[] arr, int value)
        {
            var result = arr.Where(x => x > value).ToArray();
            return result;
        }
        #endregion

        #region Get distinct elements from a list
        public int[] GetDistinct(int[] arr)
        {
            var result = arr.Distinct().ToArray();
            return result;
        }
        #endregion

        #region Count total elements in a list
        public int CountElements(int[] arr)
        {
            var count = arr.Count();
            return count;
        }
        #endregion

        #region Check if a value exists in a list (`Any`)
        public bool Contains(int[] arr, int n)
        {
             var res = arr.Any(x => x == n);

             return res;
        }

        #endregion

        #region Find duplicate elements  ***
        public int[] GetDuplicates(int[] arr)
        {
            var duplicates = arr.GroupBy(x => x)
                                .Where(g => g.Count() > 1)
                                .Select(g => g.Key)
                                .ToArray();
            return duplicates;
        }

        #endregion

    }
}
