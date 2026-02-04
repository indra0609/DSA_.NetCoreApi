using DSA.API.Models;
using DSA.Array;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DSA.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArrayController : ControllerBase
    {
        EasyArray easyArray = new EasyArray();
        MediumArray mediumArray = new MediumArray();
        #region
        #region Basic Traversal & Logic

        //Find the largest element in an array
        [Route("FindLargestElement")]
        [HttpPost]
        public IActionResult FindLargestElement(int[] arr)
        {
            return Ok(easyArray.FindLargestElement(arr));
        }

        //Find the **second largest** element
        [Route("FindSecondLargestElement")]
        [HttpPost]
        public IActionResult FindSecondLargestElement(int[] arr)
        {
            return Ok(easyArray.FindSecondLargestElement(arr));
        }

        //Check if an array is **sorted**
        [Route("IsArraySorted")]
        [HttpPost]
        public IActionResult IsArraySorted(int[] arr)
        {
            return Ok(easyArray.IsArraySorted(arr));
        }

        //Reverse an array
        [Route("ReverseArray")]
        [HttpPost]
        public IActionResult ReverseArray(int[] arr)
        {
            return Ok(easyArray.ReverseArray(arr));
        }

        // Count **even & odd** numbers
        [Route("CountEvenOddNumbers")]
        [HttpPost]
        public IActionResult CountEvenOddNumbers(int[] arr)
        {
            var result = easyArray.CountEvenOdd(arr);
            return Ok($"Even {result.evenCount} \nOdd {result.oddCount} ");
        }

        //Remove **duplicates from sorted array**
        [Route("RemoveDuplicatesFromSortedArray")]
        [HttpPost]
        public IActionResult RemoveDuplicatesFromSortedArray(int[] arr)
        {
            return Ok(easyArray.RemoveDuplicatesFromSortedArray(arr));
        }

        //Move all **zeros to the end**
        [Route("MoveZerosToEnd")]
        [HttpPost]
        public IActionResult MoveZerosToEnd(int[] arr)
        {
            return Ok(easyArray.MoveZerosToEnd(arr));
        }

        //Rotate array **left by 1**
        [Route("RotateArrayLeftByOne")]
        [HttpPost]
        public IActionResult RotateArrayLeftByOne(int[] arr)
        {
            return Ok(easyArray.RotateArrayLeftByOne(arr));
        }
        #endregion


        #region Math / Brute Force
        //Find sum of all elements
        [Route("FindSumOfAllElements")]
        [HttpPost]
        public IActionResult FindSumOfAllElements(int[] arr)
        {
            return Ok(easyArray.FindSumOfAllElements(arr));
        }

        //Check if array is **palindrome**
        [Route("IsArrayPalindrome")]
        [HttpPost]
        public IActionResult IsArrayPalindrome(int[] arr)
        {
            return Ok(easyArray.IsArrayPalindrome(arr));
        }

        //Find max consecutive 1s ⭐
        [Route("FindMaxConsecutiveOnes")]
        [HttpPost]
        public IActionResult FindMaxConsecutiveOnes(int[] arr)
        {
            return Ok(easyArray.FindMaxConsecutiveOnes(arr));
        }

        // Replace every element with greatest on right
        [Route("ReplaceElementsWithGreatestOnRight")]
        [HttpPost]
        public IActionResult ReplaceElementsWithGreatestOnRight(int[] arr)
        {
            return Ok(easyArray.ReplaceEveryElementWithGreatestOnRight(arr));
        }

        // count-elements-with-maximum-frequency
        [Route("CountElementsWithMaximumFrequency")]
        [HttpPost]
        public IActionResult CountElementsWithMaximumFrequency(int[] arr)
        {
            return Ok(easyArray.MaxFrequencyElements(arr));
        }

        // Find sum of unique elements
        [Route("FindSumOfUniqueElements")]
        [HttpPost]
        public IActionResult FindSumOfUniqueElements(int[] arr)
        {
            return Ok(easyArray.SumOfUnique(arr));
        }

        //merge-sorted-array
        [Route("MergeSortedArray")]
        [HttpPost]
        public IActionResult MergeSortedArray([FromBody] MergeSortedArrayRequest request)
        {
            return Ok(easyArray.MergeSortedArray(request.Arr1, request.M, request.Arr2, request.N));
        }

        //two-sum unsorted array
        [Route("TwoSumUnsortedArray")]
        [HttpPost]
        public IActionResult TwoSumUnsortedArray([FromBody] TwoSumUnsortedArrayRequest request)
        {
            return Ok(easyArray.TwoSum(request.Arr, request.Target));
        }

        //maximum-subarray
        [HttpPost("MaximumSubarraySum")]
        public IActionResult MaximumSubarraySum(int[] arr)
        {
            return Ok(easyArray.MaxSubArraySum(arr));
        }

        //majority-element
        [HttpPost("MajorityElement")]
        public IActionResult MajorityElement(int[] arr)
        {
            return Ok(easyArray.MajorityElement(arr));
        }

        // missing-number
        [HttpPost("MissingNumber")]
        public IActionResult MissingNumber(int[] arr)
        {
            return Ok(easyArray.MissingNumber(arr));
        }
        #endregion


        #endregion

        #region Medium Array Problems

        #region sort-colors
        //sort-colors
        [Route("SortColors")]
        [HttpPost]
        public IActionResult SortColors(int[] arr)
        {
            mediumArray.SortColors(arr);
            return Ok(arr);
        }

        //rotate-array by K
        [Route("RotateArrayByK")]
        [HttpPost]
        public IActionResult RotateArrayByK([FromBody] RotateArrayByKRequest request)
        {
            mediumArray.Rotate(request.Arr, request.K);
            return Ok(request.Arr);
        }
        #endregion

        #endregion
    }
}
