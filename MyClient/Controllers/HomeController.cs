using Managers;
using Microsoft.AspNetCore.Mvc;
using MyAPIClient.Controllers;
using Shared;
using ControllerBase = MyAPIClient.Controllers.ControllerBase;
using IServiceProvider = Shared.IServiceProvider;

namespace MyClient.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {        
        public HomeController(ILogger logger, IServiceProvider serviceProvider, IUserContext userContext, IConfiguration configuration) : base(logger, serviceProvider, userContext, configuration)
        {
        }

        [HttpGet(Name = "Home")]
        public async Task<string> Get()
        {
            return await _serviceProvider.GetService<IMyManager>().TestMe("test");
        }
    }
}