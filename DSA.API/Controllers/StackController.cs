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
    }
}
