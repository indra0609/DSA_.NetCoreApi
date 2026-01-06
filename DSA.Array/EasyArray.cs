using System;
using System.Collections.Generic;
using System.Text;

namespace DSA.Array
{
    public class EasyArray
    {
        #region Find the largest element in an array
        public int FindLargestElement(int[] arr)
        {
            if (arr.Length == 0)
                return -1;
            int max = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                    max = arr[i];
            }
            return max;
        }
        #endregion

        #region Find the largest element in an array
        public int FindSecondLargestElement(int[] arr)
        {
            if (arr.Length == 0 || arr.Length == 1)
                return -1;
            int max1 = arr[0];
            int max2 = int.MinValue;
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max1)
                {
                    max2 = max1;
                    max1 = arr[i];
                }
                else if (arr[i] > max2 && arr[i] < max1)
                    max2 = arr[i];
            }
            return max2;
        }
        #endregion

        #region Check if an array is **sorted**
        public bool IsArraySorted(int[] arr)
        {
            if (arr.Length == 0 || arr.Length == 1)
                return true;
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < arr[i - 1])
                    return false;
            }
            return true;
        }
        #endregion

        #region Reverse an array
        public int[] ReverseArray(int[] arr)
        {
            if(arr.Length == 0 || arr.Length == 1)
                return arr; 
            int start = 0;
            int end = arr.Length - 1;
            while (start < end)
            {
                int temp = arr[start];
                arr[start] = arr[end];
                arr[end] = temp;
                start++;
                end--;
            }
            return arr;
        }
        #endregion

        #region Count **even & odd** numbers
        public (int evenCount, int oddCount) CountEvenOdd(int[] arr)
        {
            int evenCount = 0;
            int oddCount = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                    evenCount++;
                else
                    oddCount++;
            }
            return (evenCount, oddCount);
        }
        #endregion

        #region Remove **duplicates from sorted array**
        public int[] RemoveDuplicatesFromSortedArray(int[] arr)
        {
            if (arr.Length == 0 || arr.Length == 1)
                return arr;
            int p1 = 0;
            for (int p2 = 1; p2 < arr.Length; p2++)
            {
                if (arr[p1] != arr[p2])
                {
                    p1++;
                    arr[p1] = arr[p2];
                }
            }
            return arr;
        }
        #endregion
    }
}
