using Managers;
using Microsoft.AspNetCore.Mvc;
using MyAPIClient.Controllers;
using Shared;
using IServiceProvider = Shared.IServiceProvider;

namespace MyClient.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase<HomeController>
    {        
        public HomeController(ILogger<HomeController> logger, IServiceProvider serviceProvider, IUserContext userContext) : base(logger, serviceProvider, userContext)
        {
        }

        [HttpGet(Name = "Home")]
        public Task<string> Get()
        {
            return _serviceProvider.GetService<IMyManager>().TestMe("test");
        }
    }
}