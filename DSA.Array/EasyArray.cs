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

        #region Find sum of unique elements
        public int SumOfUnique(int[] nums)
        {
            if (nums == null) return 0;
            Dictionary<int, int> dc = new Dictionary<int, int>();
            int sum = 0;
            foreach (int i in nums)
            {
                if (dc.ContainsKey(i))
                {
                    dc[i]++;
                    continue;
                }
                dc[i] = 1;
            }
            foreach (var i in dc)
            {
                if (i.Value == 1)
                    sum += i.Key;
            }
            return sum;
        }
        #endregion

        #region merge-sorted-array
        /*
         You are given two integer arrays nums1 and nums2, sorted in non-decreasing order, and two integers m and n, representing the number of elements in nums1 and nums2 respectively.

        Merge nums1 and nums2 into a single array sorted in non-decreasing order.
        
        The final sorted array should not be returned by the function, but instead be stored inside the array nums1. To accommodate this, nums1 has a length of m + n, where the first m elements denote the elements that should be merged, and the last n elements are set to 0 and should be ignored. nums2 has a length of n.
        
         
        
        Example 1:
        
        Input: nums1 = [1,2,3,0,0,0], m = 3, nums2 = [2,5,6], n = 3
        Output: [1,2,2,3,5,6]
        Explanation: The arrays we are merging are [1,2,3] and [2,5,6].
        The result of the merge is [1,2,2,3,5,6] with the underlined elements coming from nums1.
        Example 2:
        
        Input: nums1 = [1], m = 1, nums2 = [], n = 0
        Output: [1]
        Explanation: The arrays we are merging are [1] and [].
        The result of the merge is [1].
        Example 3:
        
        Input: nums1 = [0], m = 0, nums2 = [1], n = 1
        Output: [1]
        Explanation: The arrays we are merging are [] and [1].
        The result of the merge is [1].
        Note that because m = 0, there are no elements in nums1. The 0 is only there to ensure the merge result can fit in nums1.
 
         */

        public int[] MergeSortedArray(int[] nums1, int m, int[] nums2, int n)
        {
            m--;
            n--;
            for (int i = nums1.Length - 1; i >= 0; i--)
            {
                if (n < 0) break;

                if (m >= 0 && nums1[m] > nums2[n])
                {
                    nums1[i] = nums1[m];
                    m--;

                }
                else
                {
                    nums1[i] = nums2[n];
                    n--;
                }

            }
            return nums1;
        }
        #endregion
        #region two-sum un-sorted-array
        public int[] TwoSum(int[] nums, int target)
        {
            if (nums == null)
                return null;
            Dictionary<int, int> map = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (map.ContainsKey(target - nums[i]))
                    return new int[] { map[target - nums[i]], i };
                map[nums[i]] = i;
            }

            return null;

        }
        #endregion

        #region maximum-subarray
        public int MaxSubArraySum(int[] nums)
        {
            if (nums == null)
                return -1;
            int maxSum = nums[0];
            int currentSum = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                if (currentSum + nums[i] > nums[i])
                {
                    currentSum += nums[i];
                }
                else
                {
                    currentSum = nums[i];
                }

                if (currentSum > maxSum)
                {
                    maxSum = currentSum;
                }
            }
            return maxSum;
        }
        #endregion


    }
}
