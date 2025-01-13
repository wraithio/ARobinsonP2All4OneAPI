using ARobinsonP2All4OneAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace ARobinsonP2All4OneAPI.Controllers
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