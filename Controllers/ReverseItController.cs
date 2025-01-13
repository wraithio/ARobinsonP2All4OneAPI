using ARobinsonP2All4OneAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace ARobinsonP2All4OneAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ReverseItController : ControllerBase
    {
        private readonly ReverseNumServices _reverseNumServices;
        private readonly ReverseCharServices _reverseCharServices;

        public ReverseItController(ReverseNumServices reverseNumServices, ReverseCharServices reverseCharServices)
        {
            _reverseNumServices = reverseNumServices;
             _reverseCharServices = reverseCharServices;
        }

        [HttpGet]
        [Route ("GoReverseNum/{userInt}")]

        public string GoReverseNum(string userInt)
        {
              int convertedNum;
            bool success = int.TryParse(userInt, out convertedNum);
            if(success)
            {
            return _reverseNumServices.GoReverseNum(userInt);
            }
            else
            {
            return "Numbers and special characters are not acceptable.";
            }
        }

        [HttpGet]
        [Route("GoReverseChar/{userString}")]

        public string GoReverseChar(string userString)
        {
            return _reverseCharServices.GoReverseChar(userString);
        }
    }
}