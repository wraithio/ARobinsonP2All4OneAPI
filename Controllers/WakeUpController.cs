using ARobinsonP2All4OneAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace ARobinsonP2All4OneAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WakeUpController : ControllerBase
    {
        private readonly WakeUpServices _wakeUpServices;

        public WakeUpController(WakeUpServices wakeUpServices)
        {
            _wakeUpServices = wakeUpServices;
        }

        [HttpGet]
        [Route("InputName/{name}/{time}")]
        public string InputName(string name, int time)
        {
            return _wakeUpServices.InputName(name, time);
        }
    }
}