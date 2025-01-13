using ARobinsonP2All4OneAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace ARobinsonP2All4OneAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Magic8Controller : ControllerBase
    {
        private readonly Magic8Services _magic8Services;

        public Magic8Controller(Magic8Services magic8Services)
        {
            _magic8Services = magic8Services;
        }

        [HttpGet]
        [Route("goMagic8/{question}")]
        public string goMagic8(string question)
        {
            return _magic8Services.goMagic8(question);
        }
    }
}