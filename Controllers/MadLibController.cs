using ARobinsonP2All4OneAPI.Models;
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
        [Route("goMadLib/{color}/{adjective}/{place}/{adjective_2}/{place_2}/{food_S}/ {food_P}/{verb}/{noun_P}/{adjective_3}")]

        public string goMadLib(string color, string adjective, string place, string adjective_2, string place_2, string food_S, string food_P, string verb, string noun_P, string adjective_3)
        {
            return _madLibServices.goMadLib(color, adjective, place, adjective_2, place_2, food_S, food_P, verb, noun_P, adjective_3);

        }
    }
}