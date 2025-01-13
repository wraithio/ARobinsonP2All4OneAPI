using ARobinsonP2All4OneAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace ARobinsonP2All4OneAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GuessItController : ControllerBase
    {
        private readonly GuessItServices _guessItServices;

        public GuessItController(GuessItServices guessItServices)
        {
            _guessItServices = guessItServices;
        }

        [HttpGet]
        [Route("EasygoGuessIt/{guessInt}")]
        public string goGuessIt(int guessInt)
        {
            return _guessItServices.EasygoGuessIt(guessInt);
        }

        [HttpGet]
        [Route("MediumgoGuessIt/{guessInt}")]
        public string MediumgoGuessIt(int guessInt)
        {
            return _guessItServices.MediumgoGuessIt(guessInt);
        }

        [HttpGet]
        [Route("HardgoGuessIt/{guessInt}")]
        public string HardgoGuessIt(int guessInt)
        {
            return _guessItServices.HardgoGuessIt(guessInt);
        }
    }
}