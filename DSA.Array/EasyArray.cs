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

        #region Move all **zeros to the end**
        public int[] MoveZerosToEnd(int[] arr)
        {
            if (arr.Length == 0 || arr.Length == 1)
                return arr;
            int p1 = 0;
            for (int p2 = 0; p2 < arr.Length; p2++)
            {
                if (arr[p2] != 0)
                {
                    arr[p1] = arr[p2];
                    p1++;
                }
            }
            while (p1 < arr.Length)
            {
                arr[p1] = 0;
                p1++;
            }
            return arr;
        }


        #endregion

        #region Rotate array **left by 1**
        public int[] RotateArrayLeftByOne(int[] arr)
        {
            if (arr.Length == 0 || arr.Length == 1)
                return arr;
            int first = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                arr[i - 1] = arr[i];
            }
            arr[arr.Length - 1] = first;
            return arr;
        }
        #endregion

        #region Find sum of all elements
        public int FindSumOfAllElements(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }
        #endregion

        #region Check if array is **palindrome**
        public bool IsArrayPalindrome(int[] arr)
        {
            if (arr.Length == 0 || arr.Length == 1)
                return true;
            int start = 0;
            int end = arr.Length - 1;
            while (start < end)
            {
                if (arr[start] != arr[end])
                    return false;
                start++;
                end--;
            }
            return true;
        }
        #endregion

        #region Find max consecutive 1s ⭐
        public int FindMaxConsecutiveOnes(int[] arr)
        {
            int maxCount = 0;
            int currentCount = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 1)
                {
                    currentCount++;
                    if (currentCount > maxCount)
                        maxCount = currentCount;
                }
                else
                {
                    currentCount = 0;
                }
            }
            return maxCount;
        }

        #endregion
    }
}
