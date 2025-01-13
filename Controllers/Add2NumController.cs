using ARobinsonMC3Two2Four_EndPnt.services;
using Microsoft.AspNetCore.Mvc;

namespace ARobinsonMC3Two2Four_EndPnt.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Add2NumController : ControllerBase
    {
        private readonly Add2NumServices _add2NumServices;

        public Add2NumController(Add2NumServices add2NumServices)
        {
            _add2NumServices = add2NumServices;
        }

        [HttpGet]
        [Route("Add2Num/{Num1}/{Num2}")]
        public string Add2Num(int Num1, int Num2)
        {
            return _add2NumServices.Add2Num(Num1, Num2);
        }
    }
}