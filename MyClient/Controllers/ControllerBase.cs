using Microsoft.AspNetCore.Mvc;
using Shared;
using IServiceProvider = Shared.IServiceProvider;

namespace MyAPIClient.Controllers
{
    public class ControllerBase : Microsoft.AspNetCore.Mvc.ControllerBase
    {
        protected readonly ILogger _logger;
        protected readonly IServiceProvider _serviceProvider;
        protected readonly IUserContext _userContext;
        protected readonly IConfiguration _configuration;

        public ControllerBase(ILogger logger, IServiceProvider serviceProvider, IUserContext userContext, IConfiguration configuration)
        {
            _serviceProvider = serviceProvider;
            _logger = logger;
            _userContext = userContext;
            _configuration = configuration;
        }
    }
}