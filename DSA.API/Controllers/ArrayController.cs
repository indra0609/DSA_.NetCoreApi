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
        #endregion

        #endregion
    }
}
