using ARobinsonMC3Two2Four_EndPnt.services;
using Microsoft.AspNetCore.Mvc;

namespace ARobinsonMC3Two2Four_EndPnt.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GtrThnLessThnController : ControllerBase
    {
        private readonly GtrThnLessThnServices _gtrThnLessThnServices;

        public GtrThnLessThnController(GtrThnLessThnServices gtrThnLessThnServices)
        {
            _gtrThnLessThnServices = gtrThnLessThnServices;
        }
        [HttpGet]
        [Route("GtrLssThn/{Num1}/{Num2}")]
        public string GtrLssThn(int Num1, int Num2)
        {
            return _gtrThnLessThnServices.GtrLssThn(Num1, Num2);
        }
    }
}