using DSA.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DSA.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LinqController : ControllerBase
    {
        EasyLinq easyLinq = new EasyLinq();

        #region Easy
        [HttpPost("GetEven")]
        public IActionResult GetEven([FromBody] int[] arr)
        {
            var result = easyLinq.GetEven(arr);
            return Ok(result);
        }

        [HttpPost("GetGreaterThan")]
        public IActionResult GetGreaterThan([FromBody] int[] arr, int value)
        {
            var result = easyLinq.GetGreaterThan(arr, value);
            return Ok(result);
        }

        [HttpPost("GetDistinct")]
        public IActionResult GetDistinct([FromBody] int[] arr)
        {
            var result = easyLinq.GetDistinct(arr);
            return Ok(result);
        }

        [HttpPost("CountElements")]
        public IActionResult CountElements([FromBody] int[] arr)
        {
            var count = easyLinq.CountElements(arr);
            return Ok(count);
        }

        [HttpPost("Contains")]
        public IActionResult Contains([FromBody] int[] arr, int n)
        {
            var res = easyLinq.Contains(arr, n);
            return Ok(res);
        }

        [HttpPost("GetDuplicates")]
        public IActionResult GetDuplicates([FromBody] int[] arr)
        {
            var duplicates = easyLinq.GetDuplicates(arr);
            return Ok(duplicates);
        }
        #endregion
    }
}
