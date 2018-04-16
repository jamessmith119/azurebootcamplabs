using HelloWorldMessageService;
using Microsoft.AspNetCore.Mvc;
using Microsoft.ServiceFabric.Services.Remoting.Client;
using Microsoft.ServiceFabric.Services.Remoting.V2.FabricTransport.Client;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HelloWorldWeb.Controllers
{
    [Produces("application/json")]
    [Route("api/Greetings")]
    public class GreetingsController : Controller
    {
        [HttpGet]
        public async Task<IEnumerable<string>> Get()
        {
            var proxyFactory = new ServiceProxyFactory((c) =>
            {
                return new FabricTransportServiceRemotingClientFactory();
            });

            var client = proxyFactory.CreateServiceProxy<IMessageService>(new Uri("fabric:/HelloWorld/MessageService"));
            var message = await client.WriteMessage();
            return new string[] { message };
        }
    }
}