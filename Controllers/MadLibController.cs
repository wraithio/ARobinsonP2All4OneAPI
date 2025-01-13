using ARobinsonP2All4OneAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace ARobinsonP2All4OneAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MadLibController : ControllerBase
    {
        private readonly MadLibServices _madLibServices;


        public MadLibController(MadLibServices madLibServices)
        {
            _madLibServices = madLibServices;
        }

        [HttpGet]
        [Route("goMadLib/{color}/{adjective}/{place}/{adjective2}/{place2}/{singular_food}/{plural_food}/{verb}/{plural_noun}/{adjective3}")]

        public string goMadLib(string color, string adjective, string place, string adjective2, string place2, string singular_food, string plural_food, string verb, string plural_noun, string adjective3)
        {
            return _madLibServices.goMadLib(color, adjective, place, adjective2, place2, singular_food, plural_food, verb, plural_noun, adjective3);

        }
    }
}