using ARobinsonP2All4OneAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace ARobinsonMC1SayHllo_EndPnt.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SayHelloController : ControllerBase
    {
        private readonly SayHelloServices _sayHelloServices;
        public SayHelloController(SayHelloServices sayHelloServices)
        {
            _sayHelloServices = sayHelloServices;
        }
        
        [HttpGet]
        [Route("InputName/{name}")]
        public string SayHello(string name)
        {
            return _sayHelloServices.SayHello(name);
        }
    }
}