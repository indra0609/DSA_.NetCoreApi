using System;
using System.Collections.Generic;
using System.Text;

namespace DSA.Array
{
    public class MediumArray
    {
        #region sort-colors
        /* Given an array nums with n objects colored red, white, or blue, sort them in-place so that objects of the same color are adjacent, with the colors in the order red, white, and blue.
        We will use the integers 0, 1, and 2 to represent the color red, white, and blue, respectively.
        You must solve this problem without using the library's sort function.

        Example 1:
        Input: nums = [2,0,2,1,1,0]
        Output: [0,0,1,1,2,2]
         */
        public void SortColors(int[] nums)
        {
            int start = 0;
            int end = nums.Length - 1;
            int mid = 0;

            while (mid <= end)
            {
                if (nums[start] == 0)
                {
                    start++;
                    mid++;
                }
                else if (nums[mid] == 2)
                {
                    Swap(nums, mid, end);
                    end--;
                }
                else
                {
                    if (nums[mid] == 0)
                    {
                        Swap(nums, start, mid);
                        start++;
                    }
                    mid++;

                }

            }
        }

        public void Swap(int[] nums, int i, int j)
        {
            int temp = nums[i];
            nums[i] = nums[j];
            nums[j] = temp;
        }
        #endregion

        #region rotate-array by K
        public void Rotate(int[] nums, int k)
        {
            if (nums.Length < k)
            {
                k = k % nums.Length;
            }
            ReverseArray(nums, 0, nums.Length - k - 1);
            ReverseArray(nums, nums.Length - k, nums.Length - 1);
            ReverseArray(nums, 0, nums.Length - 1);

        }
        public void ReverseArray(int[] nums, int i, int j)
        {
            while (i <= j)
            {
                int temp = nums[i];
                nums[i] = nums[j];
                nums[j] = temp;
                i++;
                j--;
            }
        }
        #endregion
    }
}
