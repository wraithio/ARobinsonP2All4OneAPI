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
        [Route("goMadLib/{madLibs}")]

        public string goMadLib(LibModel madLibs)
        {
            return _madLibServices.goMadLib();

        }
    }
}