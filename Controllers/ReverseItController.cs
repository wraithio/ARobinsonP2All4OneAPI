using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ARobinsonMC4Five2Svn_EndPnt.Services;
using Microsoft.AspNetCore.Mvc;

namespace ARobinsonMC4Five2Svn_EndPnt.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ReverseItController : ControllerBase
    {
        private readonly ReverseNumServices _reverseNumServices;
        private readonly ReverseCharServices _reverseCharServices;

        public ReverseItController(ReverseNumServices reverseNumServices)
        {
                _reverseNumServices = reverseNumServices;
        }
        public ReverseItController(ReverseCharServices reverseCharServices)
        {
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