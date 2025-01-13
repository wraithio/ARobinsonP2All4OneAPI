using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ARobinsonP2All4OneAPI.Services
{
    public class SayHelloServices
    {
        public string SayHello(string name)
        {
            return $"Hello {name}.";
        }
    }
}