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

        #region Replace every element with greatest on right
        //Input: arr = [17,18,5,4,6,1]
        //Output: [18,6,6,6,1,-1]
        public int[] ReplaceEveryElementWithGreatestOnRight(int[] arr)
        {
            if (arr.Length == 0 || arr.Length == 1)
                return arr;
            int maxRight = -1;
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                int current = arr[i];
                arr[i] = maxRight;
                maxRight = Math.Max(current, maxRight);
            }
            return arr;
        }
        #endregion

        #region Find **frequency of each element**

        #endregion

        #region count-elements-with-maximum-frequency
        /*Input: nums = [1,2,2,3,1,4]
        Output: 4
        Explanation: The elements 1 and 2 have a frequency of 2 which is the maximum frequency in the array.
        So the number of elements in the array with maximum frequency is 4.
        Example 2:
        
        Input: nums = [1,2,3,4,5]
        Output: 5
        Explanation: All elements of the array have a frequency of 1 which is the maximum.
        So the number of elements in the array with maximum frequency is 5.
         */

        public int MaxFrequencyElements(int[] nums)
        {
            if (nums == null) return 0;
            Dictionary<int, int> dc = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (dc.ContainsKey(nums[i]))
                {
                    dc[nums[i]]++;
                    continue;
                }
                dc[nums[i]] = 1;
            }
            int max = 0, res = max;
            foreach (int i in dc.Values)
            {
                if (i == max)
                    res += max;
                else if (i > max)
                {
                    max = i;
                    res = max;
                }
            }
            return res;
        }
        #endregion
    }
}
