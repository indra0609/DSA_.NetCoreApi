using DSA.Stack;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DSA.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StackController : ControllerBase
    {
        EasyStack easyStack = new EasyStack();
        #region valid-parentheses
        [HttpPost("IsValidparentheses")]
        public IActionResult IsValidparentheses([FromBody] string s)
        {
            return Ok(easyStack.IsValidparentheses(s));
        }
        #endregion

        #region next-greater-element-i
        [HttpPost("NextGreaterElement")]
        public IActionResult NextGreaterElement([FromBody] int[][] nums)
        {
            return Ok(easyStack.NextGreaterElement(nums[0], nums[1]));
        }
        #endregion
    }
}
