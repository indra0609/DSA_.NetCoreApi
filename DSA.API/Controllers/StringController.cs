using DSA.API.Models;
using DSA.String;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DSA.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StringController : ControllerBase
    {
        #region EasyString

        EasyString easyString = new EasyString();

        #region ReverseString
        [HttpPost("ReverseString")]
        public IActionResult ReverseString([FromBody] string s)
        {
            return Ok(easyString.ReverseString(s.ToCharArray()));
        }
        #endregion

        #region reverse-vowels-of-a-string
        [HttpPost("ReverseVowels")]
        public IActionResult ReverseVowels([FromBody] string s)
        {
            return Ok(easyString.ReverseVowels(s));
        }
        #endregion

        #region valid-anagram
        [HttpPost("IsAnagram")]
        public IActionResult IsAnagram([FromBody] AnagramRequest request)
        {
            return Ok(easyString.IsAnagram(request.s, request.t));
        }
        #endregion
        #endregion
    }
}
